using System.ComponentModel.DataAnnotations;

namespace DatabaseLayer.Models
{
    public abstract class Entity
    {
        [Key,Required]
        public int Id { get; set; } 

    }
}
