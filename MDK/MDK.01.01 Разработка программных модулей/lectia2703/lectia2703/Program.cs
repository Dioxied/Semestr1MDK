using lectia2703;

class Program
{
    static void Main()
    {
        InformationSystem system1 = new InformationSystem();
        InformationSystem system2 = new InformationSystem("ИСиП", "7.2", "Илья");
        InformationSystem system3 = new InformationSystem{Name = "Vozduhanka", Version = "20.07", Developer = "Катюха"};

        system1.DisplayInfo();
        Console.WriteLine("-----------");
        system2.DisplayInfo();
        Console.WriteLine("-----------");
        system3.DisplayInfo();
        Console.WriteLine("-----------");

        var (name, version, developer) = system2;
        Console.WriteLine($"Деконструктор: {name}, {version}, {developer}");
    }
}