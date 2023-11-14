class Program5
{
    static void main()
    {
        string DoorNumber = "4";

        int Result;

        bool IsParseSuccessful = int.TryParse(DoorNumber, out Result);

        if (IsParseSuccessful)
        {
            Console.WriteLine("Parse Successful \n Value: {0}", Result);
        }
        else
        {
            System.Console.WriteLine("Parse failed !");
        }
    }
}
