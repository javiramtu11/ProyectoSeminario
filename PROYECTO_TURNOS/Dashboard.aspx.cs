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
        public void llenarTurnos() {
            MostrarDatos md = new MostrarDatos();
            md.clinica1();

            lbldocclinica1.Text = md.doc;
            lblpaclinica1.Text = md.paciente;
            Lblcontclinica1.Text = md.turno;

            md.clinica2();

            lbldocclinica2.Text = md.doc2;
            lblpaclinica2.Text = md.paciente2;
            lblcontclinica2.Text = md.turno2;

            md.clinica3();
            lbldocclinica3.Text = md.doc3;
            lblpaclinica3.Text = md.paciente3;
            lblcontclinica3.Text = md.turno3;

            md.clinica4();
            Lbldocclinica4.Text = md.doc4;
            Lblpaclinica4.Text = md.paciente4;
            Lblcontclinica4.Text = md.turno4;

            md.clinica5();
            Lbldocclinica5.Text = md.doc5;
            Lblpaclinica5.Text = md.paciente5;
            Lblcontclinica5.Text = md.turno5;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            llenarTurnos();


        }
    }
}