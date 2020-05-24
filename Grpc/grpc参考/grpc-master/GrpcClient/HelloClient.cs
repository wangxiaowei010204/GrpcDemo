using Grpc.Core;
using GrpcLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrpcClient
{
    public static class HelloClient
    {
        private static Channel _channel;
        private static HelloService.HelloServiceClient _client;

        static HelloClient()
        {
            _channel = new Channel("localhost:8088",ChannelCredentials.Insecure);
            _client = new HelloService.HelloServiceClient(_channel);
        }
        public static GetMsgSumReply getSum(int num1, int num2)
        {
            return _client.GetSum(new GetMsgNumRequest { Num1=num1,Num2=num2});
        }
        public static GetLotAll GetLotAll(int num1, string s)
        {
            return _client.test(new GetLotID { Num1 = num1, S = s });
        }
    }
}
