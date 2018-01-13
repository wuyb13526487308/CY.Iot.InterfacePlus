using CY.Iot.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CY.Iot.DataService
{
    public class MenuService : BaseDataContext, IMenuService
    {
        public string DeleteFunctionMenu(Iot_FunctionMenu functionMenu)
        {
            throw new NotImplementedException();
        }

        public string InsertFunctionMenu(Iot_FunctionMenu functionMenu)
        {
            throw new NotImplementedException();
        }

        public List<Iot_ChildFunctionBar> ReadChildFunctionBar(int rootId)
        {
            return this.GetTable<Iot_ChildFunctionBar>().Where(p=>p.RootID == rootId).ToList();
        }

        public List<Iot_FunctionDefine> ReadFunctionDefine()
        {
            return this.GetTable<Iot_FunctionDefine>().ToList();
        }
        /// <summary>
        /// 读取菜单配置数据
        /// </summary>
        /// <returns></returns>
        public List<Iot_FunctionMenu> ReadFunctionMenu()
        {
            return this.GetTable<Iot_FunctionMenu>().ToList();
        }

        public List<Frame_MainMenu> ReadMainMenus()
        {
            return this.GetTable<Frame_MainMenu>().ToList();
        }

        public void Test()
        {
        }

        public string UpdateFunctionMenu(Iot_FunctionMenu functionMenu)
        {
            Iot_FunctionMenu menu = this.GetTable<Iot_FunctionMenu>().Where(p => p.ID == functionMenu.ID).SingleOrDefault();
            if (menu == null) return "指定的菜单不存在";
            try
            {
                menu.IsGroup = functionMenu.IsGroup;
                menu.MainMenuID = functionMenu.MainMenuID;
                menu.MenuName = functionMenu.MenuName;
                menu.MenuOrder = functionMenu.MenuOrder;
                menu.RootID = functionMenu.RootID;
                this.SubmitChanges();
                return "";
            }
            catch(Exception e)
            {
                return "更新失败。";
            }
        }
    }
}
