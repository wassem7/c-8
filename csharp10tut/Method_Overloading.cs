class Overloading
{
    public static void Main()
    {
        Add(2, 3);
    }

    public static void Add(int FN, int SN)
    {
        Console.WriteLine("Sum :{0}", FN + SN);
    }

    public static void Add(int FN, int SN, int TN)
    {
        System.Console.WriteLine("Sum : {0}", FN + SN + TN);
    }
}
