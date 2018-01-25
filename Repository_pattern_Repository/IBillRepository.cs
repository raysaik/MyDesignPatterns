using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository_Pattern_Model_Abstract;

namespace Repository_pattern_Repository
{
    public interface IBillRepository
    {
        List<string> GetAllEmployeeDesignations();
        IList<IUserBillSummaryModel> GetAllEmployeeBillDetails();
        List<IUserBillSummaryModel> GetEmployeeBillDetailsByDesignation(string Designation);
    }
}
