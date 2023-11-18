class EnumsV2
{
    static void Main()
    {
        int[] values = (int[])Enum.GetValues(typeof(Gender));
        foreach (int value in values)
        {
            System.Console.WriteLine(value);
        }
        string[] names = Enum.GetNames(typeof(Gender));
        foreach (string name in names)
        {
            System.Console.WriteLine(name);
        }
    }
}

public enum Gender
{
    MALE = 10,
    FEMALE
}
