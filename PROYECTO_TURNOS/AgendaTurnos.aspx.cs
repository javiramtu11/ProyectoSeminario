using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PROYECTO_TURNOS
{
    public partial class AgendaTurnos : System.Web.UI.Page
    {
        string CadenaConexion = "Data Source = DESKTOP-RTIU5G0; Initial Catalog = HospitalAdonai; Integrated Security = True";
        int idDoctor = 0;
        string nombreDoc = null;
        string apellidoDoc = null;
        string identificador = null;

        public void buscarllenarDoc()
        {
            SqlConnection conexionSQL = new SqlConnection(CadenaConexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT ID_MEDICO, NOMBRE, APELLIDO FROM MEDICO WHERE USERNAME = '"+ Session["USUARIO"] + "'";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexionSQL;
            conexionSQL.Open();

            DataTable Datos = new DataTable();
            Datos.Load(cmd.ExecuteReader());
            int y = 0;

            foreach (DataRow item in Datos.Rows)
            {
                if (y == 0)
                {

                    idDoctor = int.Parse(item[0].ToString());
                    y++;
                }
                if (y == 1)
                {
                    nombreDoc = item[1].ToString();
                    y++;
                }
                if (y == 2)
                {
                    apellidoDoc = item[2].ToString();
                    y++;
                }
            }

            identificador = nombreDoc + " " + apellidoDoc;
            doctormodal.Value = identificador;
            conexionSQL.Close();



        }

        public void obtenerTurnos()
        {
            SqlConnection conexionSQL = new SqlConnection(CadenaConexion);
            SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = "SELECT TURNO_DIARIO, (p.NOMBRE + ' ' + p.APELLIDO)AS PERSONA, MOTIVO FROM PACIENTES p "+
            //"INNER JOIN TURNOS t ON p.ID_PACIENTE = t.ID_PACIENTE WHERE t.ESTADO = 1 AND t.FECHA_INGRESO = GETDATE() AND ID_MEDICO = 1 ";
            cmd.CommandText = "SELECT ID_TURNO, TURNO_DIARIO, (p.NOMBRE + ' ' + p.APELLIDO)AS PERSONA, MOTIVO FROM PACIENTES p " +
           "INNER JOIN TURNOS t ON p.ID_PACIENTE = t.ID_PACIENTE WHERE t.ESTADO = 1 AND t.FECHA_INGRESO = '2019-10-1' AND ID_MEDICO = '"+idDoctor+"' ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexionSQL;
            conexionSQL.Open();

            DataTable Datos = new DataTable();
            Datos.Load(cmd.ExecuteReader());
            Grid.DataSource = Datos;
            Grid.DataBind();
            conexionSQL.Close();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                buscarllenarDoc();
                obtenerTurnos();
            }
            
        }

        protected void btnSelect_Click(object sender, EventArgs e)
        {
            Button btnSelect = (sender as Button);
            string commandName = btnSelect.CommandName;
            string commandArgument = btnSelect.CommandArgument;

            GridViewRow row = (btnSelect.NamingContainer as GridViewRow);

            int rowIndex = row.RowIndex;

            int CodigoPaciente = Convert.ToInt32(commandName);
            string NombrePaciente = Convert.ToString(commandArgument);

            Session["Codigodecita"] = CodigoPaciente.ToString();
         
            Response.Redirect("AppAtencion.aspx");
        }

        protected void Grid_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }
    }
}