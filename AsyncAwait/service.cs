 using HR.model;
 using System;
 using System.Collections.Generic;
 using System.Threading.Tasks;
 namespace HR.services
{
    
    public class   HROperationService
    {
        
        public async Task<List<Employee>> GetEmployeesAsync()
        {
            await Task.Delay(2000);
            return new List<Employee>
            {
                new Employee{id=1,name="asd",department="it",salary=123},
                new Employee{id=1,name="asd",department="it",salary=123},
                new Employee{id=1,name="asd",department="it",salary=123},
                new Employee{id=1,name="asd",department="it",salary=123},
                new Employee{id=1,name="asd",department="it",salary=123}
                
                



            };





        }

        public async Task<double>CalculateBonusAsync(Employee emp)
        {
            await Task.Delay(2000);
            return emp.salary*100;
        }

        public async Task SaveEmployeeAsync(Employee emp)
        {
            
            await Task.Delay(3000);
            Console.WriteLine($"Employee saved asynchronously: {emp.name}");

        }



    }
}

