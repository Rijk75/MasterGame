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
    public partial class Form3 : Form
    {
        // Variables used troughout the whole program.
        private PictureBox[] boxes;
        private String[] fooArray;
        private highscore highscore;

        public Form3()
        {
            InitializeComponent();
            highscore = new highscore();
            //set gamescreen width and height based on the size of your computer screen.
            double form_width = (double)this.Width;
            double full_screen_width = (double)Screen.PrimaryScreen.Bounds.Width;
            double resize_width_factor = full_screen_width / form_width;
            double form_height = (double)this.Height;
            double full_screen_height = (double)Screen.PrimaryScreen.Bounds.Height;
            double resize_height_factor = full_screen_height / form_height;
            //Send a request to the file called get_highscores_top7.php
            string response = highscore.SendRequest(highscore.return_phpfile("get_highscores_top7.php"));
            //set all labels to the highscore values from get_highscores_top7.php
            if (response != null)
            {
                fooArray = response.Split(',');
                Label[] highscorelabels = new Label[21] { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label11, label12, label13, label14, label15, label16, label17, label18, label19, label20, label21 };
                int highscoreresult = fooArray.Length;
                for (int j = 0; j < highscorelabels.Length; j++)
                {
                    if (j < highscoreresult)
                    {
                        highscorelabels[j].Text = fooArray[j].ToString();
                    }
                    else
                    {
                        highscorelabels[j].Text = "";
                    }
                    //set highscorelabel width and height based on the size of your computer screen and the font on 14.
                    highscorelabels[j].Font = new Font("Arial", 14);
                    (highscorelabels[j]).Width = (int)(highscorelabels[j].Width * resize_width_factor);
                    highscorelabels[j].Height = (int)(highscorelabels[j].Height * resize_height_factor);
                    (highscorelabels[j]).Left = (int)(highscorelabels[j].Location.X * resize_width_factor);
                    highscorelabels[j].Top = (int)(highscorelabels[j].Location.Y * resize_height_factor);
                }
                //MessageBox.Show(response, "Hey there!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //set boxes width and height based on the size of your computer screen.
            boxes = new PictureBox[1] { pictureBox1 };
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
            this.Hide(); //Hide form3.
            var form1 = new Form1();
            //Set location of form3 for form1. 
            form1.Left = this.Left;
            form1.Top = this.Top;
            form1.Size = this.Size; //Set size of form3 as for form1.
            form1.Closed += (s, args) => this.Close(); //close form3.
            form1.Show();
        }
    }
}
