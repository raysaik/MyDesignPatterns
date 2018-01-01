using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_pattern_Repository
{
    public interface IBillRepository
    {
        List<string> GetAllEmployeeDesignations();
    }
}
