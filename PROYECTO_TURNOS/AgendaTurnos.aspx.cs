using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Texto_a_Voz;

namespace PROYECTO_TURNOS
{
    public partial class AgendaTurnos : System.Web.UI.Page
    {
        MostrarDatos md = new MostrarDatos();
        string con = MostrarDatos.CadenaConexion; 

        int idDoctor = 0;
        string nombreDoc = null;
        string apellidoDoc = null;
        string clinicax = null;
        string identificador = null;

        public void buscarllenarDoc()
        {
            SqlConnection conexionSQL = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT ID_MEDICO, NOMBRE, APELLIDO,  c.CLINICA FROM CLINICAS c INNER JOIN MEDICO d " +
                              " ON (c.ID_CLINICA = d.ID_CLINICA) WHERE USERNAME = '"+ Session["USUARIO"] + "'";
            

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
                if (y == 3)
                {
                    clinicax = item[3].ToString();
                }
            }

       
            identificador = nombreDoc + " " + apellidoDoc;

            Session["NombreDoc"] = identificador;
            Session["InicNombre"] = nombreDoc.Substring(0, 1);
            Session["InicApellido"] = apellidoDoc.Substring(0, 1);
            Session["Clinica"] = clinicax;
            Session["IDdoctor"] = idDoctor;
            doctormodal.Value = identificador;
            conexionSQL.Close();



        }

        public void obtenerTurnos()
        {
            SqlConnection conexionSQL = new SqlConnection(con);
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

            int Turno = Convert.ToInt32(commandName);
            Session["Turno"] = Turno.ToString();
            string NombrePaciente = Convert.ToString(commandArgument);
            Session["NomPaciente"] = NombrePaciente.ToString();

            string cadenallamar = "--Paciente. " + NombrePaciente + ". con turno. numero "+ Session["InicNombre"] + ", "+ Session["InicApellido"] + "., 00" + Turno + "., pasar a la clinica del doctor. " + Session["NombreDoc"];

   

            //Session["Codigodecita"] = Turno.ToString();
            TextToVoiceDJ voz = new TextToVoiceDJ();
            voz.EjecutarTextToVoice(cadenallamar);

            
            Response.Redirect("AgendaTurnos.aspx");
        }

        protected void Grid_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

        protected void btnAtender_Click(object sender, EventArgs e)
        {
            Button btnAtender = (sender as Button);
            string commandName = btnAtender.CommandName;
            string commandArgument = btnAtender.CommandArgument;

            GridViewRow row = (btnAtender.NamingContainer as GridViewRow);

            int rowIndex = row.RowIndex;

            int Turno = Convert.ToInt32(commandName);
            string NombrePaciente = Convert.ToString(commandArgument);

           
            SqlConnection conexionSQL = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "UPDATE TURNOS SET ESTADO = 2 WHERE ID_TURNO = '" + Turno + "' ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexionSQL;
            conexionSQL.Open();
            cmd.ExecuteNonQuery();
            conexionSQL.Close();

            Response.Redirect("AgendaTurnos.aspx");

        }

        protected void btnSuspender_Click(object sender, EventArgs e)
        {
            Button btnSuspender = (sender as Button);
            string commandName = btnSuspender.CommandName;
            string commandArgument = btnSuspender.CommandArgument;

            GridViewRow row = (btnSuspender.NamingContainer as GridViewRow);

            int rowIndex = row.RowIndex;

            int Turno = Convert.ToInt32(commandName);
            string NombrePaciente = Convert.ToString(commandArgument);

            

            SqlConnection conexionSQL = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "UPDATE TURNOS SET ESTADO = 3 WHERE ID_TURNO = '" + Turno + "' ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexionSQL;
            conexionSQL.Open();
            cmd.ExecuteNonQuery();
            conexionSQL.Close();

            Response.Redirect("AgendaTurnos.aspx");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Button btnCancelar = (sender as Button);
            string commandName = btnCancelar.CommandName;
            string commandArgument = btnCancelar.CommandArgument;

            GridViewRow row = (btnCancelar.NamingContainer as GridViewRow);

            int rowIndex = row.RowIndex;

            int Turno = Convert.ToInt32(commandName);
            string NombrePaciente = Convert.ToString(commandArgument);

      

            SqlConnection conexionSQL = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "UPDATE TURNOS SET ESTADO = 4 WHERE ID_TURNO = '" + Turno + "' ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexionSQL;
            conexionSQL.Open();
            cmd.ExecuteNonQuery();
            conexionSQL.Close();
            Response.Redirect("AgendaTurnos.aspx");
        }
    }
}