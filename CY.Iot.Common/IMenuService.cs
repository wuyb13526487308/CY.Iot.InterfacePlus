using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace CY.Iot.Common
{
    [ServiceContract]
    public interface IMenuService
    {
        /// <summary>
        /// 读取所有菜单配置
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<Iot_FunctionMenu> ReadFunctionMenu();
        /// <summary>
        /// 读取所有物联网功能定义
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<Iot_FunctionDefine> ReadFunctionDefine();
        /// <summary>
        /// 读取物联网功能对应子功能定义
        /// </summary>
        /// <param name="rootId">主功能ID</param>
        /// <returns></returns>
        [OperationContract]
        List<Iot_ChildFunctionBar> ReadChildFunctionBar(int rootId);

        [OperationContract]
        string InsertFunctionMenu(Iot_FunctionMenu functionMenu);
        [OperationContract]
        string UpdateFunctionMenu(Iot_FunctionMenu functionMenu);
        [OperationContract]
        string DeleteFunctionMenu(Iot_FunctionMenu functionMenu);
        [OperationContract]
        List<Frame_MainMenu> ReadMainMenus();
        [OperationContract]
        void Test();

    }
}
