string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("****************************");
    Console.WriteLine("***** vypocet pi *****");
    Console.WriteLine("****************************");
    Console.WriteLine("******* Jakub Chabera ********");
    Console.WriteLine("****************************");
    Console.WriteLine();


    //Vstup hodnoty do programu 
    Console.Write("Zadejte přesnost (např. 0.0001):");
    double presnost;

    while (!double.TryParse(Console.ReadLine(), out presnost))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte hodnotu znovu: ");
    }

    double i = 1;
    double piCtvrt = 1;
    double znamenko = 1;

    while ((1.0 / i) >= presnost)
    {
        i = i + 2;
        znamenko = -znamenko;
        piCtvrt = piCtvrt + znamenko * (1.0 / i);
    }

    double pi = piCtvrt * 4;

    Console.WriteLine($"Vypočtená hodnota pí: {pi}");
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();


}


