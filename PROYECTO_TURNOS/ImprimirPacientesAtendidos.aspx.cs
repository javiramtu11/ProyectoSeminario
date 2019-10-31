using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PROYECTO_TURNOS
{
    public partial class ImprimirPacientesAtendidos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

            }

        }

        public void MostrarReporte()
        {
            DateTime fechainicial = Convert.ToDateTime(TxtFechaInicial.Value);
            DateTime fechafinal = Convert.ToDateTime(TxtFechaFinal.Value);
            DateTime fechaactual = DateTime.Now;

            if (string.IsNullOrEmpty(TxtFechaInicial.Value) || string.IsNullOrEmpty(TxtFechaFinal.Value))
            {
                fechainicial = fechaactual;
                fechafinal = fechaactual;
            }




            RptPacientesAtendidos rp = new RptPacientesAtendidos();
            rp.SetDatabaseLogon("dafm", "Maquina123");
            rp.SetParameterValue("@prmFInicial", fechainicial);
            rp.SetParameterValue("@prmFFinal", fechafinal);
            CrystalReportViewer1.ReportSource = rp;
            CrystalReportViewer1.RefreshReport();
        }

 

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Response.Write("<script>alert('EXISTEN CAMPOS IMPORTANTES QUE ESTAN VACÍOS, VERIFIQUE PARA CONTINUAR')</script>");
            MostrarReporte();
        }
    }
}