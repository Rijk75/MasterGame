using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Threading.Tasks;
using Mastermind;
using System.Collections.Specialized;
using System.Net;
using System.IO;

namespace MasterMind
{
    public partial class Form4 : Form
    {
        // Variables used troughout the whole program.
        private PictureBox[] boxes;

        public Form4()
        {
            InitializeComponent();
            //set gamescreen width and height based on the size of your computer screen.
            double form_width = (double)this.Width;
            double full_screen_width = (double)Screen.PrimaryScreen.Bounds.Width;
            double resize_width_factor = full_screen_width / form_width;
            double form_height = (double)this.Height;
            double full_screen_height = (double)Screen.PrimaryScreen.Bounds.Height;
            double resize_height_factor = full_screen_height / form_height;
            //set boxes width and height based on the size of your computer screen.
            boxes = new PictureBox[1] { pictureBox1};
            for (int i = 0; i < boxes.Length; i++)
            {
                (boxes[i]).Width = (int)(boxes[i].Width * resize_width_factor);
                boxes[i].Height = (int)(boxes[i].Height * resize_height_factor);
                (boxes[i]).Left = (int)(boxes[i].Location.X * resize_width_factor);
                boxes[i].Top = (int)(boxes[i].Location.Y * resize_height_factor);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide(); //Hide form4.
            var form1 = new Form1();
            //Set location of form4 for form1. 
            form1.Left = this.Left;
            form1.Top = this.Top;
            form1.Size = this.Size; //Set size of form4 as for form1.
            form1.Closed += (s, args) => this.Close(); //close form4.
            form1.Show();
        }
    }
}
