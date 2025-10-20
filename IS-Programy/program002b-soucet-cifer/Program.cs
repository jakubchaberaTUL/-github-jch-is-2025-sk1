string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("****************************");
    Console.WriteLine("***** Součet cifer *****");
    Console.WriteLine("****************************");
    Console.WriteLine("******* Jakub Chabera ********");
    Console.WriteLine("****************************");
    Console.WriteLine();


    Console.Write("Zadejte celé číslo, pro které chcete určit součet a součin jeho cifer: ");
    string input = Console.ReadLine();

    int number;
    while (!int.TryParse(input, out number))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte hodnotu znovu: ");
        input = Console.ReadLine();
    }


    if (input.StartsWith("-"))
    {
        input = input.Substring(1);
    }

    int suma = 0;
    int soucin = 1;

    foreach (char c in input)
    {
        int cifra = c - '0';  
        Console.WriteLine("Cifra = {0}", cifra);
        suma += cifra;
        soucin *= cifra;
    }

    Console.WriteLine();
    Console.WriteLine("Součet cifer čísla {0} je {1}.", number, suma);
    Console.WriteLine("Součin cifer čísla {0} je {1}.", number, soucin);

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();
}
