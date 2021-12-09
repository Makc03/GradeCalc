using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradingcalc
{
    public class PersonModel
    {
        // gets all varibales for database
        public string Subject { get; set; }
        public double Achieved { get; set; }
        public double bTotal { get; set; }
        public double rTotal { get; set; }
        public string isRound { get; set; }
    }
}
