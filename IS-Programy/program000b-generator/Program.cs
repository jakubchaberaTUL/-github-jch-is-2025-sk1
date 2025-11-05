string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("****************************");
    Console.WriteLine("*Generátor pseudonáhodných čísel**");
    Console.WriteLine("****************************");
    Console.WriteLine("******* Jakub Chabera ********");
    Console.WriteLine("****************************");
    Console.WriteLine();


    Console.Write("Zadejte počet generovaných čísel: ");
    int n;

    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste číslo. Zadejte hodnotu znovu: ");
    }

    Console.Write("Zadejte maximální hodnotu generovaných čísel: ");
    int upperbound;

    while (!int.TryParse(Console.ReadLine(), out upperbound))
    {
        Console.Write("Nezadali jste číslo. Zadejte hodnotu znovu: ");
    }

    Console.Write("Zadejte minimální hodnotu generovaných čísel: ");
    int lowerbound;

    while (!int.TryParse(Console.ReadLine(), out lowerbound))
    {
        Console.Write("Nezadali jste číslo. Zadejte hodnotu znovu: ");
    }

    Console.WriteLine("****************************");
    Console.WriteLine("Zadané hodnoty:");
    Console.WriteLine($"Počet generovaných čísel: {n}");
    Console.WriteLine($"Maximální hodnota generovaných čísel: {upperbound}");
    Console.WriteLine($"Minimální hodnota generovaných čísel: {lowerbound}");
    Console.WriteLine("****************************");

    int[] randomNumbers = new int[n];

    Random rand = new Random();

    Console.WriteLine("****************************");
    Console.WriteLine("Pseudonáhodná čísla: ");


    for (int i = 0; i < n; i++)
    {
        randomNumbers[i] = rand.Next(lowerbound, upperbound + 1);
        Console.WriteLine("{0}", randomNumbers[i]);
    }



    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();


}

