using System.ComponentModel.DataAnnotations;

namespace Library.Model;

public class Autor
{
    [Key] public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Surname { get; set; }
    public DateTime? Birthday { get; set; }
}