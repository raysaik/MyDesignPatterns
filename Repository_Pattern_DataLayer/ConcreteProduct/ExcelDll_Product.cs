using Repository_Pattern_DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel;

namespace Repository_Pattern_DataLayer.ConcreteProduct
{
    public class ExcelDll_Product : IExcelProduct
    {
        public List<BillDALClass> billList
        {
            get;
            set;
        }
        public ExcelDll_Product()
        {
            billList = new List<BillDALClass>();
        }
    }
}
