class ConcreteDerivedClass : AbstractBaseClass
{
    //Virtual method realization
    //Əgər realizasiya etməsək Base Class metodu çağrılacaq.
    public override void VirtualMethod()
    {
        Console.WriteLine("DerivedClass.VirtualMethod();");
    }

    // Abstract method realization.

    public override void AbstractMethod()
    {
        Console.WriteLine("DerivedClass.AbstractMethod();");
    }
}