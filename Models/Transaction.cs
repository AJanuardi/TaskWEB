using System.Collections.Generic;

namespace MVC.Models
{
    public class Transaction
    {
        public int id {get; set;}
        public string name {get; set;}
        public string address {get;set;}
        public string phone {get;set;}
        public string email {get;set;}
        public int total {get; set;}
    }
}