namespace PZ3;

public class Zwierze(string imie, int wiek, double waga)
{
    public string Imie { get; set; } = imie;
    public int Wiek { get; set; } = wiek;
    public double Waga { get; set; } = waga;

    public override string ToString() => $"{GetType().Name} {Imie}, Wiek: {Wiek}, Waga: {Waga}kg";
}