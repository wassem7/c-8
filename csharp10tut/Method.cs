class Methods
{
    public static void Test(ref int j)
    {
        j = 101;
    }

    static void main()
    {
        int i = 0;
        Test(ref i);
        System.Console.WriteLine(i);
    }
}
