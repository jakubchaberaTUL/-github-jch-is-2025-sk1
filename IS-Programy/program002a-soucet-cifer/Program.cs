string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("****************************");
    Console.WriteLine("***** Název programu *****");
    Console.WriteLine("****************************");
    Console.WriteLine("******* Jakub Chabera ********");
    Console.WriteLine("****************************");
    Console.WriteLine();

    //Vstup hodnoty do programu
    Console.Write("zadejte celé číslo pro nejž chcete určit součet a součin jeho cifer: ");
    int number;

    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte hodnotu znovu: ");
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();


}


