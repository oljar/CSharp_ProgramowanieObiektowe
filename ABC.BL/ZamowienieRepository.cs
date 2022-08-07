using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.BL
{
    public  class ZamowienieRepository
    {

        /// <summary>
        /// Pobieramy jedno zamowienie
        /// </summary>
        /// <param name="zamowienieId"></param>
        /// <returns></returns>
        public Zamowienie Pobierz(int zamowienieId)
        {

            //Tworzymy instancję klasy zamówenie i przekazujemy identyfikator
            Zamowienie zamowienie = new Zamowienie(zamowienieId);
            if (zamowienieId == 10)
            {
                zamowienie.DataZamowienia = new DateTimeOffset(2018, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }

            // Kod, który pobiera zdefiniowane zamowienie
            return zamowienie;
        }


        public WyswietlanieZamowienia PobierzZamowienieDoWyswietlenia(int zamowienieId)
        {
            WyswietlanieZamowienia wyswietlanieZamowienia = new WyswietlanieZamowienia();

            // Kod, który zdefiniuje pola zamowienie

            // Tymczasowe dane 

            if (zamowienieId == 10)
            {
                wyswietlanieZamowienia.Imie = "Jarek";
                wyswietlanieZamowienia.Nazwisko = "Zegarek";
                wyswietlanieZamowienia.DataZamowienia = new DateTimeOffset(2018, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
                wyswietlanieZamowienia.AdresDostawy = new Adres()
                {
                    AdresTyp = 1,
                    Ulica = "Kosmiczna",
                    Miasto = "Katowice",
                    KodPocztowy = "40-467",
                    Kraj = "Polska"
                };

            }

            wyswietlanieZamowienia.WyswietlaniePozycjiZamowieniaLista = new List<WyswietlaniePozycjiZamowienia>();

            // Kod pobiera elementy zamowienia

            // Tymczasowe dane

            if (zamowienieId == 10)
            {
                var wyswietlaniePozycjiZamowienia = new WyswietlaniePozycjiZamowienia()
                {

                    NazwaProduktu = "Krzesło",
                    IloscZamowienia = 4,
                    CenaZakupu = 119.77M

                };
                wyswietlanieZamowienia.WyswietlaniePozycjiZamowieniaLista.Add(wyswietlaniePozycjiZamowienia);


                wyswietlaniePozycjiZamowienia = new WyswietlaniePozycjiZamowienia()
                {

                    NazwaProduktu = "Stolik",
                    IloscZamowienia = 7,
                    CenaZakupu = 249M

                };
                wyswietlanieZamowienia.WyswietlaniePozycjiZamowieniaLista.Add(wyswietlaniePozycjiZamowienia);


            }
            return wyswietlanieZamowienia;
        }  
        // Zwracam obiekt z zamówienim i wszystkimi danymi kienta






        /// <summary>
        /// Zapisujemy biezace zamowienie
        /// </summary>
        /// <returns></returns>
        public bool Zapisz(Zamowienie zamowienie)

        {// Kod, który zapisuje zdefiniowany produkt

            var sukces = true;

            if (zamowienie.MaZmiany && zamowienie.DaneSaPrawidlowe)
            {

                if (zamowienie.JestNowy)
                {
                    // wywolujemy insert  - procedura składowaną insert
                }
                else
                {
                    // wywolujemy update  - procedura składowaną update
                }

            }

            return sukces;
        }
    }
}
