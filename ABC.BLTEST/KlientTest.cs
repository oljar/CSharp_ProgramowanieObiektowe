using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ABC.BL;


namespace ABC.BLTEST
    {
        [TestClass]
        public class KlientTest
        {
            [TestMethod]
            public void ImieNazwiskoTest()
            {


                //Arrange (zaaranżuj test)
                Klient klient = new Klient();
                klient.Imie = "Tomasz";
                klient.Nazwisko = "Nowak";
                string oczekiwana = "Tomasz,Nowak";


                //ACT (Działaj)

                string aktualna = klient.ImieNazwisko;


                // Assert (pobieraj test)

                Assert.AreEqual(oczekiwana, aktualna);
            }


            [TestMethod]
            public void ImieNazwiskoImiePuste()

            {


                Klient klient = new Klient();
                klient.Imie = "Tomasz";
                string oczekiwana = "Tomasz,";


                //ACT (Działaj)

                string aktualna = klient.ImieNazwisko;


                // Assert (pobieraj test)

                Assert.AreEqual("Tomasz", aktualna);
            }


        [TestMethod]
        public void StaticTest()

        {
            Klient klient1 = new Klient();
            klient1.Imie = "Tomasz";
            string oczekiwana1 = "Tomasz";
            Klient.Licznik += 1;

            Klient klient2 = new Klient();
            klient2.Imie = "Tomasz";
            string oczekiwana2 = "Tomasz";
            Klient.Licznik += 1;

            Klient klient3 = new Klient();
            klient3.Imie = "Tomasz";
            string oczekiwana3 = "Tomasz";
            Klient.Licznik += 1;

            Assert.AreEqual(3, Klient.Licznik);

        }

        [TestMethod]
        public void ZwalidujTest()

        {
            //Arrange

            var klient = new Klient();
            klient.Nazwisko = "Nowak";
            klient.Email = "hobby@wp.pl";

            var oczekiwana = true;

            


           



            //ACT
            var aktualna = klient.Zwaliduj();

            //Assert

            Assert.AreEqual(oczekiwana, aktualna);

        }




    }

}

