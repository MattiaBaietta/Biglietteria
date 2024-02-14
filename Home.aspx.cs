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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButtonList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnPrenotazione_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Biglietteria"].ToString();
            SqlConnection conn= new SqlConnection(connectionString);
            try
            {
                conn.Open();
                Response.Write("Connessione aperta");
            }
            catch
            {
                Response.Write("Connsessione non aperta");
            }
        }
    }
}