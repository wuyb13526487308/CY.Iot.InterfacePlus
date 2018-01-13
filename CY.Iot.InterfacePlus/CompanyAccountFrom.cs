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
    public partial class CompanyAccountFrom : Form
    {
        public CompanyAccountFrom()
        {
            InitializeComponent();

            CompanyAccount companyAccount = LoginChecker.getInstance().CompanyAccount;
            if (companyAccount != null)
            {
                this.txtAccount.Text = companyAccount.CompanyID;
                this.txtCompanyName.Text = companyAccount.CompanyName;
                this.txtUrl.Text = companyAccount.ServiceURL;
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            CompanyAccount companyAccount = new CompanyAccount()
            {
                CompanyID = this.txtAccount.Text,
                CompanyName = this.txtCompanyName.Text,
                CompanyPwd = this.txtPwd.Text,
                ServiceURL = this.txtUrl.Text
            };
            if (companyAccount.CompanyID.Length == 0)
            {
                MessageBox.Show("请输入合法的企业账号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //检查账号密码是否正确，执行一次登录尝试
            if (LoginChecker.getInstance().BindingCheck(companyAccount))
            {
                using (CompanyAccountServiceBF bf = new CompanyAccountServiceBF())
                {
                    if (bf.ICompanyAccount.BindCompanyAccount(companyAccount) == "")
                    {
                        MessageBox.Show("账号绑定设置成功，请重启收费系统完成绑定操作！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("账号绑定失败，请检查输入的URL、账号和密码是否正确", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
