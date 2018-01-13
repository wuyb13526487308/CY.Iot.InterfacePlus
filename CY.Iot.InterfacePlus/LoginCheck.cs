using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CY.Iot.InterfacePlus
{
    public partial class LoginCheck : Form
    {
        public bool OK { get; private set; }

        private bool isLogin = false;
        Uri url;
        public LoginCheck(Uri url, bool isLogin)
        {
            InitializeComponent();
            this.url = url;
            this.webKitBrowser1.Url = url;
            this.isLogin = isLogin;
        }

        public LoginCheck(Uri url, bool isLogin,string tooptip)
        {
            InitializeComponent();
            this.url = url;
            this.webKitBrowser1.Url = url;
            this.isLogin = isLogin;
            this.label1.Text = tooptip;
        }

        private void webKitBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //登录验证
            if(this.webKitBrowser1.Url.AbsoluteUri == this.url.AbsoluteUri && isLogin)
            {
                string strScript = string.Format("$('#loginID').val('{0}@{0}');$('#loginPsw').val('{1}');",LoginChecker.getInstance().CompanyAccount.CompanyID , LoginChecker.getInstance().CompanyAccount.CompanyPwd);
                webKitBrowser1.StringByEvaluatingJavaScriptFromString(strScript);
                //MessageBox.Show(this.webKitBrowser1.DocumentText);
                webKitBrowser1.Document.InvokeScriptMethod("SFXTLogin");
                return;
            }
            //登录检查
            if (this.webKitBrowser1.Url.AbsoluteUri == this.url.AbsoluteUri && !isLogin)
            {
                webKitBrowser1.Document.InvokeScriptMethod("SfxtCheckLogin");
                return;
            }

            string result = this.webKitBrowser1.DocumentText;

            if (result.ToUpper().IndexOf("TRUE")>=0)
            {
                this.OK = true;                
            }
            else
            {
                this.OK = false;
            }
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.OK = false;
            this.Close();
        }

        public void Check(Uri url)
        {

        }
    }
}
