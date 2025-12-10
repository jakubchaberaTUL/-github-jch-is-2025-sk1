string again = "a";
while (again == "a")
{
    Console.Clear();
    Razitko();

    ulong a = NactiCislo("Zadejte číslo a: ");
    ulong b = NactiCislo("Zadejte číslo b: ");

    ulong nsd = VypocetNSD(a, b);
    ulong nsn = VypocetNSN(a, b, nsd);

   
    Console.WriteLine($"NSD({a}, {b}) = {nsd}");
    Console.WriteLine($"NSN({a}, {b}) = {nsn}");

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();
}

void Razitko()
{
    Console.WriteLine("****************************");
    Console.WriteLine("***** Výpočet NSD a NSN *****");
    Console.WriteLine("****************************");
    Console.WriteLine("******* Jakub Chabera ********");
    Console.WriteLine("****************************");
    Console.WriteLine();
}

ulong NactiCislo(string zprava)
{
    Console.Write(zprava);
    ulong cislo;
    while (!ulong.TryParse(Console.ReadLine(), out cislo))
    {
        Console.Write("Nezadali jste přirozené číslo. Zadejte hodnotu znovu: ");
    }
    return cislo;
}

ulong VypocetNSD(ulong a, ulong b)
{
    while (b != 0)
    {
        ulong temp = b;
        b = a % b;
        a = temp;
    }
    return a;
}

ulong VypocetNSN(ulong a, ulong b, ulong nsd)
{
    if (a == 0 || b == 0) return 0;
    return (a / nsd) * b;
}

