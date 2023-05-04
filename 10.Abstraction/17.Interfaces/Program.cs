DerivedClass instance = new DerivedClass();
instance.Method();

IInterface instance1 = instance as IInterface;
instance1.Method();

interface IInterface
{
    void Method();
}

class BaseClass
{
    public void Method()
    {
        Console.WriteLine("BaseClass.Method()");
    }
}

class DerivedClass : BaseClass, IInterface
{
    // İnterfeysin realizasiya mütləq deyil, çünki BaseClass-daki metodun siqnaturası interfeysdəki metodun   siqnaturası ilə eynidir.
}