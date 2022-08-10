using ABC.BL;
using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace commonTest
{
    [TestClass]
    public class UslugaLogowania
    {
        [TestMethod]
        public void PiszDoPlikuTest()
        {
            //Arrange

            var zmienioneElementy = new List<ILogowanie>();
            aaa.azor();
         

            var klent = new Klient(1)
            {
                Email = "admin@dev-hobby.pl",
                Imie = "Mariusz",
                Nazwisko = "Kowal",
                ListaAdresow = null

            };

            zmienioneElementy.Add(klent as ILogowanie);

            var produkt = new Produkt(2)
            {
                NazwaProduktu = " Klocki",
                Opis = " KLocki do zabawy",
                AktualnaCena = 120M


            };
            zmienioneElementy.Add(produkt as ILogowanie);


            var zamowienie = new Zamowienie(3)
            {
                DataZamowienia = new DateTime(2018, 9, 21)
            };
            zmienioneElementy.Add(zamowienie as ILogowanie);


            //Act
            UslugaLogowanie.PiszDoPliku(zmienioneElementy);
            // Wywołanie metody statycznej C#  
            
        
        }
    }
}
