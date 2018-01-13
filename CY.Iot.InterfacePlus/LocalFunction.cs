using CY.FrameLib.Common;
using CY.Iot.Common;
using CY.Iot.InterfacePlus.pay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CY.Iot.InterfacePlus
{
    class LocalFunction
    {
        Iot_FunctionDefine funName;
        IMainFrm mainFrm;
        public LocalFunction(IMainFrm mainFrm, Iot_FunctionDefine funcDefine)
        {
            this.mainFrm = mainFrm;
            this.funName = funcDefine;
            this.OnEventHandler = new EventHandler(itemMenu_OnClicked);
        }

        private void itemMenu_OnClicked(object sender, EventArgs e)
        {
            switch (this.funName.FunName)
            {
                case "企业账号绑定":
                    CreateCompanyAccountBinding();
                    break;
                case "物联网表菜单设置":
                    SetIotMenu();
                    break;
                case "物联网表充值":
                    SetPay();
                    break;

            }
        }

        public EventHandler OnEventHandler;

        private void SetPay()
        {
            if (funName.WinType == 0)
            {
                //0 模式窗口
                new PayManageForm(this.mainFrm).ShowDialog();
            }
            else
            {
                CreatePayWindows();
            }
        }
        PayManageForm _payForm;

        private void CreatePayWindows()
        {
            if (_payForm == null)
            {
                this._payForm = new PayManageForm(this.mainFrm);
                this._payForm.MdiParent = this.mainFrm.getMDI;
                this._payForm.FormClosed += _payForm_FormClosed;
                this._payForm.Show();
            }
            else
            {
                this._payForm.Activate();
            }
        }

        private void _payForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            this._payForm.Dispose();
            this._payForm = null;
        }

        private void SetIotMenu()
        {
            if (funName.WinType == 0)
            {
                //0 模式窗口
                new IotFunMenuManageForm().ShowDialog();
            }
            else
            {
                CreateMenuWindows();
            }
        }
        IotFunMenuManageForm _setMenuForm;
        private void CreateMenuWindows()
        {
            if (_setMenuForm == null)
            {
                this._setMenuForm = new IotFunMenuManageForm();
                this._setMenuForm.MdiParent = this.mainFrm.getMDI;
                this._setMenuForm.FormClosed += _setMenuForm_FormClosed;
                this._setMenuForm.Show();
            }
            else
            {
                this._setMenuForm.Activate();
            }
        }

        private void _setMenuForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            this._setMenuForm.Dispose();
            this._setMenuForm = null;
        }

        //企业账号绑定
        private void CreateCompanyAccountBinding()
        {
            if (funName.WinType == 0)
            {
                //0 模式窗口
                new CompanyAccountFrom().ShowDialog();
            }
        }
    }
}
