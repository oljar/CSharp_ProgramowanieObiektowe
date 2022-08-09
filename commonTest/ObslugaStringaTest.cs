using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Common;

namespace commonTest
{
    [TestClass]
    public class ObslugaStringaTest
    {
        [TestMethod]
        public void WstawSpacjeTest()
        {
            // Arrange
            var zrodlo = "KlockiLego";
            var oczekiwana = "Klocki Lego";

            // Act
            var aktualna = zrodlo.WstawSpacje();

            //Assert 

            Assert.AreEqual(oczekiwana, aktualna);

        }



        [TestMethod]
        public void WstawSpacjeTestZeSpacja()
        {
            // Arrange
            var zrodlo = "KlockiLego";
            var oczekiwana = "Klocki Lego";// test ze spacja

            // Act
            var aktualna = zrodlo.WstawSpacje();

            //Assert 

            Assert.AreEqual(oczekiwana, aktualna);

        }

    }  
}
