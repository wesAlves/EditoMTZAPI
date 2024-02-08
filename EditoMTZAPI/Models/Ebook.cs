using System.ComponentModel.DataAnnotations;

namespace EditoMTZAPI.Models;

public class Ebook
{
    [Key]
    public Guid EbookID { get; set; }
    
    public string EbookName { get; set; }
    
}