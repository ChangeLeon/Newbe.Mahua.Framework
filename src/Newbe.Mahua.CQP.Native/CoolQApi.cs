using System.Runtime.InteropServices;
using Newbe.Mahua.CQP.NativeApi;

namespace Newbe.Mahua.CQP.Native
{


    public class CoolQApi : ICoolQApi
    {
        /// <summary>
        /// 发送好友消息
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="QQID">目标QQ</param>
        /// <param name="msg">消息内容</param>
        /// <returns></returns>
        int ICoolQApi.CQ_sendPrivateMsg(int AuthCode, long QQID, string msg)
            => NativeMethods.CQ_sendPrivateMsg(AuthCode, QQID, msg);

        /// <summary>
        /// 发送群消息
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="群号">目标群</param>
        /// <param name="msg">消息内容</param>
        /// <returns></returns>
        int ICoolQApi.CQ_sendGroupMsg(int AuthCode, long 群号, string msg)
            => NativeMethods.CQ_sendGroupMsg(AuthCode, 群号, msg);

        /// <summary>
        /// 发送讨论组消息
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="讨论组号">目标讨论组</param>
        /// <param name="msg">消息内容</param>
        /// <returns></returns>
        int ICoolQApi.CQ_sendDiscussMsg(int AuthCode, long 讨论组号, string msg)
            => NativeMethods.CQ_sendDiscussMsg(AuthCode, 讨论组号, msg);

        /// <summary>
        /// 发送赞
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="QQID">目标QQ</param>
        /// <returns></returns>
        int ICoolQApi.CQ_sendLike(int AuthCode, long QQID)
            => NativeMethods.CQ_sendLike(AuthCode, QQID);

        /// <summary>
        /// 发送赞
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="QQID">目标QQ</param>
        /// <param name="times">赞的次数，最多10次</param>
        /// <returns></returns>
        int ICoolQApi.CQ_sendLikeV2(int AuthCode, long QQID, int times)
            => NativeMethods.CQ_sendLikeV2(AuthCode, QQID, times);

        /// <summary>
        /// 取Cookies(慎用
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        string ICoolQApi.CQ_getCookies(int AuthCode)
            => NativeMethods.CQ_getCookies(AuthCode);

        /// <summary>
        /// 接收语音
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="file">收到消息中的语音文件名(file)</param>
        /// <param name="outformat">应用所需的格式</param>
        /// <returns></returns>
        string ICoolQApi.CQ_getRecord(int AuthCode, string file, string outformat)
            => NativeMethods.CQ_getRecord(AuthCode, file, outformat);

        /// <summary>
        /// 取CsrfToken(慎用
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        int ICoolQApi.CQ_getCsrfToken(int AuthCode)
            => NativeMethods.CQ_getCsrfToken(AuthCode);

        /// <summary>
        /// 取应用目录
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        string ICoolQApi.CQ_getAppDirectory(int AuthCode)
            => NativeMethods.CQ_getAppDirectory(AuthCode);

        /// <summary>
        /// 取登录QQ
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        long ICoolQApi.CQ_getLoginQQ(int AuthCode)
            => NativeMethods.CQ_getLoginQQ(AuthCode);

        /// <summary>
        /// 取登录昵称
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        string ICoolQApi.CQ_getLoginNick(int AuthCode)
            => NativeMethods.CQ_getLoginNick(AuthCode);

        /// <summary>
        /// 置群员移除
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="群号">目标群</param>
        /// <param name="QQID">目标QQ</param>
        /// <param name="拒绝再加群">如果为真，则“不再接收此人加群申请”，请慎用</param>
        /// <returns></returns>
        int ICoolQApi.CQ_setGroupKick(int AuthCode, long 群号, long QQID, bool 拒绝再加群)
            => NativeMethods.CQ_setGroupKick(AuthCode, 群号, QQID, 拒绝再加群);

        /// <summary>
        /// 置群员禁言
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="群号">目标群</param>
        /// <param name="QQID">目标QQ</param>
        /// <param name="禁言时间">禁言的时间，单位为秒。如果要解禁，这里填写0</param>
        /// <returns></returns>
        int ICoolQApi.CQ_setGroupBan(int AuthCode, long 群号, long QQID, long 禁言时间)
            => NativeMethods.CQ_setGroupBan(AuthCode, 群号, QQID, 禁言时间);

        /// <summary>
        /// 置群管理员
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="群号">目标群</param>
        /// <param name="QQID">被设置的QQ</param>
        /// <param name="成为管理员">真/设置管理员 假/取消管理员</param>
        /// <returns></returns>
        int ICoolQApi.CQ_setGroupAdmin(int AuthCode, long 群号, long QQID, bool 成为管理员)
            => NativeMethods.CQ_setGroupAdmin(AuthCode, 群号, QQID, 成为管理员);

        /// <summary>
        /// 置群成员专属头衔
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="群号">目标群</param>
        /// <param name="QQID">目标QQ</param>
        /// <param name="头衔">如果要删除，这里填空</param>
        /// <param name="过期时间">专属头衔有效期，单位为秒。如果永久有效，这里填写-1</param>
        /// <returns></returns>
        int ICoolQApi.CQ_setGroupSpecialTitle(int AuthCode, long 群号, long QQID, string 头衔, long 过期时间)
            => NativeMethods.CQ_setGroupSpecialTitle(AuthCode, 群号, QQID, 头衔, 过期时间);

        /// <summary>
        /// 置全群禁言
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="群号">目标群</param>
        /// <param name="开启禁言">真/开启 假/关闭</param>
        /// <returns></returns>
        int ICoolQApi.CQ_setGroupWholeBan(int AuthCode, long 群号, bool 开启禁言)
            => NativeMethods.CQ_setGroupWholeBan(AuthCode, 群号, 开启禁言);

        /// <summary>
        /// 置匿名群员禁言
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="群号">目标群</param>
        /// <param name="匿名">群消息事件收到的“匿名”参数</param>
        /// <param name="禁言时间">禁言的时间，单位为秒。不支持解禁</param>
        /// <returns></returns>
        int ICoolQApi.CQ_setGroupAnonymousBan(int AuthCode, long 群号, string 匿名, long 禁言时间)
            => NativeMethods.CQ_setGroupAnonymousBan(AuthCode, 群号, 匿名, 禁言时间);

        /// <summary>
        /// 置群匿名设置
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="群号"></param>
        /// <param name="开启匿名"></param>
        /// <returns></returns>
        int ICoolQApi.CQ_setGroupAnonymous(int AuthCode, long 群号, bool 开启匿名)
            => NativeMethods.CQ_setGroupAnonymous(AuthCode, 群号, 开启匿名);

        /// <summary>
        /// 置群成员名片
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="群号">目标群</param>
        /// <param name="QQID">被设置的QQ</param>
        /// <param name="新名片_昵称"></param>
        /// <returns></returns>
        int ICoolQApi.CQ_setGroupCard(int AuthCode, long 群号, long QQID, string 新名片_昵称)
            => NativeMethods.CQ_setGroupCard(AuthCode, 群号, QQID, 新名片_昵称);

        /// <summary>
        /// 置群退出
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="群号">目标群</param>
        /// <param name="是否解散">真/解散本群(群主) 假/退出本群(管理、群成员)</param>
        /// <returns></returns>
        int ICoolQApi.CQ_setGroupLeave(int AuthCode, long 群号, bool 是否解散)
            => NativeMethods.CQ_setGroupLeave(AuthCode, 群号, 是否解散);

        /// <summary>
        /// 置讨论组退出
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="讨论组号">目标讨论组</param>
        /// <returns></returns>
        int ICoolQApi.CQ_setDiscussLeave(int AuthCode, long 讨论组号)
            => NativeMethods.CQ_setDiscussLeave(AuthCode, 讨论组号);

        /// <summary>
        /// 置好友添加请求
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="请求反馈标识">请求事件收到的“反馈标识”参数</param>
        /// <param name="反馈类型">#请求_通过 或 #请求_拒绝</param>
        /// <param name="备注">添加后的好友备注</param>
        /// <returns></returns>
        int ICoolQApi.CQ_setFriendAddRequest(int AuthCode, string 请求反馈标识, int 反馈类型, string 备注)
            => NativeMethods.CQ_setFriendAddRequest(AuthCode, 请求反馈标识, 反馈类型, 备注);

        /// <summary>
        /// 置群添加请求
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="请求反馈标识">请求事件收到的“反馈标识”参数</param>
        /// <param name="请求类型">根据请求事件的子类型区分 #请求_群添加 或 #请求_群邀请</param>
        /// <param name="反馈类型">#请求_通过 或 #请求_拒绝</param>
        /// <returns></returns>
        int ICoolQApi.CQ_setGroupAddRequest(int AuthCode, string 请求反馈标识, int 请求类型, int 反馈类型)
            => NativeMethods.CQ_setGroupAddRequest(AuthCode, 请求反馈标识, 请求类型, 反馈类型);

        /// <summary>
        /// 置群添加请求
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="请求反馈标识">请求事件收到的“反馈标识”参数</param>
        /// <param name="请求类型">根据请求事件的子类型区分 #请求_群添加 或 #请求_群邀请</param>
        /// <param name="反馈类型">#请求_通过 或 #请求_拒绝</param>
        /// <param name="理由">操作理由，仅 #请求_群添加 且 #请求_拒绝 时可用</param>
        /// <returns></returns>
        int ICoolQApi.CQ_setGroupAddRequestV2(int AuthCode, string 请求反馈标识, int 请求类型, int 反馈类型, string 理由)
            => NativeMethods.CQ_setGroupAddRequestV2(AuthCode, 请求反馈标识, 请求类型, 反馈类型, 理由);

        /// <summary>
        /// 增加运行日志
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="优先级">#Log_ 开头常量</param>
        /// <param name="类型"></param>
        /// <param name="内容"></param>
        /// <returns></returns>
        int ICoolQApi.CQ_addLog(int AuthCode, int 优先级, string 类型, string 内容)
            => NativeMethods.CQ_addLog(AuthCode, 优先级, 类型, 内容);

        /// <summary>
        /// 置致命错误提示
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="错误信息"></param>
        /// <returns></returns>
        int ICoolQApi.CQ_setFatal(int AuthCode, string 错误信息)
            => NativeMethods.CQ_setFatal(AuthCode, 错误信息);

        /// <summary>
        /// 取群成员信息(旧版
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="群号">目标QQ所在群</param>
        /// <param name="QQID">目标QQ</param>
        /// <returns></returns>
        string ICoolQApi.CQ_getGroupMemberInfo(int AuthCode, long 群号, long QQID)
            => NativeMethods.CQ_getGroupMemberInfo(AuthCode, 群号, QQID);

        /// <summary>
        /// 取群成员信息(支持缓存)
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="群号">目标QQ所在群</param>
        /// <param name="QQID">目标QQ</param>
        /// <param name="不使用缓存"></param>
        /// <returns></returns>
        string ICoolQApi.CQ_getGroupMemberInfoV2(int AuthCode, long 群号, long QQID, bool 不使用缓存)
            => NativeMethods.CQ_getGroupMemberInfoV2(AuthCode, 群号, QQID, 不使用缓存);

        /// <summary>
        /// 取群成员列表
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="群号">目标QQ所在群</param>
        /// <returns></returns>
        string ICoolQApi.CQ_getGroupMemberList(int AuthCode, long 群号)
            => NativeMethods.CQ_getGroupMemberList(AuthCode, 群号);

        /// <summary>
        /// 取陌生人信息(支持缓存)
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="QQID">目标QQ</param>
        /// <param name="不使用缓存"></param>
        /// <returns></returns>
        string ICoolQApi.CQ_getStrangerInfo(int AuthCode, long QQID, bool 不使用缓存)
            => NativeMethods.CQ_getStrangerInfo(AuthCode, QQID, 不使用缓存);

        /// <summary>
        /// 取群列表
        /// </summary>
        /// <returns></returns>
        string ICoolQApi.CQ_getGroupList(int AuthCode) => NativeMethods.CQ_getGroupList(AuthCode);

        private static class NativeMethods
        {
            /// <summary>
            /// 发送好友消息
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <param name="QQID">目标QQ</param>
            /// <param name="msg">消息内容</param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern int CQ_sendPrivateMsg(int AuthCode, long QQID, string msg);

            /// <summary>
            /// 发送群消息
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <param name="群号">目标群</param>
            /// <param name="msg">消息内容</param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern int CQ_sendGroupMsg(int AuthCode, long 群号, string msg);

            /// <summary>
            /// 发送讨论组消息
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <param name="讨论组号">目标讨论组</param>
            /// <param name="msg">消息内容</param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern int CQ_sendDiscussMsg(int AuthCode, long 讨论组号, string msg);

            /// <summary>
            /// 发送赞
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <param name="QQID">目标QQ</param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern int CQ_sendLike(int AuthCode, long QQID);

            /// <summary>
            /// 发送赞
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <param name="QQID">目标QQ</param>
            /// <param name="times">赞的次数，最多10次</param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern int CQ_sendLikeV2(int AuthCode, long QQID, int times);

            /// <summary>
            /// 取Cookies(慎用
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern string CQ_getCookies(int AuthCode);

            /// <summary>
            /// 接收语音
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <param name="file">收到消息中的语音文件名(file)</param>
            /// <param name="outformat">应用所需的格式</param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern string CQ_getRecord(int AuthCode, string file, string outformat);

            /// <summary>
            /// 取CsrfToken(慎用
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern int CQ_getCsrfToken(int AuthCode);

            /// <summary>
            /// 取应用目录
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern string CQ_getAppDirectory(int AuthCode);

            /// <summary>
            /// 取登录QQ
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern long CQ_getLoginQQ(int AuthCode);

            /// <summary>
            /// 取登录昵称
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern string CQ_getLoginNick(int AuthCode);

            /// <summary>
            /// 置群员移除
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <param name="群号">目标群</param>
            /// <param name="QQID">目标QQ</param>
            /// <param name="拒绝再加群">如果为真，则“不再接收此人加群申请”，请慎用</param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern int CQ_setGroupKick(int AuthCode, long 群号, long QQID, bool 拒绝再加群);

            /// <summary>
            /// 置群员禁言
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <param name="群号">目标群</param>
            /// <param name="QQID">目标QQ</param>
            /// <param name="禁言时间">禁言的时间，单位为秒。如果要解禁，这里填写0</param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern int CQ_setGroupBan(int AuthCode, long 群号, long QQID, long 禁言时间);

            /// <summary>
            /// 置群管理员
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <param name="群号">目标群</param>
            /// <param name="QQID">被设置的QQ</param>
            /// <param name="成为管理员">真/设置管理员 假/取消管理员</param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern int CQ_setGroupAdmin(int AuthCode, long 群号, long QQID, bool 成为管理员);

            /// <summary>
            /// 置群成员专属头衔
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <param name="群号">目标群</param>
            /// <param name="QQID">目标QQ</param>
            /// <param name="头衔">如果要删除，这里填空</param>
            /// <param name="过期时间">专属头衔有效期，单位为秒。如果永久有效，这里填写-1</param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern int CQ_setGroupSpecialTitle(int AuthCode, long 群号, long QQID, string 头衔, long 过期时间);

            /// <summary>
            /// 置全群禁言
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <param name="群号">目标群</param>
            /// <param name="开启禁言">真/开启 假/关闭</param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern int CQ_setGroupWholeBan(int AuthCode, long 群号, bool 开启禁言);

            /// <summary>
            /// 置匿名群员禁言
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <param name="群号">目标群</param>
            /// <param name="匿名">群消息事件收到的“匿名”参数</param>
            /// <param name="禁言时间">禁言的时间，单位为秒。不支持解禁</param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern int CQ_setGroupAnonymousBan(int AuthCode, long 群号, string 匿名, long 禁言时间);

            /// <summary>
            /// 置群匿名设置
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <param name="群号"></param>
            /// <param name="开启匿名"></param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern int CQ_setGroupAnonymous(int AuthCode, long 群号, bool 开启匿名);

            /// <summary>
            /// 置群成员名片
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <param name="群号">目标群</param>
            /// <param name="QQID">被设置的QQ</param>
            /// <param name="新名片_昵称"></param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern int CQ_setGroupCard(int AuthCode, long 群号, long QQID, string 新名片_昵称);

            /// <summary>
            /// 置群退出
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <param name="群号">目标群</param>
            /// <param name="是否解散">真/解散本群(群主) 假/退出本群(管理、群成员)</param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern int CQ_setGroupLeave(int AuthCode, long 群号, bool 是否解散);

            /// <summary>
            /// 置讨论组退出
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <param name="讨论组号">目标讨论组</param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern int CQ_setDiscussLeave(int AuthCode, long 讨论组号);

            /// <summary>
            /// 置好友添加请求
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <param name="请求反馈标识">请求事件收到的“反馈标识”参数</param>
            /// <param name="反馈类型">#请求_通过 或 #请求_拒绝</param>
            /// <param name="备注">添加后的好友备注</param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern int CQ_setFriendAddRequest(int AuthCode, string 请求反馈标识, int 反馈类型, string 备注);

            /// <summary>
            /// 置群添加请求
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <param name="请求反馈标识">请求事件收到的“反馈标识”参数</param>
            /// <param name="请求类型">根据请求事件的子类型区分 #请求_群添加 或 #请求_群邀请</param>
            /// <param name="反馈类型">#请求_通过 或 #请求_拒绝</param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern int CQ_setGroupAddRequest(int AuthCode, string 请求反馈标识, int 请求类型, int 反馈类型);

            /// <summary>
            /// 置群添加请求
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <param name="请求反馈标识">请求事件收到的“反馈标识”参数</param>
            /// <param name="请求类型">根据请求事件的子类型区分 #请求_群添加 或 #请求_群邀请</param>
            /// <param name="反馈类型">#请求_通过 或 #请求_拒绝</param>
            /// <param name="理由">操作理由，仅 #请求_群添加 且 #请求_拒绝 时可用</param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern int CQ_setGroupAddRequestV2(int AuthCode, string 请求反馈标识, int 请求类型, int 反馈类型,
                string 理由);

            /// <summary>
            /// 增加运行日志
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <param name="优先级">#Log_ 开头常量</param>
            /// <param name="类型"></param>
            /// <param name="内容"></param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern int CQ_addLog(int AuthCode, int 优先级, string 类型, string 内容);

            /// <summary>
            /// 置致命错误提示
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <param name="错误信息"></param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern int CQ_setFatal(int AuthCode, string 错误信息);

            /// <summary>
            /// 取群成员信息(旧版
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <param name="群号">目标QQ所在群</param>
            /// <param name="QQID">目标QQ</param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern string CQ_getGroupMemberInfo(int AuthCode, long 群号, long QQID);

            /// <summary>
            /// 取群成员信息(支持缓存)
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <param name="群号">目标QQ所在群</param>
            /// <param name="QQID">目标QQ</param>
            /// <param name="不使用缓存"></param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern string CQ_getGroupMemberInfoV2(int AuthCode, long 群号, long QQID, bool 不使用缓存);

            /// <summary>
            /// 取群成员列表
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <param name="群号">目标QQ所在群</param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern string CQ_getGroupMemberList(int AuthCode, long 群号);

            /// <summary>
            /// 取陌生人信息(支持缓存)
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <param name="QQID">目标QQ</param>
            /// <param name="不使用缓存"></param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern string CQ_getStrangerInfo(int AuthCode, long QQID, bool 不使用缓存);

            /// <summary>
            /// 取群列表
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern string CQ_getGroupList(int AuthCode);
        }
    }
}
