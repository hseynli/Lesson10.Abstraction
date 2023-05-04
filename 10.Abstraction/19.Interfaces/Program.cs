IPerson person = new Person();
person.DoWork();

interface IPerson
{
    int Age { get; set; }
    void DoWork() { Console.WriteLine("Person works"); }
}

class Person : IPerson
{
    public int Age { get; set; } = 45;
}