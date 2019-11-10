using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PROYECTO_TURNOS
{
    public partial class PrintTurno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //RptTurno rp = new RptTurno();
            //string NoTurno = "5";
            //string FechaTurno = "20-10-19";
            //string PacienteTurno = "Pedro Pica Piedra";
            //string DoctorTurno = "Jorge Vásquez";


            //rp.SetParameterValue("@prmNroTurno", NoTurno);
            //rp.SetParameterValue("@prmFecha", FechaTurno);
            //rp.SetParameterValue("@prmNombreApellido", PacienteTurno);
            //rp.SetParameterValue("@prmDoctor", DoctorTurno);

            //this.CrystalReportViewer1.ReportSource = rp;
            //CrystalReportViewer1.RefreshReport();

            Form1_Load();
        }

        public void Form1_Load()
        {
            string var = Convert.ToString(Session["USUARIO"]);

            if (String.IsNullOrEmpty(var))
            {
                Response.Redirect("Login.aspx");
            }

            //
            // Creo el parametro y asigno el nombre
            //
            ParameterField param = new ParameterField();
            param.ParameterFieldName = "prmNroTurno";
            param.ParameterFieldName = "prmFecha";
            param.ParameterFieldName = "prmNombreApellido";
            param.ParameterFieldName = "prmDoctor";
            //
            // creo el valor que se asignara al parametro
            //
            ParameterDiscreteValue discreteValue = new ParameterDiscreteValue();
            discreteValue.Value = "5";
            discreteValue.Value = "20-10-19";
            discreteValue.Value = "juan";
            discreteValue.Value = "jorge";
            param.CurrentValues.Add(discreteValue);

            //
            // Asigno el paramametro a la coleccion
            //
            ParameterFields paramFiels = new ParameterFields();
            paramFiels.Add(param);

            //
            // Asigno la coleccion de parametros al Crystal Viewer
            //
            CrystalReportViewer1.ParameterFieldInfo = paramFiels;

            //
            // Creo la instancia del reporte
            //
            RptTurno report = new RptTurno();

            //
            // Cambio el path de la base de datos
            //

            string server = @"JAVIRAMPC\BDDJAVIERAM";
            string BDD = "HospitalAdonai";

            report.DataSourceConnections[0].SetConnection(server, BDD, string.Empty, string.Empty);

            string numero = Convert.ToString(Session["NUMEROTURNO"]);
            string fecha = Convert.ToString(Session["FECHATURNO"]);
            string paciente = Convert.ToString(Session["PACIENTETURNO"]);
            string doctor = Convert.ToString(Session["DOCTORTURNO"]);

            report.SetParameterValue("@prmnroturno", numero);
            report.SetParameterValue("@prmfecha", fecha);
            report.SetParameterValue("@prmnombreapellido", paciente);
            report.SetParameterValue("@prmdoctor", doctor);

            //
            // Asigno el reporte a visor
            //
            CrystalReportViewer1.ReportSource = report;




            //string NombreImpresora = "";//Donde guardare el nombre de la impresora por defecto

            ////Busco la impresora por defecto
            //for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            //{
            //    PrinterSettings a = new PrinterSettings();
            //    a.PrinterName = PrinterSettings.InstalledPrinters[i].ToString();
            //    if (a.IsDefaultPrinter)
            //    {
            //        NombreImpresora = PrinterSettings.InstalledPrinters[i].ToString();
            //    }
            //}

            //CrystalReportViewer1.DataBind();
            //CrystalReportViewer1.PrintMode = CrystalDecisions.Web.PrintMode.ActiveX;
            //PrinterSettings impresora = new PrinterSettings();
            //impresora.PrinterName = NombreImpresora;
            report.PrintOptions.PrinterName = "Canon G2000 series Printer";
            report.PrintToPrinter(1, false, 0, 0);
        }
    }
}