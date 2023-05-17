using System.Threading;

void Iterate(IEnumerable<Warrior>allWariors)
{
	foreach (var warrior in allWariors)
	{
		Console.WriteLine($"A Warrior {warrior.Name} shows the power");
		warrior.Poder();
		Console.WriteLine();
	}
}
Warrior ninja = new Ninja();
Warrior superman = new Superman();
Warrior zombie = new Zombie();
Warrior spiderman = new Spiderman();
Warrior goku = new Goku();
var Warriors = new List<Warrior> { ninja,superman,zombie,spiderman,goku};
Iterate(Warriors);
abstract class Warrior
{
	public abstract string Name { get;}
	public abstract void Poder();
	
}
class Ninja
    : Warrior
{
	public override string Name => "Ninja";

    public override void Poder()
    {
        Console.WriteLine("Invisible!");
    }
}
class Superman
    : Warrior
{
    public override string Name => "superman";

    public override void Poder()
    {
        Console.WriteLine("Fly!");
    }
}
class Zombie
    : Warrior
{
    public override string Name => "Zombie";

    public override void Poder()
    {
        Console.WriteLine("Infection!");
    }
}
class Spiderman
    : Warrior
{
    public override string Name => "Spiderman";

    public override void Poder()
    {
        Console.WriteLine("Superhuman Strength!");
    }
}

class Goku
    : Warrior
{
    public override string Name => "Goku";

    public override void Poder()
    {
        Console.WriteLine("shape shifter!");
    }
}

