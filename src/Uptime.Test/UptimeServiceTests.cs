using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uptime.Domain;

namespace Uptime.Test
{
    [TestClass]
    public class UptimeServiceTests
    {
        // Testing examples: https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/testing?view=aspnetcore-2.1
        [TestMethod]
        public void Get_Basic_Uptime()
        {
            // Arrange
            IUptimeService service = new UptimeService();
            service.FilePath = "uptime.txt";
            
            // Act
            UptimeResult result = service.Get();
            
            // Assert
            Assert.AreEqual(Decimal.Parse("107762.39"), result.Seconds);
            Assert.AreEqual(Decimal.Parse("1796.04"), result.Minutes);
            Assert.AreEqual(Decimal.Parse("29.93"), result.Hours);
            Assert.AreEqual(Decimal.Parse("1.25"), result.Days);
        }
    }
}