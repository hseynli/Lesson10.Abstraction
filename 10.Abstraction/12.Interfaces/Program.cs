ConcreteClass instance = new ConcreteClass();
instance.Method1();
instance.Method2();

IInterface1 instance1 = instance as IInterface1;
instance1.Method1();

IInterface2 instance2 = instance as IInterface2;
instance2.Method1();
instance2.Method2();

interface IInterface1
{
    void Method1();
}

interface IInterface2 : IInterface1
{
    void Method2();
}

class ConcreteClass : IInterface2
{
    public void Method1()
    {
        Console.WriteLine("IInterface1.Method1()");
    }

    public void Method2()
    {
        Console.WriteLine("IInterface2.Method2()");
    }
}