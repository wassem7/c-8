interface I1
{
    void Print();
}

interface I2
{
    void Print();
}

class Printer : I1, I2
{
    public void Print()
    {
        System.Console.WriteLine("Default Method");
    }

    void I1.Print()
    {
        System.Console.WriteLine("Interface I1 Print...");
    }

    void I2.Print()
    {
        System.Console.WriteLine("Interface I2 Print...");
    }

    static void main()
    {
        // Type-casting objects to the particular interface
        Printer P1 = new Printer();
        P1.Print();
        ((I1)P1).Print();
        ((I2)P1).Print();

        I1 P3 = new Printer();
        P3.Print();
    }
}
