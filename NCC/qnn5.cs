using System;

abstract class Employee
{
    public string Name;

    public Employee(string name)
    {
        Name = name;
    }

    // Abstract method
    public abstract double CalculateSalary();
}

class Manager : Employee
{
    public Manager(string name) : base(name)
    {
    }

    public override double CalculateSalary()
    {
        return 50000;
    }
}

class Clerk : Employee
{
    public Clerk(string name) : base(name)
    {
    }

    public override double CalculateSalary()
    {
        return 25000;
    }
}

class EmployeeTest
{
    static void Main(string[] args)
    {
        Employee manager = new Manager("Kamana");
        Employee clerk = new Clerk("Manila");

        Console.WriteLine("Employee Name: " + manager.Name);
        Console.WriteLine("Salary: " + manager.CalculateSalary());

        Console.WriteLine();

        Console.WriteLine("Employee Name: " + clerk.Name);
        Console.WriteLine("Salary: " + clerk.CalculateSalary());
    }
}