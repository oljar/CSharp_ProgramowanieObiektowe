***ToString***

Metoda ToString C# służy do tekstowego reprezentowania obiektu. Jet równoznaczna z __str__(); __repr__() w Pythonie 

Za pomocą dziedziczenia można się wbić do metody ToString którą klasy dziedziczą po Object (prarodzicu)

Każda klasa niejawnie dziedziczy z klasy Object

Nadpisana metoda ToString może zachowywać się inaczej w zależności od typu obiektu który ją wywołuje.---Polimorfizm

***OVERRIDE***

Nadpisanie ToString() w VS

W wpisz - override + spacja - wyskakuje okienko z metodami do nadpisania . Po wybraniu ToString() pokaże się :

{
	 public override string ToString()
        {
            return base.ToString();
        }
}
git 
***BASE***
Słowo base kluczowe jest używane do uzyskiwania dostępu do składowych klasy bazowej z klasy pochodnej

Teraz można modyfikować
{
	 public override string ToString()
        {
            return DataZamowienia.Value.Date + " (" + ZamowienieId + ")";
        }
}
*** Klasa ABSTRACT ***
Klasa Abstrakcyjnia nie może być utworzona - nie można użyć new
Jest przeznaczona jako klasa podstawowa , bazowa 

***Klasa KONKRETNA***

Można utworzyć klasę rzeczywistą przez - new



*** METODA VIRTUAL  i  METODA ABSTRACT ***

Jeśli metoda musi zostać nadpisana to trzeba użyć ABSTRACT - nie ma własnej implementacji.

Każda klasa pochodna musi ją implementować

Metoda może być obcjonalnie nadpisana jesli nadamy metodzie VIRTUAL

Metody aby były nadpisane  muszą być poprzedzone modyfikatorem virtual lub abstract.



*** SEALED***
Klasa zamknięta bez możliwości OVERRIDE

***Filary programowania obiektowego***
1. Abstrakcja
2. Kapsułkowanie
3. Dziedziczenie
4. Polimorfizm.

***PROTECTED***
Modyfikator dostępu oznacza że element jest dostępny tylko w klasie bazowej w której się znajduję lub pochodnych które dziedziczą po bazowej

***PRIVATE***
Modyfikator dostępu oznacza że element jest dostępny w klasie w której znajdują się owe właściwości lub metody.