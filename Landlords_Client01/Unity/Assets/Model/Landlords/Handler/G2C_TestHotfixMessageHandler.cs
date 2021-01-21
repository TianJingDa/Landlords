using System;

namespace ETModel
{
    [MessageHandler(AppType.ClientM)]
    public class G2C_TestHotfixMessageHandler : AMHandler<G2C_TestHotfixMessage>
    {
        protected override async ETTask Run(Session session, G2C_TestHotfixMessage message)
        {
            Log.Info(message.Info);
        }
    }
}
