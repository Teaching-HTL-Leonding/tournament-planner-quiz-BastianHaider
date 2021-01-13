using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TournamentPlanner.Data
{
    public class Match
    {
        public int ID { get; set; }

        public int Round { get; set; }

        public Player Player1 { get; set; }

        public int Player1ID { get; set; }

        public Player Player2 { get; set; }

        public int Player2ID { get; set; }

        // This class is NOT COMPLETE.
        // Todo: Complete the class according to the requirements
    }
}

