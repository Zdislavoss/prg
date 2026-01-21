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