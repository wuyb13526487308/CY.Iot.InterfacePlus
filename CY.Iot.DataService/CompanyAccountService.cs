using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using CY.Iot.Common;

namespace CY.Iot.DataService
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“Service1”。
    public class CompanyAccountService : BaseDataContext, ICompanyAccount
    {
        /// <summary>
        /// 绑定账号
        /// </summary>
        /// <param name="company"></param>
        /// <returns></returns>
        public string BindCompanyAccount(CompanyAccount company)
        {
            try
            {
                CompanyAccount _company = this.GetTable<CompanyAccount>().SingleOrDefault();
                if (_company != null)
                {
                    this.GetTable<CompanyAccount>().DeleteOnSubmit(_company);
                    this.SubmitChanges();
                }

                this.GetTable<CompanyAccount>().InsertOnSubmit(company);
                this.SubmitChanges();
                return "";
            }
            catch
            {
                return "绑定失败。";
            }
        }



        /// <summary>
        /// 从物联网系统读取企业名称
        /// </summary>
        /// <param name="companyId"></param>
        /// <returns></returns>
        public string QueryCompanyName(string companyId)
        {
            throw new NotImplementedException();
        }

        public List<Iot_OperatorMaping> QueryIotOperator(string localOperatorId)
        {
            throw new NotImplementedException();
        }

        public CompanyAccount ReadComapnyAccount()
        {
            CompanyAccount company = this.GetTable<CompanyAccount>().SingleOrDefault();
            return company;
        }

        public string SetIotPayTicketTemplate(int id)
        {
            string sql = string.Format(@"UPDATE  Dictionary SET PValue1 = '{0}' WHERE  PType ='{1}'", id, "IotPayTicketTemplate");

            try
            {
                object[] par = new object[0];
                var query = this.ExecuteQuery<string>(sql, par).ToString();
                return "";
            }
            catch
            {
                return "失败";
            }
        }

        public int GetIotPayTicketTemplate()
        {
            Dictionary dic = this.GetTable<Dictionary>().Where(p => p.PType == "IotPayTicketTemplate").SingleOrDefault();
            if (dic == null)
                return -1;
            else
                return Convert.ToInt32(dic.PValue1);
        }

        public List<ReportTemplate> getInvoiceTemplate()
        {
            string sql = "SELECT RID, ReportName FROM ReportTemplate where ReportType =1";
            object[] par = new object[0];
            var query = this.ExecuteQuery<ReportTemplate>(sql, par);

            return query.ToList();
        }

        public string AddTopUpRecord(Iot_TopUpRecord record)
        {
            this.GetTable<Iot_TopUpRecord>().InsertOnSubmit(record);
            try
            {
                this.SubmitChanges();
                return "";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
