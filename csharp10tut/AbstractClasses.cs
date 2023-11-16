public abstract class CustomerV2
{
    public abstract void Print();

    public void Balance(double balance)
    {
        System.Console.WriteLine("Balance : {0}", balance);
    }
}

public class PensionCustomer : CustomerV2
{
    public override void Print()
    {
        System.Console.WriteLine("Pension Customer");
    }
}

public class AbstractClass
{
    static void main()
    {
        PensionCustomer C1 = new PensionCustomer();
        C1.Balance(21.12);
    }
}
