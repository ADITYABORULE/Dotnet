namespace HR;
abstract class Employee
{
    public int Id {get; set;}
    string Name {get; set;}

    protected decimal Salary {get; set;}

    string Department {get; set;}
    public Employee()
    {
        this.Id = 1 ;
        this.Name= "sumit";
        this.Salary = 50000;
        this.Department= "tester";
    }

    public Employee(int id, string name, decimal salary , string department)
    {
        this.Id= id ;
        this.Name= name ;
        this.Salary= salary;
        this.Department=department ;
    }

    public abstract decimal computepay();
    public virtual void Displaydetails()
    {
        Console.WriteLine($"id: {Id}, Name : {Name}, salary: {Salary}, department: {Department}");
    }
}
