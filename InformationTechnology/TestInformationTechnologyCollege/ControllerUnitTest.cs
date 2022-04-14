using InformationTechnology.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Web.Mvc;

namespace TestInformationTechnologyCollege
{
    [TestClass]
    public class ControllerUnitTest
    {
        [TestMethod]
        public void About()
        {
            /*
            HomeController controller = new HomeController();
            ViewResult result = controller.About() as ViewResult;

            Assert.AreEqual("Your Application description page.", //Message);
            */
        }



        [TestMethod]
        public void IndexWelcomeMessage()
        {
            /*
            HomeController controller = new HomeController();

            HomeController controller1 = controller;
            ViewResult result = controller1.Index();

            Assert.AreEqual("Welcome to the shop. Kindly spend all your money with us!", controller.ViewBag.WelcomeMessage);
            */
        }

    }
}
