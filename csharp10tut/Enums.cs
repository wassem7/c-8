public delegate string GenderDelegate(int gender);

public class DiscountCustomer
{
    public string Name { get; set; }
    public int Gender { get; set; }
}

class Enums
{
    public static string GetGenderString(int gender)
    {
        switch (gender)
        {
            case 0:
                return "Male";

            case 1:
                return "Female";

            default:
                return "Gender not specified";
        }
    }

    static void Main()
    {
        GenderDelegate genderDelegate = new GenderDelegate(GetGenderString);

        // Male=0,Female=1
        DiscountCustomer[] discountCustomers = new DiscountCustomer[3]
        {
            new DiscountCustomer() { Name = "Wassem", Gender = 0 },
            new DiscountCustomer() { Name = "Ama", Gender = 1 },
            new DiscountCustomer() { Name = "Kweku", Gender = 0 },
        };

        foreach (DiscountCustomer customer in discountCustomers)
        {
            System.Console.WriteLine(
                "Name : {0}, Gender :{1}",
                customer.Name,
                genderDelegate(customer.Gender)
            );
        }
    }
}
