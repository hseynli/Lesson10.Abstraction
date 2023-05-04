MyClass my = new MyClass();

my.Method();

// İnterfeyslər özündə metod, property, indeksator, event, statik field və konstanta saxlaya bilər.
interface IInterface
{
    void Method();
}

class MyClass : IInterface
{
    public void Method()
    {
        Console.WriteLine("Realization interface method");
    }
}