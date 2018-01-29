using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Pattern_DataLayer.Interfaces
{
    public interface ISqlDALUtilities
    {
        List<tbl_Employee> GetAllEmployeeDetails();
        List<tbl_Employee> GetEmployeeDetailsByDesignation(string Designation);
        List<string> GetAllEmployeeDesignationsFromDB();
    }
}
