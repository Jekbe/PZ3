namespace PZ3;

internal static class Program
{
    private static void Main()
    {
        Zoo zoo = new();
        
        Owca owca = new("Dolly", 3, 45.5);
        Wilk wilk = new("Fenrir", 5, 60.2);
        Swinia swinia = new("Peppa", 2, 30.7);

        zoo.DodajZwierze(owca);
        zoo.DodajZwierze(wilk);
        zoo.DodajZwierze(swinia);

        zoo.KopiujDoList();

        Console.WriteLine("Wszystkie zwierzaki:");
        zoo.WyswietlZwierzaki();

        Console.WriteLine("\nRoślinożercy:");
        zoo.WyswietlRoslinozercow();

        Console.WriteLine("\nMięsożercy:");
        zoo.WyswietlMiesozerow();

        Console.WriteLine("\nKarmienie grupowe:");
        zoo.KarmWszystkichRoslinozercow();
        zoo.KarmWszystkichMiesozerow();

        Console.WriteLine("\nKarmienie pojedynczego zwierzaka:");
        Zoo.KarmRoslinozercę(owca);
        Zoo.KarmMiesozernego(wilk);
    }
}