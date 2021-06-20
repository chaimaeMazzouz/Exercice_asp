using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Controle_Asp_Mazzouz
{
    public partial class Gestionnaire : System.Web.UI.Page
    {
        SqlConnection cn_Client = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {

        }
       
        protected void BtnIns_Click(object sender, EventArgs e)
        {
            cn_Client.Open();
            SqlCommand cmd = new SqlCommand($"insert into Gestionnaire values('{TextBoxPseudo.Text}','{TextBox_NomPrenom.Text}','{TextBoxPass.Text}')", cn_Client);
            cmd.ExecuteNonQuery();
            cn_Client.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Inserted');", true);
            TextBoxPseudo.Text = TextBoxPass.Text = TextBox_NomPrenom.Text  = "";
           
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            SqlCommand cmd_pseudo = new SqlCommand("Select count(*) from Gestionnaire where pseudo=@numPs");
            cmd_pseudo.Connection = cn_Client;
            SqlParameter pnum = new SqlParameter("@numPs", SqlDbType.VarChar);
            cmd_pseudo.Parameters.Add(pnum);
            pnum.Value = args.Value.ToString();
            cn_Client.Open();
            int nbre = (int)cmd_pseudo.ExecuteScalar();
            if (nbre != 0)
                args.IsValid = false;
            else
                args.IsValid = true;
            cn_Client.Close();
        }
    }
}