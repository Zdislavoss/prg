Console.Clear();
List<Charakter> charakters = [
    new Warrior("meč", "Bojovnik", 20),
    new Mage(200, "Nepritel", 0)
];

foreach (var charakter in charakters)
{
    charakter.Attack();
    
}



class Charakter
{
    public string Name { get; set; } = "";
    public int Level { get; set; }

    public Charakter(string name,int level)
    {
        Name = name;
        Level = level;
    }

    public virtual void Attack()
    {
        Console.WriteLine($"{Name} is attacking");
    }
}


class Warrior : Charakter
{
    public string WeaponName { get; set; }
    

    public Warrior(string weaponname, string name, int level) : base(name, level)
    {
        WeaponName = weaponname;
    }

    public override void Attack()
    {
        Console.WriteLine($"{Name} utoci pomocí  {WeaponName}");
    }
}

class Mage : Charakter
{
    public int ManaPoints { get; set; }

    public Mage(int manapoints, string name, int level) : base(name, level)
    {
        ManaPoints = manapoints;
    }

    public override void Attack()
    {
        Console.WriteLine($"{Name} sesíla kouzlo a zbývá mu {ManaPoints} many!");
    }
}