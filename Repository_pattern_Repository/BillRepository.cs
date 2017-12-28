using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL = Repository_Pattern_DataLayer;
using Model = Repository_pattern_Models;
using DALInterfaces = Repository_Pattern_DataLayer.Interfaces;

namespace Repository_pattern_Repository
{
    public class BillRepository
    {
        
        private DAL.SqlDALUtilities su;
        private DAL.ExcelUtilities eu;
        public BillRepository()
        {
            eu = new DAL.ExcelUtilities();
            su = new DAL.SqlDALUtilities();
        }



        public List<Model.UserBillSummaryModel> GetAllEmployeeBillDetails()
        {
            List<Model.UserBillSummaryModel> userBillModels = new List<Model.UserBillSummaryModel>();
            var employeesByGivenDesignation = su.GetAllEmployeeDetails();
            IList<Model.BillModel> billModelList = GetRawBill(eu.GetExcelData());
            GenerateBillModel(billModelList, employeesByGivenDesignation, userBillModels);
            return userBillModels;
        }

        public List<Model.UserBillSummaryModel> GetEmployeeBillDetailsByDesignation(string Designation)
        {

            List<Model.UserBillSummaryModel> userBillModels = new List<Model.UserBillSummaryModel>();
            var employeesByGivenDesignation = su.GetEmployeeDetailsByDesignation(Designation);
            IList<Model.BillModel> billModelList = GetRawBill(eu.GetExcelData());
            GenerateBillModel(billModelList, employeesByGivenDesignation, userBillModels);
            return userBillModels;
        }

        #region PRIVATE METHODS    
    
        private void GenerateBillModel(IList<Model.BillModel> billModelFromExcel, List<DAL.tbl_Employee> empListFromDB, List<Model.UserBillSummaryModel> userBillModels)
        {
            foreach (var employee in empListFromDB)
            {
                double totalBill = 0;
                var billData = billModelFromExcel.Where(bill => bill.BillFor.Equals(employee.EmpName)).ToList();
                foreach (var bill in billData)
                {
                    totalBill += bill.Amount;
                }
                userBillModels.Add(new Model.UserBillSummaryModel() { EmpName = employee.EmpName, BillAmount = totalBill });
            }
        }

        private IList<Model.BillModel> GetRawBill(DALInterfaces.IExcelProduct excelOutput)
        {
            IList<Model.BillModel> billList = new List<Model.BillModel>();
            Model.BillModel billModel = null;
            foreach (var item in excelOutput.billList)
            {
                billModel = new Model.BillModel()
                {
                    BillID = item.BillID,
                    BillFor = item.BillFor,
                    Amount = item.Amount,
                    PaidBy = item.PaidBy
                };
                billList.Add(billModel);
            }
           
            return billList;
        }
        #endregion
    }
}
