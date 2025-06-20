using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Model;
public class User
{
    [Key] public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime Birthday { get; set; }
    
    public List<int>? VidachaIds { get; set; }
}