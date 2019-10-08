using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace PROYECTO_TURNOS
{
    public partial class ConfigMedico : System.Web.UI.Page
    {

        string CadenaConexion = "Data Source = DESKTOP-RTIU5G0; Initial Catalog = HospitalAdonai; Integrated Security = True";

        public void AddMedico() {

            SqlConnection conexionSQL = new SqlConnection(CadenaConexion);
            SqlCommand cmd = new SqlCommand();

            int IdCline = int.Parse(clinica.Value);
            string name = nombre.Value;
            string lastname = apellido.Value;
            string direction = dire.Value;
            string fechaN = fechanac.Value;
            string tel = telefono.Value;

            cmd.CommandText = "INSERT INTO MEDICO (ID_CLINICA, NOMBRE, APELLIDO, DIRECCION, FECHA_NACIMIENTO, TELEFONO, ESTADO)" +
               " VALUES (@ID_CLINICA, @NOMBRE, @APELLIDO, @DIRECCION, @FECHANAC, @TELEFONO, 1)";
            cmd.Parameters.Add("@ID_CLINICA", SqlDbType.Int).Value = IdCline;
            cmd.Parameters.Add("@NOMBRE", SqlDbType.Text).Value = name;
            cmd.Parameters.Add("@APELLIDO", SqlDbType.Text).Value = lastname;
            cmd.Parameters.Add("@DIRECCION", SqlDbType.Text).Value = direction;
            cmd.Parameters.Add("@FECHANAC", SqlDbType.Date).Value = Convert.ToDateTime(fechaN);
            cmd.Parameters.Add("@TELEFONO", SqlDbType.Text).Value = tel;

            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexionSQL;
            conexionSQL.Open();
            cmd.ExecuteNonQuery();
            Response.Write("<script>alert('Doctor Ingresado con Exito')</script>");

        }

        private void llenarSelect() {

            clinica.DataSource = consultar("SELECT * FROM CLINICAS");
            clinica.DataTextField = "CLINICA";
            clinica.DataValueField = "ID_CLINICA";
            clinica.DataBind();

            clinica.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
        }
  
       

        public DataSet consultar(string strSQL) {

            SqlConnection conexionSQL = new SqlConnection(CadenaConexion);
            conexionSQL.Open();
            SqlCommand cmd = new SqlCommand(strSQL, conexionSQL);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds);
            conexionSQL.Close();
            return ds;



        }

        public void obtenerMedico() {
            SqlConnection conexionSQL = new SqlConnection(CadenaConexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ID_MEDICO, c.CLINICA, NOMBRE, DIRECCION, FECHA_NACIMIENTO, TELEFONO  FROM CLINICAS c "+ 
            "INNER JOIN MEDICO d ON c.ID_CLINICA = d.ID_CLINICA ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexionSQL;
            conexionSQL.Open();

            DataTable Datos = new DataTable();
            Datos.Load(cmd.ExecuteReader());
            Grid.DataSource = Datos;
            Grid.DataBind();
            conexionSQL.Close();

        }

        public void buscarMedico() {
            SqlConnection conexionSQL = new SqlConnection(CadenaConexion);
            SqlCommand cmd = new SqlCommand();

            string buscar = txtbuscar.Value;
            cmd.CommandText = "SELECT ID_MEDICO, c.CLINICA, NOMBRE, DIRECCION, FECHA_NACIMIENTO, TELEFONO  FROM CLINICAS c " +
            "INNER JOIN MEDICO d ON (c.ID_CLINICA = d.ID_CLINICA ) WHERE c.ClINICA LIKE '%" + buscar + "%' OR NOMBRE = '"+buscar+"'";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexionSQL;
            conexionSQL.Open();//mira este? ahh ya vi algo perame.........perame ya encontre algo

            DataTable Datos = new DataTable();
            Datos.Load(cmd.ExecuteReader());
            Grid.DataSource = Datos;
            Grid.DataBind();
            conexionSQL.Close();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                llenarSelect();
            }
            obtenerMedico();
        }

        protected void InsertarMedico_Click(object sender, EventArgs e)
        {
            AddMedico();
            Response.Redirect("ConfigMedico.aspx");
        }

        protected void BtnBuscarMedico_Click(object sender, EventArgs e)
        {
            buscarMedico();
        }
    }
}