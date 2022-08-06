##1) Relacja "UŻYWA""  -  Jedna klasa używa innej klasy . RepozytoriumKlienta używa obiektu (instancji) klient z klasy Klinet.##
**inaczej relacja WSPÓŁPRACY**

*RELACJA WSPÓŁPRACY -typu "Używa" Polega na tym że w klasie A jest używana  instancja klasy B 

Używa aby wypełnić podczas pobierania danych i serializować podczas zapisu.

Metoda POBIERZ  wywołała instancję obiektu klasy Klient i  przypisała jej właściwościom dane

public class KLientRepository
   
{
	        public Klient Pobierz(int klientId)

        {  
            Klient klient = new Klient(klientId);
            klientId = 1;
            // kod, który pobiera określonego klienta
            if (klientId == 1)
            {
                klient.Email = "jaro@tlen.pl";
                klient.Imie = "jarek";
                klient.Nazwisko = "Zegarek";
                System.Console.WriteLine(klient.KlientId);
            }

            return klient;
        }
}