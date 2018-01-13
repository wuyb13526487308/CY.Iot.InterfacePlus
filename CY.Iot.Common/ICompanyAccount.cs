using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CY.Iot.Common
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IService1”。
    [ServiceContract]
    public interface ICompanyAccount
    {
        /// <summary>
        /// 读取当前
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        CompanyAccount ReadComapnyAccount();

        [OperationContract]
        string BindCompanyAccount(CompanyAccount company);

        [OperationContract]
        string QueryCompanyName(string companyId);
        [OperationContract]
        List<Iot_OperatorMaping> QueryIotOperator(string localOperatorId);

        //
        [OperationContract]
        int GetIotPayTicketTemplate();
        [OperationContract]
        string SetIotPayTicketTemplate(int id);
        [OperationContract]
        List<ReportTemplate> getInvoiceTemplate();
        //
        [OperationContract]
        string AddTopUpRecord(Iot_TopUpRecord record);
    }
}
