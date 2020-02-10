using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;

namespace MVC.Models
{
    public class Cookie
    {
        public int id {get; set;}
        public int rating {get; set;}
        public string nama {get; set;}
        public string foto {get; set;}
        public string deskripsi {get; set;}
        public int harga {get;set;}

        SqlConnection con = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=Store;Trusted_Connection=True;");
        SqlCommand cmd = new SqlCommand();

        public string InsertCookies (Cookie obj)
        {
            cmd.CommandText = "Insert into [Cookies] values ('"+obj.rating +"','"+ obj.nama+"','"+obj.foto+"', '"+obj.deskripsi+"','"+Convert.ToInt32(obj.harga)+"')";
            cmd.Connection = con;
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return "Success";
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}