public delegate void MethodDelegate();

// Creating a multicast delegate by chaining multiple instances of delegates
class TestV5
{
    public static void SampleMethodOne()
    {
        System.Console.WriteLine("Sample Method One Invoked");
    }

    public static void SampleMethodTwo()
    {
        System.Console.WriteLine("Sample Method Two Invoked");
    }

    public static void SampleMethodThree()
    {
        System.Console.WriteLine("Sample Method Three Invoked");
    }

    static void Main()
    {
        MethodDelegate del1,
            del2,
            del3,
            del4;

        del1 = new MethodDelegate(SampleMethodOne);
        del2 = new MethodDelegate(SampleMethodTwo);
        del3 = new MethodDelegate(SampleMethodThree);

        del4 = del1 + del2 + del3 - del2;

        del4.Invoke();
    }
}
