using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasterMind
{
    class Check
    {
        //Make variables to use in the whole class.
        private Boolean rowcheck;
        private string Right_Place = @"C:\Users\Paras\Documents\Visual Studio 2010\Projects\MasterMind\MasterMind\Resources\Right_Place.png";
        private string Right_Color = @"C:\Users\Paras\Documents\Visual Studio 2010\Projects\MasterMind\MasterMind\Resources\Right_Color.png";
        private string Right_Place_R = @"C:\Users\Rijk\Documents\Visual Studio 2010\Projects\MasterMind\MasterMind\Resources\Right_Place.png";
        private string Right_Color_R = @"C:\Users\Rijk\Documents\Visual Studio 2010\Projects\MasterMind\MasterMind\Resources\Right_Color.png";
        private string standard_dot = @"C:\Users\Paras\Documents\Visual Studio 2010\Projects\MasterMind\MasterMind\Resources\Hole.png";
        private string solution_dot = @"C:\Users\Paras\Documents\Visual Studio 2010\Projects\MasterMind\MasterMind\Resources\Hole_solution.png";

        public Check()
        {
            rowcheck = false;
        }

        //This function check if each dot in a row has been filled.
        public Boolean check_each_dot_in_row()
        {
            return rowcheck;
        }

        //This function is active when each dot in a row has been filled.
        public void set_rowcheck_active()
        {
            rowcheck = true;
        }

        //This function return the small dot 'right place and color' or 'right color but wrong place' image.
        public string get_row_right_dot(String dotneeded)
        {
            if (dotneeded == "Right_Place")
            {
                return Right_Place;
            }
            else if (dotneeded == "Right_Place_R")
            {
                return Right_Place_R;
            }
            else if (dotneeded == "Right_Color_R")
            {
                return Right_Color_R;
            }
            else
            {
                return Right_Color;
            }
        }

        //This function return the dot image.
        public string set_dot_back(String image)
        {
            if (image == "Hole_solution")
            {
                return solution_dot;
            }
            else
            {
                return standard_dot;
            }
        }
    }
}
