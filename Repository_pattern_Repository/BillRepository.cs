using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL = Repository_Pattern_DataLayer;
using Model = Repository_pattern_Models;
using DALInterfaces = Repository_Pattern_DataLayer.Interfaces;
using BAL = Repository_Pattern_BusinessLayer;

namespace Repository_pattern_Repository
{
    public class BillRepository : IBillRepository
    {
        
        private DAL.SqlDALUtilities su;
        private DAL.ExcelUtilities eu;
        private IList<BAL.IRule> allRules;
        public BillRepository()
        {
            eu = new DAL.ExcelUtilities();
            su = new DAL.SqlDALUtilities();
            allRules = BAL.RuleHelpers.InitializeRuleEngine();
        }

        public List<Model.UserBillSummaryModel> GetAllEmployeeBillDetails()
        {
            List<Model.UserBillSummaryModel> userBillModels = new List<Model.UserBillSummaryModel>();
            var employeesByGivenDesignation = su.GetAllEmployeeDetails();
            IList<Model.BillModel> billModelList = GetRawBill(eu.GetExcelData());
            GenerateBillModel(billModelList, employeesByGivenDesignation, userBillModels,allRules);

            return userBillModels;
        }

        public List<Model.UserBillSummaryModel> GetEmployeeBillDetailsByDesignation(string Designation)
        {

            List<Model.UserBillSummaryModel> userBillModels = new List<Model.UserBillSummaryModel>();
            var employeesByGivenDesignation = su.GetEmployeeDetailsByDesignation(Designation);
            IList<Model.BillModel> billModelList = GetRawBill(eu.GetExcelData());
            GenerateBillModel(billModelList, employeesByGivenDesignation, userBillModels, allRules);
            return userBillModels;
        }

        public List<string> GetAllEmployeeDesignations()
        {
            return su.GetAllEmployeeDesignationsFromDB();
        }

        #region PRIVATE METHODS    

        private void GenerateBillModel(IList<Model.BillModel> billModelFromExcel, List<DAL.tbl_Employee> empListFromDB,
            List<Model.UserBillSummaryModel> userBillModels, IList<BAL.IRule> AllRules)
        {
            foreach (var employee in empListFromDB)
            {
                double totalBill = 0; double amountTobePaid = 0; double _amountPaidInCash = 0;
                var billData = billModelFromExcel.Where(bill => bill.BillFor.Equals(employee.EmpName)).ToList();
                foreach (var bill in billData)
                {
                    if (bill.PaidBy.Equals("Cash"))
                        _amountPaidInCash += bill.Amount;
                    totalBill += bill.Amount;
                }
                amountTobePaid = totalBill;
                ExecuteBusinessRules(AllRules,employee.EmpGrade,employee.EmdDesignation,_amountPaidInCash, ref amountTobePaid);
                userBillModels.Add(new Model.UserBillSummaryModel() { EmpName = employee.EmpName, BillAmount = totalBill , 
                    BillToBePaidByEmployee = amountTobePaid, EmpDesignation = employee.EmdDesignation });
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

        private void ExecuteBusinessRules(IList<BAL.IRule> AllRules,string Grade, string Designation, double AmountPaidInCash, ref double Amount)
        {
            foreach (var rule in AllRules)
            {
                Amount = rule.RuleImplementation(Grade, Amount, Designation, AmountPaidInCash);
            }
        }       
        #endregion
    }
}
