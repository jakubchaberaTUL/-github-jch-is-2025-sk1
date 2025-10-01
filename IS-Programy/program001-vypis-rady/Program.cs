string again = "a";
while (again == "a")
{
    Console.Write("Program na vypsání číselné řady.\n");
    Console.Write("Zadejte cislo: ");

    int first;
    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.Write("Neplatny vstup. Zadejte cislo: ");
    }

    Console.Write("Pro opakovani stisknete 'a', jinak jiny znak: ");
    again = Console.ReadLine();
}
