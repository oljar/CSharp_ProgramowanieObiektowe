using System;
using System.Collections.Generic;

namespace ABC.BL
{
    public class Zamowienie : KlasaBazowa
    {
        public Zamowienie()
        {
        }

        public Zamowienie(int zamowienieId)
        {
            ZamowienieId = zamowienieId;
        }

        public int ZamowienieId { get; private set; }


        public DateTimeOffset? DataZamowienia { get; set; }

        public List<PozycjaZamowienia> pozycjaZamowienie { get; set; }

        public int KlientId { get; set; }  // Zmówienie będzie zawierało tylko numer Klienta nie obiekt

        public int AdresDostawyId { get; set; }  // Zmówienie będzie zawierało tylko numer Klienta nie obiekt




        /// <summary>
        /// Pobieramy jedno zamowienie
        /// </summary>
        /// <param name="zamowienieId"></param>
        /// <returns></returns>
        public Zamowienie Pobierz(int zamowienieId)
        {
            // Kod, który pobiera zdefiniowane zamowienie
            return new Zamowienie();
        }



        /// <summary>
        /// Zapisujemy biezace zamowienie
        /// </summary>
        /// <returns></returns>
        public bool Zapisz(Zamowienie zamowienie)
        {
            {
                // Kod, który zapisuje zdefiniowany produkt

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

        /// <summary>
        /// Sprawdzamy dane zamowienia
        /// </summary>
        /// <returns></returns>
        public override bool Zwaliduj()
        {
            var poprawne = true;

            if (DataZamowienia == null)
                poprawne = false;

            return poprawne;
        }


        public override string ToString()
        {
            return DataZamowienia.Value.Date + " (" + ZamowienieId + ")";
        }
    }
}
