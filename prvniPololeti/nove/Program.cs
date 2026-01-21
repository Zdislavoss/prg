using System.Security.Cryptography;

Console.Clear();
/*
int[] cisla = new int[5];
for (int i = 0; i < cisla.Length; i++)
{
    Boolean platnyVstup = false;
    while (platnyVstup == false)
    {
        Console.Write("Zadej: " + (i + 1) + ". číslo");
        string vstup = Console.ReadLine();
        int hodnota =  int.Parse(vstup);

        if (hodnota <= 5 && hodnota >= 1)
        {
           platnyVstup = true;
           cisla[i] = hodnota;
        }
        else
        {
            Console.WriteLine("Špatně zadané číslo, zkus to znovu!");
        }
    }
}

int soucet = 0;

int minimum = cisla[0];
int maximum = cisla[0];

int pocetPetek = 0;
int pocetJednicek = 0;

for (int i = 0; i < cisla.Length; i++)
{
    soucet = soucet + cisla[i];
    if (cisla[i] < minimum)
    {
        minimum = cisla[i];
    }

    if (cisla[i] > maximum)
        {
        maximum = cisla[i];
        }

    if (cisla[i] == 5)
    {
        pocetPetek++;
    }
}

double prumer = (double)soucet / cisla.Length;
Console.WriteLine("Průměr je: " + prumer);
Console.WriteLine("Součet je: " + soucet);
Console.WriteLine("Minimum je: " + minimum);
Console.WriteLine("Maximum je: " + maximum);

for (int znamka = 1; znamka <= 5; znamka++)
{
    int pocet = 0;

    for (int i = 0; i < cisla.Length; i++)
    {
        if (cisla[i] == znamka)
        {
            pocet++;
        }
    }

    Console.WriteLine("Počet " + znamka + "je " + pocet);
}

for (int i = 0; i < cisla.Length; i++)
{
    string slovne = "";
    switch (cisla[i])
    {
     case 1:
         slovne = "Výborně";
         break;
     case 2:
         slovne = "Chvalitebně";
         break;
     case 3:
         slovne = "Dobre";
         break;
     case 4:
         slovne = "Dostatečné";
         break;
     case 5:
         slovne = "Nedostatečné";
         break;
     default:
         slovne = "x";
         break;
    }
    Console.WriteLine("Znamka " + cisla[i] + "na " + i + ". pozici: " + slovne);
}


//FOR
int[] znamky = {1, 2, 3, 4, 5}

for (int i = 0; i < znamky.Length; i++)
{
    Console.WriteLine(znamky[i]);
}

//FOREACH
foreach (var z in znamky)
{
    Console.WriteLine(z);
}

*/

/*
string path = "data.txt";

if (File.Exists(path))
{
    StreamReader sr = new StreamReader(path);
    
    string line = sr.ReadLine();

    while (line != null)
        {
        Console.WriteLine(line);
        line = sr.ReadLine();
        }
    
    sr.Close();
}

if (File.Exists(path))
{
    StreamWriter sw = new StreamWriter(path, true);
    sw.WriteLine("\n Hello World!");
    sw.WriteLine("Třetí řádek");
    
    sw.Close();
}
*/

/*
string path = "zaci.txt";

int celkovyVek = 0;
int pocetZaku = 0;

if (File.Exists(path))
{
    StreamReader sr = new StreamReader(path);
    string radek = sr.ReadLine();
            
    while (radek != null)
    {
        string[] data = radek.Split(';');

        string jmeno = data[0];
        string prijmeni = data[1];
        string vekString = data[2];
                
        Console.WriteLine(jmeno + " " + prijmeni);
                
        int vek = int.Parse(vekString);
                
        celkovyVek += vek;
        pocetZaku++;

        radek = sr.ReadLine();
    }
            
    sr.Close();

    // Výpočet průměrného věku
    double prumer = (double)celkovyVek / pocetZaku;

    Console.WriteLine();
    Console.WriteLine("Celkový věk: " + celkovyVek);
    Console.WriteLine("Počet žáků: " + pocetZaku);
    Console.WriteLine("Průměrný věk: " + prumer);

    // Zápis do souboru
    StreamWriter sw = new StreamWriter("vysledky.txt");
    sw.WriteLine("Celkový věk: " + celkovyVek);
    sw.WriteLine("Počet žáků: " + pocetZaku);
    sw.WriteLine("Průměrný věk: " + prumer);
    sw.Close();
}
else
{
    Console.WriteLine("Soubor zaci.txt neexistuje!");
}
}
}
*/


































