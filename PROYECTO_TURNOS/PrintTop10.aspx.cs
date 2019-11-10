using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PROYECTO_TURNOS
{
    public partial class PrintTop10 : System.Web.UI.Page
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


            RptPacientesFrecuentes rp = new RptPacientesFrecuentes();
            string server = @"JAVIRAMPC\BDDJAVIERAM";
            string BDD = "HospitalAdonai";

            rp.DataSourceConnections[0].SetConnection(server, BDD, string.Empty, string.Empty);
            CrystalReportViewer1.ReportSource = rp;
            CrystalReportViewer1.RefreshReport();
        }
    }
}