namespace PZ3;

public class Owca(string imie, int wiek, double waga) : Zwierze(imie, wiek, waga), IRoslinozerne
{
    public void ZnajdzPozywienie() => Console.WriteLine($"{Imie} szuka trawy...");

    public void ZjedzRosline() => Console.WriteLine($"{Imie} zjada trawę...");
}