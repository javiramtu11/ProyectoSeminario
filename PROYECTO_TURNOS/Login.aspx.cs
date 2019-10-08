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
        string CadenaConexion = "Data Source = DESKTOP-RTIU5G0; Initial Catalog = HospitalAdonai; Integrated Security = True";

        public void buscarUsuario() {

            SqlConnection conexionSQL = new SqlConnection(CadenaConexion);
            SqlCommand cmd = new SqlCommand();

            DataTable tabla;
            string id;
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;

            if (usuario.Contains("=") || usuario.Contains("'") || password.Contains("=") || password.Contains("'"))
            {
                Response.Write("<script>alert('SIMBOLOS NO ADMITIDOS, VERIFIQUE PARA CONTINUAR')</script>");
            }
            else
            {
                string sql = null;
                sql = "SELECT NOMBRE, APELLIDO, USERNAME FROM USUARIOS WHERE USERNAME = '"+usuario+"' AND CLAVE = '"+password+"' ";
                id = obtenertipo(sql);

                //ESTOS DATOS SIRVEN PARA HACER MATCH CON LA TABLA DOCTORES

                DataTable Datos = RunSQL(sql);
                int x = 0;
                foreach (DataRow item in Datos.Rows)
                {
                    if (x == 0)
                    {
                        Session["NOMBREUSER"] = item[0].ToString();
                        x++;
                    }
                    if (x == 1)
                    {
                        Session["APELLIDOUSER"] = item[1].ToString();
                        x++;
                    }
                    if (x == 2)
                    {
                        string user = item[2].ToString();
                    }
                }


                if (string.IsNullOrEmpty(id))
                {
                    Response.Write("<script>alert('CREDENCIALES INCORRECTAS')</script>");
                }
                else
                {
                    Session["USUARIO"] = txtUsuario.Text;
                    string var = Convert.ToString(Session["USUARIO"]);
                    Response.Redirect("AppPrincipal.aspx");
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