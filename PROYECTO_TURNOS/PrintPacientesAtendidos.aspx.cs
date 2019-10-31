using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PROYECTO_TURNOS
{
    public partial class PrintPacientesAtendidos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string var = Convert.ToString(Session["USUARIO"]);

            if (String.IsNullOrEmpty(var))
            {
                Response.Redirect("Login.aspx");
            }

            if (!IsPostBack)
            {

            }

            RptPacientesAtendidos rp = new RptPacientesAtendidos();

            //rp.SetParameterValue("@prmNroTurno", turno);
            //rp.SetParameterValue("@prmFecha", fechaactual);
            //rp.SetParameterValue("@prmNombreApellido", nombre);
            //rp.SetParameterValue("@prmDoctor", doctor);
            CrystalReportViewer1.ReportSource = rp;
            CrystalReportViewer1.RefreshReport();
        }
    }
}