using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using NUnit.Framework;
using Repository_Pattern_UI.Controllers;

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

            //Act
            var result = controller.Index() as ViewResult;

            //Assert
            Assert.AreEqual("TestAR", result.ViewName);
        }
    }
}
