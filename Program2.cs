internal class Program2
{
    private static void Main(string[] args)
    {
        void Iterate(IEnumerable<Warrior> allWariors)
        {
            foreach (var warrior in allWariors)
            {
                Console.WriteLine($"A Warrior {warrior.Name} shows the power");
                warrior.Attack();
                Console.WriteLine();
            }
        }
        Warrior ninja = new Warrior(name: "Ninja", fight: new NunchukuStrike());
        Warrior superman = new Warrior(name: "Superman", fight: new Punch());
        Warrior zombie = new Warrior(name: "Zombie", fight: new Bite());
        Warrior spiderman = new Warrior(name: "Spiderman", fight: new Kick()); ;
        Warrior goku = new Warrior(name: "goku", fight: new Punch());
        var Warriors = new List<Warrior> { ninja, superman, zombie, spiderman, goku };
        Iterate(Warriors);
        Console.WriteLine("### The Warriors Use His Power ");
        ninja.ChangeFight(new Invisible());
        superman.ChangeFight(new Cyclops());
        zombie.ChangeFight(new infection());
        spiderman.ChangeFight(new spidersensor());
        goku.ChangeFight(new KameHameHa());
        Iterate(Warriors);
    }
}

interface IFight
{
    void Fight();
}
class Punch
    : IFight
{
    public void Fight()
    {
        Console.WriteLine("Punch");
    }
}

class Kick
    : IFight
{
    public void Fight()
    {
        Console.WriteLine("Kick");
    }
}
class NunchukuStrike
    : IFight
{
    public void Fight()
    {
        Console.WriteLine("Nunchuku Strike");
    }
}
class Bite
    : IFight
{
    public void Fight()
    {
        Console.WriteLine("Bite");
    }
}
class Invisible
    : IFight
{
    public void Fight()
    {
        Console.WriteLine("Invisible");
    }
}
class Cyclops
    : IFight
{
    public void Fight()
    {
        Console.WriteLine("Cyclops");
    }
}
class spidersensor
    : IFight
{
    public void Fight()
    {
        Console.WriteLine("spider sensor");
    }
}
class infection
    : IFight
{
    public void Fight()
    {
        Console.WriteLine("infection");
    }
}
class KameHameHa
   : IFight
{
    public void Fight()
    {
        Console.WriteLine("Kame Hame Ha");
    }
}
class Warrior
{
    private  IFight _fight;
    public  string Name { get; }
    public Warrior (string name, IFight fight)
    {
        Name = name;
        _fight = fight;
    }
    public void Attack()
    {
        _fight.Fight();
    }
    public void ChangeFight(IFight fight)
    { _fight = fight; }
}
