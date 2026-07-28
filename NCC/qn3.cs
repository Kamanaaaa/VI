using System;
class week
{
    private string[] days =
    {
        "sunday",
        "monday",
        "tuesday",
        "wednesday",
        "thursday",
        "friday",
        "saturday"
    };
    public string this[int index]
    {
        get
        {
            if (index >= 0 && index < days.Length)
                return days[index];
            else
                return "invalid index";
        }
        set
        {
            if(index>=0&& index < days.Length)
                days[index] = value;
        }
    }
}
class Program
{
    static void Main()
    {
        week week=new week();
        Console.WriteLine(week[0]);
        Console.WriteLine(week[1]);
        Console.WriteLine(week[2]);
    }
}