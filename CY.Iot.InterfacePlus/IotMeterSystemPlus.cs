using CY.FrameLib.Common;
using CY.Iot.Common;
using CY.Iot.InterfacePlus.Wcf_BF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CY.Iot.InterfacePlus
{
    public class IotMeterSystemPlus : BasePlus
    {
        public IotMeterSystemPlus(IMainFrm mainFrm) : base(mainFrm)
        {

        }

        public override List<BarItem> getBar()
        {
            return base.getBar();
        }

        public override List<MenuItem> getMenu()
        {
            List<MenuItem> listMenuItem = base.getMenu();
            try
            {
                List<Iot_FunctionMenu> menus = MenuServiceBF.getInstance().getIMeterCheck.ReadFunctionMenu();
                List<Iot_FunctionDefine> functions = MenuServiceBF.getInstance().getIMeterCheck.ReadFunctionDefine();

                MenuItem item = null;
                foreach (Iot_FunctionMenu row in menus)
                {
                    Iot_FunctionDefine fun = (from p in functions where p.RootID == row.RootID select p).SingleOrDefault();

                    //检查报表查看权限
                    if (fun != null && (Convert.ToInt32(fun.RightCode) == -1 || this._iMainFrm.IsExist(Convert.ToInt32(fun.RightCode))))
                    {
                        //检查
                        item = new MenuItem();
                        item.Caption = row.MenuName;
                        item.Name = row.MenuName;
                        if(fun.URI != "")
                        {
                            //网页功能展示
                            item.MouseClicked = new WebShowFunction(this._iMainFrm, fun).OnEventHandler;
                        }
                        else
                        {
                            //本地功能实现
                            item.MouseClicked = new LocalFunction(this._iMainFrm, fun).OnEventHandler;
                        }
                       
                        listMenuItem.Add(item);
                    }
                }

            }
            catch(Exception e)
            {
                //加载菜单失败
                System.Windows.Forms.MessageBox.Show(e.Message);
            }

            return listMenuItem;
        }
    }
}
