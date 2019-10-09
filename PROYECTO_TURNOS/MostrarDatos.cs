using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace PROYECTO_TURNOS
{
    public class MostrarDatos : System.Web.UI.Page
    {
        public const string CadenaConexion = "Data Source = DESKTOP-RTIU5G0; Initial Catalog = HospitalAdonai; Integrated Security = True";
        public string doc = null, doc2 = null, doc3 = null;
        public string paciente = null, paciente2 = null, paciente3 = null;
        public string turno = null, turno2 = null, turno3 = null;
        
        public void clinica1()
        {
            int Noturno = 0;
            string persona = null;
            string dt = null;

            SqlConnection conexionSQL = new SqlConnection(CadenaConexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT TURNO_DIARIO, (p.NOMBRE + ' ' + p.APELLIDO)AS PERSONA, (d.NOMBRE + ' ' + d.APELLIDO)AS DOCTOR FROM PACIENTES p  " +
                "INNER JOIN TURNOS t ON p.ID_PACIENTE = t.ID_PACIENTE " +
                "INNER JOIN MEDICO d ON d.ID_MEDICO = t.ID_MEDICO " +
                "WHERE t.ID_MEDICO = '"+ Session["IDdoctor"] + "' AND ID_TURNO = '"+ Session["Turno"] + "' ";

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

                    Noturno = int.Parse(item[0].ToString());
                    y++;
                }
                if (y == 1)
                {
                    persona = item[1].ToString();
                    y++;
                }
                if (y == 2)
                {
                    dt = item[2].ToString();
                    y++;
                }
               
            }
            
            if (string.IsNullOrEmpty(Session["NombreDoc"].ToString()) || string.IsNullOrEmpty(Session["Turno"].ToString()) || string.IsNullOrEmpty(Session["NomPaciente"].ToString()))
            {

            }
            else
            
            {   
                doc = dt;
                turno = Convert.ToString(Noturno);
                paciente = persona;
                
            }

        }

        public void clinica2()
        {
            int Noturno = 0;
            string persona = null;
            string dt = null;

            SqlConnection conexionSQL = new SqlConnection(CadenaConexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT TURNO_DIARIO, (p.NOMBRE + ' ' + p.APELLIDO)AS PERSONA, (d.NOMBRE + ' ' + d.APELLIDO)AS DOCTOR FROM PACIENTES p  " +
                "INNER JOIN TURNOS t ON p.ID_PACIENTE = t.ID_PACIENTE " +
                "INNER JOIN MEDICO d ON d.ID_MEDICO = t.ID_MEDICO " +
                "WHERE t.ID_MEDICO = '" + Session["IDdoctor"] + "' AND ID_TURNO = '" + Session["Turno"] + "' ";

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

                    Noturno = int.Parse(item[0].ToString());
                    y++;
                }
                if (y == 1)
                {
                    persona = item[1].ToString();
                    y++;
                }
                if (y == 2)
                {
                    dt = item[2].ToString();
                    y++;
                }

            }

            if (string.IsNullOrEmpty(Session["NombreDoc"].ToString()) || string.IsNullOrEmpty(Session["Turno"].ToString()) || string.IsNullOrEmpty(Session["NomPaciente"].ToString()))
            {

            }
            else

            {
                doc2 = dt;
                turno2 = Convert.ToString(Noturno);
                paciente2 = persona;

            }
        }

        public void clinica3()
        {
            int Noturno = 0;
            string persona = null;
            string dt = null;

            SqlConnection conexionSQL = new SqlConnection(CadenaConexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT TURNO_DIARIO, (p.NOMBRE + ' ' + p.APELLIDO)AS PERSONA, (d.NOMBRE + ' ' + d.APELLIDO)AS DOCTOR FROM PACIENTES p  " +
                "INNER JOIN TURNOS t ON p.ID_PACIENTE = t.ID_PACIENTE " +
                "INNER JOIN MEDICO d ON d.ID_MEDICO = t.ID_MEDICO " +
                "WHERE t.ID_MEDICO = '" + Session["IDdoctor"] + "' AND ID_TURNO = '" + Session["Turno"] + "' ";

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

                    Noturno = int.Parse(item[0].ToString());
                    y++;
                }
                if (y == 1)
                {
                    persona = item[1].ToString();
                    y++;
                }
                if (y == 2)
                {
                    dt = item[2].ToString();
                    y++;
                }

            }

            if (string.IsNullOrEmpty(Session["NombreDoc"].ToString()) || string.IsNullOrEmpty(Session["Turno"].ToString()) || string.IsNullOrEmpty(Session["NomPaciente"].ToString()))
            {

            }
            else

            {
                doc3 = dt;
                turno3 = Convert.ToString(Noturno);
                paciente3 = persona;

            }


        }
    }
}