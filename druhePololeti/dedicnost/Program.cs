Console.WriteLine("EatAndSleep demo:");
(new Cat("Lula")).EatAndSleep();

Console.WriteLine("==========");

List<Animal> animals = [
new Dog("Dogo", "Labrador"),
new Cat("Mica")
];

foreach (Animal animal in animals)
{
    animal.Eat();
}

class Animal
{
    public string Name { get; set; } = "";

    public Animal(string name)
    {
        Name = name;
    }

    public virtual void Eat()
    {
        Console.WriteLine($"{Name} is eating");
    }
        
}


class Dog : Animal
{

  public string Bread {get; set;}

  public Dog(string name, string bread) : base(name)
  {
      Bread = bread;
  }

  public override void Eat()
  {
      Console.WriteLine($"Dog named {Name} is eating");
  }
    public void Bark()
    {
        Console.WriteLine("Haf haf!");
    }
}

class Cat : Animal
{
    public Cat(string name) : base(name)
        {
        }

    public override void Eat()
    {
        base.Eat();
        Console.WriteLine($"Cat named {Name} is eating");
    }

    public void EatAndSleep()
    {
        base.Eat();
        Console.WriteLine($"Cat named {Name} is sleeping");
    }
}

