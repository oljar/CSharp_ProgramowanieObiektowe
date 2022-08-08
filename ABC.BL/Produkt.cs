using System;
using ABC;
using Common;

namespace ABC.BL
{
    public class Produkt : KlasaBazowa
    {
        public Produkt()
        {

        }

        public Produkt(int produktId)
        {
            ProduktId = produktId;
        }

        public int ProduktId { get; private set; }
        public Decimal? AktualnaCena { get; set; }
        public string Opis { get; set; }
        private string _NazwaProduktu { get; set; }

        public string NazwaProduktu
        {
            get {
                var obslugaStringa = new ObslugaStringa();
                    return obslugaStringa.WstawSpacje(_NazwaProduktu); }
            set { _NazwaProduktu = value; }
        }
        /// <summary>
        /// Pobieramy jeden produkt
        /// </summary>
        /// <param name="produktId"></param>
        /// <returns></returns>
        /// 

        public override bool Zwaliduj()
        {
            var poprawne = true;

            if (string.IsNullOrWhiteSpace(NazwaProduktu))
                poprawne = false;

            return poprawne;
        }

        public override string ToString()
        {
            return NazwaProduktu;
        }

       
     
    }
}
