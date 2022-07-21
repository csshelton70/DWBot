using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseLayer.Models.Characters
{
    [Table("Races")]
    public class Race : Entity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }


        public ICollection<RaceNameSuggestion> RaceNameSuggestions { get; set; }



    }

}
