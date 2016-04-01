using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Mastermind
{
    class Dot
    {
        //Make variables to use in the whole class.
        private String color;
        private Boolean active = false;
        private string lol = "yup";

        //Make a new dot. 
        public Dot(Boolean dot_active)
        {
            active = dot_active;
            color = "";
        }

        //Set the color of the dot. 
        public void set_color(String selected_color)
        {
            color = selected_color;
        }

        //Return if the dot is active or not.
        public Boolean check_active()
        {
            return active;
        }

        //Return the color of the dot.
        public String get_color()
        {
            return color;
        }

        //Set the dot active.
        public void set_active()
        {
            active = true;
        }

        //Set the dot inactive.
        public void set_inactive()
        {
            active = false;
        }
    }
}
