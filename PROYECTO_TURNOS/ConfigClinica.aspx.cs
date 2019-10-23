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
    public partial class ConfigClinica : System.Web.UI.Page
    {
        MostrarDatos md = new MostrarDatos();
        string con = MostrarDatos.CadenaConexion;

        public void AddCline() {

            SqlConnection conexionSQL = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand();

            string cline = clinica.Value;
            string desc = Descripcion.Value;

            cmd.CommandText = "INSERT INTO CLINICAS (CLINICA, DESCRIPCION, ESTADO)" +
                " VALUES (@CLINICA, @DESCRIPCION, 1)";
            cmd.Parameters.Add("@CLINICA", SqlDbType.Text).Value = cline;
            cmd.Parameters.Add("@DESCRIPCION", SqlDbType.Text).Value = desc;

            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexionSQL;
            conexionSQL.Open();
            cmd.ExecuteNonQuery();

            Response.Write("<script>alert('Clinica Ingresada con Exito')</script>");
        }

        public void obtenerClinica() {
            SqlConnection conexionSQL = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT ID_CLINICA, CLINICA, DESCRIPCION FROM CLINICAS WHERE ESTADO = 1";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexionSQL;
            conexionSQL.Open();

            DataTable Datos = new DataTable();
            Datos.Load(cmd.ExecuteReader());
            Grid.DataSource = Datos;
            Grid.DataBind();
            conexionSQL.Close();
        }

        public void buscarClinica() {
            SqlConnection conexionSQL = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand();

            string buscar = txtbuscar.Value;
            cmd.CommandText = "SELECT ID_CLINICA, CLINICA, DESCRIPCION FROM CLINICAS WHERE CLINICA LIKE '%" + buscar + "%' AND ESTADO = 1 ";

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

            if (!IsPostBack)
            {
                obtenerClinica();
            }

            
        }

        protected void InsertarClinica_Click(object sender, EventArgs e)
        {
            AddCline();
            Response.Redirect("ConfigClinica.aspx");
        }

        protected void BtnBuscarClinica_Click(object sender, EventArgs e)
        {
            buscarClinica();
        }
    }
}