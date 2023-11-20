class VipCustomer
{
    #region Fields
    private int _id;
    private string _firstname;

    private string _lastname;

    #endregion


    #region Public Properties
    public int ID
    {
        get { return this._id; }
        set { this._id = value; }
    }

    public string FirstName
    {
        get { return this._firstname; }
        set { this._firstname = value; }
    }

    public string LastName
    {
        get { return this._lastname; }
        set { this._lastname = value; }
    }
    #endregion

    #region Methods
    public void GetFullName()
    {
        System.Console.WriteLine($"FullName : {this._firstname} {this._lastname}");
    }

    #endregion
}

class TestV9{
    static void main (){

        System.Console.WriteLine("Hello");
    }
}
