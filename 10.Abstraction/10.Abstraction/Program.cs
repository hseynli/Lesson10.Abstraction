AbstractClass instance = new ConcreteClass();

instance.Method();


// Abstrakt klass.
abstract class AbstractClass
{
    public abstract void Method();
}

// Konkret klas.
class ConcreteClass : AbstractClass
{
    public override void Method()
    {
        Console.WriteLine("Implementation");
    }
}