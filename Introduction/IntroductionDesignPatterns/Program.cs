


SportyPerson person1 = new SportyPerson("Evelio",31,"Colombian");
SportyPerson person2 = new SportyPerson("Cristina", 37, "Colombian");
Console.WriteLine(person1.Show());
person1.Run();

Console.WriteLine(person2.Show());


//abstract especify functionality, qualities or properties but doesnt allow to create objects, just use in inheritance
abstract class Person
{
    public string name;
    public int age;
    public string nationality;

    public Person(string _name, int _age, string _nationality)
    {
        name = _name;
        age = _age;
        nationality = _nationality;
    }

    public string Show()
    {
        return name + " " + age + " " + nationality;
    }
}

class SportyPerson : Person
{
    public SportyPerson(string _name, int _age, string _nationality) : base(_name, _age, _nationality)
    {

    }


    public void Run()
    {
        Console.WriteLine(name + " is running");
    }
}