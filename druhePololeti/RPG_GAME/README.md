# Nadpis 1

---
## Nadpis 2

---

*Dneska* je pěkná ***středa***

1. sdasd
2. dsada
2. sdada
○3. addsa

- sdsadas
- asdasdas
  - asdas
  - asdad
    - dsads

adasd asdasdasd asd sd s d [UTB](https://www.utb.cz) s s `Program.cs`

[UTB](https://www.utb.cz)

![obrazek](https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSqPK_vUvvy0g7fTFExGYI8m7662-kUmFouig&s)

```csharp

public class Dragon : Enemy
{
    public Dragon(int health) : base("Drak", 120) { }

    public override void Attack(Entity target)
    {
        Console.WriteLine($"{Name} chrlí oheň a způsobuje 25 poškození!");
        target.TakeDamage(25);
    }
}


```