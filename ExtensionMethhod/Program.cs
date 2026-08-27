Policy p= new Policy
{
    id = 1,
    PolicyholderName = "POL12345678",
    PolicyNumber = "parikshit shelorkar",
    Premium = 10000,
    StartDate = DateTime.Today.AddMonths(-6),
    EndDate = DateTime.Today.AddDays(20),
    IsActive = true
};

Console.WriteLine(p.IsValid());
Console.WriteLine(p.DaysRemaining());
Console.WriteLine(p.GetSummary());