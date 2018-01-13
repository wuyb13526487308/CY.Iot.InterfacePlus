using CY.FrameLib.Common;
using CY.Iot.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CY.Iot.InterfacePlus
{
    class BarFunction
    {
        Iot_ChildFunctionBar barFunction;
        IMainFrm mainFrm;
        public BarFunction(IMainFrm mainFrm, Iot_ChildFunctionBar barFunction)
        {
            this.mainFrm = mainFrm;
            this.barFunction = barFunction;
            this.OnEventHandler = new EventHandler(itemMenu_OnClicked);

        }
        BarWebKitFrom webKitFrom;

        private void itemMenu_OnClicked(object sender, EventArgs e)
        {
            //在此打开封装了WebKit内核的浏览器窗口
            if (barFunction.WinType == 0)
            {
                //0 模式窗口
                new BarWebKitFrom(this.mainFrm, barFunction).ShowDialog();
            }
            else
            {
                //1
                if (webKitFrom == null)
                {
                    this.webKitFrom = new BarWebKitFrom(this.mainFrm, barFunction);
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
