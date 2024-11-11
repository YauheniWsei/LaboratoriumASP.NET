using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic.CompilerServices;

namespace LaboratoriumASP.NET.Models;

public class Calculator
{
    public double? A { get; set; }
    public double? B { get; set; }
    public Operators? Operator { get; set; }

    public string Op
    {
        get
        {
            switch (Operator)
            {
                case Operators.Add:
                    return "+";
                case Operators.Sub:
                    return "-";
                case Operators.Mul:
                    return "*";
                case Operators.Div:
                    return "/";
                default:
                    return "";
            }
        }
    }
    
    public bool IsValid()
    {
        return Operator != null && A != null && B != null;
    }

    public double Calculate()
    {
        if (!IsValid())
        {
            Console.WriteLine($"A: {A}, B: {B}, Operator: {Operator}");
            return double.NaN; 
        }
        
        switch (Operator)
        {   
            case Operators.Add:
                return (double) (A + B);
            case Operators.Sub:
                return (double) (A - B);
            case Operators.Mul:
                return (double) (A * B);
            case Operators.Div:
                return B != 0 ? (double)(A / B) : double.NaN;
            default:
                return double.NaN;
        }
    }
    
    public enum Operators
    {
        Add,
        Sub,
        Mul,
        Div
    }

    
}