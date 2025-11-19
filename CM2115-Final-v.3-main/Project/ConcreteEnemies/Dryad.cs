namespace Project;

public class Dryad : IEnemy
{
    public string Name => "Dryad";
    public int Health { get; set; } = 100;
    public int AttackPower => 20;

    public bool IsDefeated => Health <= 0;

    public void Attack(Player player)
    {
        Console.WriteLine($"{Name} attacks for {AttackPower} damage!");
        player.Health -= AttackPower;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Name} takes {damage} damage!");
    }
}
//Defining specific enemy type with its unique properties and behaviors
//Will be renamed for actual enemy name later
//Implements IEnemy interface
//Provides concrete implementations for Attack and TakeDamage methods
//Includes properties for Name, Health, AttackPower, and IsDefeated status
