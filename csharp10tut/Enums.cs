public delegate string GenderDelegate(gender gender);

public class DiscountCustomer
{
    public string Name { get; set; }
    public gender Gender { get; set; }
}

public enum gender
{
    MALE,
    FEMALE
}

class Enums
{
    public static string GetGenderString(gender gender)
    {
        switch (gender)
        {
            case gender.MALE:
                return "Male";

            case gender.FEMALE:
                return "Female";

            default:
                return "Gender not specified";
        }
    }

    static void main()
    {
        GenderDelegate genderDelegate = new GenderDelegate(GetGenderString);

        // Male=0,Female=1
        DiscountCustomer[] discountCustomers = new DiscountCustomer[3]
        {
            new DiscountCustomer() { Name = "Wassem", Gender = gender.MALE },
            new DiscountCustomer() { Name = "Ama", Gender = gender.FEMALE },
            new DiscountCustomer() { Name = "Kweku", Gender = gender.MALE },
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
