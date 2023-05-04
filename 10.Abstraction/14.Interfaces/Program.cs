Console.OutputEncoding = System.Text.Encoding.UTF8;

ConcreteClass instance = new ConcreteClass();
instance.Method();

IInterface1 instance1 = instance as IInterface1;
instance1.Method();

IInterface2 instance2 = instance as IInterface2;
instance2.Method();

interface IInterface1
{
    void Method();
}

interface IInterface2
{
    void Method();
}

class ConcreteClass : IInterface1, IInterface2
{
    public void Method()
    {
        Console.WriteLine("Hər iki interfeysin eyni adlı metodunu realizasiya etmək");
    }
}