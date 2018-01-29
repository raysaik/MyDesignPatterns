using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rhino.Mocks;
using NUnit.Framework;
using Interfaces = Repository_Pattern_Model_Abstract;
using Repository_Pattern_DataLayer.Interfaces;
using Repository_Pattern_DataLayer;

namespace Repository_pattern_Repository.Tests
{
    [TestFixture]
    public class BillRepositoryTest
    {
        public void GetAllEmployeeBillDetailsTest()
        {
            var _sqlUtilityMock = MockRepository.GenerateMock<ISqlDALUtilities>();
            var _empByDesignation = _sqlUtilityMock.Stub(m => m.GetAllEmployeeDetails()).Return(new List<tbl_Employee>());
            var mockBillModel = MockRepository.GenerateMock<IBillRepository>();
        }
    }
}
