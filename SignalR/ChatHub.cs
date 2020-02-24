using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using MVC.Data;
using System.Linq;
using MVC.Models;

namespace SignalR.SignalR
{

    public class Chathub: Hub
    {
        public AppDbContext _appDbContext;

        public Chathub (AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task SendMessage(string from, string to,  string message)
        {
            Chat chat = new Chat()
            {
                from = from,
                to = to,
                pesan = message
            };
            _appDbContext.Chats.Add(chat);
            await _appDbContext.SaveChangesAsync();
            await Clients.All.SendAsync("GotAMessage", from, to, message);
        }

        public async Task Read(string read)
        {
            var x = from i in _appDbContext.Chats where (i.status == null) select i;
            foreach (var i in x)
            {
                i.status = read;
            }
            await _appDbContext.SaveChangesAsync();
        }

        public async Task Notify(string confirmed)
        {
            var x = (from i in _appDbContext.Transactions.OrderBy(a => a.id) where (i.status == "pay") select i).LastOrDefault();
            x.status = confirmed;
            await _appDbContext.SaveChangesAsync();
        }
    }
}