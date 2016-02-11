using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckoutKata.Controllers;
using System.Web.Mvc;

namespace CheckoutKata.Tests.Controllers
{
    [TestClass]
    public class StoreControllerTest
    {
        [TestMethod]
        public void AAAEquals130()
        {
            // Arrange
            StoreController controller = new StoreController();

            // Act
            ViewResult result = controller.Index(new ViewModels.ProductViewModel() { Item = "aaa" }) as ViewResult;
            
            // Assert
            Assert.AreEqual(130, result.ViewBag.Total);
        }
        [TestMethod]
        public void AEquals50()
        {
            // Arrange
            StoreController controller = new StoreController();

            // Act
            ViewResult result = controller.Index(new ViewModels.ProductViewModel() { Item = "a" }) as ViewResult;

            // Assert
            Assert.AreEqual(50, result.ViewBag.Total);
        }

        [TestMethod]
        public void AAEquals100()
        {
            // Arrange
            StoreController controller = new StoreController();

            // Act
            ViewResult result = controller.Index(new ViewModels.ProductViewModel() { Item = "aa" }) as ViewResult;

            // Assert
            Assert.AreEqual(100, result.ViewBag.Total);
        }
        [TestMethod]
        public void ABEquals80()
        {
            // Arrange
            StoreController controller = new StoreController();

            // Act
            ViewResult result = controller.Index(new ViewModels.ProductViewModel() { Item = "ab" }) as ViewResult;

            // Assert
            Assert.AreEqual(80, result.ViewBag.Total);
        }
        [TestMethod]
        public void CDBAEquals115()
        {
            // Arrange
            StoreController controller = new StoreController();

            // Act
            ViewResult result = controller.Index(new ViewModels.ProductViewModel() { Item = "CDBA" }) as ViewResult;

            // Assert
            Assert.AreEqual(115, result.ViewBag.Total);
        }
        [TestMethod]
        public void AAABBEquals175()
        {
            // Arrange
            StoreController controller = new StoreController();

            // Act
            ViewResult result = controller.Index(new ViewModels.ProductViewModel() { Item = "AAABB" }) as ViewResult;

            // Assert
            Assert.AreEqual(175, result.ViewBag.Total);
        }
    }
}
