using System;
using System.Collections.Generic;

interface IPayable
{
    void Pay();
}
class Invoice: IPayable
{
    public void Pay()
    {
        Console.WriteLine("Payment made for Invoice");
    }
}
class salary: IPayable
{
    public void Pay()
    {
        Console.WriteLine("salary payment processed.");
    }
}
class Program
{
    static void Main()
    {
        List<IPayable> payments = new List<IPayable>();
        payments.Add(new Invoice());
        payments.Add(new salary());

        foreach (IPayable payment in payments)
        {
            payment.Pay();
        }
    }
}