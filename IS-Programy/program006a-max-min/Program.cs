string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("****************************");
    Console.WriteLine("Generátor pseudonáhodných čísel");
    Console.WriteLine("****************************");
    Console.WriteLine("******* Jakub Chabera ******");
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

    Console.WriteLine();
    Console.WriteLine("Zadané hodnoty:");
    Console.WriteLine($"Počet generovaných čísel: {n}");
    Console.WriteLine($"Maximální hodnota generovaných čísel: {upperbound}");
    Console.WriteLine($"Minimální hodnota generovaných čísel: {lowerbound}");

    int[] randomNumbers = new int[n];

    Random rand = new Random();

    Console.WriteLine();
    Console.WriteLine("Pseudonáhodná čísla: ");


    for (int i = 0; i < n; i++)
    {
        randomNumbers[i] = rand.Next(lowerbound, upperbound + 1);
        Console.WriteLine("{0}", randomNumbers[i]);
    }



    //Hledání maxima a minima
    int max = randomNumbers[0];
    int min = randomNumbers[0];
    int posMax = 0;
    int posMin = 0;

    for (int i = 1; i < n; i++)
    {
        if (randomNumbers[i] > max)
        {
            max = randomNumbers[i];
            posMax = i;
        }
        if (randomNumbers[i] < min)
        {
            min = randomNumbers[i];
            posMin = i;
        }
    }

    Console.WriteLine();
    Console.WriteLine("****************************");
    Console.WriteLine($"Maximální hodnota: {max}");
    Console.WriteLine($"Pozice maxima v poli: {posMax}");
    Console.WriteLine($"Minimální hodnota: {min}");
    Console.WriteLine($"Pozice minima v poli: {posMin}");
    Console.WriteLine("****************************");

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();

}

