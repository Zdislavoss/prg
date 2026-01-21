/*
string veta = "Dnes je velmi hezky.";

//zZměna velikost písmen
Console.WriteLine(veta.ToUpper());
Console.WriteLine(veta.ToLower());

//Odstranění mezer
Console.WriteLine(veta);
Console.WriteLine(veta.Trim());

//Hedání
Console.WriteLine(veta.Contains("Dnes")); //true x false
Console.WriteLine(veta.IndexOf("s")); //pozice prvniho vyskytu

//Začíná/Končí
Console.WriteLine(veta.StartsWith("Dnes")); //true x false
Console.WriteLine(veta.Trim().EndsWith("s"));



Console.Clear();
//---------------------------------------------
Console.WriteLine("Napiš své Jméno a Příjmení");
string vstup = Console.ReadLine();
vstup = vstup.Trim();

Console.WriteLine(vstup.Length);
Console.WriteLine(vstup.ToUpper());
Console.WriteLine(vstup.Contains("Jan"));
Console.WriteLine(vstup[0]);
Console.WriteLine(vstup[vstup.Length-1]);
*/

/*
//
string datum = "2025-11-11T16:00";
string rok = datum.Substring(0, 4);
string cas = datum.Substring(11);
string den = datum.Substring(5, 5);
Console.WriteLine($"Rok: {rok}, Cas: {cas}, Den: {den}");

//
string text = "Cena: 100 Kc, Doprava: 50 kc";
string opraveno = text.ToLower().Replace("kc", "CZK");
Console.WriteLine(opraveno);

//
string csvRadek = "Pavel;Novak;30;Praha";
string[] casti = csvRadek.Split(';');
Console.WriteLine($"Jméno: {casti[0]}, Příjmení: {casti[1]}, Věk: {casti[2]}, Město: {casti[3]}");

//
string veta = "Dnes je krásný den";
string[] slova = veta.Split(" ");
Console.WriteLine(slova.Length);



Console.Clear();
//1
Console.WriteLine("Napiš své Jméno a Příjmení");
string vstup = Console.ReadLine();
vstup = vstup.Trim().ToLower();

//vypis nuly
Console.WriteLine(vstup.IndexOf(" "));

//dve casti
string[] casti = vstup.Split(" ");
char jmeno = casti[0].ToUpper()[0];
string prijmeni = casti[1].ToUpper()[0] + casti[1].Substring(1);

Console.WriteLine(jmeno + "." + prijmeni);


//-------------------------


//2 Vypis cista data Karel 45 Praha
string data = "JMENO=Karel; Vek=45; MESTO=Praha";
string[] casti = data.Split('=', ';');
Console.Write($"{casti[1]} {casti[3]} {casti[5]}");

*/

/*
//první způsob (pro ukazku)
string[] radky = File.ReadAllLines("data.txt");

foreach (var radek in radky)
{
    Console.WriteLine(radek);
} 

*/

//druhy zpusob
string cesta = "data.txt";
if (File.Exists(cesta))
{
    StreamReader sr = new StreamReader(cesta);
    string line = sr.ReadLine();

    while (line != null)
        {
        Console.WriteLine(line);
        line = sr.ReadLine();
        }
    sr.Close();
    
    StreamWriter sw = new StreamWriter(cesta, true);
    
    sw.WriteLine("\nHello World!");
    sw.WriteLine("Dobry den");
    
    for (int i = 0; i < 10 ; i++)
    {
        sw.WriteLine($"Index: {i}");
    }
    
    sw.Close();
}

