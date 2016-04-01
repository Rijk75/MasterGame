using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mastermind
{
    class Player
    {
        //Make variables to use in the whole class.
        private String name = "";

        // Make a new player. 
        public Player(String submitted_name)
        {
            name = submitted_name;
        }

        //Return players name.
        public string get_player_name()
        {
            return name;
        }
    }
}
