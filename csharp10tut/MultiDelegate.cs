public delegate int SampleMethodDelegate();

class MultiDelegate
{
    static void Main()
    {
        SampleMethodDelegate del1 = new SampleMethodDelegate(SamleMethodOne);
        del1 += SamleMethodTwo;

        int delresults = del1();
        System.Console.WriteLine(delresults);
    }

    public static int SamleMethodOne()
    {
        return 1;
    }

    public static int SamleMethodTwo()
    {
        return 2;
    }
}
