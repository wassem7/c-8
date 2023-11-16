interface IA
{
    void PrintA();
}

interface IB
{
    void PrintB();
}

class A : IA
{
    public void PrintA()
    {
        System.Console.WriteLine("Interface A Method");
    }
}

class B : IB
{
    public void PrintB()
    {
        System.Console.WriteLine("Interface B Method");
    }
}

class AB : IA, IB
{
    A a = new A();
    B b = new B();

    public void PrintA()
    {
        a.PrintA();
    }

    public void PrintB()
    {
        b.PrintB();
    }

    static void main()
    {
        var a = new AB();
        a.PrintA();
        a.PrintB();
    }
}
