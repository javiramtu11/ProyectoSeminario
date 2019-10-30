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

        public void AddMedico()
        {

            SqlConnection conexionSQL = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand();
            int IdCline = 0;

            IdCline = int.Parse(clinica.Value);
            string dpi = codigo.Value;
            string name = nombre.Value;
            string lastname = apellido.Value;
            string direction = dire.Value;
            string fechaN = fechanac.Value;
            string tel = telefono.Value;
            string usuario = username.Value;
            string pass = clave.Value;
            string tip = tipo.Value;

            if (IdCline == 0 || string.IsNullOrEmpty(fechaN) || string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(tip))
            {
                Response.Write("<script>alert('EXISTEN CAMPOS IMPORTANTES QUE ESTAN VACÍOS, VERIFIQUE PARA CONTINUAR')</script>");

            }

            else
            {
                if (string.IsNullOrEmpty(dpi))
                {
                    dpi = "N/A";
                }
                if (string.IsNullOrEmpty(name))
                {
                    name = "N/A";
                }
                if (string.IsNullOrEmpty(lastname))
                {
                    lastname = "N/A";
                }
                if (string.IsNullOrEmpty(direction))
                {
                    direction = "N/A";
                }
                if (string.IsNullOrEmpty(tel))
                {
                    tel = "N/A";
                }
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
        }

        private void llenarSelect()
        {

            clinica.DataSource = consultar("SELECT * FROM CLINICAS");
            clinica.DataTextField = "CLINICA";
            clinica.DataValueField = "ID_CLINICA";
            clinica.DataBind();

            clinica.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
        }



        public DataSet consultar(string strSQL)
        {

            SqlConnection conexionSQL = new SqlConnection(con);
            conexionSQL.Open();
            SqlCommand cmd = new SqlCommand(strSQL, conexionSQL);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds);
            conexionSQL.Close();
            return ds;



        }

        //public void obtenerMedico()
        //{
        //    SqlConnection conexionSQL = new SqlConnection(con);
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.CommandText = "SELECT ID_MEDICO, c.CLINICA, NOMBRE, DIRECCION, CAST(FECHA_NACIMIENTO AS VARCHAR(12)) AS FECHA, TELEFONO, TIPO_USUARIO, USERNAME, CLAVE FROM CLINICAS c " + 
        //    "INNER JOIN MEDICO d ON c.ID_CLINICA = d.ID_CLINICA ";
        //    cmd.CommandType = CommandType.Text;
        //    cmd.Connection = conexionSQL;
        //    conexionSQL.Open();

        //    DataTable Datos = new DataTable();
        //    Datos.Load(cmd.ExecuteReader());
        //    Grid.DataSource = Datos;
        //    Grid.DataBind();
        //    conexionSQL.Close();

        //}

        //public void buscarMedico()
        //{
        //    //SqlConnection conexionSQL = new SqlConnection(con);
        //    //SqlCommand cmd = new SqlCommand();
        //    ////buscar medico
        //    string buscar = txtbuscar.Value;
        //    //cmd.CommandText = "SELECT d.ID_MEDICO, c.CLINICA, d.DPI, d.NOMBRE, d.APELLIDO, d.DIRECCION,  d.TELEFONO, d.TIPO_USUARIO, d.USERNAME, d.CLAVE FROM CLINICAS AS c " +
        //    //"INNER JOIN MEDICO AS d ON (c.ID_CLINICA = d.ID_CLINICA ) WHERE c.ClINICA LIKE '%" + buscar + "%' OR d.NOMBRE = '"+buscar+ "'OR d.APELLIDO = '" + buscar + "'";

        //    //cmd.CommandType = CommandType.Text;
        //    //cmd.Connection = conexionSQL;
        //    //conexionSQL.Open();//mira este? ahh ya vi algo perame.........perame ya encontre algo

        //    //DataTable Datos = new DataTable();
        //    //Datos.Load(cmd.ExecuteReader());
        //    //Grid.DataSource = Datos;
        //    //Grid.DataBind();
        //    //conexionSQL.Close();


        //    SqlDataSource2.SelectCommand = "SELECT d.ID_MEDICO, c.CLINICA, d.DPI, d.NOMBRE, d.APELLIDO, d.DIRECCION,  d.TELEFONO, d.TIPO_USUARIO, d.USERNAME, d.CLAVE FROM CLINICAS AS c " +
        //    "INNER JOIN MEDICO AS d ON (c.ID_CLINICA = d.ID_CLINICA ) WHERE c.CLINICA LIKE '" + buscar + "' OR d.NOMBRE LIKE '" + buscar + "'OR d.APELLIDO LIKE '" + buscar + "'";
        //    SqlDataSource2.UpdateCommand = "UPDATE MEDICO SET  DPI = @DPI, NOMBRE = @NOMBRE, APELLIDO = @APELLIDO, DIRECCION = @DIRECCION, TELEFONO = @TELEFONO,  TIPO_USUARIO = @TIPO_USUARIO, USERNAME = @USERNAME, CLAVE = @CLAVE WHERE NOMBRE LIKE '" + buscar + "'OR APELLIDO LIKE '" + buscar + "'";






        //}

        protected void Page_Load(object sender, EventArgs e)
        {
            string var = Convert.ToString(Session["USUARIO"]);
            string var2 = Convert.ToString(Session["TIPO"]);

            if (var2 != "Administrador")
            {
                Response.Write("<script>alert('EL USUARIO NO TIENE PERMISOS PARA USAR ESTE FORMULARIO')</script>");

                if (var2 == "Secretaria")
                {
                    Response.Redirect("AppPrincipal.aspx");
                }
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

                if (!IsPostBack)
                {
                    llenarSelect();
                }
                //obtenerMedico();
            }
        }

        protected void InsertarMedico_Click(object sender, EventArgs e)
        {
            AddMedico();
            Response.Redirect("ConfigMedico.aspx");
        }

        protected void BtnBuscarMedico_Click(object sender, EventArgs e)
        {
            //buscarMedico();
        }
    }
}