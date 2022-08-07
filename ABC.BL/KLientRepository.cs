using System.Collections.Generic;
using System.Linq;

namespace ABC.BL
{
    public class KLientRepository
    {   
        private AdresRepository adresRepository { get; set; }

        public KLientRepository()
        {
            adresRepository = new AdresRepository();
        }



        /// <summary>
        /// Zapisujemy obecnego klienta
        /// </summary>
        /// <returns></returns>
        public bool Zapisz(Klient klient)
        
        {// Kod, który zapisuje zdefiniowany produkt

            var sukces = true;

            if (klient.MaZmiany && klient.DaneSaPrawidlowe)
            {

                if (klient.JestNowy)
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

        /// <summary>
        /// Pobieramy jednego klienta.
        /// </summary>
        public Klient Pobierz(int klientId)


        {
            // Tworzymy instancję klasy Klienta
            Klient klient = new Klient(klientId);
            klient.ListaAdresow = adresRepository.PobierzPoKlientId(klientId).ToList();



            // kod, który pobiera określonego klienta


            // Tymczasowe wartości aby zwrócić klienta. 

            if (klientId == 1)
            {
                klient.Email = "jaro@tlen.pl";
                klient.Imie = "jarek";
                klient.Nazwisko = "Zegarek";
                System.Console.WriteLine(klient.KlientId);
              
               
                
            }

            return klient;
        }

        /// <summary>
        /// Pobieramy wszystkich klientów.
        /// </summary>
        public List<Klient> Pobierz()
        {
            // Kod, który pobiera wszystkich klientów
            return new List<Klient>();
        }
    }
}
