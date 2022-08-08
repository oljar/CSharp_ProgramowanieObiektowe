using System;

namespace Common
{
    public static class ObslugaStringa
    {
        public static string  WstawSpacje(string zrodlo)
        {

            string wynik = string.Empty;
            if (!String.IsNullOrEmpty(zrodlo))
            {
                foreach (var litera in zrodlo)
                {
                    if (char.IsUpper(litera))
                    {
                        // Przycinamy spację które już są
                        wynik = wynik.Trim();
                        wynik += " ";
                    }
                    wynik += litera;
                }
                wynik = wynik.Trim();

            }
            return wynik;
        }
    }
}
