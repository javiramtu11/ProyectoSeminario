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
            if (string.IsNullOrEmpty(Session["NombreDoc"].ToString()) || string.IsNullOrEmpty(Session["Turno"].ToString()) || string.IsNullOrEmpty(Session["NomPaciente"].ToString()))
            {

            }
            else
            {
                Label1.Text = Session["NombreDoc"].ToString();
                Label3.Text = Session["Turno"].ToString();
                Label4.Text = Session["NomPaciente"].ToString();
            }
            
        }
    }
}