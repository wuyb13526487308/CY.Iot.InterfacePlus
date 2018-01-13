using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CY.Iot.InterfacePlus.pay
{
    class DGSource
    {
        public int total { get; set; }
        public List<User> rows { get; set; }
    }

    class CZSource
    {
        public int total { get; set; }
        public List<ChongZhiData> rows { get; set; }
    }
}
