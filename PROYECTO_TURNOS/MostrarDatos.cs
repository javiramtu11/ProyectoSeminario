using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace PROYECTO_TURNOS
{
    public class MostrarDatos : System.Web.UI.Page
    {
        public void clinica1(string doc, string paciente, string turno)
        {
            //if (string.IsNullOrEmpty(Session["NombreDoc"].ToString()) || string.IsNullOrEmpty(Session["Turno"].ToString()) || string.IsNullOrEmpty(Session["NomPaciente"].ToString()))
            //{

            //}
            //else
            
            {
                if (Session["Clinica"].ToString() == "Pediatría")
                { 
                doc = Session["NombreDoc"].ToString();
                turno = Session["Turno"].ToString();
                paciente = Session["NomPaciente"].ToString();
                }
            }

        }

        public void clinica2(string doc, string paciente, string turno)
        {
            //if (string.IsNullOrEmpty(Session["NombreDoc"].ToString()) || string.IsNullOrEmpty(Session["Turno"].ToString()) || string.IsNullOrEmpty(Session["NomPaciente"].ToString()))
            //{

            //}
            //else
            {
                if (Session["Clinica"].ToString() == "Medicina General")
                {
                    doc = Session["NombreDoc"].ToString();
                    turno = Session["Turno"].ToString();
                    paciente = Session["NomPaciente"].ToString();
                }

            }

        }

        public void clinica3(string doc, string paciente, string turno)
        {
            //if (string.IsNullOrEmpty(Session["NombreDoc"].ToString()) || string.IsNullOrEmpty(Session["Turno"].ToString()) || string.IsNullOrEmpty(Session["NomPaciente"].ToString()))
            //{

            //}
            //else
            {
                if (Session["Clinica"].ToString() == "Ginecología")
                {
                    doc = Session["NombreDoc"].ToString();
                    turno = Session["Turno"].ToString();
                    paciente = Session["NomPaciente"].ToString();
                }
            }

        }
    }
}