using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository_Pattern_DataLayer.Interfaces;

namespace Repository_Pattern_DataLayer
{
    using Excel;
    using Repository_Pattern_DataLayer.ConcreteProduct;

    public class Excelfactory_UsingExcelDLL : IExcelFactory
    {
        //This factory has a limitation that it cannot pick a sheet from a spreadsheet using a sheet name
       // public IExcelProduct ConcreteEzxcelWorkbook
        public IExcelProduct GetExcelData(string filepath)
        {
            var worksheet = Workbook.Worksheets(filepath).FirstOrDefault();
            IExcelProduct excelProductFromDLLFactory = new ExcelDll_Product();

            BillDALClass bill = null; double _amount;           

            foreach (var row in worksheet.Rows)
            {
                if(double.TryParse(row.Cells[2].Text,out _amount))
                {
                    bill = new BillDALClass()
                    {
                        BillID = row.Cells[0].Text,
                        BillFor = row.Cells[1].Text,
                        Amount = _amount,
                        PaidBy = row.Cells[3].Text
                    };
                    excelProductFromDLLFactory.billList.Add(bill);
                }
                
            }

            return excelProductFromDLLFactory;
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
