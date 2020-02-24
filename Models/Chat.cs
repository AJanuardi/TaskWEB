using System.Collections.Generic;

namespace MVC.Models
{
    public class Chat
    {
        public int id {get;set;}
        public string from {get; set;}
        public string to {get; set;}
        public string pesan {get; set;}
        public string status {get; set;}
    }
}