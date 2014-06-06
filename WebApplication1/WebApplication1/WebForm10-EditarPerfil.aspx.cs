using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class WebForm10_EditarPerfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string TempPass = "";
            string id_usuario = Session["id_usuario"].ToString();
            TextBoxIdGrupo.Visible = false;
            SqlConnection con2 = new SqlConnection(@"Data Source=NEMIAM;Initial Catalog=TareaBD;Integrated Security=True");
            con2.Open();
            SqlCommand sql2 = new SqlCommand("SELECT id_grupo FROM Usuario WHERE id_usuario = '" + id_usuario + "';", con2);
            SqlDataReader read = sql2.ExecuteReader();
            read.Read();
            TempPass = read.GetInt32(0).ToString();
            con2.Close();
            if (TempPass.Equals("2"))
            {
                TextBoxIdGrupo.Visible = true;
            }
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2-Login.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                string contraseña = TextBoxContraseña.Text;
                string repetirContraseña = TextBoxRepetirContraseña.Text;
                string fecha = TextBoxFecha.Text;
                string avatar = TextBoxAvatar.Text;
                string id_seleccion = Session["id_seleccion"].ToString();
               
                if(contraseña.Equals(repetirContraseña))
                    {
                        SqlConnection con = new SqlConnection(@"Data Source=NEMIAM;Initial Catalog=TareaBD;Integrated Security=True");
                        con.Open();
                        SqlCommand sql = new SqlCommand("UPDATE Usuario SET contraseña = '"+repetirContraseña+"', fecha_nacimiento = '"+fecha+"', avatar_url = '"+avatar+"' WHERE id_usuario = '"+id_seleccion+"';",con);
                        sql.ExecuteNonQuery();
                        con.Close();
                        string popupScript = "<SCRIPT LANGUAGE='javascript'>alert('La edicion Fue exitosa'); document.location=('./WebForm2-Login.aspx');</SCRIPT>";
                        Page.RegisterStartupScript("Popupscript", popupScript);
                    }
                else
                    {
                        string popupScript = "<SCRIPT LANGUAGE='javascript'>alert('Las Contraseñas no coinciden. Volver a intentarlo'); document.location=('./WebForm10-EditarPerfil.aspx');</SCRIPT>";
                    }
            }
            catch (Exception ex)
            {
                Response.Write("Error en try:" + ex);
            }
        }
    }
}