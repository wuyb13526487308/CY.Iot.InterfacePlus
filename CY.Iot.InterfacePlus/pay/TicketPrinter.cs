using RX.Gas.ReportLib;
using RX.GasApp.CommonLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CY.Iot.InterfacePlus.pay
{
    public class TicketPrinter : BasePrinter
    {
        public TicketPrinter(int templateID) : base(templateID)
        {
        }

        public void Print(List<DefineSqlParameter> param,bool isPreview)
        {
            SetParamToTemplate(param);
            this.xtraReport.CreateDocument();
            if (isPreview)
            {
                this.xtraReport.ShowPreviewDialog();
            }
            else
            {
                this.xtraReport.Print();
            }
        }


        private void SetParamToTemplate(List<DefineSqlParameter> param)
        {
            ReportDataAdaptor rda = this.report.DataSource;
            foreach (DefineSqlParameter par in param)
            {
                foreach (DefineSqlParameter objPar in rda.DbParameterCollection)
                {
                    if (par.ParameterName.ToUpper() == objPar.ParameterName.ToUpper())
                    {
                        objPar.Value = par.Value;
                        break;
                    }
                }
            }
        }
    }
}
