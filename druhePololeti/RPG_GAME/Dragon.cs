
public class Dragon : Enemy
{
    public Dragon(int health) : base("Drak", 120) { }

    public override void Attack(Entity target)
    {
        Console.WriteLine($"{Name} chrlí oheň a způsobuje 25 poškození!");
        target.TakeDamage(25);
    }
}

