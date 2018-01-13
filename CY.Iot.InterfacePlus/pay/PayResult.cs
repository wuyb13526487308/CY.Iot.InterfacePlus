using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CY.Iot.InterfacePlus.pay
{
    public class PayResult
    {
        private long _ID;

        private System.Nullable<int> _Ser;

        private string _UserID;

        private System.Nullable<long> _MeterID;

        private string _MeterNo;

        private System.Nullable<decimal> _Amount;

        private System.Nullable<System.DateTime> _TopUpDate;

        private System.Nullable<char> _TopUpType;

        private string _Oper;

        private string _OrgCode;

        private System.Nullable<char> _State;

        private string _CompanyID;

        private string _TaskID;

        private string _Context;

        private System.Nullable<bool> _IsPrint;

        private System.Nullable<char> _PayType;

        private string _SFOperID;

        private string _SFOperName;

        public long ID { get => _ID; set => _ID = value; }
        public int? Ser { get => _Ser; set => _Ser = value; }
        public string UserID { get => _UserID; set => _UserID = value; }
        public long? MeterID { get => _MeterID; set => _MeterID = value; }
        public string MeterNo { get => _MeterNo; set => _MeterNo = value; }
        public decimal? Amount { get => _Amount; set => _Amount = value; }
        public DateTime? TopUpDate { get => _TopUpDate; set => _TopUpDate = value; }
        public char? TopUpType { get => _TopUpType; set => _TopUpType = value; }
        public string Oper { get => _Oper; set => _Oper = value; }
        public string OrgCode { get => _OrgCode; set => _OrgCode = value; }
        public char? State { get => _State; set => _State = value; }
        public string CompanyID { get => _CompanyID; set => _CompanyID = value; }
        public string TaskID { get => _TaskID; set => _TaskID = value; }
        public string Context { get => _Context; set => _Context = value; }
        public bool? IsPrint { get => _IsPrint; set => _IsPrint = value; }
        public char? PayType { get => _PayType; set => _PayType = value; }
        public string SFOperID { get => _SFOperID; set => _SFOperID = value; }
        public string SFOperName { get => _SFOperName; set => _SFOperName = value; }
    }
}
