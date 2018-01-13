using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CY.Iot.InterfacePlus.pay
{
    public class User
    {
        private string _CompanyID;

        private string _UserID;

        private string _UserName;

        private System.Nullable<char> _State;

        private string _Address;

        private string _Street;

        private string _Community;

        private string _Door;

        private string _MeterNo;

        private string _MeterType;

        private System.Nullable<char> _ValveState;

        private System.Nullable<decimal> _LastTotal;

        private System.Nullable<decimal> _TotalTopUp;

        private System.Nullable<decimal> _TotalAmount;

        private System.Nullable<decimal> _RemainingAmount;

        private System.Nullable<System.DateTime> _ReadDate;

        private System.Nullable<System.DateTime> _InstallDate;

        private long _MeterID;

        private System.Nullable<decimal> _Gas1;

        private System.Nullable<decimal> _Gas2;

        private System.Nullable<decimal> _Gas3;

        private System.Nullable<decimal> _Gas4;

        private System.Nullable<decimal> _Price1;

        private System.Nullable<decimal> _Price2;

        private System.Nullable<decimal> _Price3;

        private System.Nullable<decimal> _Price4;

        private System.Nullable<decimal> _Price5;

        private System.Nullable<int> _SettlementDay;

        private string _SettlementType;

        private System.Nullable<int> _Ladder;

        private System.Nullable<bool> _IsUsed;

        private string _UploadCycle;

        private string _EnableMeterOper;

        private string _Direction;

        public User()
        {
        }

        public string CompanyID
        {
            get
            {
                return this._CompanyID;
            }
            set
            {
                if ((this._CompanyID != value))
                {
                    this._CompanyID = value;
                }
            }
        }

        public string UserID
        {
            get
            {
                return this._UserID;
            }
            set
            {
                if ((this._UserID != value))
                {
                    this._UserID = value;
                }
            }
        }

        public string UserName
        {
            get
            {
                return this._UserName;
            }
            set
            {
                if ((this._UserName != value))
                {
                    this._UserName = value;
                }
            }
        }

        public System.Nullable<char> State
        {
            get
            {
                return this._State;
            }
            set
            {
                if ((this._State != value))
                {
                    this._State = value;
                }
            }
        }

        public string Address
        {
            get
            {
                return this._Address;
            }
            set
            {
                if ((this._Address != value))
                {
                    this._Address = value;
                }
            }
        }

        public string Street
        {
            get
            {
                return this._Street;
            }
            set
            {
                if ((this._Street != value))
                {
                    this._Street = value;
                }
            }
        }

        public string Community
        {
            get
            {
                return this._Community;
            }
            set
            {
                if ((this._Community != value))
                {
                    this._Community = value;
                }
            }
        }

        public string Door
        {
            get
            {
                return this._Door;
            }
            set
            {
                if ((this._Door != value))
                {
                    this._Door = value;
                }
            }
        }

        public string MeterNo
        {
            get
            {
                return this._MeterNo;
            }
            set
            {
                if ((this._MeterNo != value))
                {
                    this._MeterNo = value;
                }
            }
        }

        public string MeterType
        {
            get
            {
                return this._MeterType;
            }
            set
            {
                if ((this._MeterType != value))
                {
                    this._MeterType = value;
                }
            }
        }

        public string PayTitle { get { return "充值"; } }
        public string PrintTitle { get { return "补打票据"; } }

        public System.Nullable<char> ValveState
        {
            get
            {
                return this._ValveState;
            }
            set
            {
                if ((this._ValveState != value))
                {
                    this._ValveState = value;
                }
            }
        }

        public System.Nullable<decimal> LastTotal
        {
            get
            {
                return this._LastTotal;
            }
            set
            {
                if ((this._LastTotal != value))
                {
                    this._LastTotal = value;
                }
            }
        }

        public System.Nullable<decimal> TotalTopUp
        {
            get
            {
                return this._TotalTopUp;
            }
            set
            {
                if ((this._TotalTopUp != value))
                {
                    this._TotalTopUp = value;
                }
            }
        }

        public System.Nullable<decimal> TotalAmount
        {
            get
            {
                return this._TotalAmount;
            }
            set
            {
                if ((this._TotalAmount != value))
                {
                    this._TotalAmount = value;
                }
            }
        }

        public System.Nullable<decimal> RemainingAmount
        {
            get
            {
                return this._RemainingAmount;
            }
            set
            {
                if ((this._RemainingAmount != value))
                {
                    this._RemainingAmount = value;
                }
            }
        }

        public System.Nullable<System.DateTime> ReadDate
        {
            get
            {
                return this._ReadDate;
            }
            set
            {
                if ((this._ReadDate != value))
                {
                    this._ReadDate = value;
                }
            }
        }

        public System.Nullable<System.DateTime> InstallDate
        {
            get
            {
                return this._InstallDate;
            }
            set
            {
                if ((this._InstallDate != value))
                {
                    this._InstallDate = value;
                }
            }
        }

        public long MeterID
        {
            get
            {
                return this._MeterID;
            }
            set
            {
                if ((this._MeterID != value))
                {
                    this._MeterID = value;
                }
            }
        }

        public System.Nullable<decimal> Gas1
        {
            get
            {
                return this._Gas1;
            }
            set
            {
                if ((this._Gas1 != value))
                {
                    this._Gas1 = value;
                }
            }
        }

        public System.Nullable<decimal> Gas2
        {
            get
            {
                return this._Gas2;
            }
            set
            {
                if ((this._Gas2 != value))
                {
                    this._Gas2 = value;
                }
            }
        }

        public System.Nullable<decimal> Gas3
        {
            get
            {
                return this._Gas3;
            }
            set
            {
                if ((this._Gas3 != value))
                {
                    this._Gas3 = value;
                }
            }
        }

        public System.Nullable<decimal> Gas4
        {
            get
            {
                return this._Gas4;
            }
            set
            {
                if ((this._Gas4 != value))
                {
                    this._Gas4 = value;
                }
            }
        }

        public System.Nullable<decimal> Price1
        {
            get
            {
                return this._Price1;
            }
            set
            {
                if ((this._Price1 != value))
                {
                    this._Price1 = value;
                }
            }
        }

        public System.Nullable<decimal> Price2
        {
            get
            {
                return this._Price2;
            }
            set
            {
                if ((this._Price2 != value))
                {
                    this._Price2 = value;
                }
            }
        }

        public System.Nullable<decimal> Price3
        {
            get
            {
                return this._Price3;
            }
            set
            {
                if ((this._Price3 != value))
                {
                    this._Price3 = value;
                }
            }
        }

        public System.Nullable<decimal> Price4
        {
            get
            {
                return this._Price4;
            }
            set
            {
                if ((this._Price4 != value))
                {
                    this._Price4 = value;
                }
            }
        }

        public System.Nullable<decimal> Price5
        {
            get
            {
                return this._Price5;
            }
            set
            {
                if ((this._Price5 != value))
                {
                    this._Price5 = value;
                }
            }
        }

        public System.Nullable<int> SettlementDay
        {
            get
            {
                return this._SettlementDay;
            }
            set
            {
                if ((this._SettlementDay != value))
                {
                    this._SettlementDay = value;
                }
            }
        }

        public string SettlementType
        {
            get
            {
                return this._SettlementType;
            }
            set
            {
                if ((this._SettlementType != value))
                {
                    this._SettlementType = value;
                }
            }
        }

        public System.Nullable<int> Ladder
        {
            get
            {
                return this._Ladder;
            }
            set
            {
                if ((this._Ladder != value))
                {
                    this._Ladder = value;
                }
            }
        }

        public System.Nullable<bool> IsUsed
        {
            get
            {
                return this._IsUsed;
            }
            set
            {
                if ((this._IsUsed != value))
                {
                    this._IsUsed = value;
                }
            }
        }

        public string UploadCycle
        {
            get
            {
                return this._UploadCycle;
            }
            set
            {
                if ((this._UploadCycle != value))
                {
                    this._UploadCycle = value;
                }
            }
        }

        public string EnableMeterOper
        {
            get
            {
                return this._EnableMeterOper;
            }
            set
            {
                if ((this._EnableMeterOper != value))
                {
                    this._EnableMeterOper = value;
                }
            }
        }

        public string Direction
        {
            get
            {
                return this._Direction;
            }
            set
            {
                if ((this._Direction != value))
                {
                    this._Direction = value;
                }
            }
        }

    }
}
