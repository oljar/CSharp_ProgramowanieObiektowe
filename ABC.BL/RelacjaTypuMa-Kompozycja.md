
### 2) Kompozycja - relacja typu "MA". ###

## A)   Relacja kompozycji 01 Własność przy pomocy ODWOŁANIA ##


**Jeden obiekt posiada inny obiekt. Obiekty mogą składać się z innych obiektów.**
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

## B)   Relacja kompozycji  przy pomocy IDENTYFIKATORA ##

***Pozwala to na minimalizację sprzężenia również zapis jest prostszy.*** 

W klasie Zamowienie zostały wstawione dwie własności :

public int KlientId { get; set; }

public int AdresDostawyId { get; set; }

Należy zbudować klasy :
A) WyświetlanieZamówienia
B) WyświetlaniePozycjiZamowienia

Klasa  WyświetlanieZamówienia  używa instancji listy klasy WyświetlaniePozycjiZamówienia  definiując listę -kompozycja 

Klasy WyśwtlanieZamówenia i WyświetlaniePozycjiZamówienia są napisane w celu łatwego oddania obiektu gdzie parametrem jest - zamowienieId
      
{
    public WyswietlanieZamowienia PobierzZamowienieDoWyswietlenia(int zamowienieId)

    {
        WyswietlanieZamowienia wyswietlanieZamowienia = new WyswietlanieZamowienia();
        {
            ...
        }
        return wyswietlanieZamowienia;
    
    }
)


////


 Agregacja  - specjalny rodzaj kompozycji  w którym części składowe nie istnieją chyba że stanowią część kompozycji..

 Jeśli jest Zamówenie to jest także Pozycja Zamówenia, ale nie może być oddzielnej Pozycji Zamówienia bez zamówenia.


 Nie ma Pozycji Zamównienia bez Zamówienia.

 