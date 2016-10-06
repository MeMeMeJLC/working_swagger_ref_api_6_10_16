using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FRWP_smaller.Models
{
    public class Goal
    {
        public int ID { get; set; }
        public int PlayerID { get; set; }
        public bool IsOwnGoal { get; set; }
        public TimeSpan Time { get; set; }

        public Player Player { get; set; }
    }
}