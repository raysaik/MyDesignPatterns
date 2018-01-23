using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using NUnit.Framework;
using Repository_Pattern_UI.Controllers;
using Repository = Repository_pattern_Repository;
using Rhino.Mocks;
using Repository_Pattern_Model_Abstract;

namespace Repository_Pattern_UI.Tests
{
    //TestFixtureAttribute is used to mark a class that represents a TestFixture.
    [TestFixture]
    public class EmployeeControllerTest
    {
       //Adding this attribute to a method within a NUnit.Framework.TestFixtureAttribute
       //class makes the method callable from the NUnit test runner.
       //[Test]
        [Test]
        public void TestAR_Test()
        {
            //Arrange
            var controller = new EmployeeController();            
            //Act
            var result = controller.TestAR() as ViewResult;

            //Assert
            Assert.AreEqual("TestAR", result.ViewName);
        }

        public void IndexViewName_Test()
        {
            //Arrange
            var controller = new EmployeeController();
            //Repository.BillRepository billRepository = new Repository_pattern_Repository.BillRepository();
            var testViewModel = MockRepository.GenerateStub<Abstract_ViewModel>();
            testViewModel.ubsModels = MockRepository.GenerateStub<IEnumerable<IUserBillSummaryModel>>();
            var billRepoForMock = MockRepository.GenerateStub<Repository.IBillRepository>();
            billRepoForMock.Stub(m => m.GetAllEmployeeDesignations()).Return(new List<string>());
            ////Act
            //var result = controller.Index() as ViewResult;

            ////Assert
            //Assert.AreEqual("TestAR", result.ViewName);
        }
    }
}
