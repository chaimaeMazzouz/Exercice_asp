using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Controle_Asp_Mazzouz
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn_ComVoyage = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString))
            {
                cn_ComVoyage.Open();
                string Qr = "select count(1) from Gestionnaire where Pseudo=@Pseudo and PassWord=@pass";
                SqlCommand cmd = new SqlCommand(Qr, cn_ComVoyage);
                cmd.Parameters.AddWithValue("@Pseudo", TextBoxPseudo.Text);
                cmd.Parameters.AddWithValue("@pass", TextBoxPass.Text);

                int count = (int)cmd.ExecuteScalar();
                if (count == 1)
                {

                    string Qr_sel = "select * from Gestionnaire where Pseudo=@Pseudo and PassWord=@pass";
                    SqlCommand cmd_sel = new SqlCommand(Qr_sel, cn_ComVoyage);
                    cmd_sel.Parameters.AddWithValue("@Pseudo", TextBoxPseudo.Text);
                    cmd_sel.Parameters.AddWithValue("@pass", TextBoxPass.Text);
                    SqlDataReader dr = cmd_sel.ExecuteReader();
                    while (dr.Read())
                    {
                        Session["Pseudo"] = dr[0].ToString();
                        Session["Nom_prenom"] = dr[1].ToString();
                        Session["PassWord"] = dr[2].ToString();
                    }
                    Response.Redirect("Equipe.aspx");

                }
                else
                {
                    Response.Write("<script>alert('Ce membre n'exsist pas')</script>");
                }
            }
            
        }
    }
}