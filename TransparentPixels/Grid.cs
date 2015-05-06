using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransparentPixels
{
    class Grid
    {
        int[] grid;
        public static int GRID_SIZE = 4;
        // constructor
        Grid()
        {
            grid = new int[GRID_SIZE * GRID_SIZE];
            // ako ti treba element naces ga sa x + (n * y)
        }

        void setValueForElement(int value, int x, int y)
        {
            grid[x + (y * GRID_SIZE)] = value;
        }
    } // end grid
}
