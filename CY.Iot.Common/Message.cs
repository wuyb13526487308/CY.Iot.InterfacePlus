using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CY.Iot.Common
{
    [DataContract]
    public class Message
    {
        [DataMember]
        public bool Result
        {
            get;
            set;
        } = false;
        [DataMember]
        public object Data
        {
            get;
            set;
        }
    }
}
