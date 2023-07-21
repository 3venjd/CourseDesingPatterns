
List<IFlyer> birds = new List<IFlyer>();
var duck1 = new Duck();
birds.Add(duck1);
var duck2 = new Duck();
birds.Add(duck2);
var duck3 = new Duck();
birds.Add(duck3);

var chicken1 = new chicken();
birds.Add(chicken1);

toFly(birds);

void toFly(List<IFlyer> birds)
{
    foreach (var bird in birds)
    {
        bird.Fly();
    }
}


interface IFlyer
{
    public void Fly();
}

interface IWalker
{
    public void walk();
}

public class Duck : IFlyer, IWalker
{
    public void Fly()
    {
        Console.WriteLine("The duck flys");
    }

    public void walk()
    {
        Console.WriteLine("The duck walks");
    }
}

public class chicken : IFlyer
{
    public void Fly()
    {
        Console.WriteLine("The chicken flys");
    }
}