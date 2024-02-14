using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Biglietteria
{
    public partial class Home : System.Web.UI.Page
    {
        string NomeSala = "";
        string TipoBiglietto = "";
        static string connectionString = ConfigurationManager.ConnectionStrings["Biglietteria"].ToString();
        SqlConnection conn = new SqlConnection(connectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

            conn.Open();
            SqlCommand cmdCount = new SqlCommand($"SELECT Count(*) FROM Biglietti", conn);
            int rowCount = (int)cmdCount.ExecuteScalar();
            
            lblPosti.Text = "Posti Occupati:" + rowCount;
            conn.Close();
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            NomeSala = RadioButtonList1.SelectedValue;
        }

        protected void RadioButtonList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoBiglietto = RadioButtonList2.SelectedValue;
        }

        

        protected void lblNome_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                Response.Write("Connessione aperta");
                SqlCommand cmdInsert = new SqlCommand($"Insert into Biglietti (NomeUtente,NomeSala,TipoBiglietto) VALUES ('{lblNome.Text} {lblCognome.Text}','{NomeSala}','{TipoBiglietto}')", conn);
                int affectedRow=cmdInsert.ExecuteNonQuery();
                if (affectedRow != 0)
                {
                    Response.Write("Inserimento Effettuato");
                }
            }
            catch
            {
                Response.Write("Connsessione non aperta");
            }
            finally 
            {
                if(conn.State== System.Data.ConnectionState.Open)
                {
                    SqlCommand cmdCount = new SqlCommand($"SELECT Count(*) FROM Biglietti", conn);
                    int rowCount = (int)cmdCount.ExecuteScalar();
                    lblPosti.Text = "Posti Disponibili:" + rowCount;
                    conn.Close();
                }
            }
        }
    }
}