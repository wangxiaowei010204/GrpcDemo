using Grpc.Core;
using GrpcLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GrpcServer
{
    public class GrpcImpl : HelloService.HelloServiceBase
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

        /// <summary>
        /// 两数相乘
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public override async Task<GetMegNumMulReply> GetMul(GetMegNumMul request, ServerCallContext context)
        {
            var result = new GetMegNumMulReply();

            result.Mul = request.Num1 * request.Num2;

            return result;
        }


    }
}
