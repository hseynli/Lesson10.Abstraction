//Abstrakt klasın instance-nı yaratmaq mümkün deyil
//AbstractClass instance = new AbstractClass();


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