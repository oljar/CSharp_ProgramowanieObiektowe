using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ABC.BL;
using System.Collections.Generic;

namespace ABC.BLTEST
{
    [TestClass]
    public class KlientRepositoryTest
    {
        [TestMethod]
        public void PobierzKlienta()

        {
            //Arrange
            var klientRepository = new KLientRepository();
            var oczekiwania = new Klient(1)
            {
                Email = "jaro@tlen.pl",
                Imie = "jarek",
                Nazwisko = "Zegarek"

            };

            //Act
            var aktualna = klientRepository.Pobierz(1);

            //Assert

            //Assert.AreEqual(oczekiwania, aktualna);

            Assert.AreEqual(oczekiwania.KlientId, aktualna.KlientId);
            Assert.AreEqual(oczekiwania.Email, aktualna.Email);
            Assert.AreEqual(oczekiwania.Imie, aktualna.Imie);
            Assert.AreEqual(oczekiwania.Nazwisko, aktualna.Nazwisko);
        }

        [TestMethod]
        public void PobierzKlientaZAdresami()

        {
            //Arrange
            var klientRepository = new KLientRepository();
            var oczekiwania = new Klient(1)
            {
                Email = "jaro@tlen.pl",
                Imie = "jarek",
                Nazwisko = "Zegarek",
                ListaAdresow = new List<Adres>()
                {

                    new Adres(1)
                     {
                        AdresTyp = 1,
                        Ulica = "Goscina",
                        Miasto = "Katowice",
                        KodPocztowy = "40-476",
                        Kraj = "Polska"
                    },
                    new Adres(2)
                    {
                        AdresTyp = 2,
                        Ulica = "Goscina",
                        Miasto = "Katowice",
                        KodPocztowy = "40-476",
                        Kraj = "Polska"

                    }
        }

            };

            //Act
            var aktualna = klientRepository.Pobierz(1);

            //Assert

            //Assert.AreEqual(oczekiwania, aktualna);

            Assert.AreEqual(oczekiwania.KlientId, aktualna.KlientId);
            Assert.AreEqual(oczekiwania.Email, aktualna.Email);
            Assert.AreEqual(oczekiwania.Imie, aktualna.Imie);
            Assert.AreEqual(oczekiwania.Nazwisko, aktualna.Nazwisko);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(oczekiwania.ListaAdresow[i].AdresTyp, aktualna.ListaAdresow[i].AdresTyp);
                Assert.AreEqual(oczekiwania.ListaAdresow[i].Ulica, aktualna.ListaAdresow[i].Ulica);
                Assert.AreEqual(oczekiwania.ListaAdresow[i].Miasto, aktualna.ListaAdresow[i].Miasto);
                Assert.AreEqual(oczekiwania.ListaAdresow[i].Kraj, aktualna.ListaAdresow[i].Kraj);

            }

        }











    }
}
