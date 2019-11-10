using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace PG_CitasMedicas
{
    public partial class ConfUsuarios : System.Web.UI.Page
    {
        string CadenaConexion = @"Data Source = JAVIRAMPC\BDDJAVIERAM; Initial Catalog = HospitalAdonai; Integrated Security = True";
        
        public void AddUser() {
            //insertar la BDD
            SqlConnection conexionSQL = new SqlConnection(CadenaConexion);
            SqlCommand cmd = new SqlCommand();

            string name = nombre.Value;
            string lastname = apellido.Value;
            string DPI = dpi.Value;
            string tel = telefono.Value;
            string email = correo.Value;
            string dir = dire.Value;
            string tipUser = tipo.Value;
            string username = usuario.Value;
            string clave = pass.Value;
            

            cmd.CommandText = "INSERT INTO USUARIOS (NOMBRE, APELLIDO, DPI, TELEFONO, EMAIL, DIRECCION, TIPO_USUARIO, USERNAME, CLAVE, FECHA_INGRESO, ESTADO)" +
                " VALUES (@NOMBRE, @APELLIDO, @DPI, @TELEFONO, @EMAIL, @DIRECCION, @TIPO_USUARIO, @USERNAME, @CLAVE, GETDATE(), 1)";
            cmd.Parameters.Add("@NOMBRE", SqlDbType.Text).Value = Convert.ToString(name);
            cmd.Parameters.Add("@APELLIDO", SqlDbType.Text).Value = lastname;
            cmd.Parameters.Add("@DPI", SqlDbType.Text).Value = DPI;
            cmd.Parameters.Add("@TELEFONO", SqlDbType.Text).Value = tel;
            cmd.Parameters.Add("@EMAIL", SqlDbType.Text).Value = email;
            cmd.Parameters.Add("@DIRECCION", SqlDbType.Text).Value = dir;
            cmd.Parameters.Add("@TIPO_USUARIO", SqlDbType.Text).Value = Convert.ToString(tipUser);
            cmd.Parameters.Add("@USERNAME", SqlDbType.Text).Value = username;
            cmd.Parameters.Add("@CLAVE", SqlDbType.Text).Value = Convert.ToString(clave);

            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexionSQL;
            conexionSQL.Open();
            cmd.ExecuteNonQuery();

            Response.Write("<script>alert('Usuario Ingresado con Exito')</script>");

        }

        public void obtnerUser() {

            SqlConnection conexionSQL = new SqlConnection(CadenaConexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ID_USER, TIPO_USUARIO, NOMBRE, TELEFONO, DPI, USERNAME, DIRECCION, EMAIL FROM USUARIOS WHERE ESTADO = 1";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexionSQL;
            conexionSQL.Open();

            DataTable Datos = new DataTable();
            Datos.Load(cmd.ExecuteReader());
            Grid.DataSource = Datos;
            Grid.DataBind();
            conexionSQL.Close();
        }

        public void buscarUsuario() {
            SqlConnection conexionSQL = new SqlConnection(CadenaConexion);
            SqlCommand cmd = new SqlCommand();

            string buscar = txtbuscar.Value;
            cmd.CommandText = "SELECT ID_USER, TIPO_USUARIO, NOMBRE, TELEFONO, DPI, USERNAME, DIRECCION, EMAIL FROM USUARIOS WHERE DPI LIKE '%" + buscar + "%' OR NOMBRE = '" + buscar + "' AND ESTADO = 1 ";
           
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
            string var = Convert.ToString(Session["USUARIO"]);

            if (String.IsNullOrEmpty(var))
            {
                Response.Redirect("Login.aspx");
            }

            obtnerUser();
        }

        protected void InsertarUsuario_Click(object sender, EventArgs e)
        {
            AddUser();
            Response.Redirect("ConfUsuarios.aspx");
        }

        protected void BtnBuscarUser_Click(object sender, EventArgs e)
        {
            buscarUsuario();
        }
    }
}