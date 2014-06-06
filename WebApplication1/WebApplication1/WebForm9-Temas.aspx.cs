using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace WebApplication1
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm8-Categoria.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm10-IngTema.aspx");
        }

    
        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            //GUARDAR ID DE CATEGORIA
            int index = GridView1.SelectedIndex;
            string id = GridView1.DataKeys[index].Value.ToString();
            Session["id_tema"] = id;
            //REDIRECCIONAR A LA NUEVA VENTANA
            Response.Redirect("WebForm10-Comentarios.aspx");
        }

       
    }
}