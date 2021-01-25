using System.Collections.Generic;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Npgsql;

namespace _56BALLOV.Pages
{
    public class Result : PageModel
    {
        public void OnGet()
        {
            
        }

        public void OnPost()
        {   HtmlWeb hw = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc = hw.Load("/Result");
            string text = doc.Text;
            
            var cs =  "Host=localhost;Username=postgres;Password=qwerty;Database=url;";
            using var con = new NpgsqlConnection(cs);
            con.Open();

            using var cmd = new NpgsqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO url (string) VALUES(@text)";
            cmd.Parameters.AddWithValue("text", text);

            cmd.Prepare();

            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}