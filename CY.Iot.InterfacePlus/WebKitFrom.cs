using CY.FrameLib.Common;
using CY.Iot.Common;
using CY.Iot.InterfacePlus.Wcf_BF;
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
    public partial class WebKitFrom : BaseForm
    {
        Iot_FunctionDefine funName;
        IMainFrm mainFrm;

        public WebKitFrom(IMainFrm mainFrm, Iot_FunctionDefine funcDefine) : base(mainFrm)
        {
            InitializeComponent();

            this.mainFrm = mainFrm;
            this.funName = funcDefine;

            this.Text = funcDefine.FunName;

            //登陆检查
            if(LoginChecker.getInstance().Login(mainFrm))
            {
                //登录成功
                string strURL = string.Format("{0}/{1}", LoginChecker.getInstance().CompanyAccount.ServiceURL,
                    funcDefine.URI);
                Uri url = new System.Uri(strURL, System.UriKind.Absolute);
                this.webKitBrowser1.Url = url;

                //加载
                CreateDefineBar();
                if (this.DefineBar != null)
                {
                    this.DefineBar.BarName = "bar_"+funcDefine.FunName;
                    this.DefineBar.Text = funcDefine.FunName;
                    this.SetDock();
                }
            }
            else
            {
                this.webKitBrowser1.Url = new System.Uri(string.Format("{0}/{1}", LoginChecker.getInstance().CompanyAccount.ServiceURL,
                   "Fail.html"), System.UriKind.Absolute); ;
            }           

            //下面加载自定义bar工具条
        }

        private void CreateDefineBar()
        {
            List<Iot_ChildFunctionBar> list = MenuServiceBF.getInstance().getIMeterCheck.ReadChildFunctionBar(this.funName.RootID);
            if (list == null) return;
            foreach (Iot_ChildFunctionBar bar in list) {
                BarItem item = new BarItem();//新建自定义按钮
                if (this.mainFrm.IsExist(Convert.ToInt32(bar.RightCode)))
                {
                    //添加部门按钮
                    item.Caption = bar.FunName;//按钮显示名称
                    item.Name = "bar" + bar.FunName;
                    item.Title = bar.FunName;//提示信息标题
                    item.Describe = "";//按钮功能描述内容
                                       //增加该按钮对应的处理方法函数的映射
                    item.MouseClicked = new BarFunction(this.mainFrm, bar).OnEventHandler;
                    //设置按钮显示的图标
                    //TODO:
                    item.Glyph = global::CY.FrameLib.UI.UIResource.AddDepartment;
                    //添加到窗体中
                    this.AddBarItem(item);
                }
            }
        }

        private void webKitBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string result = this.webKitBrowser1.DocumentText;
            if(result.ToUpper().IndexOf("FALSE")>=0 && e.Url.AbsoluteUri.ToLower() == "/fail.html")
            {
                this.webKitBrowser1.DocumentText = "调用物联网表服务失败，请稍后重试。";
            }
        }
    }
}
