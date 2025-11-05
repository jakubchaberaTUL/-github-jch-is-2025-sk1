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

    // Vstup hodnoty do programu - špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    //Vstup hodnoty do programu 
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

    // Počítadla kladných, záporných čísel a nul
    int negativeNumbers = 0;
    int positiveNumbers = 0;
    int zeros = 0;

    // sudá a lichá čísla
    int evenNumbers = 0;
    int oddNumbers = 0;

    Random rand = new Random();

    Console.WriteLine("****************************");
    Console.WriteLine("Pseudonáhodná čísla: ");


    for (int i = 0; i < n; i++)
    {
        randomNumbers[i] = rand.Next(lowerbound, upperbound + 1);
        Console.WriteLine("{0}", randomNumbers[i]);

        if (randomNumbers[i] < 0)
        {
            negativeNumbers++;
        }
        else if (randomNumbers[i] > 0)
        {
            positiveNumbers++;
        }
        else
        {
            zeros++;
        }
        if (randomNumbers[i] % 2 == 0)
        {
            evenNumbers++;
        }
        else
        {
            oddNumbers++;
        }

    }

    Console.WriteLine("****************************");
    Console.WriteLine($"Počet kladných čísel: {positiveNumbers}");
    Console.WriteLine($"Počet záporných čísel: {negativeNumbers}");
    Console.WriteLine($"Počet nul: {zeros}");
    Console.WriteLine($"Počet sudých čísel: {evenNumbers}");
    Console.WriteLine($"Počet lichých čísel: {oddNumbers}");
    Console.WriteLine("****************************");





    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();


}


