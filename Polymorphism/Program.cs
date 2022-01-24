// See https://aka.ms/new-console-template for more information
using Polymorphism;

Console.WriteLine("Hello, World!");


BaseClass bc = new BaseClass();
DerivedClass dc = new DerivedClass();
BaseClass bcdc = new DerivedClass();

class BaseClass
{
    public void TakeFunction (Func<string,int> test)
    {
        var aaa = test;
        
    }
    public void Method1()
    {
        Console.WriteLine("Base - Method1");
    }

}

class DerivedClass : BaseClass
{
    public void Method2()
    {
        Console.WriteLine("Derived - Method2");
    }
}