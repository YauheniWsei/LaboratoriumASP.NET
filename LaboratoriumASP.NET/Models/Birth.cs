using Microsoft.AspNetCore.Mvc;

namespace LaboratoriumASP.NET.Models;

public class Birth
{
    public string? Name { get; set; }
    
    public string? Date { get; set; }
    
    public bool isValid()
    {
        return Name != null && Date != null && DateTime.TryParse(Date, out _);
    }

    public int GetAge()
    {
        if (!isValid())
        {
            return -1;
        }

        DateTime birthDate = DateTime.Parse(Date);
        DateTime now = DateTime.Now;
        int age = now.Year - birthDate.Year;
        if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day))
        {
            age--;
        }

        return age;
    }
}