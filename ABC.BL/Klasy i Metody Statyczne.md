***Metody statyczne C# - przykład ***

{
    Arytmetyka art = new Arytmetyka();
    int wynik = art.Dodawanie(1, 2);
}
Aby zadeklarować ,że dana zmienna bądź metoda jest statyczna musimy dopisać słowo kluczowe static po modyfikatorze dostępu ,ale przed określeniem typu.


class Arytmetyka 
{
    public static int Dodawanie(int a, int b)
    {
        return a + b;
    }
}  

Teraz możesz mieć dostęp do tej metody poprzez odwołanie się do samej nazwy klasy. Jak to widać w kodzie.
{
    int wynik = Arytmetyka.Dodawanie(1, 10);
}

Kiedy definiujesz statyczną metodę nie może ona korzystać z żadnych pól zdefiniowanych w klasie. Chyba że pola te są też statyczne. Czyli statyczne metody mogą odwoływać się tylko do innych statycznych metod i pól. Niestatyczne pola i metody wymagają utworzenia obiektu, do których będą one odwoływane.

***Klasy statyczne C#***

{
    public  static class Drukuj
    {
        public static void Wydruk()
        {
            Console.WriteLine("ala ma kota");
        }
        
    }
}


W klasie statycznej mogą znajdować się tylko pola statyczne. Aby stworzyć klasę statyczną wystarczy dopisać słowo static przed słowem class.

Wywołanie

{
    Drukuj.Wydruk();

}
