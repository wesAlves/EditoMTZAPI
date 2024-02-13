using System.ComponentModel.DataAnnotations;

namespace EditoMTZAPI.Models;

public class Template
{
    [Key]
    public Guid Id { get; set; }
    
    public string Name { get; set; }
}