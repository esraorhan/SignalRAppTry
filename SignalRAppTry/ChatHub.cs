using Microsoft.AspNetCore.SignalR;
using SignalRAppTry.Context;
using SignalRAppTry.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRAppTry
{
    public class ChatHub : Hub
    {
       
       

        //public async Task SendMessage(string user, string message)
        //{
        //    await Clients.All.SendAsync("ReceiveMessage", user, message);
        //}
        public async Task SendMessage(string user, string message)
        {
            if (Context.ConnectionId != null)
            {
                await Clients.All.SendAsync("ReceiveMessage", user, message);

                // Mesajı veritabanına kaydet
                var chatMessage = new ChatMessage
                {
                    User = user,
                    Message = message,
                    SendTime = DateTime.Now
                };
                using (var context = new DietContext())
                {
                    context.ChatMessages.Add(chatMessage);
                    context.SaveChanges();
                }
              

            }
        }




    }
}
