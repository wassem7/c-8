using PATA = ProjectA.TeamA;
using PBTB = ProjectA.TeamB;

class ProgramNameSpace
{
    static void main()
    {
        PATA.ClassA.Print();
        PBTB.ClassA.Print();
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
                System.Console.WriteLine("Class A Print Method");
            }
        }
    }

    namespace TeamB
    {
        class ClassA
        {
            public static void Print()
            {
                System.Console.WriteLine("Class B Print Method");
            }
        }
    }
}
