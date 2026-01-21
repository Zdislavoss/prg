Console.Clear();

//vaha
Console.Write("Zadej váhu v kg: ");
float vaha = float.Parse(Console.ReadLine());

//vyska
Console.Write("Zadej výšku v cm: ");
float vyska = float.Parse(Console.ReadLine());

//vypocet vysky
float vyska2 = vyska / 100.00f;

//vypocet bmi
float bmi = vaha / (vyska2 * vyska2);

//vypis bmi
if (bmi >= 30.00f)
{
    Console.WriteLine($"BMI: {bmi:F2} (OBEZITA)");
}
else if (bmi >= 25.00f)
{
    Console.WriteLine($"BMI: {bmi:F2} (NADVÁHA)");
}
else if (bmi >= 18.50f)
{
    Console.WriteLine($"BMI: {bmi:F2} (NORMÁLNÍ)");
}
else if (bmi < 18.49f)
{
    Console.WriteLine($"BMI: {bmi:F2} (PODVÁHA)");
}