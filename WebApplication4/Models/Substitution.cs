using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FRWP_smaller.Models
{
    public class Substitution
    {
        public int ID { get; set; }
        public int PlayerGoingOnFieldID { get; set; }
        public int PlayerGoingOffFieldID { get; set; }
        public TimeSpan Time { get; set; }

        public Player PlayerGoingOnField { get; set; }
        public Player PlayerGoingOffField { get; set; }
    }
}