using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using PG_CitasMedicas;

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
            Aplicacion ap = new Aplicacion();

            cmd.CommandText = "SELECT TURNO_DIARIO, (p.NOMBRE + ' ' + p.APELLIDO)AS PERSONA, (d.NOMBRE + ' ' + d.APELLIDO)AS DOCTOR FROM PACIENTES p " +
                "INNER JOIN TURNOS t ON p.ID_PACIENTE = t.ID_PACIENTE " +
                "INNER JOIN MEDICO d ON d.ID_MEDICO = t.ID_MEDICO " +
                "INNER JOIN CLINICAS c ON c.ID_CLINICA = d.ID_CLINICA " +
                "WHERE c.ID_CLINICA = '1' AND t.ESTADO = 0 AND t.FECHA_INGRESO = '2019-10-1'";

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
            
            if (dt == null || Convert.ToString(Noturno) == null || persona == null)
            {
                doc = " Doctor";
                turno = "Turno";
                paciente = "Paciente";
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
            Aplicacion ap = new Aplicacion();

            cmd.CommandText = "SELECT TURNO_DIARIO, (p.NOMBRE + ' ' + p.APELLIDO)AS PERSONA, (d.NOMBRE + ' ' + d.APELLIDO)AS DOCTOR FROM PACIENTES p " +
                "INNER JOIN TURNOS t ON p.ID_PACIENTE = t.ID_PACIENTE " +
                "INNER JOIN MEDICO d ON d.ID_MEDICO = t.ID_MEDICO " +
                "INNER JOIN CLINICAS c ON c.ID_CLINICA = d.ID_CLINICA " +
                "WHERE c.ID_CLINICA = '2' AND t.ESTADO = 0 AND t.FECHA_INGRESO = '2019-10-1'";

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

            if (dt == null || Convert.ToString(Noturno) == null || persona == null)
            {
                doc2 = " Doctor";
                turno2 = "Turno";
                paciente2 = "Paciente";
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

            cmd.CommandText = "SELECT TURNO_DIARIO, (p.NOMBRE + ' ' + p.APELLIDO)AS PERSONA, (d.NOMBRE + ' ' + d.APELLIDO)AS DOCTOR FROM PACIENTES p " +
               "INNER JOIN TURNOS t ON p.ID_PACIENTE = t.ID_PACIENTE " +
               "INNER JOIN MEDICO d ON d.ID_MEDICO = t.ID_MEDICO " +
               "INNER JOIN CLINICAS c ON c.ID_CLINICA = d.ID_CLINICA " +
               "WHERE c.ID_CLINICA = '3' AND t.ESTADO = 0 AND t.FECHA_INGRESO = '2019-10-1'";

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

            if (dt == null || Convert.ToString(Noturno) == null || persona == null)
            {
                doc3 = " Doctor";
                turno3 = "Turno";
                paciente3 = "Paciente";
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