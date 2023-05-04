ConcreteClass instance = new ConcreteClass();
instance.Method();

interface Interface
{
    void Method();
}

abstract class AbstractClass : Interface
{
    public void Method()
    {
        Console.WriteLine("Abstrakt klasda realizasiya");
    }
}

class ConcreteClass : AbstractClass
{
}