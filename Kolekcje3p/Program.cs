// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Tablica 6 wartości losowych
//funkcja zwraca tablicę przekazujemy do niej liczbe elementów

int[] wylosujTablice(int liczbaElementow)
{
    int[] tablicaWylosowana = new int[liczbaElementow];
    Random random = new Random();
    for (int i = 0; i < tablicaWylosowana.Length; i++)
    {
        tablicaWylosowana[i] = random.Next(1, 100);
    }
    return tablicaWylosowana;
}

void wypiszTablice(int[] tablicaDoWypisanie)
{
    Console.WriteLine("Tablica:");
    for (int i = 0; i < tablicaDoWypisanie.Length; i++)
    {
        Console.Write(tablicaDoWypisanie[i]+", ");
    }
}
int[] tablicaTestowa = wylosujTablice(10);
wypiszTablice(tablicaTestowa);

int[] wczytajLiczbyDoTablicy(int ileLiczb)
{
    int[] tablicaZKlawiatury = new int[ileLiczb];
    for (int i = 0;i < ileLiczb; i++)
    {
        Console.WriteLine("podaj liczbe " + i);
        tablicaZKlawiatury[i]= int.Parse(Console.ReadLine());
    }
    return tablicaZKlawiatury;
}
int[] tablicaWczytana = wczytajLiczbyDoTablicy(6);
wypiszTablice(tablicaWczytana);