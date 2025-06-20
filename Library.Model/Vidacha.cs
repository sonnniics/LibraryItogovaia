using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Model;

public class Vidacha
{
    [Key] public int Id { get; set; }
    public DateTime Date { get; set; }
    public DateTime? EndDate { get; set; } = null;
    
    public int UserId { get; set; }
    [ForeignKey("UserId")] public User User { get; set; }
    public int KnigaId { get; set; }
    [ForeignKey("KnigaId")] public Kniga Kniga { get; set; }
    
}