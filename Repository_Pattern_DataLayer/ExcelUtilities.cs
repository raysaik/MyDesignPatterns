using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelInterop = Microsoft.Office.Interop.Excel; 

namespace Repository_Pattern_DataLayer
{
    public class ExcelUtilities
    {
        ExcelInterop.Application xlApp;
        ExcelInterop.Workbook xlWorkBook;
        ExcelInterop.Worksheet xlWorkSheet;
        ExcelInterop.Range range;
        public ExcelUtilities ()
	    {
            xlApp = new ExcelInterop.Application();
            xlWorkBook = xlApp.Workbooks.Open(@"C:\Users\saika\OneDrive\My Study\Design Patterns\Repository\Data Source\Bill_data_summary.xlsx", 0, true, 5, "", "", true, ExcelInterop.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = (ExcelInterop.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            range = xlWorkSheet.UsedRange;
	    }

        public ExcelInterop.Range GetExcelData()
        {
            return range;
        }


    }
}
