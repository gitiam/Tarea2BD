using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("webForm1-Inicio.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=NEMIAM;Initial Catalog=TareaBD;Integrated Security=True");
            string usuario = TextBox1.Text;
            Session["nombre"] = usuario;
            string password = TextBox2.Text;
            string TempPass = "";
            string sql = "select contraseña,id_grupo,id_usuario from Usuario where nombre= '"+ usuario +"';";
            try
            {     
                SqlCommand reader = new SqlCommand(sql,con);
                con.Open();
                SqlDataReader read = reader.ExecuteReader();
                if (read.HasRows)
                {
                    read.Read();
                    TempPass = read.GetString(0);
                    int TempIdGrupo = read.GetInt32(1);
                    int id_usuario = read.GetInt32(2);
                    Session["id_usuario"] = id_usuario;
                    if (password.Equals(TempPass))
                    {
                        //DETERMINA QUE TIPO DE USUARIO ES:
                        if ((TempIdGrupo.ToString()).Equals("2")) //ADMINISTRADOR
                        {
                            Session["Volver"] = 2;
                            Response.Redirect("webForm4-Admin.aspx");
                        }
                        else if ((TempIdGrupo.ToString()).Equals("3")) //MODERADOR
                        {
                            Session["Volver"] = 3;
                            Response.Redirect("webForm5-Moderador.aspx");
                        }
                        else if ((TempIdGrupo.ToString()).Equals("4")) //COMUN
                        {
                            Session["Volver"] = 4;
                            Response.Redirect("webForm6-Comun.aspx");
                        }
                        else 
                        {
                            string popupScripts1 = "<SCRIPT LANGUAGE='javascript'>alert('Passwords no esta dentro de los menu soportado'); document.location=('./WebForm1-Inicio.aspx');</SCRIPT>";
                            Page.RegisterStartupScript("Popupscript", popupScripts1);
                        }
                    }
                    else //Si la password correspondiente al usuario coincide con la entregada
                    {
                        string popupScripts2 = "<SCRIPT LANGUAGE='javascript'>alert('Passwords no coinciden'); document.location=('./WebForm1-Inicio.aspx');</SCRIPT>";
                        Page.RegisterStartupScript("Popupscript", popupScripts2);
                    }
                    
                    read.Close();
                }
                else 
                {
                    string popupScripts3 = "<SCRIPT LANGUAGE='javascript'>alert('No hay datos en usuario'); document.location=('./WebForm1-Inicio.aspx');</SCRIPT>";
                    Page.RegisterStartupScript("Popupscript", popupScripts3);
                }
            }
            catch (Exception ex)
            {
                Response.Write("Error en el Try: " + ex);
            }
            finally
            {
                con.Close();
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm7-Visita.aspx");
        }

      

      
      
    }
}