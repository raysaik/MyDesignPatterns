using Repository_Pattern_DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Pattern_DataLayer
{
    public class SqlDALUtilities : ISqlDALUtilities
    {
        private RepositoryPattern_DBEntities db;
        public SqlDALUtilities()
        {
            db = new RepositoryPattern_DBEntities();
        }

        public List<tbl_Employee> GetAllEmployeeDetails()
        {
            return db.tbl_Employee.ToList();
        }

        public List<tbl_Employee> GetEmployeeDetailsByDesignation(string Designation)
        {
            return db.tbl_Employee.Where(emp => emp.EmdDesignation.Equals(Designation)).ToList();
        }

        public List<string> GetAllEmployeeDesignationsFromDB()
        {
            var empDesgs = (from desg in db.tbl_Designations
                        select desg.EmployeeDesignation).Distinct().ToList();
            return empDesgs;
        }
    }
}
