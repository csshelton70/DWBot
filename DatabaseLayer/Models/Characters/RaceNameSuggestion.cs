using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer.Models.Characters
{
    public class RaceNameSuggestion:Entity
    {
        public string Name { get; set; }

        public Race Race { get; set; }

    }
}
