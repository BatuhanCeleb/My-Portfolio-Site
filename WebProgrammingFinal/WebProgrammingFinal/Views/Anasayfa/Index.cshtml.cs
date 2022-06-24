using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;

namespace WebProgrammingFinal.Pages
{
    public class IndexModel : PageModel
    {
        public string Id;
        public string TextHeader;
        public string Text;
        public string Image;


        public void OnGet()
        {
            string connectionString = "Server=(localdb)\\BATU;Database=DBFINAL;Trusted_Connection=True;MultipleActiveResultSets=true";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string sqlQuery = "SELECT Id,TextHeader,Text,Image FROM Anasayfa";
            SqlCommand cmd = new SqlCommand(sqlQuery, con);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                Id = dr["Id"].ToString();
                TextHeader = dr["TextHeader"].ToString();
                Text = dr["Text"].ToString();
                Image = dr["Image"].ToString();

                con.Close();

            }
        }
    }
}


