using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseLayer.Models.Moves
{
    [Table("Spells")]
    public class Spell : Entity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }



    }

}
