using Grpc.Core;
using GrpcLibrary;
using GrpcServer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace GrpcDemo
{
    class Program
    {
        private static Server _server;
        static void Main(string[] args)
        {
            _server = new Server
            {
                Services = { HelloService.BindService(new GrpcImpl()) },
                Ports = { new ServerPort("localhost", 8088, ServerCredentials.Insecure) }
            };
            _server.Start();
            Console.WriteLine("grpc ServerListening On Port 8088");
            Console.WriteLine("任意键退出...");
            Console.ReadKey();

            _server?.ShutdownAsync().Wait();


        }
    }
}
