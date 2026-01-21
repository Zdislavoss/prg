Console.Clear();

while (true)
{
    int vys = 1; 
    Console.WriteLine("Math Menu");
    Console.WriteLine("1. Vypocet faktorialu");
    Console.WriteLine("2. Vypocet mocniny");
    Console.WriteLine("3. Konec");
    Console.Write("Vyberte moznost (1-3):");
    string vyber = Console.ReadLine();

    if (vyber == "1")
    {
        Console.Write("Zadejte cislo:");
        string cislo = Console.ReadLine();
        int cislo1 = int.Parse(cislo);

        for (int i = 1; i <= cislo1; i++)
        {
            vys = vys * i;
        }
        Console.WriteLine(vys);
    }

    if (vyber == "2")
    {
        Console.Write("Zadejte mocninec:");
        string mocninec = Console.ReadLine();
        int mocninec1 = int.Parse(mocninec);

        Console.Write("Zadejte mocnina:");
        string mocnina = Console.ReadLine();
        int mocnina1 = int.Parse(mocnina);

        for (int j = 1; j <= mocnina1; j++)
        {
            vys = vys * mocninec1;
        }
        Console.WriteLine(vys);
    }

    if (vyber == "3")
    {
        break;
    }
}