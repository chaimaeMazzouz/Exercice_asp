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
    public partial class Equipe : System.Web.UI.Page
    {
        SqlConnection cn_Client = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                RemplirGrid();
                //BindChauffeur();
            }
        }
        void RemplirGrid()
        {
            cn_Client.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select*from Gestionnaire", cn_Client);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            gv_Gest.DataSource = dt;
            gv_Gest.DataBind();
            cn_Client.Close();
        }

        protected void gv_Gest_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string id = gv_Gest.DataKeys[e.RowIndex].Value.ToString();
            TextBox txtname = (TextBox)gv_Gest.Rows[e.RowIndex].FindControl("TextBoxPseudo");
            TextBox txtprenom = (TextBox)gv_Gest.Rows[e.RowIndex].FindControl("TextBoxNom_prenom");
            TextBox txtadresse = (TextBox)gv_Gest.Rows[e.RowIndex].FindControl("TextBoxPassWord");
            mofifier_Chauffeur(txtname.Text, txtname.Text, txtprenom.Text);
            gv_Gest.EditIndex = -1;
            RemplirGrid();
        }

        protected void gv_Gest_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gv_Gest.EditIndex = -1;
            RemplirGrid();
        }

        protected void gv_Gest_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string id = gv_Gest.DataKeys[e.RowIndex].Value.ToString();
            supprimer_Chauffeur(id);
            RemplirGrid();
        }

        protected void gv_Gest_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gv_Gest.EditIndex = e.NewEditIndex;
            RemplirGrid();
        }
        private void mofifier_Chauffeur(string Pseudo, string Nom_prenom, string PassWord)
        {
            cn_Client.Open();
            SqlCommand cmd = new SqlCommand($"update Gestionnaire set  Pseudo ='{Pseudo}',Nom_prenom='{Nom_prenom}',PassWord ='{PassWord}' where Pseudo ='{Pseudo}'", cn_Client);
            cmd.ExecuteNonQuery();
            cn_Client.Close();
        }
        private void supprimer_Chauffeur(string id)
        {
            cn_Client.Open();
            SqlCommand cmd = new SqlCommand($"delete from Gestionnaire where Pseudo ='{id}'", cn_Client);
            cmd.ExecuteNonQuery();
            cn_Client.Close();
        }
    }
}