using CY.FrameLib.Common;
using CY.Iot.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CY.Iot.InterfacePlus
{
    class WebShowFunction
    {
        Iot_FunctionDefine funName;
        IMainFrm mainFrm;
        public WebShowFunction(IMainFrm mainFrm, Iot_FunctionDefine funcDefine)
        {
            this.mainFrm = mainFrm;
            this.funName = funcDefine;
            this.OnEventHandler = new EventHandler(itemMenu_OnClicked);
        }
        WebKitFrom webKitFrom;

        private void itemMenu_OnClicked(object sender, EventArgs e)
        {
            //在此打开封装了WebKit内核的浏览器窗口
            if (funName.WinType == 0)
            {
                //0 模式窗口
                new WebKitFrom(this.mainFrm,funName).ShowDialog();
            }
            else
            {
                //1
                if (webKitFrom == null)
                {
                    this.webKitFrom = new WebKitFrom(this.mainFrm, funName);
                    this.webKitFrom.MdiParent = this.mainFrm.getMDI;
                    this.webKitFrom.FormClosed += WebKitFrom_FormClosed;
                    this.webKitFrom.Show();
                }
                else
                {
                    this.webKitFrom.Activate();
                }
            }
        }

        private void WebKitFrom_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            this.webKitFrom.Dispose();
            this.webKitFrom = null;
        }

        public EventHandler OnEventHandler;

    }
}
