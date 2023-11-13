class Customer
{
    string _firstName;
    string _lastName;

    public Customer()
        : this("Wassem", "Darkwa") { }

    public Customer(string FirstName, string LastName)
    {
        _firstName = FirstName;
        _lastName = LastName;
    }

    public void PrintFullName()
    {
        System.Console.WriteLine("Customer Fullname : {0}", _firstName + " " + _lastName);
    }

    static void main()
    {
        Customer customer1 = new Customer();
        customer1.PrintFullName();
    }
}
