using Tamagochi_AM;

var count = 0;
try
{
    var pes = new Pes();
    var who = pes.WhoAmI();
    Console.WriteLine(who);
    
    while (true)
    {
        Console.WriteLine("\n");
        Thread.Sleep(500);
        var toss = pes.Do();
        Console.WriteLine($"hod byl {toss}");
        if (toss > 0)
        {
            Console.WriteLine("F = najíst");
            Console.WriteLine("P = hrát si");
            var action = Console.ReadLine();
            Console.WriteLine("\n");
            while (action != "exit")
            {
                if (action?.ToUpper() == "F")
                {
                    pes.Feed();
                    break;
                }
                if (action?.ToUpper() == "P")
                {
                    pes.Play();
                    break;
                }

                action = Console.ReadLine();
            }
        }
        Console.Write("hlad: ");
        Console.WriteLine(pes.Hunger);
        Console.Write("znuděnost: ");
        Console.WriteLine(pes.Boredom);
        Console.WriteLine(pes.IsAlive() ? "žije" : "nežije");
        Console.WriteLine("\n");
        count++;
    }
}
catch (DeadPetException)
{
    Console.WriteLine("RIP, pes umřel");
}

Console.WriteLine($"Přežil {count} kol");