using CY.FrameLib.Common;
using CY.Iot.Common;
using CY.Iot.InterfacePlus.Wcf_BF;
using Newtonsoft.Json;
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
    public partial class Payment : Form
    {
        User _user;

        bool isPaying = false;
        string strURL;
        string payType = "0";
        IMainFrm mainFrm;
        public Payment(IMainFrm mainFrm,User user)
        {
            InitializeComponent();
            this._user = user;
            this.mainFrm = mainFrm;
            if (this._user != null)
            {
                this.txtUserId.Text = this._user.UserID;
                this.txtUserName.Text = this._user.UserName;
                this.txtMeterNo.Text = this._user.MeterNo;
                this.txtAddress.Text = this._user.Address;
            }
            this.txtAmount.Select(0,1);
            strURL = string.Format("{0}/IotM/SFXT/Payment.html", LoginChecker.getInstance().CompanyAccount.ServiceURL);
            this.webKitBrowser1.Url= new System.Uri(strURL, System.UriKind.Absolute);
        }


        private void webKitBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (this.isPaying && this.webKitBrowser1.Url.AbsolutePath.ToLower() == "/iotm/sfxt/payment.html")
            {
                StringBuilder sbScript = new StringBuilder();
                sbScript.Append(string.Format("var userId=\"{0}\";", this._user.UserID));
                sbScript.Append(string.Format("var meterNo=\"{0}\";", this._user.MeterNo));
                sbScript.Append(string.Format("var meterId=\"{0}\";", this._user.MeterID));
                sbScript.Append(string.Format("var amount=\"{0}\";", this.txtAmount.Value));
                sbScript.Append(string.Format("var payType=\"{0}\";", this.payType));
                sbScript.Append(string.Format("var operId=\"{0}\";", this.mainFrm.getOperatorID));
                sbScript.Append(string.Format("var operName=\"{0}\";", this.mainFrm.getOperatorName));
                string strScript = string.Format("{0} ChongZhi(userId, meterNo, meterId, amount,payType,operId,operName);", sbScript.ToString());
                webKitBrowser1.StringByEvaluatingJavaScriptFromString(strScript);
            }
        }

        private void webKitBrowser1_DocumentTitleChanged(object sender, EventArgs e)
        {
            if (isPaying)
            {
                isPaying = false;
                //充值返回了数据
                try
                {
                    Message msg = JsonConvert.DeserializeObject<Message>(this.webKitBrowser1.DocumentTitle);
                    if (msg.Result)
                    {
                        //充值成功，提示打印票据
                        PayResult pay = JsonConvert.DeserializeObject<PayResult>(msg.TxtMessage);
                        Print(pay);
                        using (CompanyAccountServiceBF bf = new CompanyAccountServiceBF())
                        {
                            Iot_TopUpRecord topUpRecord = new Iot_TopUpRecord()
                            {
                                ID = pay.ID,
                                Address = this._user.Address,
                                Amount = pay.Amount,
                                Context = pay.Context,
                                MeterID = pay.MeterID,
                                MeterNo = pay.MeterNo,
                                Oper = pay.Oper,
                                OrgCode = "",
                                PayType = pay.PayType,
                                Ser=pay.Ser,
                                CompanyID="",
                                State = (char)pay.State,
                                TaskID = pay.TaskID,
                                TopUpDate = pay.TopUpDate,
                                TopUpType = (char)pay.TopUpType,
                                UserID = pay.UserID,
                                UserName = _user.UserName
                            };
                            bf.ICompanyAccount.AddTopUpRecord(topUpRecord);
                        }
                    }
                    else
                    {
                        //充值失败
                        this.btnClose.Enabled = true;
                        this.btnPay.Enabled = true;
                        MessageBox.Show("充值失败，原因：" + msg.TxtMessage, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ee)
                {
                    this.btnClose.Enabled = true;
                    this.btnPay.Enabled = true;
                    MessageBox.Show("充值失败，原因：服务器返回错误数据。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        PayResult result;

        public PayResult Result { get => result; set => result = value; }

        private void Print(PayResult result)
        {
            this.result = result;
            this.DialogResult = DialogResult.OK;
            this.Close();
  
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (this.txtAmount.Value <= 0)
            {
                MessageBox.Show("充值金额不能小于或等于0，请修改充值金额。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if(MessageBox.Show(string.Format("为用户【{0}】充值【{1}】元吗？",this._user.UserName,this.txtAmount.Value),"系统提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //开始充值
                this.btnPay.Enabled = false;
                this.btnClose.Enabled = false;
                if (radioButton1.Checked)
                    payType = "0";
                else if (radioButton2.Checked)
                    payType = "1";
                else if (radioButton3.Checked)
                {
                    payType = "2";
                }
                isPaying = true;
                this.webKitBrowser1.Navigate(this.strURL);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
