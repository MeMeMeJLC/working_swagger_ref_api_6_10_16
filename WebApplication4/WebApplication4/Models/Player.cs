using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FRWP_smaller.Models
{
    public class Player
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TeamID { get; set; }
        public int JerseyNumber { get; set; }
        public bool IsCaptain { get; set; }
        public bool IsSubstitute { get; set; }

        public virtual Team Team { get; set; }

        public virtual ICollection<Goal> Goals { get; set; }
        public virtual ICollection<Penalty> Penalties { get; set; }
        //public virtual ICollection<Substitution> Substitutions { get; set; }
    }
}