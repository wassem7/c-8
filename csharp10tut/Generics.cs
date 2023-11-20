internal class Generics
{

    public static void Main()
    {

        bool equal = Calculator<int>.IsEqual('2', '2');
        if (equal)
        {
            Console.WriteLine("Equal");
        }

        else
        {
            Console.WriteLine("Not Equal");
        }

    }
}

class Calculator<T>
{
    public static bool IsEqual(T Value1,T Value2)
    {
        return Value1.Equals(Value2);
    }
}