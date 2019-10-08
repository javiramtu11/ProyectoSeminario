
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace PG_CitasMedicas
{
    public partial class AppPrincipal : System.Web.UI.Page
    {
        string CadenaConexion = "Data Source = DESKTOP-RTIU5G0; Initial Catalog = HospitalAdonai; Integrated Security = True";
        int idPaciente = 0; //ahora te muestro se llena esta variable

        public void AddPaciente()
        {
            SqlConnection conexionSQL = new SqlConnection(CadenaConexion);
            SqlCommand cmd = new SqlCommand();

            string DPI = dpi.Value;
            string name = nombre.Value;
            string lastname = apellidox.Value;
            string Sexo = genero.Value;
            string dire = direccionx.Value;
            string fechaN = fechanac.Value;

            cmd.CommandText = "INSERT INTO PACIENTES (DPI, NOMBRE, APELLIDO, GENERO, DIRECCION, FECHA_NAC, FECHA_INGRESO, ESTADO)" +
                " VALUES (@DPI, @NOMBRE, @APELLIDO, @GENERO, @DIRECCION, @FECHA_NAC, GETDATE(), 1)";
            cmd.Parameters.Add("@DPI", SqlDbType.Text).Value = DPI;
            cmd.Parameters.Add("@NOMBRE", SqlDbType.Text).Value = name;
            cmd.Parameters.Add("@APELLIDO", SqlDbType.Text).Value = lastname;
            cmd.Parameters.Add("@GENERO", SqlDbType.Text).Value = Convert.ToString(Sexo);
            cmd.Parameters.Add("@DIRECCION", SqlDbType.Text).Value = dire;
            cmd.Parameters.Add("@FECHA_NAC", SqlDbType.Date).Value = Convert.ToDateTime(fechaN);

            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexionSQL;
            conexionSQL.Open();
            cmd.ExecuteNonQuery();

            limpiarText();
        }

        public void buscarllenarPaciente() {

            SqlConnection conexionSQL = new SqlConnection(CadenaConexion);
            SqlCommand cmd = new SqlCommand();

            string buscar = dpimodal.Value;
            cmd.CommandText = "SELECT ID_PACIENTE, NOMBRE, APELLIDO, DIRECCION, CAST(FECHA_NAC AS VARCHAR(12)) AS Fecha   FROM PACIENTES WHERE DPI LIKE '%" + buscar + "%' OR NOMBRE = '" + buscar + "' AND ESTADO = 1 ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexionSQL;
            conexionSQL.Open();

            DataTable Datos = new DataTable();
            Datos.Load(cmd.ExecuteReader());
            int x = 0;
            foreach (DataRow item in Datos.Rows)
            {
                if (x == 0)
                {
                    idPaciente = int.Parse(item[0].ToString());
                    Session["PACIENTE"] = idPaciente; 
                    x++;
                }
                if (x == 1)
                {
                    nombremodal.Value = item[1].ToString();
                    x++;
                }
                if (x == 2)
                {
                    apellidomodal.Value = item[2].ToString();
                    x++;
                }
                if (x == 3)
                {
                    direccionmodal.Value = item[3].ToString();
                    x++;
                }
                if (x == 4)
                {
                    fechamodal.Value = Convert.ToString(item[4]).ToString();
                    x++;
                }

            } 
            conexionSQL.Close();

        }

        public DataSet consultar(string strSQL)
        {

            SqlConnection conexionSQL = new SqlConnection(CadenaConexion);
            conexionSQL.Open();
            SqlCommand cmd = new SqlCommand(strSQL, conexionSQL);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds);
            conexionSQL.Close();
            return ds;



        }

        private void llenarSelect()
        {

            doctor.DataSource = consultar("SELECT * FROM MEDICO");
            doctor.DataTextField = "NOMBRE";
            doctor.DataValueField = "ID_MEDICO";
            doctor.DataBind();

            doctor.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
        }

        public void AddTurno() {

            SqlConnection conexionSQL = new SqlConnection(CadenaConexion);
            SqlCommand cmd = new SqlCommand();
            
            int medico = int.Parse(doctor.Value); 
            int paciente = idPaciente;
            string fecha = datecita.Value;
            string motivo = motivomodal.Value;

            //VALIDACIONES ANTES DE INSERTAR 
            string turnoDiario = null;
            int insertarNum = 0;
            DateTime thisDay = DateTime.Today;
            string fechaactual = Convert.ToString(thisDay.ToString("d"));

            //sabes el id? me imagino que es el 1 porque es el unico va
            // hay que hacer una validación que cuando no seleccione médico le mande un alert ok probemoslo

            //fecha actual + id médico, para que nos jale el ultimo turno para ese médico específico
            //lo probaremos hasta allí para no hacer el insert dale// hay que llamar la funcion perame
            
                
            cmd.CommandText = "SELECT TOP 1 TURNO_DIARIO FROM TURNOS WHERE FECHA_INGRESO = '" + fecha + "' AND ID_MEDICO = '" + medico + "' ORDER BY TURNO_DIARIO DESC";

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

                    turnoDiario = item[0].ToString();
                    y++;
                }
            }
            insertarNum = Convert.ToInt32(turnoDiario) + 1;
            conexionSQL.Close();

            int var = Convert.ToInt32(Session["PACIENTE"]);

            cmd.CommandText = "INSERT INTO TURNOS (TURNO_DIARIO, ID_MEDICO, ID_PACIENTE, FECHA_INGRESO, MOTIVO, ESTADO)" +
              " VALUES (@TURNO_DIARIO, @ID_MEDICO, @ID_PACIENTE, @FECHAIN, @MOTIVO, 1)";
            cmd.Parameters.Add("@TURNO_DIARIO", SqlDbType.Int).Value = int.Parse(insertarNum.ToString());
            cmd.Parameters.Add("@ID_MEDICO", SqlDbType.Int).Value = medico;
            cmd.Parameters.Add("@ID_PACIENTE", SqlDbType.Int).Value = var;
            cmd.Parameters.Add("@FECHAIN", SqlDbType.Date).Value = Convert.ToDateTime(fecha);
            cmd.Parameters.Add("@MOTIVO", SqlDbType.Text).Value = motivo;
            //probemos ok
           
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexionSQL;
            conexionSQL.Open();
            cmd.ExecuteNonQuery();
            Response.Write("<script>alert('Turno Ingresado con Exito')</script>");
        }

        public void limpiarText() {
            dpimodal.Value = null;
            nombremodal.Value = null;
            apellidomodal.Value = null;
            fechamodal.Value = null;
            direccionmodal = null;
            motivomodal.Value = null;
            datecita.Value = null;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                llenarSelect();
            }
        }

        protected void InsertarPaciente_Click(object sender, EventArgs e)
        {
            AddPaciente();
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            buscarllenarPaciente();
        }

        protected void BtnGenerarCita_Click(object sender, EventArgs e)
        {
            AddTurno();
            Response.Redirect("AppPrincipal.aspx");
        }
    }
}