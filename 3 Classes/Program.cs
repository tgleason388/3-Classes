using System;

public class Octane
{
    public void octane()
    {
        Console.WriteLine("I am the best car in the game!");
    }
    public void Open()
    {
        Console.WriteLine("I am used by all the best players");
    }
    public void Tag()
    {
        Console.WriteLine("I have been in the game the longest");
    }
    public void Skill()
    {
        Console.WriteLine("I have one of the best turning radiuses");
    }
}

public class Dominus
{
    public void dominus()
    {
        Console.WriteLine("Step aside chumo dominus coming through");
    }
    public void Open()
    {
        Console.WriteLine("Only the best of the best can master my car");
    }
    public void Tag()
    {
        Console.WriteLine("I am the best at flicks");
    }
    public void Skill()
    {
        Console.WriteLine("My turning radius may be wide but i can 50 like a SSL");
    }
}

public class Fennec
{
    public void fennec()
    {
        Console.WriteLine("Move over losers, I'm the new guy!");
    }
    public void Open()
    {
        Console.WriteLine("I am the best parts of both of you lameos");
    }
    public void Tag()
    {
        Console.WriteLine("I can do everything you both can do and better");
    }
    public void Skill()
    {
        Console.WriteLine("I can turn as fast and my sharp edges make it so I'm a 50 king!");
    }
}

public class Spawn
{
    static void Main(string[] args)
    {
        Octane mob1 = new Octane();
        Console.WriteLine(" A wild Octane Appears");
        mob1.octane();
        mob1.Open();
        mob1.Tag();
        mob1.Skill();

        Dominus mob2 = new Dominus();
        Console.WriteLine(" A dirty Dominus comes from nowhere");
        mob2.dominus();
        mob2.Open();
        mob2.Tag();
        mob2.Skill();

        Fennec mob3 = new Fennec();
        Console.WriteLine(" A fierce Fennec approaches");
        mob3.fennec();
        mob3.Open();
        mob3.Tag();
        mob3.Skill();
    }
}
