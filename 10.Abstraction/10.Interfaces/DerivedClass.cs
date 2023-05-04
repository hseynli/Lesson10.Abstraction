class DerivedClass : Interface1, Interface2
{
    // Əgər metodların adları eynidirsə, onda metodun qarşısında birbaşa hansı interfeysin metodunu realizasiya etdiymimiz göstəririk. Default olaraq bele metodlar private olur və birbaşa access modifier istifadə etməyə icazə verilmir.
    void Interface1.Method()
    {
        Console.WriteLine("Interface1.Method()");
    }

    void Interface2.Method()
    {
        Console.WriteLine("Interface2.Method()");
    }
}