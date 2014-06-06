using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class WebForm10_Comentarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=NEMIAM;Initial Catalog=TareaBD;Integrated Security=True");
                string mensajep = TextBox1.Text;
                string id_usuario = Session["id_usuario"].ToString();
                string id_tema = Session["id_tema"].ToString();
                con.Open();
                SqlCommand sql = new SqlCommand("insert into Comentario(id_tema,id_usuario,mensaje) values ('" + id_tema + "','" + id_usuario + "','" + mensajep + "'); ", con);
                sql.ExecuteNonQuery();
                con.Close();
                string popupScript = "<SCRIPT LANGUAGE='javascript'>alert('Comentario ingresado con éxito.'); document.location=('./WebForm10-Comentarios.aspx');</SCRIPT>";
                Page.RegisterStartupScript("Popupscript", popupScript);
            }
            catch (Exception ex)
            {
                Response.Write("Error en try:" + ex);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm4-Admin.aspx");
        }

    }
}