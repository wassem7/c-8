using ProjectA.TeamA;

class ProgramNameSpace
{
    static void Main()
    {
        ClassA.Print();
    }
}

namespace ProjectA
{
    namespace TeamA
    {
        class ClassA
        {
            public static void Print()
            {
                System.Console.WriteLine("Class A");
            }
        }
    }
}
