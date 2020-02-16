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

    }
}