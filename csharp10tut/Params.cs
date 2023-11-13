class ParamMethod
{
    public static void Iterate(params int[] numbers)
    {
        System.Console.WriteLine("Number of Elements : {0}", numbers.Length);

        foreach (int i in numbers)
        {
            System.Console.WriteLine(i);
        }
    }

    static void main()
    {
        Iterate(1, 2, 3);
    }
}
