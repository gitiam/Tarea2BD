using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm10_Perfil2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            string id = GridView1.DataKeys[0].Value.ToString();
            Session["id_seleccion"] = id;
            Response.Redirect("WebForm10-EditarPerfil.aspx");
        }
    }
}