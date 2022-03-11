bool isRunning = true;
while (isRunning)
{
    Console.WriteLine("Welkom bij KortingBerekener!");/*Menu bar*/
    Console.WriteLine("\n");
    Console.WriteLine("Voer uw bedrag in");

    int price = Convert.ToInt32(Console.ReadLine());/*Input*/

    if (price <= 10)/*Kijk of iets kleiner is dan het input*/
    {
        double korting = (double)price / 100 * 5;/*Korting berekenen*/
        Console.WriteLine($"De bedrag dat u bedaalt {price} en het korting is {korting}");/*Output op het terminal*/
        double newPrice = price - korting;/*Totale prijs*/
        Console.WriteLine($"Nieuw prijs is {newPrice}");/*nieuwe prijs*/
    }
    if (price > 10 && price <= 40)
    {
        double korting = (double)price / 100 * 12.50;
        Console.WriteLine($"De bedrag dat u bedaalt {price} en het korting is {korting}");
        double newPrice = price - korting;
        Console.WriteLine($"Nieuw prijs is {newPrice}");
    }
    if (price > 40 && price <= 100)
    {
        double korting = (double)price / 100 * 15;
        Console.WriteLine($"De bedrag dat u bedaalt {price} en het korting is {korting}");
        double newPrice = price - korting;
        Console.WriteLine($"Nieuw prijs is {newPrice}");
    }
    if (price > 100)
    {
        double korting = (double)price / 100 * 21.50;
        Console.WriteLine($"De bedrag dat u bedaalt {price} en het korting is {korting}");
        double newPrice = price - korting;
        Console.WriteLine($"Nieuw prijs is {newPrice}");
    }
    Console.WriteLine("Wilt u stoppen? (ja of nee)");
    string? ans = Console.ReadLine();
    if(ans == "nee")
    {
        continue;
    }
    else
    {
        isRunning = false;
    }
}

