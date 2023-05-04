ConcreteClass instance = new ConcreteClass();
instance.Method();

interface Interface
{
    void Method();
}

abstract class AbstractClass : Interface
{
    // Abstrakt klasda interfeysin metodunu dəyişirik.
    public abstract void Method();
}

class ConcreteClass : AbstractClass
{
    // Realizasiya mütləqdir.
    public override void Method()
    {
        Console.WriteLine("Realization");
    }
}