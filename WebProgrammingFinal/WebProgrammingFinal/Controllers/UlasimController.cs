using Microsoft.AspNetCore.Mvc;
using System;
using System.Data.SqlClient;
using WebProgrammingFinal.Models;

namespace WebProgrammingFinal.Controllers
{
    public class UlasimController : Controller
    {
        public ActionResult Gorusme()
        {
            return View(new Ulasim() { Name = "Ertürk", Surname = "Erdağı" });
        }


        [HttpPost]
        public ActionResult Gorusme(Ulasim Gorusme)
        {
            SqlConnection con = new SqlConnection("Server=(localdb)\\BATU;Database=DBFINAL;Trusted_Connection=True;MultipleActiveResultSets=true");
            SqlCommand cmd = new SqlCommand("Sp_UlasimInsert", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@Name",System.Data.SqlDbType.NVarChar).Value = Gorusme.Name;
            cmd.Parameters.Add("@Surname", System.Data.SqlDbType.NVarChar).Value = Gorusme.Surname;
            cmd.Parameters.Add("@EMail", System.Data.SqlDbType.NVarChar).Value = Gorusme.EMail;
            cmd.Parameters.Add("@PhoneNumber", System.Data.SqlDbType.NVarChar).Value = Gorusme.PhoneNumber;
            cmd.Parameters.Add("@Message", System.Data.SqlDbType.NVarChar).Value = Gorusme.Message;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();


            return View(Gorusme);
        }
    }
}

