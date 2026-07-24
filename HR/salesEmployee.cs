using System.Buffers.Text;
using System.Diagnostics.Contracts;

namespace HR ;
class SalesEmployee : Employee
{
    public int Target {get; set;}
    public decimal Commission{ get; set;} 
    
    public SalesEmployee(int id, string name, decimal salary , string department , int target , decimal commission) : base(id ,name, salary, department)
    {

        Target =target ; 
        Commission= commission ; 
    }

    public override decimal computepay()
    {
        return Salary+(Target * this.Commission) ;
    }

    public override void Displaydetails()
    {
        base.Displaydetails();

        Console.WriteLine("total salary"+ computepay());
    }
}