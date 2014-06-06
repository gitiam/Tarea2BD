using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class WebForm10_IngTema : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm9-Temas.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string id_categoria = Session["id_categoria"].ToString();
                string id_usuario = Session["id_usuario"].ToString();
                string nombre = TextBoxNombreTema.Text;
                string descripcion = TextBoxDescTema.Text;
                int bl;
                if (CheckBox1.Checked)
                {
                    bl = 1;
                }
                else 
                {
                    bl = 0;
                }
                string mensaje = TextBoxMensTema.Text;
                SqlConnection con = new SqlConnection(@"Data Source=NEMIAM;Initial Catalog=TareaBD;Integrated Security=True");
                con.Open();
                SqlCommand sql = new SqlCommand("insert into Tema(id_categoria,id_usuario,nombre,descripcion,mensaje,publico) values('" + Convert.ToInt32(id_categoria) + "','" + Convert.ToInt32(id_usuario) + "','" + nombre + "','" + descripcion + "','" + mensaje + "','" + bl + "'); ", con);
                sql.ExecuteNonQuery();
                con.Close();
                string popupScript = "<SCRIPT LANGUAGE='javascript'>alert('Se agrego correctamente el Tema'); document.location=('./WebForm1-Inicio.aspx');</SCRIPT>";
                Page.RegisterStartupScript("Popupscript", popupScript);
            }
                
                
            


            catch (Exception ex)
            {
                Response.Write("Error en try:" + ex);
            }
        }
    }
}