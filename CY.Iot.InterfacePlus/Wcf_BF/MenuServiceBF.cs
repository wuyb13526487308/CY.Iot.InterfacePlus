using CY.Iot.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;

namespace CY.Iot.InterfacePlus.Wcf_BF
{
    class MenuServiceBF
    {
        /// <summary>
        /// 声明MeterCheck对象
        /// </summary>
        private static MenuServiceBF _MeterCheckInfoM;

        /// <summary>
        /// 初始化object新实例
        /// </summary>
        private static object _object = new object();

        /// <summary>
        /// 声明IMeterCheck接口对象
        /// </summary>
        private IMenuService _iMenuService;
        private ChannelFactory<IMenuService> _channelMeterCheck;

        private string host;   // 地址
        private string port;   // 端口号

        private MenuServiceBF()
        {
            host = global::CY.FrameLib.Common.Properties.Settings.Default.Server;
            port = global::CY.FrameLib.Common.Properties.Settings.Default.ServerPort;
        }

        public static MenuServiceBF getInstance()
        {
            if (_MeterCheckInfoM == null)
            {
                lock (_object)
                {
                    if (_MeterCheckInfoM == null)
                    {
                        _MeterCheckInfoM = new MenuServiceBF();
                    }
                }
            }
            return _MeterCheckInfoM;
        }

        /// <summary>
        /// 初始化通道
        /// </summary>
        /// <returns></returns>
        private ChannelFactory<IMenuService> InitiMeterCheckChannel()
        {
            //初始化WCF接口对象
            Binding binding = new NetTcpBinding();// new WSDualHttpBinding();
            string uri = string.Format("net.tcp://{0}:{1}/MenuService", host, port);
            //通道身份验证（采用无验证方式）
            ((NetTcpBinding)binding).Security.Mode = SecurityMode.None;
            ((NetTcpBinding)binding).ReceiveTimeout = new TimeSpan(10, 1, 0);
            ((NetTcpBinding)binding).SendTimeout = new TimeSpan(10, 1, 0);
            ((NetTcpBinding)binding).MaxReceivedMessageSize = 1024 * 1024 * 1024;
            //创建用户管理服务通道
            _channelMeterCheck = new ChannelFactory<IMenuService>(binding, new EndpointAddress(uri));
            this._iMenuService = this._channelMeterCheck.CreateChannel();
            return this._channelMeterCheck;
        }

        /// <summary>
        /// 获得用户数据访问接口
        /// </summary>
        public IMenuService getIMeterCheck
        {
            get
            {
                try
                {
                    //测试通道可用性
                    this._iMenuService.Test();
                }
                catch
                {
                    // 重新初始化通道对象
                    this._iMenuService = InitiMeterCheckChannel().CreateChannel();
                }
                return _iMenuService;
            }

        }
    }
}
