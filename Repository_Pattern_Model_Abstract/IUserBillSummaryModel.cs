using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Pattern_Model_Abstract
{
    public interface IUserBillSummaryModel
    {
        double BillAmount { get; set; }
        string EmpName { get; set; }
        double BillToBePaidByEmployee { get; set; }
        string EmpDesignation { get; set; }
    }
}
