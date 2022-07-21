using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseLayer.Models.Characters
{
    [Table("Bonds")]
    public class Bond : Entity
    {
        public string Description { get; set; }

        public CharacterClass CharacterClass { get; set; }



    }

}
