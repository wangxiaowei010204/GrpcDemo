using Grpc.Core;
using GrpcLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GrpcServer
{
    class Program
    {
      public  class GrpcImpl : HelloService.HelloServiceBase
        {
     
            public override async Task<GetMsgSumReply> GetSum(GetMsgNumRequest request, ServerCallContext context)
            {
                var result = new GetMsgSumReply();

                result.Sum = request.Num1 + request.Num2;

                return result;
            }
            public override async Task<GetLotAll> test(GetLotID request, ServerCallContext context)
            {
                var result = new GetLotAll();
                string s = "这里一共有:";
                if (request.Num1 == 1)
                {
                    s += "1个字符";
                }
                s += request.S;
             
                UserList userList = new UserList();
                userList.UserName = "张三";
                result.User.Add(userList);

                List<UserList> userLists = new List<UserList>();
                result.User.AddRange(userLists);
                result.T = GetLotAll.Types.Lists.Wip;
                return result;
            }

        }
        private static Server _server;
        static void Main(string[] args)
        {
            _server = new Server {
                Services = {HelloService.BindService(new GrpcImpl()) },
                Ports = { new ServerPort("localhost",8088,ServerCredentials.Insecure)}
            };
            _server.Start();
            Console.WriteLine("grpc ServerListening On Port 8088");
            Console.WriteLine("任意键退出...");
            Console.ReadKey();

            _server?.ShutdownAsync().Wait();


        }
    }
}
