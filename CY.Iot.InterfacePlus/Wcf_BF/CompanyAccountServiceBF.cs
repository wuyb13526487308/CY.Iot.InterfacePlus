using CY.Iot.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;

namespace CY.Iot.InterfacePlus.Wcf_BF
{
    class CompanyAccountServiceBF : IDisposable
    {
        ICompanyAccount iCompanyAccount;
        private ChannelFactory<ICompanyAccount> _channelMeterCheck;
        private Binding binding;

        private string host;   // 地址
        private string port;   // 端口号
        private bool disposed = false;

        ~CompanyAccountServiceBF()
        {
            if (this._channelMeterCheck != null)
            {
                this.Close();
            }
        }

        public CompanyAccountServiceBF()
        {
            host = global::CY.FrameLib.Common.Properties.Settings.Default.Server;
            port = global::CY.FrameLib.Common.Properties.Settings.Default.ServerPort;
            this._channelMeterCheck = this.InitiCompanyAccountChannel();
        }

        /// <summary>
        /// 初始化通道
        /// </summary>
        /// <returns></returns>
        private ChannelFactory<ICompanyAccount> InitiCompanyAccountChannel()
        {
            //初始化WCF接口对象
            binding = new NetTcpBinding();// new WSDualHttpBinding();
            string uri = string.Format("net.tcp://{0}:{1}/CompanyAccountService", host, port);
            //通道身份验证（采用无验证方式）
            ((NetTcpBinding)binding).Security.Mode = SecurityMode.None;
            ((NetTcpBinding)binding).ReceiveTimeout = new TimeSpan(10, 1, 0);
            ((NetTcpBinding)binding).SendTimeout = new TimeSpan(10, 1, 0);
            ((NetTcpBinding)binding).MaxReceivedMessageSize = 1024 * 1024 * 1024;
            //创建用户管理服务通道
            _channelMeterCheck = new ChannelFactory<ICompanyAccount>(binding, new EndpointAddress(uri));
            this.iCompanyAccount = this._channelMeterCheck.CreateChannel();
            return this._channelMeterCheck;
        }

        public void Close()
        {
            try
            {
                if (this._channelMeterCheck != null)
                {
                    this._channelMeterCheck.Close();
                    this._channelMeterCheck = null;
                }
            }
            catch
            {
            }            
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private void Dispose(bool disposing)
        {
            // Check to see if Dispose has already been called.
            if (!this.disposed)
            {
                // If disposing equals true, dispose all managed 
                // and unmanaged resources.
                if (disposing)
                {
                    // Dispose managed resources.
                    Close();
                }
            }
            disposed = true;
        }

        public ICompanyAccount ICompanyAccount
        {
            get
            {
                return this.iCompanyAccount;
            }
        }
    }
}
