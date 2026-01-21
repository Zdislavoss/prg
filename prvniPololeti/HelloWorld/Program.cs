Console.Clear();

Console.Write("Enter age: ");
string ageString = Console.ReadLine();
int age = int.Parse(ageString);

if (age <= 0 || age > 150)
{
    Console.WriteLine("Zadána nesprávná hodnota");
}
else if (age < 18)
{
    Console.WriteLine("Jsi nezletilý");
}
else if (age > 65)
{
    Console.WriteLine("Jsi senior");
}
else
{
    Console.WriteLine("Jsi dospely");
}
/*





body:
15
30
40
A

gemy:
1:0
5:6

Set:
1:0
2:1