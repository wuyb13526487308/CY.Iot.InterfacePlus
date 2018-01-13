using RX.Gas.ReportLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CY.Iot.InterfacePlus.pay
{
    public partial class PrintTicket : Form
    {
        PayResult pay;
        string strURL;
        User user;
        TicketPrinter ticketPrinter;
        bool isPrev = false;
        ChongZhiData chongzhiData;
        private long id;
        private bool isRePrint = false;
        public PrintTicket(TicketPrinter printer,PayResult result,User user,bool isPrev)
        {
            InitializeComponent();
            this.pay = result;
            this.user = user;
            this.isPrev = isPrev;
            ticketPrinter = printer;
            id = result.ID;
            
            strURL = string.Format("{0}/IotM/SFXT/Payment.html", LoginChecker.getInstance().CompanyAccount.ServiceURL);
            this.webKitBrowser1.Url = new System.Uri(strURL, System.UriKind.Absolute);
        }

        public PrintTicket(TicketPrinter printer,ChongZhiData chongzhiData,bool isPrev)
        {
            InitializeComponent();
            this.isPrev = isPrev;
            id = chongzhiData.AID;
            this.chongzhiData = chongzhiData;
            ticketPrinter = printer;
            isRePrint = Convert.ToBoolean(chongzhiData.IsPrint);

            strURL = string.Format("{0}/IotM/SFXT/Payment.html", LoginChecker.getInstance().CompanyAccount.ServiceURL);
            this.webKitBrowser1.Url = new System.Uri(strURL, System.UriKind.Absolute);

        }
       
        private void webKitBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (isRePrint)
            {
                this.timer1.Start();
                return;
            }
            StringBuilder sbScript = new StringBuilder();
            sbScript.Append(string.Format("var id=\"{0}\";", id));
            string strScript = string.Format("{0} PrintTicket(id);", sbScript.ToString());
            webKitBrowser1.StringByEvaluatingJavaScriptFromString(strScript);
            this.timer2.Start();
        }

        private void webKitBrowser1_DocumentTitleChanged(object sender, EventArgs e)
        {
            this.timer2.Stop();
            this.timer2.Tick -= timer2_Tick;
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.timer1.Stop();
            List<DefineSqlParameter> param = new List<DefineSqlParameter>();
            if (pay == null)
            {
                SetParm(param);
            }
            else
            {
                param.Add(getPar("UserId", SqlDbType.VarChar, 20, user.UserID));
                param.Add(getPar("UserName", SqlDbType.VarChar, 20, user.UserName));
                param.Add(getPar("ID", SqlDbType.VarChar, 20, pay.ID));
                param.Add(getPar("Address", SqlDbType.VarChar, 100, user.Address));
                param.Add(getPar("Amount", SqlDbType.Money, 20, pay.Amount));
                param.Add(getPar("PayDate", SqlDbType.DateTime, 20, pay.TopUpDate));
                string payType = "现金";
                if (pay.PayType.ToString() == "1")
                {
                    payType = "支付宝";
                }
                else if (pay.PayType.ToString() == "2")
                {
                    payType = "微信";
                }
                param.Add(getPar("PayType", SqlDbType.VarChar, 20, payType));
                param.Add(getPar("OperName", SqlDbType.VarChar, 20, pay.SFOperName));
            }
            if (this.ticketPrinter != null)
                this.ticketPrinter.Print(param, isPrev);
            else
                MessageBox.Show("票据模版未定义或被删除，请联系管理员！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            this.Close();
        }

        private void SetParm(List<DefineSqlParameter> param)
        {

            param.Add(getPar("UserId", SqlDbType.VarChar, 20, chongzhiData.UserID));
            param.Add(getPar("UserName", SqlDbType.VarChar, 20, chongzhiData.UserName));
            param.Add(getPar("ID", SqlDbType.VarChar, 20, chongzhiData.AID));
            param.Add(getPar("Address", SqlDbType.VarChar, 100, chongzhiData.Address));
            param.Add(getPar("Amount", SqlDbType.Money, 20, chongzhiData.Amount));
            param.Add(getPar("PayDate", SqlDbType.DateTime, 20, chongzhiData.TopUpDate));
            string payType = "现金";
            if (chongzhiData.PayType.ToString() == "1")
            {
                payType = "支付宝";
            }
            else if (chongzhiData.PayType.ToString() == "2")
            {
                payType = "微信";
            }
            param.Add(getPar("PayType", SqlDbType.VarChar, 20, payType));
            param.Add(getPar("OperName", SqlDbType.VarChar, 20, chongzhiData.SFOperName));
        }

        private DefineSqlParameter getPar(string paraName, SqlDbType dbType, int size,object value)
        {
            DefineSqlParameter par = null;
            par = new DefineSqlParameter(paraName, dbType, size, "");
            par.Value = value;
            return par;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.timer2.Stop();
            MessageBox.Show("服务器无应答或服务故障，请稍后重试！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }
    }
}
