using System;
using System.Net;
using ETModel;

namespace ETHotfix
{
    [MessageHandler(AppType.Gate)]
    public class C2G_TestTimeHandler : AMRpcHandler<C2G_TestTime, G2C_TestTime>
    {
        protected override async ETTask Run(Session session, C2G_TestTime request, G2C_TestTime response, Action reply)
        {
            response.Message = DateTime.Now.ToString();
            reply();
        }
    }
}