using CY.FrameLib.Common;
using CY.Iot.Common;
using CY.Iot.InterfacePlus.Wcf_BF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CY.Iot.InterfacePlus
{
    class LoginChecker
    {
        private static LoginChecker _loginChecker;
        private static object _lock = new object();
        private CompanyAccount companyAccount;
        private bool isLogin = false;
        private Timer _timer;
        private IMainFrm mainFrm;
        private LoginChecker()
        {
            //this._timer = new Timer(3600000);//登陆成功后没一个小时检查一次登录
            this._timer = new Timer();//登陆成功后没一个小时检查一次登录
            this._timer.Interval = 3600000;
            this._timer.Tick += _timer_Tick;
            this._timer.Start();
            ReadCompanyAccount();
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            CheckLogin();
        }

        ~LoginChecker()
        {
            if (this._timer != null)
            {
                this._timer.Stop();
                this._timer = null;
            }
        }
        public static LoginChecker getInstance()
        {
            if (_loginChecker == null)
            {
                lock (_lock)
                {
                    if (_loginChecker == null)
                    {
                        _loginChecker = new LoginChecker();
                    }
                }
            }
            return _loginChecker;
        }

        public bool Login(IMainFrm mainFrm)
        {
            this.mainFrm = mainFrm;
            if (isLogin)
            {
                return true;
            }
            else
            {
                //登陆
                string strURL = string.Format("{0}/Login.aspx", this.companyAccount.ServiceURL);
                Uri url = new System.Uri(strURL, System.UriKind.Absolute);
                LoginCheck lc = new LoginCheck(url,true);
                lc.ShowDialog();
                isLogin = lc.OK;
                if (lc.OK)
                    this._timer.Start();
                else
                    this._timer.Stop();
                return lc.OK;
            }
        }

        public bool BindingCheck(CompanyAccount account)
        {
            this.companyAccount = account;
            string strURL = string.Format("{0}/Login.aspx", this.companyAccount.ServiceURL);
            Uri url = new System.Uri(strURL, System.UriKind.Absolute);
            LoginCheck lc = new LoginCheck(url, true,"账号检查，请稍后...");
            lc.ShowDialog();
            isLogin = lc.OK;
            return lc.OK;
        }

        private bool CheckLogin()
        {
            lock (_lock)
            {
                string strURL = string.Format("{0}/CheckLogin.html", this.companyAccount.ServiceURL);
                LoginCheck lc = new LoginCheck(new System.Uri(strURL, System.UriKind.Absolute), false);
                lc.ShowDialog();
                isLogin = lc.OK;
                lc = null;
                return true;// lc.OK;
            }
        }
        private void ReadCompanyAccount()
        {          
            using (CompanyAccountServiceBF bf = new CompanyAccountServiceBF())
            {
                this.companyAccount = bf.ICompanyAccount.ReadComapnyAccount();
            }        
        }

        public CompanyAccount CompanyAccount
        {
            get
            {
                return this.companyAccount;
            }
        }
    }
}
