using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace EditoMTZAPI.Models;

public class Ebook
{
    [Key] public Guid Id { get; set; }

    [NotNull] public string Title { get; set; }

    [AllowNull] public string SubTitle { get; set; }

    [AllowNull] public string Language { get; set; }

    [AllowNull] public string Subject { get; set; }

    [AllowNull] public string Description { get; set; }
    
    //Simple many-to-many
    public List<Chapter> Chapters { get; } = [];
}