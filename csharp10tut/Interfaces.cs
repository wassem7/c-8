interface ICustomer
{
    void Print();
    double Balance(double balance);
}

interface ICustomer1
{
    void Print1();
}

class Customer1 : ICustomer, ICustomer1
{
    public void Print()
    {
        Console.WriteLine("Void Print Method");
    }

    public void Print1()
    {
        System.Console.WriteLine("Interface I2 Method");
    }

    public double Balance(double balance)
    {
        return balance;
    }
}

class Interfaces
{
    static void main()
    {
        Customer1 C1 = new Customer1();
        ICustomer C2 = new Customer1();
    }
}
