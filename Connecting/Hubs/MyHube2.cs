using Connecting.Models;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;


namespace Connecting.Hubs
{
    public class MyHube2
    { 
        [HubName("myHub2")]
        public class myHub2 : Hub
        {
            // Is set via the constructor on each creation
            private Broadcaster _broadcaster;


            public myHub2()
            : this(Broadcaster.Instance)
            {

            }

            public myHub2(Broadcaster broadcaster)
            {
                _broadcaster = broadcaster;

            }

        }
         
        /// <summary>
            /// 数据广播器
            /// </summary>
        public class Broadcaster
        {
            

            private readonly static Lazy<Broadcaster> _instance =
            new Lazy<Broadcaster>(() => new Broadcaster());

            private readonly IHubContext _hubContext;



            private Timer _broadcastLoop;

            public Broadcaster()
            {
                // 获取所有连接的句柄，方便后面进行消息广播
                _hubContext = GlobalHost.ConnectionManager.GetHubContext<myHub2>();
                // Start the broadcast loop
                _broadcastLoop = new Timer(
    BroadcastShape,
    null,
    1000,
    1000);

            }
             
            private Random random = new Random(); 

            private void BroadcastShape(object state)
            {
                Random rd = new Random();
                int values = rd.Next(10);
                float f = (float)(61 + values * 1);
                // 定期执行的方法
                _hubContext.Clients.All.sendTest1(f);

                Random rd2 = new Random();
                int values2 = rd.Next(10);
                float f2 = (float)(30 + values * 0.1); 
                // 定期执行的方法
                _hubContext.Clients.All.sendTest2(f2);
            }

            public static Broadcaster Instance
            {
                get
                {
                    return _instance.Value;
                }
            }
        }
    }
}