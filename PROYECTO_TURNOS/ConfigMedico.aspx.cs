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

        MostrarDatos md = new MostrarDatos();
        string con = MostrarDatos.CadenaConexion;

        public void AddMedico() {

            SqlConnection conexionSQL = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand();

            int IdCline = int.Parse(clinica.Value);
            string dpi = codigo.Value;
            string name = nombre.Value;
            string lastname = apellido.Value;
            string direction = dire.Value;
            string fechaN = fechanac.Value;
            string tel = telefono.Value;
            string usuario = username.Value;
            string pass = clave.Value;
            string tip = tipo.Value;

 
            cmd.CommandText = "INSERT INTO MEDICO (ID_CLINICA, NOMBRE, APELLIDO, DIRECCION, FECHA_NACIMIENTO, TELEFONO, ESTADO, DPI, TIPO_USUARIO, USERNAME, CLAVE)" +
               " VALUES (@ID_CLINICA, @NOMBRE, @APELLIDO, @DIRECCION, @FECHANAC, @TELEFONO, 1, @DPI , @TIPO, @USER, @CLAVE)";
            cmd.Parameters.Add("@ID_CLINICA", SqlDbType.Int).Value = IdCline;
            cmd.Parameters.Add("@NOMBRE", SqlDbType.Text).Value = name;
            cmd.Parameters.Add("@APELLIDO", SqlDbType.Text).Value = lastname;
            cmd.Parameters.Add("@DIRECCION", SqlDbType.Text).Value = direction;
            cmd.Parameters.Add("@FECHANAC", SqlDbType.Date).Value = Convert.ToDateTime(fechaN);
            cmd.Parameters.Add("@TELEFONO", SqlDbType.Text).Value = tel;
            cmd.Parameters.Add("@DPI", SqlDbType.Text).Value = dpi;
            cmd.Parameters.Add("@TIPO", SqlDbType.Text).Value = tip;
            cmd.Parameters.Add("@USER", SqlDbType.Text).Value = usuario;
            cmd.Parameters.Add("@CLAVE", SqlDbType.Text).Value = pass;

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

            SqlConnection conexionSQL = new SqlConnection(con);
            conexionSQL.Open();
            SqlCommand cmd = new SqlCommand(strSQL, conexionSQL);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds);
            conexionSQL.Close();
            return ds;



        }

        public void obtenerMedico() {
            SqlConnection conexionSQL = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ID_MEDICO, c.CLINICA, NOMBRE, DIRECCION, FECHA_NACIMIENTO, TELEFONO, TIPO_USUARIO, USERNAME  FROM CLINICAS c "+ 
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
            SqlConnection conexionSQL = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand();
            //buscar medico
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
            string var = Convert.ToString(Session["USUARIO"]);

            if (String.IsNullOrEmpty(var))
            {
                Response.Redirect("Login.aspx");
            }

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