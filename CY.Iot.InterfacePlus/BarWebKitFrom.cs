using CY.FrameLib.Common;
using CY.Iot.Common;
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
    public partial class BarWebKitFrom : Form
    {
        IMainFrm mainFrm;
        Iot_ChildFunctionBar functionBar;

        public BarWebKitFrom(IMainFrm mainFrm, Iot_ChildFunctionBar functionBar)
        {
            InitializeComponent();
            this.mainFrm = mainFrm;
            this.functionBar = functionBar;
            this.Text = functionBar.FunName;

            //登陆检查
            if (LoginChecker.getInstance().Login(mainFrm))
            {
                //登录成功
                string strURL = string.Format("{0}/{1}", LoginChecker.getInstance().CompanyAccount.ServiceURL,
                    functionBar.URI);
                Uri url = new System.Uri(strURL, System.UriKind.Absolute);
                this.webKitBrowser1.Url = url;
            }
            else
            {
                this.webKitBrowser1.Url = new System.Uri(string.Format("{0}/{1}", LoginChecker.getInstance().CompanyAccount.ServiceURL,
                   "Fail.html"), System.UriKind.Absolute); ;
            }

        }

        private void webKitBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string result = this.webKitBrowser1.DocumentText;
            if (result.ToUpper().IndexOf("FALSE") >= 0 && e.Url.AbsoluteUri.ToLower() == "/fail.html")
            {
                this.webKitBrowser1.DocumentText = "调用物联网表服务失败，请稍后重试。";
            }
        }
    }
}
