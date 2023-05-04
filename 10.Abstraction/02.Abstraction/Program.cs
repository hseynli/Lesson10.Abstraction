AbstractClass instance = new ConcreteClass();

instance.Method();


// Abstrakt klass.
abstract class AbstractClass
{
    public abstract void Method();

    //private abstract void Method2(); //private ola bilməz!
}

// Konkret klas.
class ConcreteClass : AbstractClass
{
    // Mütləq realizasiya etməlidir
    public override void Method()
    {
        Console.WriteLine("Implementation");
    }
}