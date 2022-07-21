using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseLayer.Models.Characters
{
    [Table("CharacterClasses")]
    public class CharacterClass : Entity
    {
        [Required]
        public string Name { get; set; }



        public ICollection<Spell> Spells { get; set; }

        public ICollection<Bond> Bonds { get; set; }



    }

}
