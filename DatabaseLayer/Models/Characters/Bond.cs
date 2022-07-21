﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseLayer.Models.Moves
{
    [Table("Bonds")]
    public class Bond : Entity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }


    }

}
