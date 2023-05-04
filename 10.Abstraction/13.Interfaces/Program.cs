ConcreteClass instance = new ConcreteClass();
//instance.Method();

IInterface1 instance1 = instance as IInterface1;
instance1.Method();

IInterface2 instance2 = instance as IInterface2;
instance2.Method();

interface IInterface1
{
    void Method();
}

interface IInterface2 : IInterface1
{
    // new olmadan xəta olmayaq, amma kompilyator warning göstərəcək.
    new void Method();
}

class ConcreteClass : IInterface2
{
    void IInterface1.Method()
    {
        Console.WriteLine("IInterface1.Method()");
    }

    void IInterface2.Method()
    {
        Console.WriteLine("IInterface2.Method()");
    }
}