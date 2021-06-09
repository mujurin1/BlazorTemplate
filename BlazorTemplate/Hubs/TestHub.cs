using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTemplate.Hubs
{
    public interface ITestHub
    {
        Task Hello(string msg);
    }

    public class TestHub : Hub<ITestHub>
    {
        public async Task Hello(string msg)
            => await Clients.Others.Hello(msg);
    }
}
