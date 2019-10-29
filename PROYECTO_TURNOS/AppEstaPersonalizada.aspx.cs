using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using PROYECTO_TURNOS;


namespace PROYECTO_TURNOS
{
    public partial class AppEstaPersonalizada : System.Web.UI.Page
    {
        protected string ObtnerDatosPieGenero()
        {
            

            MostrarDatos md = new MostrarDatos();
            string con = MostrarDatos.CadenaConexion;
            SqlConnection conexionSQL = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT GENERO, COUNT(GENERO) AS CANTIDAD FROM PACIENTES " +
                "	WHERE FECHA_INGRESO between '" + fechaini.Value + "' and '" + fechafin.Value + "' GROUP BY GENERO ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexionSQL;
            conexionSQL.Open();

            DataTable Datos = new DataTable();
            Datos.Load(cmd.ExecuteReader());
            conexionSQL.Close();



            string strDatos;
            strDatos = "[['Genero', 'Cantidad'],";

            foreach (DataRow dr in Datos.Rows)
            {
                strDatos = strDatos + "[";
                strDatos = strDatos + "'" + dr[0] + "'" + "," + dr[1];
                strDatos = strDatos + "],";
            }

            strDatos = strDatos + "]";

            return strDatos;
        }

        protected string ObtnerDatosNiñoAdulto()
        {
            MostrarDatos md = new MostrarDatos();
            string con = MostrarDatos.CadenaConexion;
            SqlConnection conexionSQL = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = " SELECT CASE P.GENERO WHEN 'Masculino' THEN 'Masculino' WHEN 'Femenino' THEN 'Femenino'" +
                " ELSE ''END AS GENERO," +
                "COUNT(CASE WHEN DATEDIFF(YEAR, FECHA_NAC, GETDATE()) < 18 then 1 end) as Niños," +
                "COUNT(CASE WHEN DATEDIFF(YEAR, FECHA_NAC, GETDATE()) >= 18 then 1 end) as Adultos" +
                " FROM PACIENTES P WHERE P.FECHA_INGRESO between '" + fechaini3.Value + "' and '" + fechafin3.Value + "' group by GENERO";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexionSQL;
            conexionSQL.Open();

            DataTable Datos = new DataTable();
            Datos.Load(cmd.ExecuteReader());
            conexionSQL.Close();

            string strDatos;
            strDatos = "[['Genero','Niños', 'Adultos'],";

            foreach (DataRow dr in Datos.Rows)
            {
                strDatos = strDatos + "[";
                strDatos = strDatos + "'" + dr[0] + "'" + "," + dr[1] + "," + dr[2];
                strDatos = strDatos + "],";
            }

            strDatos = strDatos + "]";

            return strDatos;
        }

        protected string ObtnerDatosMunicipio()
        {
            MostrarDatos md = new MostrarDatos();
            string con = MostrarDatos.CadenaConexion;
            SqlConnection conexionSQL = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT  MUNICIPIO, COUNT(MUNICIPIO) AS CANTIDAD FROM PACIENTES " +
                "WHERE FECHA_INGRESO between '" + fechaini4.Value + "' and '" + fechafin4.Value + "' GROUP BY MUNICIPIO;";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexionSQL;
            conexionSQL.Open();

            DataTable Datos = new DataTable();
            Datos.Load(cmd.ExecuteReader());
            conexionSQL.Close();



            string strDatos;
            strDatos = "[['Genero', 'Cantidad'],";

            foreach (DataRow dr in Datos.Rows)
            {
                strDatos = strDatos + "[";
                strDatos = strDatos + "'" + dr[0] + "'" + "," + dr[1];
                strDatos = strDatos + "],";
            }

            strDatos = strDatos + "]";

            return strDatos;
        }



        protected string ObtnerDatosGeneroConRango()
        {
            MostrarDatos md = new MostrarDatos();
            string con = MostrarDatos.CadenaConexion;
            SqlConnection conexionSQL = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT CASE P.GENERO WHEN 'Masculino' THEN 'Masculino' WHEN 'Femenino' THEN 'Femenino' ELSE '' END AS GENERO, " +
                "COUNT(case when DATEDIFF(YEAR, FECHA_NAC, GETDATE()) >= 0 AND DATEDIFF(YEAR, FECHA_NAC, GETDATE()) <= 10 then 1 end) AS DE_0_A_10," +
                " COUNT(case when DATEDIFF(YEAR, FECHA_NAC, GETDATE()) >= 11 AND DATEDIFF(YEAR, FECHA_NAC, GETDATE()) <= 25 then 1 end) AS DE_11_A_25, " +
                "COUNT(case when DATEDIFF(YEAR, FECHA_NAC, GETDATE()) >= 26 AND DATEDIFF(YEAR, FECHA_NAC, GETDATE()) <= 50 then 1 end) AS DE_26_A_50, " +
                "COUNT(case when DATEDIFF(YEAR, FECHA_NAC, GETDATE()) >= 51 AND DATEDIFF(YEAR, FECHA_NAC, GETDATE()) <= 65 then 1 end) AS DE_51_A_65, " +
                "COUNT(case when DATEDIFF(YEAR, FECHA_NAC, GETDATE()) >= 66 then 1 end) AS MAYOR_A_66  " +
                "FROM PACIENTES P WHERE P.FECHA_INGRESO between '" + fechaini2.Value + "' and '" + fechafin2.Value + "' group by GENERO";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexionSQL;
            conexionSQL.Open();

            DataTable Datos = new DataTable();
            Datos.Load(cmd.ExecuteReader());
            conexionSQL.Close();

            string strDatos;
            strDatos = "[['Genero', '0 - 10 Años', '11 - 25 Años', '26 - 50 Años', '51 - 65 Años', 'Mayor a 66 Años'],";

            foreach (DataRow dr in Datos.Rows)
            {
                strDatos = strDatos + "[";
                strDatos = strDatos + "'"
                    + dr[0] + "', "
                    + dr[1] + ", "
                    + dr[2] + ", "
                    + dr[3] + ", "
                    + dr[4] + ", "
                    + dr[5];
                strDatos = strDatos + "],";
            }
            strDatos = strDatos + "]";
            return strDatos;
        }

        protected string ObtnerDatosTurnosMedicos()
        {
            MostrarDatos md = new MostrarDatos();
            string con = MostrarDatos.CadenaConexion;
            SqlConnection conexionSQL = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT(d.NOMBRE + ' ' + d.APELLIDO)AS MEDICO," +
                " COUNT (CASE WHEN t.ESTADO = 2 then 1 end) as Atendidos,	" +
                "COUNT(CASE WHEN t.ESTADO = 3 then 1 end) as Suspendidos," +
                "COUNT(CASE WHEN t.ESTADO = 4 then 1 end) as Cancelados FROM MEDICO d " +
                "inner join TURNOS t on(t.ID_MEDICO = d.ID_MEDICO)" +
                "WHERE t.FECHA_INGRESO between '" + fechaini5.Value + "' and '" + fechafin5.Value + "'" +
                " group by t.ID_MEDICO, d.NOMBRE, d.APELLIDO; ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexionSQL;
            conexionSQL.Open();

            DataTable Datos = new DataTable();
            Datos.Load(cmd.ExecuteReader());
            conexionSQL.Close();

            string strDatos;
            strDatos = "[['Medico', 'Atendidos', 'Suspendidos', 'Cancelados'],";

            foreach (DataRow dr in Datos.Rows)
            {
                strDatos = strDatos + "[";
                strDatos = strDatos + "'"
                    + dr[0] + "', "
                    + dr[1] + ", "
                    + dr[2] + ", "
                    + dr[3];
                strDatos = strDatos + "],";
            }
            strDatos = strDatos + "]";
            return strDatos;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            string var = Convert.ToString(Session["USUARIO"]);

            if (String.IsNullOrEmpty(var))
            {
                Response.Redirect("Login.aspx");
            }

            if (!Page.IsPostBack)
            {
                
            }
        }

        protected void btnact1_Click(object sender, EventArgs e)
        {
            
            ObtnerDatosPieGenero();
        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            ObtnerDatosGeneroConRango();
        }

        protected void Btn3_Click(object sender, EventArgs e)
        {
            ObtnerDatosNiñoAdulto();
        }

        protected void Btn4_Click(object sender, EventArgs e)
        {
            ObtnerDatosMunicipio();
        }

        protected void Btn5_Click(object sender, EventArgs e)
        {
            ObtnerDatosTurnosMedicos();
        }
    }
}