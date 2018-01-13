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
    public partial class IotFunMenuManageForm : Form
    {
        public IotFunMenuManageForm()
        {
            InitializeComponent();

            this.bsMenuDefine.DataSource = MenuServiceBF.getInstance().getIMeterCheck.ReadFunctionMenu();
            this.mainMenu.DataSource = MenuServiceBF.getInstance().getIMeterCheck.ReadMainMenus();
            this.iotFun.DataSource = MenuServiceBF.getInstance().getIMeterCheck.ReadFunctionDefine();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.bsMenuDefine.EndEdit();
            List<Iot_FunctionMenu> list = this.bsMenuDefine.DataSource as List<Iot_FunctionMenu>;
            foreach (Iot_FunctionMenu menu in list)
            {
                MenuServiceBF.getInstance().getIMeterCheck.UpdateFunctionMenu(menu);
            }
            MessageBox.Show("保存完成.");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
