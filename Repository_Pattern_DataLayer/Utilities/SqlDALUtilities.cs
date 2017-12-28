using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Pattern_DataLayer
{
    public class SqlDALUtilities
    {
        private RepositoryPattern_DBEntities db;
        public SqlDALUtilities()
        {
            db = new RepositoryPattern_DBEntities();
        }

        public List<tbl_Employee> GetEmployeeDetailsByDesignation(string Designation)
        {
            return db.tbl_Employee.Where(emp => emp.EmdDesignation.Equals(Designation)).ToList();
        }
    }
}
