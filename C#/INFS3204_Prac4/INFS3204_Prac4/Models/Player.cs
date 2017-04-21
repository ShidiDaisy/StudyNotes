using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INFS3204_Prac4.Models
{
    public class Player
    {
        public string Registration_ID { get; set; }
        public string Player_name { get; set; }
        public string Team_name { get; set; }
        public DateTime Date_of_birth { get; set; }
    }
}           