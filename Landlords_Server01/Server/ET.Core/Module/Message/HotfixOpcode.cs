using ETModel;
namespace ETModel
{
//测试向服务器发送消息
	[Message(HotfixOpcode.C2G_TestMessage)]
	public partial class C2G_TestMessage : IRequest {}

//测试向服务器返回消息
	[Message(HotfixOpcode.G2C_TestMessage)]
	public partial class G2C_TestMessage : IResponse {}

//测试向服务器请求时间
	[Message(HotfixOpcode.C2G_TestTime)]
	public partial class C2G_TestTime : IRequest {}

//测试从服务器返回时间
	[Message(HotfixOpcode.G2C_TestTime)]
	public partial class G2C_TestTime : IResponse {}

//客户端登陆网关请求
	[Message(HotfixOpcode.A0003_LoginGate_C2G)]
	public partial class A0003_LoginGate_C2G : IRequest {}

//客户端登陆网关返回
	[Message(HotfixOpcode.A0003_LoginGate_G2C)]
	public partial class A0003_LoginGate_G2C : IResponse {}

//客户端登陆认证请求
	[Message(HotfixOpcode.A0002_Login_C2R)]
	public partial class A0002_Login_C2R : IRequest {}

//客户端登陆认证返回
	[Message(HotfixOpcode.A0002_Login_R2C)]
	public partial class A0002_Login_R2C : IResponse {}

//客户端注册请求
	[Message(HotfixOpcode.A0001_Register_C2R)]
	public partial class A0001_Register_C2R : IRequest {}

//客户端注册请求回复
	[Message(HotfixOpcode.A0001_Register_R2C)]
	public partial class A0001_Register_R2C : IResponse {}

//获取用户信息
	[Message(HotfixOpcode.A1001_GetUserInfo_C2G)]
	public partial class A1001_GetUserInfo_C2G : IRequest {}

//返回用户信息
	[Message(HotfixOpcode.A1001_GetUserInfo_G2C)]
	public partial class A1001_GetUserInfo_G2C : IResponse {}

//设置用户信息
	[Message(HotfixOpcode.A1002_SetUserInfo_C2G)]
	public partial class A1002_SetUserInfo_C2G : IRequest {}

//返回设置用户信息
	[Message(HotfixOpcode.A1002_SetUserInfo_G2C)]
	public partial class A1002_SetUserInfo_G2C : IResponse {}

//向realm用户发送上线消息
	[Message(HotfixOpcode.A0004_PlayerOnline_G2R)]
	public partial class A0004_PlayerOnline_G2R : IMessage {}

//向realm用户发送下线消息
	[Message(HotfixOpcode.A0005_PlayerOffline_G2R)]
	public partial class A0005_PlayerOffline_G2R : IMessage {}

	[Message(HotfixOpcode.A0007_KickOutPlayer_R2G)]
	public partial class A0007_KickOutPlayer_R2G : IRequest {}

	[Message(HotfixOpcode.A0007_KickOutPlayer_G2R)]
	public partial class A0007_KickOutPlayer_G2R : IResponse {}

//==>匹配玩家并进入斗地主游戏房间 4月18
//玩家信息
	[Message(HotfixOpcode.GamerInfo)]
	public partial class GamerInfo {}

//返回大厅
	[Message(HotfixOpcode.C2G_ReturnLobby_Ntt)]
	public partial class C2G_ReturnLobby_Ntt : IMessage {}

//斗地主匹配模块
	[Message(HotfixOpcode.C2G_StartMatch_Req)]
	public partial class C2G_StartMatch_Req : IRequest {}

	[Message(HotfixOpcode.G2C_StartMatch_Back)]
	public partial class G2C_StartMatch_Back : IResponse {}

	[Message(HotfixOpcode.Actor_LandMatcherPlusOne_NTT)]
	public partial class Actor_LandMatcherPlusOne_NTT : IActorMessage {}

	[Message(HotfixOpcode.Actor_LandMatcherReduceOne_NTT)]
	public partial class Actor_LandMatcherReduceOne_NTT : IActorMessage {}

//进入房间(广播)
	[Message(HotfixOpcode.Actor_GamerEnterRoom_Ntt)]
	public partial class Actor_GamerEnterRoom_Ntt : IActorMessage {}

//退出房间(广播)
	[Message(HotfixOpcode.Actor_GamerExitRoom_Ntt)]
	public partial class Actor_GamerExitRoom_Ntt : IActorMessage {}

//匹配玩家并进入斗地主游戏房间 <==
//准备游戏消息
	[Message(HotfixOpcode.Actor_GamerReady_Landlords)]
	public partial class Actor_GamerReady_Landlords : IActorMessage {}

//ET----
	[Message(HotfixOpcode.C2R_Login)]
	public partial class C2R_Login : IRequest {}

	[Message(HotfixOpcode.R2C_Login)]
	public partial class R2C_Login : IResponse {}

	[Message(HotfixOpcode.C2G_LoginGate)]
	public partial class C2G_LoginGate : IRequest {}

	[Message(HotfixOpcode.G2C_LoginGate)]
	public partial class G2C_LoginGate : IResponse {}

	[Message(HotfixOpcode.G2C_TestHotfixMessage)]
	public partial class G2C_TestHotfixMessage : IMessage {}

	[Message(HotfixOpcode.C2M_TestActorRequest)]
	public partial class C2M_TestActorRequest : IActorLocationRequest {}

	[Message(HotfixOpcode.M2C_TestActorResponse)]
	public partial class M2C_TestActorResponse : IActorLocationResponse {}

	[Message(HotfixOpcode.PlayerInfo)]
	public partial class PlayerInfo : IMessage {}

	[Message(HotfixOpcode.C2G_PlayerInfo)]
	public partial class C2G_PlayerInfo : IRequest {}

	[Message(HotfixOpcode.G2C_PlayerInfo)]
	public partial class G2C_PlayerInfo : IResponse {}

	[Message(HotfixOpcode.C2G_LoginGate_Req)]
	public partial class C2G_LoginGate_Req : IRequest {}

	[Message(HotfixOpcode.G2C_LoginGate_Back)]
	public partial class G2C_LoginGate_Back : IResponse {}

}
namespace ETModel
{
	public static partial class HotfixOpcode
	{
		 public const ushort C2G_TestMessage = 10001;
		 public const ushort G2C_TestMessage = 10002;
		 public const ushort C2G_TestTime = 10003;
		 public const ushort G2C_TestTime = 10004;
		 public const ushort A0003_LoginGate_C2G = 10005;
		 public const ushort A0003_LoginGate_G2C = 10006;
		 public const ushort A0002_Login_C2R = 10007;
		 public const ushort A0002_Login_R2C = 10008;
		 public const ushort A0001_Register_C2R = 10009;
		 public const ushort A0001_Register_R2C = 10010;
		 public const ushort A1001_GetUserInfo_C2G = 10011;
		 public const ushort A1001_GetUserInfo_G2C = 10012;
		 public const ushort A1002_SetUserInfo_C2G = 10013;
		 public const ushort A1002_SetUserInfo_G2C = 10014;
		 public const ushort A0004_PlayerOnline_G2R = 10015;
		 public const ushort A0005_PlayerOffline_G2R = 10016;
		 public const ushort A0007_KickOutPlayer_R2G = 10017;
		 public const ushort A0007_KickOutPlayer_G2R = 10018;
		 public const ushort GamerInfo = 10019;
		 public const ushort C2G_ReturnLobby_Ntt = 10020;
		 public const ushort C2G_StartMatch_Req = 10021;
		 public const ushort G2C_StartMatch_Back = 10022;
		 public const ushort Actor_LandMatcherPlusOne_NTT = 10023;
		 public const ushort Actor_LandMatcherReduceOne_NTT = 10024;
		 public const ushort Actor_GamerEnterRoom_Ntt = 10025;
		 public const ushort Actor_GamerExitRoom_Ntt = 10026;
		 public const ushort Actor_GamerReady_Landlords = 10027;
		 public const ushort C2R_Login = 10028;
		 public const ushort R2C_Login = 10029;
		 public const ushort C2G_LoginGate = 10030;
		 public const ushort G2C_LoginGate = 10031;
		 public const ushort G2C_TestHotfixMessage = 10032;
		 public const ushort C2M_TestActorRequest = 10033;
		 public const ushort M2C_TestActorResponse = 10034;
		 public const ushort PlayerInfo = 10035;
		 public const ushort C2G_PlayerInfo = 10036;
		 public const ushort G2C_PlayerInfo = 10037;
		 public const ushort C2G_LoginGate_Req = 10038;
		 public const ushort G2C_LoginGate_Back = 10039;
	}
}
