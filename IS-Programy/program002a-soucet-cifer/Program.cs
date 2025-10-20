string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("****************************");
    Console.WriteLine("***** Součet cifer - matematicky *****");
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


    int suma = 0;
    int numberBackup = number;
    int digit;

    if (number < 0) {
        number = -number;
    }

    while (number >= 10)
    {
        digit = number % 10;
        number = (number - digit) / 10;
        Console.WriteLine("Digit = {0}", digit);
        suma = suma + digit;
    }
    Console.WriteLine("Zbytek = {0}", number);

    // přičtení poslední číslice do sumy
    suma = suma + number;

    Console.WriteLine();
    Console.WriteLine("Součet cifer čísla {0} je {1}.", numberBackup, suma);



    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();


}


