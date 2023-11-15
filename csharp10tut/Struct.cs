public struct CustomerStruct
{
    private int _id;
    private string _name;

    public CustomerStruct(int Id, string Name)
    {
        this._name = Name;
        this._id = Id;
    }

    public int ID
    {
        get { return this._id; }
        set { this._id = value; }
    }

    public string Name
    {
        get { return this._name; }
        set { this._name = value; }
    }

    public void PrintCustomer()
    {
        System.Console.WriteLine($"Id : {this._id}\nName:{this._name}");
    }
}

class Test
{
    static void main()
    {
        CustomerStruct C1 = new CustomerStruct(1, "Wassem");
        CustomerStruct C2 = new CustomerStruct();
        CustomerStruct C3 = new CustomerStruct { ID = 2, Name = "Kwame" };
        C2.Name = "Wid-dad";
        System.Console.WriteLine("Name : {0}", C2.Name);
        System.Console.WriteLine(C3);
    }
}
