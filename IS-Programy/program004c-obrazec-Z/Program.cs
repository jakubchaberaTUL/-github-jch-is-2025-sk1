string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("***********************************");
    Console.WriteLine("***** Vykreslení obrazce 'Z' ******");
    Console.WriteLine("***********************************");
    Console.WriteLine("********** Jakub Chabera **********");
    Console.WriteLine("***********************************");
    Console.WriteLine();

    Console.Write("Zadejte velikost obrazce (celé číslo): ");
    int size;
    while (!int.TryParse(Console.ReadLine(), out size))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte hodnotu znovu: ");
    }
    
    Console.WriteLine(); 
    
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            if (i == 0 || i == size - 1 || i + j == size - 1)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
            
            Thread.Sleep(TimeSpan.FromMilliseconds(5));
        }
        Console.WriteLine();
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();
}
