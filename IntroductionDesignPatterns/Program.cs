


Person person1 = new Person("Evelio",31,"Colombian");
Person person2 = new Person("Cristina", 37, "Colombian");
Console.WriteLine(person1.Show());
Console.WriteLine(person2.Show());


class Person
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