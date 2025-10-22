string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("****************************");
    Console.WriteLine("***** Seřazení dvou čísel *****");
    Console.WriteLine("****************************");
    Console.WriteLine("******* Jakub Chabera ********");
    Console.WriteLine("****************************");
    Console.WriteLine();

    // Vstup hodnoty do programu - špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    //Vstup hodnoty do programu 
    Console.Write("Zadejte hodnotu (celé číslo): ");
    int a;

    while (!int.TryParse(Console.ReadLine(), out a))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte hodnotu znovu: ");
    }

    int b;
     Console.Write("Zadejte hodnotu (celé číslo): ");
    while (!int.TryParse(Console.ReadLine(), out b))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte hodnotu znovu: ");
    }


    Console.WriteLine();
    int pom;
    if (a > b)
    {
        pom = a;
        a = b;
        b = pom;
        Console.WriteLine("Došlo k prohození hodnot.");
    }

    Console.WriteLine($"Seřazená čísla jsou: {a}, {b}");




    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();


}


