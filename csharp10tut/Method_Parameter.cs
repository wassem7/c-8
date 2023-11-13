class OutParameters
{
    public static void Add(int FN, int LN, out int Sum, out int Product)
    {
        Sum = FN + LN;
        Product = FN * LN;
    }

    static void main()
    {
        int Sum;
        int Product;
        Add(3, 4, out Sum, out Product);
        System.Console.WriteLine("Sum : {0},Product : {1}", Sum, Product);
    }
}
