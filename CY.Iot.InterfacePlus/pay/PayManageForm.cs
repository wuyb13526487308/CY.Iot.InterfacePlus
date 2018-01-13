using CY.FrameLib.Common;
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
    public partial class PayManageForm : Form
    {
        IMainFrm mainFrm;
        /// <summary>
        /// 票据打印类
        /// </summary>
        TicketPrinter printer;

        public PayManageForm(IMainFrm mainFrm)
        {
            InitializeComponent();
            this.mainFrm = mainFrm;
            this.btnPrinterSelect.Visible = mainFrm.IsExist(1024);

            if (LoginChecker.getInstance().Login(mainFrm))
            {
                //登录成功
                string strURL = string.Format("{0}/IotM/SFXT/Payment.html", LoginChecker.getInstance().CompanyAccount.ServiceURL);
                Uri url = new System.Uri(strURL, System.UriKind.Absolute);
                this.webKitBrowser1.Url = url;
            }
            else
            {
                this.webKitBrowser1.Url = new System.Uri(string.Format("{0}/{1}", LoginChecker.getInstance().CompanyAccount.ServiceURL,
                   "Fail.html"), System.UriKind.Absolute); ;
            }
            //需要增加票据模版定义功能
            using (CompanyAccountServiceBF bf = new CompanyAccountServiceBF())
            {
                this.printer = new TicketPrinter(bf.ICompanyAccount.GetIotPayTicketTemplate());
            }

        }

        private void webKitBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void webKitBrowser1_DocumentTitleChanged(object sender, EventArgs e)
        {
            if (this.webKitBrowser1.Url.AbsolutePath.ToLower() != "/iotm/sfxt/payment.html") return;
            try
            {
                DGSource source = JsonConvert.DeserializeObject<DGSource>(this.webKitBrowser1.DocumentTitle);
                if (source != null)
                {
                    List<User> list = source.rows; //JsonConvert.DeserializeObject<List<User>>(source.rows);
                    this.bindingSource1.DataSource = list;                    
                }
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string sqlWhere = " and MeterType='01'";
            string where = "";
            if (this.txtUserId.Text.Trim() != "")
            {
                where += string.Format(" and UserID  like \'%{0}%\'", this.txtUserId.Text.Trim());
            }
            if (this.txtUserName.Text.Trim() != "")
            {
                where += string.Format(" and UserName  like \'%{0}%\'", this.txtUserName.Text.Trim());
            }

            if (this.txtMeterNo.Text.Trim() != "")
            {
                where += string.Format(" and MeterNo  like \'%{0}%\'", this.txtMeterNo.Text.Trim());
            }

            if (this.txtAddress.Text.Trim() != "")
            {
                where += string.Format(" and Address  like \'%{0}%\'", this.txtAddress.Text.Trim());
            }

            if (where == "")
            {
                MessageBox.Show("请输入查询条件，然后重试！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (this.webKitBrowser1.Url.AbsolutePath.ToLower() != "/iotm/sfxt/payment.html") return;
            object[] param = { sqlWhere + where };
            string strScript = string.Format("var param = \"{0}\";QueryUserInfo(param);", sqlWhere + where);
            webKitBrowser1.StringByEvaluatingJavaScriptFromString(strScript);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!this.mainFrm.IsExist(1023)) return;

            if (e.ColumnIndex < 5) return;
            User user = this.dataGridView1.CurrentRow.DataBoundItem as User;
            if (e.ColumnIndex == 5)
            {
                //点击了充值按钮
                Payment pay = new Payment(this.mainFrm, user);
                if(pay.ShowDialog() == DialogResult.OK)
                {
                    if (printer == null)
                    {
                        MessageBox.Show("票据模版未定义或被删除，请联系管理员！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (MessageBox.Show("充值完成，打印票据吗？", "打印提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //从这里传入打印模版对象

                        new PrintTicket(printer, pay.Result, user,this.checkBox1.Checked).ShowDialog();
                    }
                }
            }
            if (e.ColumnIndex == 6)
            {
                //点击了重打票据按钮
                new RePrintNote(this.mainFrm, user, this.printer).ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.txtAddress.Text = "";
            this.txtMeterNo.Text = "";
            this.txtPhone.Text = "";
            this.txtUserId.Text = "";
            this.txtUserName.Text = "";
        }

        private void btnPrinterSelect_Click(object sender, EventArgs e)
        {
            //设置打印模版
            PrintTemplateSelect templateSelect = new PrintTemplateSelect();
            if (templateSelect.ShowDialog() == DialogResult.OK)
            {
                //重新初始化模版
                this.printer = new TicketPrinter(templateSelect.TemplateId);
            }
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            foreach (DataGridViewRow r in dataGridView1.SelectedRows)
                r.Selected = false;
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            if (row != null)
            {
                row.Selected = true;
            }
        }
    }
}
