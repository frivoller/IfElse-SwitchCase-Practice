//switchcase çözümü. çözüm olarak switchcase tercih edilmeli çünkü kod daha organize ve okunabilir.

class Program
{
    static int ManavFiyatiSwitch(string meyve)
    {
        switch (meyve)
        {
            case "Elma":
                return 5;
            case "Armut":
                return 3;
            case "Çilek":
                return 2;
            case "Muz":
                return 3;
            default:
                return 4; // Diğer bütün meyveler
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine(ManavFiyatiSwitch("Elma"));   // 5
        Console.WriteLine(ManavFiyatiSwitch("Armut"));  // 3
        Console.WriteLine(ManavFiyatiSwitch("Çilek"));  // 2
        Console.WriteLine(ManavFiyatiSwitch("Muz"));    // 3
        Console.WriteLine(ManavFiyatiSwitch("Kavun"));  // 4
    }
}
