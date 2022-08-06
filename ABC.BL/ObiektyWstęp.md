Sygnatura metody - nazwa i typ parametrów. Sygnatura nie zawiera typu zwrotnego. System wykorzystuje sygnaturę aby dopasować 
aby dopasować wywołanie do funkcji.  Gdy są różne parametry wtedy są różne metody. - różne sygnatury.

Przciążenie - overloading - nazw ta sama - różne parametry = wariancje tej samej funkcjonalności. 
Kontrakt klasy - Właściwości i metody z modyfikatorem dostępu Public


Konstruktora domyślnego nie trzeba tworzyć . Kompilator sam go utworzy.
  public Klient()
        {

        }

Ponadto

 public Klient(int klientid)
        {
            this.klientid = klientid;  // kompilator wyłapie że nie nie trzeba this jak własność KlientId się różni - kientid 
        }


//..lub 

public int KlientId { get; private set; }

         public Klient(int klientid)
        {
            Klientid = klientid;  // kompilator wyłapie że nie trzeba this jak własność KlientId się różni - kientid 
        }

Jeśli do konstuktora nie dodajesz żadnego kodu to nie trzeba dodawać konstruktora - konstruktor domyślny jest dodawany automatycznie.

Jeśli do konstruktora dodajemy jakiś kod to trzeba dodać konstruktor domyślny + ten z kodem. 

//..

?   - Pozwala na typ nullable  -pozwala na wertość zerową

//..

Sprzęrzenie - zależności między klasami - powinno być niskie 
Spójność - miara tego czy wszystko w klasie ma jeden cel . - powinno być wysokie
Np przy zamówieniach nie powinno być zarządzania adresami wysyłki 

Repozytoriun to klasa odpowiedzialna za pobieranie i zapisywanie danych encji. 

Wzorce projektowe - praktyki definiujące zestawu  klas i powiązanych z nimi relacji. 

