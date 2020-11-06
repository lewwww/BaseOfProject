using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Forms
{
    public partial class Form1 : Form
    {
        Bitmap OutputBitmap = new Bitmap(640, 480);
        Canvas MyCanvas;
        public Form1()
        {
            InitializeComponent();
            MyCanvas = new Canvas(Graphics.FromImage(OutputBitmap));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine("key down");
            String Command = ProgramWindow.Text.Trim().ToLower();
            if (e.KeyCode == Keys.Enter)
                
            {
                if (Command.Equals("square") == true)
                {
                    MyCanvas.DrawSquare(40);
                }
                else if (Command.Equals("line") == true)
                {
                    MyCanvas.DrawLine(160, 120);
                    Console.WriteLine("Line");
                }
                ProgramWindow.Text = "";
                Refresh();
                    Console.WriteLine("ENTER PRESSED");
            }
        }

        private void DrawingBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImageUnscaled(OutputBitmap, 0, 0);
        }
    }
}
