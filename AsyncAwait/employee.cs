namespace HR.model;

public class Employee
{
    
    public int id;
    public string name;
    public string department;
    public double salary;

    public override string ToString()
    {
        return $"{id} |{name}|{department}|{salary}";
    }
}

