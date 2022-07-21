using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseLayer.Models.Moves
{
    [Table("Moves")]
    public class Move : Entity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Key { get; set; }

        public int? Requires { get; set; }

        public int? Replaces { get; set; }


    }

}
