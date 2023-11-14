class Student
{
    private int _id;
    private string _name;

    private int _passMark;

    public void SetName(string Name)
    {
        if (string.IsNullOrEmpty(Name))
        {
            throw new Exception("Name cannot be Empty");
        }

        this._name = Name;
    }

    public string GetName()
    {
        return string.IsNullOrWhiteSpace(this._name) ? "No Name" : $"Name : {this._name}";
    }

    public void SetId(int Id)
    {
        if (Id <= 0)
        {
            throw new Exception("Id is less than 0");
        }

        this._id = Id;
    }

    public int GetId()
    {
        return this._id;
    }

    class Properties
    {
        static void main()
        {
            Student C1 = new Student();
            C1.SetId(1);
            C1.SetName("   ");
            System.Console.WriteLine(C1.GetName());
        }
    }
}
