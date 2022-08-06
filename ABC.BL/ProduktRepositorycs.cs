﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.BL
{
    public class ProduktRepository
    {

        /// <summary>
        /// Pobieramy jeden produkt
        /// </summary>
        /// <param name="produktId"></param>
        /// <returns></returns>
        public Produkt Pobierz(int produktId)
        { Produkt produkt = new Produkt(produktId);
            // Kod, który pobiera zdefiniowany produkt

            //Tymczasowe zakodowane wartości , aby zwrócić produkt
            if (produktId == 2)
            { 
                produkt.NazwaProduktu = "Klocki";
                produkt.Opis = "Klocki do zabawy dla dieci powyżej 3 lat";
                produkt.AktualnaCena = 119.99M;
            }
            return produkt;
        }

        /// <summary>
        /// Zapisujemy biezacy produkt
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            // Kod, który zapisuje zdefiniowany produkt
            return true;
        }


    }
}
