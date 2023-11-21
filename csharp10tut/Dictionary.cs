class Dictionary
{
    static void main()
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

        Customr[] CustomerArray = new Customr[3];
        CustomerArray[0] = C1;
        CustomerArray[1] = C2;
        CustomerArray[2] = C3;

        var CustomrDictionary = CustomerArray.ToDictionary(cust => cust.Id, cust => cust);

        #region
        Console.WriteLine("ARRAY CONVERTED TO DICTIONARY");
        foreach (KeyValuePair<int,Customr> customerkeyvaluepair in CustomrDictionary)
        {
            Console.WriteLine($"KEY : {customerkeyvaluepair.Key}");
            Console.WriteLine($"FULLNAME : {customerkeyvaluepair.Value.FullName}");
            Console.WriteLine($"SALARY : {customerkeyvaluepair.Value.Salary}");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - ");
        }
        #endregion

        Customr cust; 
        bool isSuccess = CustomerDictionary.TryGetValue(100, out cust);
        if (isSuccess)
        {
            Console.WriteLine($"FullName : {cust.FullName}");
        }
        else
        {
            Console.WriteLine("The key is not found !");
        }

        Console.WriteLine("Total Customers : {0}", CustomerDictionary.Count(kvp => kvp.Value.Salary > 400));

        //foreach (KeyValuePair<int, Customr> customerkeyvaluepair in CustomerDictionary)
        //{
        //    Console.WriteLine($"Key : {customerkeyvaluepair.Key}");
        //    Console.WriteLine("FullName : {0}", customerkeyvaluepair.Value.Id);
        //    Console.WriteLine("FullName : {0}", customerkeyvaluepair.Value.FullName);
        //    Console.WriteLine("Salary : {0}", customerkeyvaluepair.Value.Salary);
        //    Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - -");
        //}

        //Retreiving just the keys in the dictionary

        //foreach (int key in CustomerDictionary.Keys)
        //{
        //    Console.WriteLine(key);
        //}
    }
}

class Customr
{
    public int Id { get; set; }
    public string FullName { get; set; }

    public double Salary { get; set; }
}