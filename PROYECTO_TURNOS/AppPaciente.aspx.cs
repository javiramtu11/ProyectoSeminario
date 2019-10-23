using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using PROYECTO_TURNOS;

namespace PG_CitasMedicas
{
    public partial class AppPaciente : System.Web.UI.Page
    {
        MostrarDatos md = new MostrarDatos();
        string con = MostrarDatos.CadenaConexion;

        public void AddPaciente()
        {
            SqlConnection conexionSQL = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand();

            string DPI = dpi.Value;
            string name = nombre.Value;
            string lastname = apellidox.Value;
            string Sexo = genero.Value;
            string dire = direccionx.Value;
            string fechaN = fechanac.Value;
            string muni = municipiox.Value;
            string depto = deptox.Value;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(lastname) || string.IsNullOrEmpty(Sexo) ||
                string.IsNullOrEmpty(dire) || string.IsNullOrEmpty(fechaN) || string.IsNullOrEmpty(muni) ||
                string.IsNullOrEmpty(depto))
            {
                Response.Write("<script>alert('EXISTEN CAMPOS IMPORTANTES QUE ESTAN VACÍOS, VERIFIQUE PARA CONTINUAR')</script>");

            }
            else
            {
                if (string.IsNullOrEmpty(DPI))
                {
                    DPI = "N/A";
                }
                cmd.CommandText = "INSERT INTO PACIENTES (DPI, NOMBRE, APELLIDO, GENERO, DIRECCION, FECHA_NAC, FECHA_INGRESO, ESTADO, DEPARTAMENTO, MUNICIPIO)" +
                    " VALUES (@DPI, @NOMBRE, @APELLIDO, @GENERO, @DIRECCION, @FECHA_NAC, GETDATE(), 1, @DEPTO, @MUNI)";
                cmd.Parameters.Add("@DPI", SqlDbType.Text).Value = DPI;
                cmd.Parameters.Add("@NOMBRE", SqlDbType.Text).Value = name;
                cmd.Parameters.Add("@APELLIDO", SqlDbType.Text).Value = lastname;
                cmd.Parameters.Add("@GENERO", SqlDbType.Text).Value = Convert.ToString(Sexo);
                cmd.Parameters.Add("@DIRECCION", SqlDbType.Text).Value = dire;
                cmd.Parameters.Add("@FECHA_NAC", SqlDbType.Date).Value = Convert.ToDateTime(fechaN);
                cmd.Parameters.Add("@DEPTO", SqlDbType.Text).Value = depto;
                cmd.Parameters.Add("@MUNI", SqlDbType.Text).Value = muni;

                cmd.CommandType = CommandType.Text;
                cmd.Connection = conexionSQL;
                conexionSQL.Open();
                cmd.ExecuteNonQuery();

                Response.Write("<script>alert('Paciente Ingresado con Exito')</script>");
            }
        }

        public void obtenerPaciente() {
            SqlConnection conexionSQL = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ID_PACIENTE, DPI, NOMBRE, GENERO, DIRECCION, FECHA_NAC  FROM PACIENTES WHERE ESTADO = 1";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexionSQL;
            conexionSQL.Open();

            DataTable Datos = new DataTable();
            Datos.Load(cmd.ExecuteReader());
            Grid.DataSource = Datos;
            Grid.DataBind();
            conexionSQL.Close();
        }

        public void buscarPaciente() {

           
            SqlConnection conexionSQL = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand();

            string buscar = TxtBuscar.Text;
            cmd.CommandText = "SELECT ID_PACIENTE, DPI, NOMBRE, GENERO, DIRECCION, FECHA_NAC  FROM PACIENTES WHERE DPI LIKE '%"+buscar+"%' OR NOMBRE = '"+buscar+"' AND ESTADO = 1 ";
            //cmd.Parameters.Add("@buscar", SqlDbType.Text).Value = buscar;
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

            obtenerPaciente();
        }

        protected void InsertarPaciente_Click(object sender, EventArgs e)
        {
            AddPaciente();
            Response.Redirect("AppPaciente.aspx");
        }

        protected void Lbtn_Buscar_Click(object sender, EventArgs e)
        {
            buscarPaciente();
        }
    }
}