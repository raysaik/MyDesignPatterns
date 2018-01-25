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

        [Test]
        public void Index_PageTitle_Test()
        {
            //Arrange
            var billRepoForMock = MockRepository.GenerateStub<Repository.IBillRepository>();
            billRepoForMock.Stub(m => m.GetAllEmployeeDesignations()).Return(new List<string>());
            billRepoForMock.Stub(m => m.GetAllEmployeeBillDetails()).Return(new List<IUserBillSummaryModel>());
            var controller = new EmployeeController(billRepoForMock);

            ////Act
            var result = controller.Index() as ViewResult;

            ////Assert
            Assert.AreEqual("GetAllEmployeeBillDetails", result.ViewBag.Title);
        }

        [Test]
        public void Index_ViewReturn_Test()
        {

        }
    }
}
