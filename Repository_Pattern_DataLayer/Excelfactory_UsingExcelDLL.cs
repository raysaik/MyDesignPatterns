using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository_Pattern_DataLayer.Interfaces;

namespace Repository_Pattern_DataLayer
{
    using Excel;

    public class Excelfactory_UsingExcelDLL : IExcelFactory
    {

        public T GetExcelData<T>(string filepath)
        {
            foreach (var worksheet in Workbook.Worksheets(@"C:\Users\saika\Documents\Visual Studio 2012\Projects\Repository_Pattern\Data Source\Bill_data_summary.xlsx"))
            {
                foreach (var row in worksheet.Rows){
                       foreach (var cell in row.Cells){
                        }
                }
            }
            return (T)(new object());
        }

        public bool AddExcelData()
        {
            throw new NotImplementedException();
        }

        public bool RemoveExcelData()
        {
            throw new NotImplementedException();
        }
    }
}
