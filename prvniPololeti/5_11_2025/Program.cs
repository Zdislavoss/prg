Console.Clear();

/*

//deklarace pole
int[] mojeCisla;

// Inicializace
mojeCisla = new int[5];

// Kombinace
int[] znamky = new int[5];

// přístup k prvkům
znamky[0] = 1; //první pozice je hodnota 1
znamky[1] = 3;
znamky[4] = 2; //poslední pozice v poli


int prvniZnamka = znamky[0];
Console.WriteLine(prvniZnamka);

Console.WriteLine(znamky[3]);

string[] dnyVTydnu = new string[7];
dnyVTydnu[0] = "Pondělí";

string[] dnyVTydnuJinak = { "ondělí", "Úterý", "Středa", "Čtvrtek", "Pátek", "Sobota", "Neděle" };
Console.WriteLine(dnyVTydnuJinak[1] + ", " + dnyVTydnuJinak[5]);

int velikost = dnyVTydnuJinak.Length;
Console.WriteLine("velikost pole Dny V Týdnu Jinak: " + velikost);

    for (int i = 0; i < dnyVTydnuJinak; i++)
    {
        Console.WriteLine(dnyVTydnuJinak[i]);
    }

*/

//1
string[] nakupniSeznam = new string[4];
nakupniSeznam[0] = "Máslo";
nakupniSeznam[1] = "Vajíčka";
nakupniSeznam[2] = "Rajče";
nakupniSeznam[3] = "Jablko";

int velikost1 = nakupniSeznam.Length;

Console.WriteLine(nakupniSeznam[0] + ", " + nakupniSeznam[3]);
Console.WriteLine("Velikost: " + velikost1);


//2
int[] cisla =  {1, 2, 3, 4, 5, 6};
int soucet = cisla[0] + cisla[1];
Console.WriteLine("Soucet: " + soucet);

cisla[2] = 99;
    Console.WriteLine("Prostřední prvek: " + cisla[2]);






















