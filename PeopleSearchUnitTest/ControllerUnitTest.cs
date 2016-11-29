using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using MyPeopleSearchApplication;
using MyPeopleSearchApplication.Controllers;

namespace PeopleSearchUnitTest
{
    [TestClass]
    public class ControllerUnitTest
    {
        [TestMethod]
        public void Index()
        {
            //Arrange
            HomeController controller = new HomeController();
            //Act
            ViewResult result = controller.Index() as ViewResult;
            //Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void Contact()
        {
            //Arrange
            HomeController controller = new HomeController();
            //Act
            ViewResult result = controller.Contact() as ViewResult;
            //Assert
            Assert.AreEqual("Your contact page.",result.ViewBag.Message);
        }
        [TestMethod]
        public void Create()
        {
            //Arrange
            SearchPeoplesController controller = new SearchPeoplesController();
            //Act
            ViewResult result = controller.Create() as ViewResult;
            //Assert
            Assert.AreEqual("searchPeople",result.ViewName);
        }
    }
}
