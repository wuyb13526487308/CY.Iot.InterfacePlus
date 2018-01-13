using CY.FrameLib.Common;
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
    public partial class RePrintNote : Form
    {
        User _user;
        IMainFrm mainFrm;
        TicketPrinter printer;
        string strURL;
        bool isSelected = false;
        public RePrintNote(IMainFrm mainFrm, User user, TicketPrinter printer)
        {
            InitializeComponent();

            this.mainFrm = mainFrm;
            this._user = user;
            this.printer = printer;

            strURL = string.Format("{0}/IotM/SFXT/Payment.html", LoginChecker.getInstance().CompanyAccount.ServiceURL);
            this.webKitBrowser1.Url = new System.Uri(strURL, System.UriKind.Absolute);

        }

        private void webKitBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (this.webKitBrowser1.Url.AbsolutePath.ToLower() == "/iotm/sfxt/payment.html")
            {
                StringBuilder sbScript = new StringBuilder();
                sbScript.Append(string.Format("var userId=\"{0}\";", this._user.UserID));
                string strScript = string.Format("{0} ChongZhiQuery(userId);", sbScript.ToString());
                webKitBrowser1.StringByEvaluatingJavaScriptFromString(strScript);
            }
        }

        private void webKitBrowser1_DocumentTitleChanged(object sender, EventArgs e)
        {
            try
            {
                CZSource source = JsonConvert.DeserializeObject<CZSource>(this.webKitBrowser1.DocumentTitle);
                if (source != null)
                {
                    List<ChongZhiData> list = source.rows; //JsonConvert.DeserializeObject<List<User>>(source.rows);
                    this.bindingSource1.DataSource = list;
                }
            }
            catch
            {

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ChongZhiData czData = this.dataGridView1.CurrentRow.DataBoundItem as ChongZhiData;
            if (czData == null) return;

            new PrintTicket(printer, czData, this.checkBox1.Checked).ShowDialog();
            this.webKitBrowser1.Navigate(strURL);
            this.isSelected = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.isSelected = true;
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            if (row != null)
            {
                row.Selected = true;
            }
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || isSelected) return;
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
