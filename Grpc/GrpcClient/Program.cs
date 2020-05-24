using Grpc.Core;
using GrpcLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrpcClient
{
    class Program
    {
        static void Main(string[] args)
        {
            GetMsgSumReply helloMsg = HelloClient.getSum(11, 2);

            var helloMsgMul = HelloClient.GetMul(11, 2);
            GetLotAll getLotAll = HelloClient.GetLotAll(132, "我是老哈哈哈哈");
            Console.WriteLine("grpc Client Call GetSum():" + helloMsg.Sum);
            Console.WriteLine("grpc Client Call GetMul():" + helloMsgMul.Mul);
            string user = string.Empty;
            foreach (var item in getLotAll.User)
            {
                user += item;
            }
            Console.WriteLine("grpc Client Call GetLotAll():" + user);
            Console.WriteLine("任意键退出...");
            Console.ReadKey();
        }
    }
}
