﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FPSample;
using FPSample.Controllers;

namespace FPSample.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {

        HomeController controller = new HomeController();

        [TestMethod]
        public void Index()
        {
            // Arrange
           

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void AddTest()
        {
            int result = controller.Add(20, 10);
            Assert.AreEqual(30, result);
        }
        [TestMethod]
        public void SubtractTest()
        {
            int result = controller.Subtract(20, 10);
            Assert.AreEqual(10, result);
        }

    }
}
