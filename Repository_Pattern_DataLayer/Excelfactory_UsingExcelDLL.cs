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
        //This factory has a limitation that it cannot pick a sheet from a spreadsheet using a sheet name
       // public IExcelProduct ConcreteEzxcelWorkbook
        public IExcelProduct GetExcelData<T>(string filepath)
        {
            var worksheet = Workbook.Worksheets(filepath).FirstOrDefault();

            //foreach (var worksheet in Workbook.Worksheets(@"C:\Saikat\RepositoryPattern\MyDesignPatterns\Data Source\Bill_data_summary.xlsx"))
            //{
            //    foreach (var row in worksheet.Rows){
            //           foreach (var cell in row.Cells){

            //            }
            //    }
            //}
            //Excel
            return worksheet;
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
