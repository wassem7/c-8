class Delegate
{
    public static void main()
    {
        CustomerDelegate CD = new CustomerDelegate(DisplayCustomerDetails);
        CD(Name: "Kwame Darkwa", Balance: 3345432);
    }

    public delegate void CustomerDelegate(string Name, double Balance);

    public static void DisplayCustomerDetails(string Name, double Balance)
    {
        System.Console.WriteLine($"Name : {Name}\nBalance : {Balance}");
    }
}
