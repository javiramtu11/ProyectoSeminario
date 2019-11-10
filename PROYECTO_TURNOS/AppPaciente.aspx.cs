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
            cmd.CommandText = "SELECT ID_PACIENTE, DPI, NOMBRE, APELLIDO, GENERO, DIRECCION, CAST(FECHA_NAC AS VARCHAR(12)) AS FECHA, DEPARTAMENTO, MUNICIPIO  FROM PACIENTES WHERE ESTADO = 1 order by NOMBRE";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexionSQL;
            conexionSQL.Open();

            DataTable Datos = new DataTable();
            Datos.Load(cmd.ExecuteReader());
            Grid.DataSource = Datos;
            Grid.DataBind();
            conexionSQL.Close();
        }

        //public void buscarPaciente() {

           
        //    SqlConnection conexionSQL = new SqlConnection(con);
        //    SqlCommand cmd = new SqlCommand();

        //    string buscar = TxtBuscar.Text;
        //    string buscar1 = Text1.Value;
        //    cmd.CommandText = "SELECT ID_PACIENTE, DPI, NOMBRE, APELLIDO, (NOMBRE + ' ' + APELLIDO) AS PERSONA, GENERO, DIRECCION, CAST(FECHA_NAC AS VARCHAR(12)) AS FECHA  FROM PACIENTES WHERE DPI LIKE '%" + buscar1+"%' OR NOMBRE = '"+buscar1+ "' OR PERSONA = '" + buscar1 + "' AND ESTADO = 1 ";
        //    //cmd.Parameters.Add("@buscar", SqlDbType.Text).Value = buscar;
        //    cmd.CommandType = CommandType.Text;
        //    cmd.Connection = conexionSQL;
        //    conexionSQL.Open();

        //    DataTable Datos = new DataTable();
        //    Datos.Load(cmd.ExecuteReader());
        //    Grid.DataSource = Datos;
        //    Grid.DataBind();
        //    conexionSQL.Close();
            
        //}

        protected void Page_Load(object sender, EventArgs e)
        {
            string var = Convert.ToString(Session["USUARIO"]);

            string var2 = Convert.ToString(Session["TIPO"]);

            if (String.IsNullOrEmpty(var))
            {
                Response.Redirect("Login.aspx");
            }

            if (!Page.IsPostBack)
            {

            }

            if (var2 != "Secretaria" && var2 != "Administrador")
            {
                Response.Write("<script>alert('EL USUARIO NO TIENE PERMISOS PARA USAR ESTE FORMULARIO')</script>");

                if (var2 == "Doctor")
                {
                    Response.Redirect("AgendaTurnos.aspx");
                }

            }

            else
            {

                if (String.IsNullOrEmpty(var))
                {
                    Response.Redirect("Login.aspx");
                }

                //obtenerPaciente();
            }
        }

        protected void InsertarPaciente_Click(object sender, EventArgs e)
        {
            AddPaciente();
        }

        protected void Lbtn_Buscar_Click(object sender, EventArgs e)
        {
            //buscarPaciente();
        }

        protected void rowEditingEvent(object sender, GridViewEditEventArgs e)
        {
            Grid.EditIndex = e.NewEditIndex;
            obtenerPaciente();
        }

        protected void Grid_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            Grid.PageIndex = e.NewPageIndex;
            obtenerPaciente();
        }

        protected void rowUpdatingEvent(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow fila = Grid.Rows[e.RowIndex];
            int codigo = Convert.ToInt32(Grid.DataKeys[e.RowIndex].Values[0]);

            string dpi = (fila.FindControl("TextDPI") as TextBox).Text;
            string nombre = (fila.FindControl("TextNOMBRE") as TextBox).Text;
            string apellido = (fila.FindControl("TextAPELLIDO") as TextBox).Text;
            string Genero = (fila.FindControl("TextGENERO") as TextBox).Text;
            string direccion = (fila.FindControl("TextDIRECCION") as TextBox).Text;
            string fechanac = (fila.FindControl("TextFECHANAC") as TextBox).Text;
            string depto = (fila.FindControl("TextDEPARTAMENTO") as TextBox).Text;
            string muni = (fila.FindControl("TextMUNICIPIO") as TextBox).Text;
            
            if (Grid.DataKeys[e.RowIndex].Value.ToString() == null)
            {

            }
            else
            {
                string sql = "update PACIENTES set DPI = '" + dpi + "', NOMBRE = '" + nombre + "', APELLIDO = '" + apellido + "', GENERO = '" + Genero + "', DIRECCION = '" + direccion + "', FECHA_NAC = '" + fechanac + "', DEPARTAMENTO = '" + depto + "', MUNICIPIO = '" + muni + "' where ID_PACIENTE = " + Grid.DataKeys[e.RowIndex].Value.ToString();
                MostrarDatos clas_consulta = new MostrarDatos();

                if (clas_consulta.non_query(sql))
                {
                    obtenerPaciente();
                    Response.Write("<script>alert('MODIFICACIÓN REALIZADA EXITOSAMENTE')</script>");
                }
                else
                {
                    Response.Write("<script>alert('NO SE HA PODIDO MODIFICAR')</script>");
                }
            }

            Grid.EditIndex = -1;
            obtenerPaciente();
        }


    }
}