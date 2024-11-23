using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace LaboratoriumASP.NET.Models;

public class Komputer
{
    [HiddenInput]
    public int Id {get; set;}
    
    [MinLength(length:3, ErrorMessage = "Nazwa producenta musi miec przynajmniej 3 znaki")]
    public string Producent {get; set;}
    
    [MinLength(length:3, ErrorMessage = "Nazwa komputera musi miec przynajmniej 3 znaki")]
    [Required(ErrorMessage = "Podaj nazwe komputera")]
    public string Nazwa {get; set;}
    
    [MinLength(length:3, ErrorMessage = "Nazwa procesora musi miec przynajmniej 3 znaki")]
    [Required(ErrorMessage = "Podaj model procesora")]
    public string Cpu {get; set;}
    
    [Range(1, 128, ErrorMessage = "Podaj ilosc pamieci RAM z zakresu 1-128")]
    [Required(ErrorMessage = "Podaj ilosc pamieci RAM")]
    public int Ram {get; set;}
    
    [MinLength(length:3, ErrorMessage = "Nazwa karty graficznej musi miec przynajmniej 3 znaki")]
    [Required(ErrorMessage = "Podaj model karty graficznej")]
    public string Gpu {get; set;}
    
    [DataType(DataType.Date)]
    public DateOnly DataProdukcji {get; set;}
    
    
    
}