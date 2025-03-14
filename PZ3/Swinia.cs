namespace PZ3;

public class Swinia(string imie, int wiek, double waka) : Zwierze(imie, wiek, waka), IRoslinozerne, IMiesozerne
{
    void IRoslinozerne.ZnajdzPozywienie() => Console.WriteLine($"{Imie} szuka warzyw...");
    void IRoslinozerne.ZjedzRosline() => Console.WriteLine($"{Imie} zjada marchewkę.");

    void IMiesozerne.ZnajdzPozywienie() => Console.WriteLine($"{Imie} szuka resztek mięsa...");
    void IMiesozerne.ZjedzMieso() => Console.WriteLine($"{Imie} zjada kawałek mięsa.");
}