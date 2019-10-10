using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PG_CitasMedicas
{
    public partial class Aplicacion : System.Web.UI.MasterPage
    {
        public string userLog = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            string var = Convert.ToString(Session["USUARIO"]);

            //if (String.IsNullOrEmpty(var))
            //{
            //    Response.Redirect("Inicio.aspx");
            //}

            Label1.Text = var.ToUpper();
            userLog = var;


        }
    }
}