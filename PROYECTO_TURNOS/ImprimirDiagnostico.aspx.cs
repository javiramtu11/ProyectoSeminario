﻿using PROYECTO_TURNOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PG_CitasMedicas
{
    public partial class ImprimirDiagnostico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RptPacientesAtendidosDoc rp = new RptPacientesAtendidosDoc();                       
            CrystalReportViewer1.ReportSource = rp;
            CrystalReportViewer1.RefreshReport();

            string var = Convert.ToString(Session["USUARIO"]);
            string var2 = Convert.ToString(Session["TIPO"]);

            if (String.IsNullOrEmpty(var))
            {
                Response.Redirect("Login.aspx");
            }

            if (var2 != "Doctor" && var2 != "Administrador")
            {
                Response.Write("<script>alert('EL USUARIO NO TIENE PERMISOS PARA USAR ESTE FORMULARIO')</script>");

                if (var2 == "Secretaria")
                {
                    Response.Redirect("AppPrincipal.aspx");
                }

            }

            else
            {

                if (String.IsNullOrEmpty(var))
                {
                    Response.Redirect("Login.aspx");
                }
            }
        }

        protected void VerDiagnostico_Click(object sender, EventArgs e)
        {

        }

        protected void CrystalReportViewer1_Init(object sender, EventArgs e)
        {

        }
    }
}