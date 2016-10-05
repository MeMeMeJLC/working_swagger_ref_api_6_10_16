using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FRWP_smaller.Models
{
    public class Team
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Colours { get; set; }

        public virtual ICollection<Player> Players { get; set; }
    }
}