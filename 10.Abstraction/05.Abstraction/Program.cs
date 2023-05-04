AbstractClassA instance = new ConcreteClass();

instance.OperationA();

//instance.OperationB();  // Niyə bu metod görsənmir?

AbstractClassB instance2 = instance as AbstractClassB;

Console.WriteLine(instance.GetHashCode() == instance2.GetHashCode());


// Abstrakt klas A.
abstract class AbstractClassA
{
    public abstract void OperationA();
}

// Abstrakt klas B.
abstract class AbstractClassB : AbstractClassA
{
    public abstract void OperationB();

    // Realizasiya etməsi mütləq deyil
    //public override void OperationA() { }
}

// Konkret klas.
class ConcreteClass : AbstractClassB
{
    public override void OperationA()
    {
        Console.WriteLine("ConcreteClass.OperationA");
    }

    public override void OperationB()
    {
        Console.WriteLine("ConcreteClass.OperationB");
    }
}
