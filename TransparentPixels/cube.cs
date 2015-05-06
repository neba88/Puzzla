using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransparentPixels
{
    class cube
    {
        Rectangle Cube = new Rectangle(600, 25, 200, 200);
        public void Cube_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush cetka1 = new SolidBrush(Color.DodgerBlue);
            e.Graphics.FillRectangle(cetka1, Cube);
        }
      
    }
}
