using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel; 

namespace Repository_Pattern_DataLayer
{
    public class ExcelUtilities
    {
        Excel.Application xlApp;
        Excel.Workbook xlWorkBook;
        Excel.Worksheet xlWorkSheet;
        Excel.Range range;
        public ExcelUtilities ()
	    {
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(@"C:\Users\saika\OneDrive\My Study\Design Patterns\Repository\Data Source\Bill_data_summary.xlsx",0,true,5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            range = xlWorkSheet.UsedRange;
	    }

        public Excel.Range GetExcelData()
        {
            return range;
            //IList<BillSummary> billList = new List<BillSummary>();
            //BillSummary myBillSummary;
            //int rows = range.Rows.Count;
            //int columns = range.Columns.Count;  
            //for (int rCnt = 1; rCnt <= rows; rCnt++)
            //{
            //    myBillSummary = new BillSummary()
            //    {
            //        BillId = (string)(range.Cells[rCnt, 0] as Excel.Range).Value,
            //        BillFor = (string)(range.Cells[rCnt, 1] as Excel.Range).Value,
            //        Amount = (double)(range.Cells[rCnt, 1] as Excel.Range).Value,
            //        PaidBy = (string)(range.Cells[rCnt, 3] as Excel.Range).Value
            //    };
            //    billList.Add(myBillSummary);
            //}
            //return billList;
        }


    }
}
