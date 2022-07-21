using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer.Models.Moves
{
    public class BaseMoveClass : Entity
    {
        [ForeignKey("Move")]
        public int MoveId { get; set; }
        public Move move { get; set; }
    }
}
