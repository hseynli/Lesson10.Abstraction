AbstractClass instance = new ConcreteClass();

Console.WriteLine(new string('-', 55));

instance.AbstractMethod();

abstract class AbstractClass
{
    // Konstruktor (birinci işə düşür).
    public AbstractClass()
    {
        Console.WriteLine("1 AbstractClass()");

        // Realizasiya olunun klasdaki metod çağırılır.
        this.AbstractMethod();

        Console.WriteLine("2 AbstractClass()");
    }

    public abstract void AbstractMethod();
}

class ConcreteClass : AbstractClass
{
    string s = "FIRST";

    // Konstruktor (ikinci işə düşür).
    public ConcreteClass()
    {
        Console.WriteLine("3 ConcreteClass()");
        s = "SECOND";
    }

    public override void AbstractMethod()
    {
        Console.WriteLine("Realization in Concrete class {0}", s);
    }
}