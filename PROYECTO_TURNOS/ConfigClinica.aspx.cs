using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace PROYECTO_TURNOS
{
    public partial class ConfigClinica : System.Web.UI.Page
    {
        MostrarDatos md = new MostrarDatos();
        string con = MostrarDatos.CadenaConexion;

        public void AddCline()
        {

            SqlConnection conexionSQL = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand();

            string cline = clinica.Value;
            string desc = Descripcion.Value;

            if (string.IsNullOrEmpty(cline) || string.IsNullOrEmpty(desc))
            {
                
            }
            else
            {
                cmd.CommandText = "INSERT INTO CLINICAS (CLINICA, DESCRIPCION, ESTADO)" +
                    " VALUES (@CLINICA, @DESCRIPCION, 1)";
                cmd.Parameters.Add("@CLINICA", SqlDbType.Text).Value = cline;
                cmd.Parameters.Add("@DESCRIPCION", SqlDbType.Text).Value = desc;

                cmd.CommandType = CommandType.Text;
                cmd.Connection = conexionSQL;
                conexionSQL.Open();
                cmd.ExecuteNonQuery();

                Response.Write("<script>alert('Clinica Ingresada con Exito')</script>");
            }
        }

        public void obtenerClinica()
        {
            SqlConnection conexionSQL = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT ID_CLINICA, CLINICA, DESCRIPCION FROM CLINICAS WHERE ESTADO = 1";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexionSQL;
            conexionSQL.Open();

            DataTable Datos = new DataTable();
            Datos.Load(cmd.ExecuteReader());
            Grid.DataSource = Datos;
            Grid.DataBind();
            conexionSQL.Close();
        }

        //public void buscarClinica()
        //{
        //    SqlConnection conexionSQL = new SqlConnection(con);
        //    SqlCommand cmd = new SqlCommand();

        //    string buscar = txtbuscar.Value;
        //    cmd.CommandText = "SELECT ID_CLINICA, CLINICA, DESCRIPCION FROM CLINICAS WHERE CLINICA LIKE '%" + buscar + "%' AND ESTADO = 1 ";

        //    cmd.CommandType = CommandType.Text;
        //    cmd.Connection = conexionSQL;
        //    conexionSQL.Open();

        //    DataTable Datos = new DataTable();
        //    Datos.Load(cmd.ExecuteReader());
        //    Grid.DataSource = Datos;
        //    Grid.DataBind();
        //    conexionSQL.Close();
        //}



        protected void Page_Load(object sender, EventArgs e)
        {
            string var = Convert.ToString(Session["USUARIO"]);
            string var2 = Convert.ToString(Session["TIPO"]);

            if (var2 != "Administrador")
            {
                Response.Write("<script>alert('EL USUARIO NO TIENE PERMISOS PARA USAR ESTE FORMULARIO')</script>");

                if (var2 == "Secretaria")
                {
                    Response.Redirect("AppPrincipal.aspx");
                }
                if (var2 == "Doctor")
                {
                    Response.Redirect("AgendaTurnos.aspx");
                }

            }
            else
            {
                if (String.IsNullOrEmpty(var))
                {
                    Response.Redirect("Login.aspx");
                }

                if (!IsPostBack)
                {
                    obtenerClinica();
                }

            }
        }

        protected void InsertarClinica_Click(object sender, EventArgs e)
        {

            
            AddCline();
            Response.Redirect("ConfigClinica.aspx");
        }

        protected void BtnBuscarClinica_Click(object sender, EventArgs e)
        {
           
            //buscarClinica();
            
        }

        protected void rowCancelEdit(object sender, GridViewCancelEditEventArgs e)
        {
            Grid.EditIndex = -1;
            obtenerClinica();
        }

        protected void rowEditingEvent(object sender, GridViewEditEventArgs e)
        {
            Grid.EditIndex = e.NewEditIndex;
            obtenerClinica();
        }

        protected void Grid_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            Grid.PageIndex = e.NewPageIndex;
            obtenerClinica();
        }

        protected void rowUpdatingEvent(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow fila = Grid.Rows[e.RowIndex];
            int codigo = Convert.ToInt32(Grid.DataKeys[e.RowIndex].Values[0]);

            string clinica = (fila.FindControl("TextClinica") as TextBox).Text;
            string descripcion = (fila.FindControl("TextDescripcion") as TextBox).Text;
            

            if (Grid.DataKeys[e.RowIndex].Value.ToString() == null)
            {

            }
            else
            {
                string sql = "update CLINICAS set CLINICA = '" + clinica + "', DESCRIPCION = '" + descripcion + "' where ID_CLINICA = " + Grid.DataKeys[e.RowIndex].Value.ToString();
                MostrarDatos clas_consulta = new MostrarDatos();

                if (clas_consulta.non_query(sql))
                {
                    obtenerClinica();
                    Response.Write("<script>alert('MODIFICACIÓN REALIZADA EXITOSAMENTE')</script>");
                }
                else
                {
                    Response.Write("<script>alert('NO SE HA PODIDO MODIFICAR')</script>");
                }
            }

            Grid.EditIndex = -1;
            obtenerClinica();
        }

        protected void Grid_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            if (Grid.DataKeys[e.RowIndex].Value.ToString() == null)
            {

            }
            else
            {
                string sql = "update CLINICAS set ESTADO ='2' where ID_CLINICA =" + Grid.DataKeys[e.RowIndex].Value.ToString();
                MostrarDatos clas_consulta = new MostrarDatos();

                if (clas_consulta.non_query(sql))
                {
                    obtenerClinica();
                    Response.Write("<script>alert('ELIMINADO EXITOSAMENTE')</script>");
                }
                else
                {
                    Response.Write("<script>alert('NO SE HA PODIDO ELIMINAR')</script>");
                }
            }

            obtenerClinica();
        }
    }
}