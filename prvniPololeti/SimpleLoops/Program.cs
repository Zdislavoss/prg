Console.Clear();

/*
int target = 10;
int sum = 0;
int i = 0;

while (i <= target)
{
    sum += i;
    i++;
}

Console.WriteLine($"Suma čísel od 0-{target}: {sum}"); */








/*
int target = 10;
int sum = 0;

for (int i = 1; i <= target; i++)
{
    sum += i;
}
Console.WriteLine($"Suma čísel od 0-{target}: {sum}");  
*/








int start = 0;
int end = 10;

for (int i = start; i <= end; i++)
    if (i % 2 == 0)
    {
        Console.WriteLine(i + " sude");
    }
    else
    { 
        Console.WriteLine(i + " liche");
    }









/*
Console.Clear();
Random random = new Random();
int target = random.Next(0, 11);
int f = 0;

for (int i = f; i <= 3; i++)
{
    
    Console.Write("Zadejte číslo 1-10: ");
    string cislo = Console.ReadLine();
    int cislo1 = int.Parse(cislo);
    
    if (cislo1 == target)
    {
        Console.WriteLine("Uhodl jsi číslo!");
        break;
    }
    else 
        Console.WriteLine("Neuhodl jsi číslo");
}
*/


/*
int size = 100;
for (int i = 0; i < size; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write(j + 1);
    }
    Console.WriteLine();
}
*/


        Console.WriteLine("Vyber akci:");
        Console.WriteLine("1 - Vklad");
        Console.WriteLine("2 - Vyber");
        Console.WriteLine("3 - Konec");
        Console.Write("Zadej volbu: ");

        string volba = Console.ReadLine();

        if (volba == "1")
        {
            Console.WriteLine("Zvolil jsi Vklad.");
        }
        else if (volba == "2")
        {
            Console.WriteLine("Zvolil jsi Vyber.");
        }
        else if (volba == "3")
        {
            Console.WriteLine("Zvolil jsi Konec.");
        }
        else
        {
            Console.WriteLine("Neplatná volba.");
        } 




