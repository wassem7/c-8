class ParentClass
{
    public ParentClass()
    {
        System.Console.WriteLine("Parent constructor called");
    }

    public ParentClass(string Message)
    {
        System.Console.WriteLine(Message);
    }
}

class ChildClass : ParentClass
{
    public ChildClass()
        : base()
    {
        System.Console.WriteLine("Child constructor called");
    }

    public ChildClass(string Message)
        : base("Message from Parent")
    {
        System.Console.WriteLine("Message from Child : {0}", Message);
    }
}

class Inheritance
{
    static void main()
    {
        ChildClass c1 = new ChildClass("Charle Omo");
    }
}
