void Greet(string name)
{
    Console.WriteLine($"Hello {name}");
}

int AddTwoNumbers(int a, int b)
{
    return a + b;
}

void MakeDouble(int x)
{
    return x * 2;
}


Greet("Radek");

int z = AddTwoNumbers(3,4);
Console.WriteLine(z);

z = MakeDouble(z);
Console.WriteLine(z);
