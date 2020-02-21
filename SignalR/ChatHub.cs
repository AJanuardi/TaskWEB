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
        public async Task SendMessage(string user, string message)
        {
            Chat chat = new Chat()
            {
                nama = user,
                pesan = message
            };
            _appDbContext.Chats.Add(chat);
            await _appDbContext.SaveChangesAsync();
            await Clients.All.SendAsync("GotAMessage", user, message);
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
    }
}