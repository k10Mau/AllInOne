using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MsTest.Demo;
using MsTest.Demo.Controllers;

namespace MsTest.Demo.Tests.Controllers
{
    [TestClass]
    public class BuySellControllerTest
    {
        [TestMethod]
        public void Buy()
        {
            // Arrange
            BuySellController controller = new BuySellController();

            // Act
            var result = controller.Buy();

            // Assert
            Assert.IsNotNull(result);
        }

        
    }
}
