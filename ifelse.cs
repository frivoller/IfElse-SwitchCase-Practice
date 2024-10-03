//if else çözümü, çözüm olarak switchcase tercih edilmeli çünkü kod daha organize ve okunabilir.
using System;

class ifelse
{
    static int ManavFiyatiIf(string meyve)
    {
        if (meyve == "Elma")
        {
            return 5;
        }
        else if (meyve == "Armut")
        {
            return 3;
        }
        else if (meyve == "Çilek")
        {
            return 2;
        }
        else if (meyve == "Muz")
        {
            return 3;
        }
        else
        {
            return 4; // Diğer bütün meyveler
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine(ManavFiyatiIf("Elma"));   // 5
        Console.WriteLine(ManavFiyatiIf("Armut"));  // 3
        Console.WriteLine(ManavFiyatiIf("Çilek"));  // 2
        Console.WriteLine(ManavFiyatiIf("Muz"));    // 3
        Console.WriteLine(ManavFiyatiIf("Kavun"));  // 4
    }
}
