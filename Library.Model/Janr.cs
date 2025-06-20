using System.ComponentModel.DataAnnotations;

namespace Library.Model;

public class Janr
{
    [Key] public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}