using System.Diagnostics;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("****************************");
    Console.WriteLine("******* Bubble Sort*********");
    Console.WriteLine("****************************");
    Console.WriteLine("******* Jakub Chabera *******");
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

    Console.WriteLine("Pseudonáhodná čísla: ");
    // Upraveno na výpis do řádku dle vzoru
    for (int i = 0; i < n; i++)
    {
        randomNumbers[i] = rand.Next(lowerbound, upperbound + 1);
        Console.Write("{0}; ", randomNumbers[i]);
    }
    Console.WriteLine();

    Stopwatch MyStopwatch = new Stopwatch();
    int compare = 0;
    int change = 0;

    // bubble sort - tvůj kód už řadil sestupně, to je správně
    MyStopwatch.Start();
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            if (randomNumbers[j] < randomNumbers[j + 1])
            {
                int temp = randomNumbers[j + 1];
                randomNumbers[j + 1] = randomNumbers[j];
                randomNumbers[j] = temp;
                change++;
            }
            compare++;
        }
    }
    MyStopwatch.Stop();

    Console.WriteLine("\nSeřazená čísla pomocí metody Bubble sort:");
    for (int i = 0; i < n; i++)
    {
        Console.Write("{0}; ", randomNumbers[i]);
    }
    Console.WriteLine();

    
    int velikostObrazce = 0;
    
    if (n >= 2)
    {
        for (int i = 1; i < n; i++)
        {
            if (randomNumbers[i] < randomNumbers[0])
            {
                velikostObrazce = randomNumbers[i];
                break;
            }
        }
        if (velikostObrazce == 0) velikostObrazce = randomNumbers[1];
    }

    Console.WriteLine($"\nDruhé největší číslo je {velikostObrazce}.");
    Console.WriteLine("\nObrazec:");

    if (velikostObrazce > 0)
    {
        for (int i = 0; i < velikostObrazce; i++)
        {
            for (int j = 0; j < velikostObrazce; j++)
            {
                if (i == 0 || i == velikostObrazce - 1 || j == 0 || j == velikostObrazce - 1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }


    Console.WriteLine();
    Console.WriteLine($"Počet porovnání: {compare}");
    Console.WriteLine($"Počet prohozů: {change}");
    Console.WriteLine($"Čas potřeby na seřazení čísel: {MyStopwatch.ElapsedMilliseconds} ms");

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();
}