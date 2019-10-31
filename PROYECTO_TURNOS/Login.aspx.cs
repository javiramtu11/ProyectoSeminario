using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace PROYECTO_TURNOS
{
    public partial class Login : System.Web.UI.Page
    {
        MostrarDatos md = new MostrarDatos();
        string con = MostrarDatos.CadenaConexion;
        string CadenaConexion = "Data Source = DOUGLASJR; Initial Catalog = HospitalAdonai; Integrated Security = True";

        public void buscarUsuario() {

            SqlConnection conexionSQL = new SqlConnection(CadenaConexion);
            SqlCommand cmd = new SqlCommand();

            DataTable tabla;
            string id = null;
            string tipo = null;
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;

            if (usuario.Contains("=") || usuario.Contains("'") || password.Contains("=") || password.Contains("'"))
            {
                Response.Write("<script>alert('SIMBOLOS NO ADMITIDOS, VERIFIQUE PARA CONTINUAR')</script>");
            }
            else
                {
                       cmd.CommandText = "SELECT NOMBRE, APELLIDO, USERNAME, TIPO_USUARIO FROM MEDICO WHERE USERNAME = '" + usuario + "' AND CLAVE = '" + password + "'";
                       cmd.CommandType = CommandType.Text;
                       cmd.Connection = conexionSQL;
                       conexionSQL.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                            if (reader.Read())
                            {
                                id = (Convert.ToString(reader[0]));
                                tipo = (Convert.ToString(reader[3]));
                                 Console.WriteLine(tipo);
                            }
                           

                if (string.IsNullOrEmpty(id))
                {
                    Response.Write("<script>alert('CREDENCIALES INCORRECTAS')</script>");
                }
                else
                {
                    Session["USUARIO"] = txtUsuario.Text;
                    Session["TIPO"] = tipo;
                    string var = Convert.ToString(Session["USUARIO"]);

                    if (tipo == "Doctor")
                    {
                        Response.Redirect("AgendaTurnos.aspx");
                    }
                    else if (tipo == "Secretaria")
                    {
                        Response.Redirect("AppPrincipal.aspx");
                    }
                    else if (tipo == "Administrador")
                    {
                        Response.Redirect("AppEstadistica.aspx");
                    }
                    else {
                        Response.Write("<script>alert('TIPO DE USUARIO NO EXISTENTE')</script>");
                    }




                }

            }


        }

        public DataTable RunSQL(String sql)
        {
            SqlConnection cnn = new SqlConnection(CadenaConexion);
            SqlCommand command = new SqlCommand(sql, cnn);
            cnn.Open();
            command.CommandTimeout = 0;
            SqlDataReader reader = command.ExecuteReader();
            DataTable datos = new DataTable();
            datos.Load(reader);
            cnn.Close();
            command.Dispose();
            return datos;
        }

        public string obtenertipo(string sql)
        {
            string Resul = "";
            SqlConnection cnn = new SqlConnection(CadenaConexion);
            SqlCommand command = new SqlCommand(sql, cnn);
            cnn.Open();
            command.CommandTimeout = 0;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Resul = (Convert.ToString(reader[0]));
            }
            return Resul;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Session["USUARIO"] = null;
        }
        protected void BtnIngresar_Click(object sender, EventArgs e)
        {

            buscarUsuario();
        }
    }
}