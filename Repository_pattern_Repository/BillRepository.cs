using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL = Repository_Pattern_DataLayer;
using Model = Repository_pattern_Models;
using Excel = Microsoft.Office.Interop.Excel;

namespace Repository_pattern_Repository
{
    public class BillRepository
    {
        private DAL.RepositoryPattern_DBEntities db;
        private DAL.ExcelUtilities eu;
        public BillRepository()
        {
            db = new DAL.RepositoryPattern_DBEntities();
            eu = new DAL.ExcelUtilities();
        }


        
        public List<Model.UserBillSummaryModel> GetEmployeeBillDetailsByDesignation(string Designation)
        {

            List<Model.UserBillSummaryModel> userBillModels = new List<Model.UserBillSummaryModel>();
            var employeesByGivenDesignation = db.tbl_Employee.Where(emp => emp.EmdDesignation.Equals(Designation)).ToList();
            IList<Model.BillModel> billModelList = GetAllBills(eu.GetExcelData());
            foreach(var employee in employeesByGivenDesignation)
            {
                double totalBill = 0;
                var billData = billModelList.Where(bill=>bill.BillFor.Equals(employee.EmpName)).ToList();
                foreach (var bill in billData)
                {
                    totalBill += bill.Amount;
                }
                userBillModels.Add(new Model.UserBillSummaryModel() { EmpName = employee.EmpName,BillAmount = totalBill });
            }


            return userBillModels;
        }

        private IList<Model.BillModel> GetAllBills(Excel.Range range)
        {
            IList<Model.BillModel> billList = new List<Model.BillModel>();
            Model.BillModel myBillSummary;
            int rows = range.Rows.Count;
            int columns = range.Columns.Count;
            for (int rCnt = 1; rCnt <= rows; rCnt++)
            {
                myBillSummary = new Model.BillModel()
                {
                    BillID = (string)(range.Cells[rCnt, 0] as Excel.Range).Value,
                    BillFor = (string)(range.Cells[rCnt, 1] as Excel.Range).Value,
                    Amount = (double)(range.Cells[rCnt, 1] as Excel.Range).Value,
                    PaidBy = (string)(range.Cells[rCnt, 3] as Excel.Range).Value
                };
                billList.Add(myBillSummary);
            }
            return billList;
        }
    }
}
