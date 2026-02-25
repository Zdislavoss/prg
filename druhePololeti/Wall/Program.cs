/*

Wall wall = new Wall(2, 2, "rock");
wall.GetSurface();
wall.PrintInfo();

class Wall
{
    public float height;
    public float width;
    public string material;

    public Wall(float height, float width, string material)
    {
        this.height = height;
        this.width = width;
        this.material = material;
    }

    public float GetSurface()
    {
        return height * width;
    }

    public void PrintInfo()
    {
        Console.WriteLine("Plocha: " + GetSurface() + "m2, Výška: " + height + "m, Šířka: " + width + "m, Materiál: " + material + ".");
    }
}

*/

Console.Clear();
List<Student> StudentList = new List<Student>();


while (true)
{
    int age;
    string name;
    Console.WriteLine("Zadejte konec pro ukonceni");
    Console.Write("Zadejte jméno studenta:");
    name = Console.ReadLine();
    if (name == "konec".ToUpper())
    {
        break;
    }
    Console.Write("Zadejte věk studenta:");
    age = int.Parse(Console.ReadLine());
    
    Student student = new Student(age, name);
    StudentList.Add(student);
}

foreach (var student in StudentList)
{
    student.Greet();
}