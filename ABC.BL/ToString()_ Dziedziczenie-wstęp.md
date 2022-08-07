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

***BASE***
Słowo base kluczowe jest używane do uzyskiwania dostępu do składowych klasy bazowej z klasy pochodnej

Teraz można modyfikować
{
	 public override string ToString()
        {
            return DataZamowienia.Value.Date + " (" + ZamowienieId + ")";
        }
}

*** VIRTUAL  ;  ABSTRACT ***
Metody przesłaniane muszą być poprzedzone modyfikatorem virtual lub abstract

Klasa typu Virtual może być nadpisana


*** SEALED***
Klasa zamknięta bez możliwości OVERRIDE

***Filary programowania obiektowego***
1. Abstrakcja
2. Kapsułkowanie
3. Dziedziczenie
4. Polimorfizm.