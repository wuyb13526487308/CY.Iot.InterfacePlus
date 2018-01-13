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

namespace CY.Iot.InterfacePlus.pay
{
    public partial class PrintTemplateSelect : Form
    {
        private int templateId = -1;
        public PrintTemplateSelect()
        {
            InitializeComponent();

            using (CompanyAccountServiceBF bf = new CompanyAccountServiceBF())
            {
                TemplateId = bf.ICompanyAccount.GetIotPayTicketTemplate(); 
                List<ReportTemplate> list = bf.ICompanyAccount.getInvoiceTemplate();

                this.bindingSource1.DataSource = bf.ICompanyAccount.getInvoiceTemplate();
                this.comboBox1.SelectedValue = templateId;

                //this.comboBox1.SelectedItem = list.Where(p => p.RD_ID == TemplateId).SingleOrDefault();
                //this.bindingSource2.DataSource = list.Where(p => p.RD_ID == TemplateId).ToList();

            }
        }

        public int TemplateId { get => templateId; private set => templateId = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.TemplateId != Convert.ToInt32(this.comboBox1.SelectedValue))
            {
                if (MessageBox.Show("设置选择的票据模版吗？","系统提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.bindingSource2.EndEdit();
                    using (CompanyAccountServiceBF bf = new CompanyAccountServiceBF())
                    {
                        string result = bf.ICompanyAccount.SetIotPayTicketTemplate(Convert.ToInt32(this.comboBox1.SelectedValue));
                        if (result == "")
                        {
                            MessageBox.Show("设置完成", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.templateId = Convert.ToInt32(this.comboBox1.SelectedValue);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("设置失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
