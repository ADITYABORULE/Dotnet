using HR;
class Program
{
    public static void Main(string[] args)
    {
        SalesEmployee sanket = new SalesEmployee (1 , "sanket", 50000, "SALES", 1000, 0.1m);
        decimal TotalSalary= sanket.computepay();
        Console.WriteLine(TotalSalary);
    }
}


