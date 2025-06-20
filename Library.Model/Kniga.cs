using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Library.Model;

public class Kniga
{
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        public bool Bronirovana { get; set; }
    
        public int? AutorId { get; set; }
        [ForeignKey("AutorId")] public Autor? Avtor { get; set; }
        
        public int? JanrId { get; set; }
        [ForeignKey("JanrId")] public Janr? Janr { get; set; }
        
        public int? UserId { get; set; }
        [ForeignKey("UserId")] public User? User { get; set; }
    
        public string image { get; set; }
        public byte[]? imageDat { get; set; }//потом надо будет
}