using System.Collections.Generic;

namespace MVC.Models
{
    public class Transaction
    {
        public int id {get; set;}
        public string konsumen {get; set;}
        public string alamat {get; set;}
        public string Province {get; set;}
        public int? PostalCode {get; set;} = null;
        public int totalBelanja {get; set;}
    }
}