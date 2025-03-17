namespace PZ3;

public class Zoo
{
    public List<Zwierze?> Zwierzeta { get; } = new();
    public List<IRoslinozerne> Roslinozercy { get; } = new();
    public List<IMiesozerne> Miesozerne { get; } = new();

    public void DodajZwierze(Zwierze? zwierzak) => Zwierzeta.Add(zwierzak);
    public void DodajRoslinozercę(IRoslinozerne zwierze) => Roslinozercy.Add(zwierze);
    public void DodajMiesozernego(IMiesozerne zwierze) => Miesozerne.Add(zwierze);

    public void KopiujDoList()
    {
        foreach (var zwierzak in Zwierzeta)
        {
            if (zwierzak is IRoslinozerne roslinozerne) DodajRoslinozercę(roslinozerne);
            if (zwierzak is IMiesozerne miesozerne) DodajMiesozernego(miesozerne);
        }
    }

    public void KarmWszystkichRoslinozercow()
    {
        foreach (var roslinozerca in Roslinozercy)
        {
            roslinozerca.ZnajdzPozywienie();
            roslinozerca.ZjedzRosline();
        }
    }

    public void KarmWszystkichMiesozerow()
    {
        foreach (var miesozerca in Miesozerne)
        {
            miesozerca.ZnajdzPozywienie();
            miesozerca.ZjedzMieso();
        }
    }

    public static void KarmRoslinozercę(IRoslinozerne zwierze)
    {
        zwierze.ZnajdzPozywienie();
        zwierze.ZjedzRosline();
    }

    public static void KarmMiesozernego(IMiesozerne zwierze)
    {
        zwierze.ZnajdzPozywienie();
        zwierze.ZjedzMieso();
    }

    public void WyswietlZwierzaki() => Zwierzeta.ForEach(Console.WriteLine);
    public void WyswietlRoslinozercow() => Roslinozercy.ForEach(Console.WriteLine);
    public void WyswietlMiesozerow() => Miesozerne.ForEach(Console.WriteLine);

    public Zwierze? ZnajdzZwierzePoImieniu(string imie) => Zwierzeta.FirstOrDefault(z => z?.Imie == imie);
}