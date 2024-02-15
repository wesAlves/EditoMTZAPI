using System.ComponentModel.DataAnnotations;

namespace EditoMTZAPI.Models;

public class Chapter
{
    [Key]
    public Guid Id { get; set; }
    
    public string Title { get; set; }
    
    public string Subtitle { get; set; }
    
    //simple many-to-many
    public List<Ebook> Ebooks { get; } = [];
}