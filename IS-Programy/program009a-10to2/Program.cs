string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("****************************");
    Console.WriteLine("*Prevod z 10 do 2 soustavy**");
    Console.WriteLine("****************************");
    Console.WriteLine("******* Jakub Chabera ********");
    Console.WriteLine("****************************");
    Console.WriteLine();


    Console.Write("Zadejte hodnotu (přirozené číslo): ");
    uint number10;

    while (!uint.TryParse(Console.ReadLine(), out number10))
    {
        Console.Write("Nezadali jste číslo. Zadejte hodnotu znovu: ");
    }

    uint backupNumber10 = number10;
    uint zbytek;

    uint[] myArray = new uint[32];

    uint i;
    for (i = 0; number10 > 0; i++)
    {
        zbytek = number10 % 2;
        number10 = (number10 - zbytek) / 2;
        myArray[i] = zbytek;

        Console.WriteLine($"Celá část= {number10}, zbytek= {zbytek}");
    }

    Console.WriteLine();
    for (int j = (int)i - 1; j >= 0; j--)
    {
        Console.Write(myArray[j]);
    }



    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();


}

