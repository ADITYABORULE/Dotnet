public static class Polyextensions
{
    public static bool IsValid(this Policy policy)
    {
        
        DateTime today=DateTime.Today;
        return policy.IsActive && policy.StartDate<=today && policy.EndDate>=today;

    }

    public static int DaysRemaining(this Policy policy)
    {
           int days = (policy.EndDate.Date - DateTime.Today).Days;
           return days;
    }

    public static string GetSummary(this Policy policy)
    {
        return 
        $"holder : {policy.PolicyholderName}\n"+
        $"policy : {policy.PolicyNumber}\n"+
        $"premium :{policy.Premium}rs \n"+
        $"Status: {(policy.IsValid() ? "Valid" : "Invalid")}";
    }
}