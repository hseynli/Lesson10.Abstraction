abstract class AbstractBaseClass
{
    // 1.
    // Simple method.
    public void SimpleMethod()
    {
        Console.WriteLine("AbstractBaseClass.SimpleMethod");
    }

    // 2.
    // Virtual method.
    public virtual void VirtualMethod()
    {
        Console.WriteLine("AbstractBaseClass.VirtualMethod");
    }

    // 3.
    // Abstract method.
    public abstract void AbstractMethod();
}