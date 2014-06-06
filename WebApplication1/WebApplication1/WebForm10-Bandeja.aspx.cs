using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm10_Bandeja : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("CONTADOR:");
            Response.Write("Mensajes Recibidos: 0");
            Response.Write("Mensajes No Leidos: 0");
        }
    }
}