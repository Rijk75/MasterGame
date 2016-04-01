using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasterMind
{
    class Solution
    {
        //Make empty variables to use in the whole class.
        private String[] solution;
        private String[] possible;
        private String tmp;
        Random random = new Random();  

        //This function make an array called solution with random values of the array 'possible'.
        public String[] make_solutions()
        {
            possible = new String[] { "dblauw", "geel", "groen", "lblauw", "orange", "paars", "rood", "rozepdn" };
            solution = new String[4] { "", "", "", "" };
            for (int i = 0; i < 4; i++)
            {
                int index = random.Next(0, possible.Length);
                var name = possible[index];
                solution[i] = name;
            }

            return solution;
        }

        public String[] removeEntry(String[] array, int entry)
        {
            // Use a temporary array
            String[] tmp = new String[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                // Only add the ones that are NOT the unwanted entry to tmp
                if (i != entry)
                {
                    tmp[i] = array[i];
                }
            }
            // Replace filter by the temporary array
            return tmp;
        }

        //This function return the image that you want to use.
        public String return_image(String image)
        {
            return @"C:\Users\Paras\Documents\Visual Studio 2010\Projects\MasterMind\MasterMind\Resources\" + image + ".png";
        }
    }
}
