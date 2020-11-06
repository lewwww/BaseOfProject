  using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Forms
{
    class Canvas
    {

        Graphics g;
        Pen Pen;
        int xPos, yPos;

        public Canvas(Graphics g)
        {
            this.g = g;
            xPos = yPos = 0;
            Pen = new Pen(Color.Black, 1);
        }

        public void DrawSquare(int size)
        {
            g.DrawRectangle(Pen, xPos, yPos, xPos + size, yPos + size);
        }

        public void DrawLine(int toX, int toY)
        {
            g.DrawLine(Pen, xPos, yPos, toX, toY);
            xPos = toX;
            yPos = toY;

        }

    }
}
