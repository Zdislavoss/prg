string filename = "input.txt";
if (!File.Exists(filename))
{
    Console.WriteLine($"File {filename} does not exist.");
    return;
}
// Pokud soubor existuje tak jeho řádky načtu do proměnné `lines`
string[] lines = File.ReadAllLines(filename);

var numsA = new List<int>();
var numsB = new List<int>();

foreach (string line in lines)
{
// Tento kód rozdělí daný řádek, jako rozdělovač používá mezeru
// jsou zde nastaveny option, které zabrání tomu,
// že by nám v array zbyly nějaké prázdné písmena
    string[] numStrings = line.Split(' ', options: StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
    if (numStrings.Length != 2)
    {
        Console.WriteLine("File format is not valid.");
        return;
    }

// Do Listu čísel přidám levé (index 0) a pravé (index 1) číslo
    numsA.Add(int.Parse(numStrings[0]));
    numsB.Add(int.Parse(numStrings[1]));

// INFO: Nyní máte array numStrings se dvěma položkami
// a můžete s ním dále pracovat
}
numsA.Sort();
numsB.Sort();

int vysledek = 0;

for (int i = 0; i < numsA.Count; i++)
{
    int vys1 = numsA[i];

    int vys2 = numsB[i];
    int rozdil = vys1 - vys2;
    int rozdil1 = Math.Abs(rozdil);

    vysledek += rozdil1;
}
Console.WriteLine($"Vysledek: {vysledek}");
// PART2
int skore = 0;
foreach (var numbL in numsA)
{
    int pocetVpravo = 0;
    foreach (var numbR in numsB)
    {
        if (numbL == numbR)
        {
            pocetVpravo++;
        }
    }
    skore += numbL * pocetVpravo;
}
Console.WriteLine($"Skore: {skore}");