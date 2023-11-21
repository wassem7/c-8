class Dictionary
{
    static void Main()
    {
        Customr C1 = new Customr()
        {
            Id = 100,
            FullName = "Kwame Darkwa",
            Salary = 323.32,
        };


        Customr C2 = new Customr()
        {
            Id = 101,
            FullName = "Kofi Agyekum",
            Salary = 2673.32,
        };

        Customr C3 = new Customr()
        {
            Id = 102,
            FullName = "Kwabena Donkor",
            Salary = 422.21,
        };

        Dictionary<int, Customr> CustomerDictionary = new Dictionary<int, Customr>();
        CustomerDictionary.Add(C1.Id, C1);
        CustomerDictionary.Add(C2.Id, C2);
        CustomerDictionary.Add(C3.Id, C3);

        foreach (KeyValuePair<int, Customr> customerkeyvaluepair in CustomerDictionary)
        {
            Console.WriteLine($"Key : {customerkeyvaluepair.Key}");
            Console.WriteLine("FullName : {0}", customerkeyvaluepair.Value.Id);
            Console.WriteLine("FullName : {0}", customerkeyvaluepair.Value.FullName);
            Console.WriteLine("Salary : {0}", customerkeyvaluepair.Value.Salary);
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - -");
        }

        //Retreiving just the keys in the dictionary

        foreach (int key  in CustomerDictionary.Keys)
        {
            Console.WriteLine(key);
        }
    }
}

class Customr
{
    public int Id { get; set; }
    public string FullName { get; set; }

    public double Salary { get; set; }
}