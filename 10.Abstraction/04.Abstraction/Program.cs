AbstractClass instance = new ConcreteClassB();

instance.Method();
instance.Operation();


// Konkret klas A.
class ConcreteClassA
{
    public void Operation()
    {
        Console.WriteLine("ConcreteClassA.Operation");
    }
}

// Abstrakt klas.
// Abstrakt klas konkret klasdan inherit ola bilər
abstract class AbstractClass : ConcreteClassA
{
    public abstract void Method();
}

// Konkret klas B.
class ConcreteClassB : AbstractClass
{
    public override void Method()
    {
        Console.WriteLine("ConcreteClassB.Method");
    }
}