class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }

    public int Experience { get; set; }

    public static void PromoteEmployee(
        List<Employee> employees,
        PromoteEmployeeDelegate promoteEmployeeDelegate
    )
    {
        foreach (Employee emp in employees)
        {
            if (promoteEmployeeDelegate(emp))
            {
                System.Console.WriteLine($"{emp.Name}, Promoted !");
            }
        }
    }

    public static bool PromoteEmployee(Employee employee)
    {
        if (employee.Experience > 5)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

delegate bool PromoteEmployeeDelegate(Employee employee);

class Promotion
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee
            {
                Name = "Wassem Darkwa",
                ID = 1,
                Experience = 6
            },
            new Employee
            {
                Name = "Kwame Darkwa",
                ID = 1,
                Experience = 3
            },
            new Employee
            {
                Name = "Kweku James",
                ID = 1,
                Experience = 9
            }
        };

        PromoteEmployeeDelegate D1 = new PromoteEmployeeDelegate(Employee.PromoteEmployee);

        Employee.PromoteEmployee(employees, D1);
    }
}
