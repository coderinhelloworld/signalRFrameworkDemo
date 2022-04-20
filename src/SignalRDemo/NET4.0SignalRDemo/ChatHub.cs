using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NET4._0SignalRDemo
{
    public class ChatHub : Hub
    {

        public void Send(string name, string message)
        {
            string connid = Context.ConnectionId;
            //发送消息给所有客户端的
            // Clients.All.broadcastMessage(name, message);            
            //发送消息给当前连接客户端
            Clients.Client(Context.ConnectionId).addContosoChatMessageToPage("name", "message");
        }
    }
}