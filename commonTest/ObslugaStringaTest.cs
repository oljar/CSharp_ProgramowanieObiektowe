﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            var aktualna = ObslugaStringa.WstawSpacje(zrodlo);

            //Assert 

            Assert.AreEqual(oczekiwana, aktualna);

 

        }
    }
}
