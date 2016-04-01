using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MasterMind
{
    public partial class Form1 : Form
    {
        // Variables used troughout the whole program.
        private PictureBox[] boxes;

        public Form1()
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
            boxes = new PictureBox[5] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5};
            for (int i = 0; i < boxes.Length; i++)
            {
                (boxes[i]).Width = (int)(boxes[i].Width * resize_width_factor);
                boxes[i].Height = (int)(boxes[i].Height * resize_height_factor);
                (boxes[i]).Left = (int)(boxes[i].Location.X * resize_width_factor);
                boxes[i].Top = (int)(boxes[i].Location.Y * resize_height_factor);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var AskName = new Name();
            AskName.ShowDialog();
            this.Hide(); //Hide form1.
            var form2 = new Form2(AskName.TheValue);
            //Set location of form1 for form2. 
            form2.Left = this.Left;
            form2.Top = this.Top;
            form2.Size = this.Size; //Set size of form1 as for form2.
            form2.Closed += (s, args) => this.Close(); //close form1.
            form2.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide(); //Hide form1.
            var form3 = new Form3();
            //Set location of form1 for form3. 
            form3.Left = this.Left;
            form3.Top = this.Top;
            form3.Size = this.Size; //Set size of form1 as for form3.
            form3.Closed += (s, args) => this.Close(); //close form1.
            form3.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide(); //Hide form4.
            var form4 = new Form4();
            //Set location of form1 for form4. 
            form4.Left = this.Left;
            form4.Top = this.Top;
            form4.Size = this.Size; //Set size of form1 as for form4.
            form4.Closed += (s, args) => this.Close(); //close form1.
            form4.Show();
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
