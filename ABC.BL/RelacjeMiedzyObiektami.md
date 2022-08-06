1) Relacja "UŻYWA""  -  Jedna klasa używa innej klasy . RepozytoriumKlienta używa obiektu (instancji) klient z klasy Klinet.
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

2) Kompozycja - relacja typu "MA". 



Jeden obiekt ma inny obiekt. Obiekty mogą składać się z innych obiektów. 
Zamówienie ma Klienta
Zamówienie ma Adres Klienta
Zamówienie ma Adres Wysyłki
Zamówienie ma pozycję zamówienia. 


****   Odwołania po elementów składowych tej klasy są realizowane za pomocą właściwości. ***


Technicznie wygląda to tak że :


Należy poprosić RepozygtoriumKlienta aby użyło repozytorium adresu w celu porania adresów.

Metoda pobierania RepozytoriumKlienta wywołuje metode RepozytoriumAdresów za pomocą identyfikatora klienta , aby pobrać adresy dla kienta. Nawiązuje się współpraca między repozytorium klienta a repozytorium adresu.
Podczas testowania będzie testowane repozytorium klienta i repo adresu. 

***obiekt klient  w  RepozytoriumKlienta posiada  właściwość ListaAdresow . Właściwość tą przyrównujemy z metodą PobierzPoKliencieId  obiektu adresRepository ( typ AdreasRepository) . Metoda ta zapewni dane.***


                                    klient.ListaAdresow = adresRepository.PobierzPoKliencieId(klientId).ToList();


////
obiekt adresRepository został stworzony w konstruktorze klasy KlientRepository

        public KLientRepository()
        {
            adresRepository = new AdresRepository();
        }


////


 Agregacja  - specjalny rodzaj kompozycji  w którym części składowe nie istnieją chyba że stanowią część kompozycji..

 Jeśli jest Zamówenie to jest także Pozycja Zamówenia, ale nie może być oddzielnej Pozycji Zamówienia bez zamówenia.


 Nie ma Pozycji Zamównienia bez Zamówienia.

 3) Dziedziczenie - określane jako " JEST"


 Klient Biznesowy - jest Klientem
 Klien Mieszkaniowy - jest Klientem
 Klinet Rządowy -  jest Klientem
 Klient Edukacyjny jest Klientem. 

 Klint Biznesowy dziedziczy po klasie Klient.
