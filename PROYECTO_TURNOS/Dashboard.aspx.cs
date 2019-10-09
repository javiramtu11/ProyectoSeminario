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
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MostrarDatos md = new MostrarDatos();

            if (Session["Clinica"].ToString() == "Pediatría")
            {
                md.clinica1();

                lbldocclinica1.Text = md.doc;
                lblpaclinica1.Text = md.paciente;
                Lblcontclinica1.Text = md.turno;
            }
            if (Session["Clinica"].ToString() == "Medicina General")
            {
                md.clinica2();

                lbldocclinica2.Text = md.doc2;
                lblpaclinica2.Text = md.paciente2;
                lblcontclinica2.Text = md.turno2;
            }

            //md.clinica2(lbldocclinica2.Text, lblpaclinica2.Text, lblcontclinica2.Text);
            //md.clinica3(lbldocclinica3.Text, lblpaclinica3.Text, lblcontclinica3.Text);



        }
    }
}