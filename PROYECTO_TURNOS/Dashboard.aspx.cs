using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace PROYECTO_TURNOS
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MostrarDatos md = new MostrarDatos();

            //md.clinica1(lbldocclinica1.Text, lblpaclinica1.Text, Lblcontclinica1.Text);
            //md.clinica2(lbldocclinica2.Text, lblpaclinica2.Text, lblcontclinica2.Text);
            //md.clinica3(lbldocclinica3.Text, lblpaclinica3.Text, lblcontclinica3.Text);

            if (string.IsNullOrEmpty(Session["NombreDoc"].ToString()) || string.IsNullOrEmpty(Session["Turno"].ToString()) || string.IsNullOrEmpty(Session["NomPaciente"].ToString()))
            {

            }
            else
            {
                if ((Session["Clinica"].ToString() == "Pediatría"))
                {
                    lbldocclinica1.Text = Session["NombreDoc"].ToString();
                    Lblcontclinica1.Text = Session["Turno"].ToString();
                    lblpaclinica1.Text = Session["NomPaciente"].ToString();
                }
                else
                {
                    if ((Session["Clinica"].ToString() == "Medicina General"))
                    {
                        lbldocclinica2.Text = Session["NombreDoc"].ToString();
                        lblcontclinica2.Text = Session["Turno"].ToString();
                        lblpaclinica2.Text = Session["NomPaciente"].ToString();
                    }
                    else
                    {
                        if ((Session["Clinica"].ToString() == "Ginecología"))
                        {
                            lbldocclinica3.Text = Session["NombreDoc"].ToString();
                            lblcontclinica3.Text = Session["Turno"].ToString();
                            lblpaclinica3.Text = Session["NomPaciente"].ToString();
                        }
                    }
                }
            }

        }
    }
}