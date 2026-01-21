Console.Clear();

int vysledek = 0;

Console.Write("Zadej prvni cislo: ");
int cislo1 = int.Parse(Console.ReadLine());

Console.Write("Zadej operaci (+ - * /): ");
string operace = Console.ReadLine();

Console.Write("Zadej druhe cislo: ");
int cislo2 = int.Parse(Console.ReadLine());

switch (operace)
{
    case "+":
        vysledek = cislo1 + cislo2;
        break;
    case "-":
        vysledek = cislo1 - cislo2;
        break;
    case "*":
        vysledek = cislo1 * cislo2;
        break;
    case "/":
        vysledek = cislo1 / cislo2;
        break;
    default:
        Console.WriteLine("Špatně zadaná hodnota");
        break;
}

Console.WriteLine("Vysledek: " + vysledek);