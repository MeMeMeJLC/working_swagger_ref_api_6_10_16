using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FRWP_smaller.Models
{
    public class Penalty
    {
        public int ID { get; set; }
        [ForeignKey("Player")]
        public int PlayerID { get; set; }
        public string Code { get; set; }
        public TimeSpan Time { get; set; }

        public Player Player { get; set; }
    }
}