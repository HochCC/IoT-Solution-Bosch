using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace Connecting.Hubs
{
    public class MyHube
    {
        [HubName("myHub")]
        public class MyHub : Hub
        {
            // Is set via the constructor on each creation
            private Broadcaster _broadcaster;


            public MyHub()
            : this(Broadcaster.Instance)
            {

            }

            public MyHub(Broadcaster broadcaster)
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
                _hubContext = GlobalHost.ConnectionManager.GetHubContext<MyHub>();
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
                int[] values = new int[10];
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = random.Next(30,31);
                }
                // 定期执行的方法
                _hubContext.Clients.All.sendTest1(values);
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