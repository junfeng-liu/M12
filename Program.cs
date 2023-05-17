using System.Threading;

void Iterate(IEnumerable<Warrior>allWariors)
{
	foreach (var warrior in allWariors)
	{
		Console.WriteLine($"A Warrior {warrior.Name} shows up");
		warrior.Attack();
		Console.WriteLine();
	}
}
var ninja = new Ninja();
var boxer = new Boxer();
var zombie = new Zombie();
var karateka = new Karateka();
var mazingerz = new Mazingerz();
var Warriors = new List<Warrior> { ninja,boxer,zombie,karateka};
Iterate(Warriors);
abstract class Warrior
{
	public abstract string Name { get;}
	public abstract void Attack();
	
}
class Ninja
    : Warrior
{
	public override string Name => "Ninja";

    public override void Attack()
    {
        Console.WriteLine("Nuchaku Strike!");
    }
}
class Boxer
    : Warrior
{
    public override string Name => "Boxer";

    public override void Attack()
    {
        Console.WriteLine("Punch!");
    }
}
class Zombie
    : Warrior
{
    public override string Name => "Zombie";

    public override void Attack()
    {
        Console.WriteLine("Bite!");
    }
}
class Karateka
    : Warrior
{
    public override string Name => "Karateka";

    public override void Attack()
    {
        Console.WriteLine("Kick!");
    }
}
class Mazingerz
    : Warrior
{
    public override string Name => "Mazingerz";

    public override void Attack()
    {
        Console.WriteLine("Punch!");
    }
}

