namespace PZ3;

public class Wilk(string imie, int wiek, double waga) : Zwierze(imie, wiek, waga), IMiesozerne
{
    public void ZnajdzPozywienie() => Console.WriteLine($"{Imie} tropi zdobycz...");

    public void ZjedzMieso() => Console.WriteLine($"{Imie} zjada mięso...");
}