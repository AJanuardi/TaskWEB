using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalR.SignalR
{
    public class Chathub: Hub
    {
        public async Task SendMessage(string user, string message)
        {
            Console.WriteLine("Oke Masuk");
            Console.WriteLine(user);
            Console.WriteLine(message);

            await Clients.All.SendAsync("GotAMessage", user, message);
        }
    }
}