Console.WriteLine(IMovable.maxSpeed);   // 260
IMovable.maxSpeed = 65;
Console.WriteLine(IMovable.maxSpeed);   // 65
//Console.WriteLine(IMovable2.Name);

interface IMovable
{    
    // konstanta
    static int minSpeed = 0;
    static int maxSpeed = 260;
    // metod
    void Move();
    // property
    string Name { get; set; }
}

interface IMovable2
{
    // Əgər const olsa onda onu private eləmək olar
    // private olan üzvlər elə interfeysin daxilində realizasiya olunmalıdır
    // (həmçinin static üzvlər də default realization olunmalıdır)
    private const string Name = "Test";
}