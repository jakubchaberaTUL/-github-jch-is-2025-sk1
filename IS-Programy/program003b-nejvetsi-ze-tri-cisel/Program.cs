string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("****************************");
    Console.WriteLine("***** Největší ze tří čísel *****");
    Console.WriteLine("****************************");
    Console.WriteLine("******* Jakub Chabera ********");
    Console.WriteLine("****************************");
    Console.WriteLine();

    // Vstup hodnot
    Console.Write("Zadejte hodnotu (celé číslo): ");
    int a;
    while (!int.TryParse(Console.ReadLine(), out a))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte hodnotu znovu: ");
    }

    Console.Write("Zadejte hodnotu (celé číslo): ");
    int b;
    while (!int.TryParse(Console.ReadLine(), out b))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte hodnotu znovu: ");
    }

    Console.Write("Zadejte hodnotu (celé číslo): ");
    int c;
    while (!int.TryParse(Console.ReadLine(), out c))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte hodnotu znovu: ");
    }

    Console.WriteLine();

    if (a > b)
    {
        if (a > c)
        {
            Console.WriteLine($"Největší číslo je: {a}");
        }
        else
        {
            Console.WriteLine($"Největší číslo je: {c}");
        }
    }
    else
    {
        if (b > c)
        {
            Console.WriteLine($"Největší číslo je: {b}");
        }
        else
        {
            Console.WriteLine($"Největší číslo je: {c}");
        }
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();
}
