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
using System.Diagnostics;
using System.Threading;

namespace MasterMind
{
    public partial class Form2 : Form
    {
        // Variables used troughout the whole program.
        private PictureBox[] boxes;
        private PictureBox[] dot_boxes;
        private PictureBox[] checkrow_boxes;
        private PictureBox[] checkdot_boxes;
        private String[] user_input;
        private String[] solution_input;
        private String[] user_input2;
        private String[] solution_input2;
        private int current_row;
        private Dot[] dots;
        private String name;
        private Player player;
        private String[] fooArray;
        private Dot dot1;
        private Dot dot2;
        private Dot dot3;
        private Dot dot4;
        private Dot dot5;
        private Dot dot6;
        private Dot dot7;
        private Dot dot8;
        private Dot dot9;
        private Dot dot10;
        private Dot dot11;
        private Dot dot12;
        private Dot dot13;
        private Dot dot14;
        private Dot dot15;
        private Dot dot16;
        private Dot dot17;
        private Dot dot18;
        private Dot dot19;
        private Dot dot20;
        private Dot dot21;
        private Dot dot22;
        private Dot dot23;
        private Dot dot24;
        private Dot dot25;
        private Dot dot26;
        private Dot dot27;
        private Dot dot28;
        private Dot dot29;
        private Dot dot30;
        private Dot dot31;
        private Dot dot32;
        private Dot dot33;
        private Dot dot34;
        private Dot dot35;
        private Dot dot36;
        private Dot dot37;
        private Dot dot38;
        private Dot dot39;
        private Dot dot40;
        private Solution solution;
        private highscore highscore;
        private Check check;
        private int score = 10;
        private String current_color_name;
        private String time;
        Stopwatch stopWatch = new Stopwatch();

        public Form2(String NameInput)
        {
            InitializeComponent();
            highscore = new highscore();
            stopWatch.Start();
            //Make a new solution from the class solution that has to been guess
            solution = new Solution();
            for (int i = 0; i < solution.make_solutions().Length; i++)
            {
                Solution1.Tag = solution.make_solutions()[0];
                Solution2.Tag = solution.make_solutions()[1];
                Solution3.Tag = solution.make_solutions()[2];
                Solution4.Tag = solution.make_solutions()[3];
                //Solution1.Image = Image.FromFile(solution.return_image(Solution1.Tag.ToString()));
                //Solution2.Image = Image.FromFile(solution.return_image(Solution2.Tag.ToString()));
                //Solution3.Image = Image.FromFile(solution.return_image(Solution3.Tag.ToString()));
                //Solution4.Image = Image.FromFile(solution.return_image(Solution4.Tag.ToString()));
            }
            solution_input = new String[] { Solution1.Tag.ToString(), Solution2.Tag.ToString(), Solution3.Tag.ToString(), Solution4.Tag.ToString() };
            solution_input2 = new String[] { Solution1.Tag.ToString(), Solution2.Tag.ToString(), Solution3.Tag.ToString(), Solution4.Tag.ToString() };
            //Send a request to the file called get_highscores_top3.php
            string response = highscore.SendRequest(highscore.return_phpfile("get_highscores_top3.php"));
            current_row = 0;
            //set all labels to the highscore values from get_highscores_top3.php
            if (response != null)
            {
                fooArray = response.Split(',');
                Label[] highscorelabels = new Label[9] { label5, label6, label7, label9, label11, label12, label13, label15, label16 };
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
                }
            }
            else
            {
                MessageBox.Show("Geen connectie met php server");
            }
            NameLabel.Text = NameInput;
            ScoreLabel.Text = score.ToString();
            //set gamescreen width and height based on the size of your computer screen.
            double form_width = (double)this.Width;
            double full_screen_width = (double)Screen.PrimaryScreen.Bounds.Width;
            double resize_width_factor = full_screen_width / form_width;
            double form_height = (double)this.Height;
            double full_screen_height = (double)Screen.PrimaryScreen.Bounds.Height;
            double resize_height_factor = full_screen_height / form_height;
            //set boxes width and height based on the size of your computer screen.
            boxes = new PictureBox[146] { Color1, Color2, Color3, Color4, Color5, Color6, Color7, Color8, Solution1, Solution2, Solution3, Solution4, Check1, Check2, Check3, Check4, Check5, Check6, Check7, Check8, Check9, Check10, Check11, Check12, Check13, Check14, Check15, Check16, Check17, Check18, Check19, Check20, Check21, Check22, Check23, Check24, Check25, Check26, Check27, Check28, Check29, Check30, Check31, Check32, Check33, Check34, Check35, Check36, Check37, Check38, Check39, Check40, Dot1, Dot2, Dot3, Dot4, Dot5, Dot6, Dot7, Dot8, Dot9, Dot10, Dot11, Dot12, Dot13, Dot14, Dot15, Dot16, Dot17, Dot18, Dot19, Dot20, Dot21, Dot22, Dot23, Dot24, Dot25, Dot26, Dot27, Dot28, Dot29, Dot30, Dot31, Dot32, Dot33, Dot34, Dot35, Dot36, Dot37, Dot38, Dot39, Dot40, CheckRow1, CheckRow2, CheckRow3, CheckRow4, CheckRow5, CheckRow6, CheckRow7, CheckRow8, CheckRow9, CheckRow10, pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25, pictureBox26, pictureBox27, pictureBox28, pictureBox29, pictureBox30, pictureBox31, pictureBox32, pictureBox33, pictureBox34, pictureBox35, pictureBox36, pictureBox37, pictureBox38, pictureBox39, pictureBox40, pictureBox41, pictureBox42, current_color, Game_Highscore, Stop };
            for (int i = 0; i < boxes.Length; i++)
            {
                (boxes[i]).Width = (int)(boxes[i].Width * resize_width_factor);
                boxes[i].Height = (int)(boxes[i].Height * resize_height_factor);
                (boxes[i]).Left = (int)(boxes[i].Location.X * resize_width_factor);
                boxes[i].Top = (int)(boxes[i].Location.Y * resize_height_factor);
            }

            dot_boxes = new PictureBox[] { Dot1, Dot2, Dot3, Dot4, Dot5, Dot6, Dot7, Dot8, Dot9, Dot10, Dot11, Dot12, Dot13, Dot14, Dot15, Dot16, Dot17, Dot18, Dot19, Dot20, Dot21, Dot22, Dot23, Dot24, Dot25, Dot26, Dot27, Dot28, Dot29, Dot30, Dot31, Dot32, Dot33, Dot34, Dot35, Dot36, Dot37, Dot38, Dot39, Dot40 };
            dots = new Dot[40] { dot1, dot2, dot3, dot4, dot5, dot6, dot7, dot8, dot9, dot10, dot11, dot12, dot13, dot14, dot15, dot16, dot17, dot18, dot19, dot20, dot21, dot22, dot23, dot24, dot25, dot26, dot27, dot28, dot29, dot30, dot31, dot32, dot33, dot34, dot35, dot36, dot37, dot38, dot39, dot40 };
            checkrow_boxes = new PictureBox[] { CheckRow1, CheckRow2, CheckRow3, CheckRow4, CheckRow5, CheckRow6, CheckRow7, CheckRow8, CheckRow9, CheckRow10 };
            checkdot_boxes = new PictureBox[] { Check1, Check2, Check3, Check4, Check5, Check6, Check7, Check8, Check9, Check10, Check11, Check12, Check13, Check14, Check15, Check16, Check17, Check18, Check19, Check20, Check21, Check22, Check23, Check24, Check25, Check26, Check27, Check28, Check29, Check30, Check31, Check32, Check33, Check34, Check35, Check36, Check37, Check38, Check39, Check40 };
            //Set the first 4 dots active. 
            for (int i = 0; i < dots.Length; i++)
            {
                dots[i] = new Dot(false);
                if (i < 4)
                {
                    dots[i].set_active();
                    dot_boxes[i].Enabled = true;
                    dot_boxes[i].Click += new System.EventHandler(dot_Turn);
                }
            }
            //Set a new eventhandler for the checkrow.
            for (int i = 0; i < checkrow_boxes.Length; i++)
            {
                checkrow_boxes[i].Click += new System.EventHandler(checkRow_Click);
            }
            //Set a new eventhandeler for the color selector. 
            for (int i = 0; i < 8; i++)
            {
                boxes[i].Click += new System.EventHandler(colorSelect_Click);
            }

            //Change fontsize of title's.
            label1.Font = new Font("Arial", 20);

            //Resize the labels based on the size of your computer.
            Label[] labels = new Label[20] { label1, label2, label4, label5, label6, label7, label8, label9, label10, label11, label12, label13, label14, label15, label16, label17, label18, label19, NameLabel, ScoreLabel };
            for (int i = 0; i < labels.Length; i++)
            {
                if (labels[i] == label2 || labels[i] == label4 || labels[i] == label5 || labels[i] == label6 || labels[i] == label7 || labels[i] == label8 || labels[i] == label9 || labels[i] == label10 || labels[i] == label11 || labels[i] == label12 || labels[i] == label13 || labels[i] == label14 || labels[i] == label15 || labels[i] == label16 || labels[i] == NameLabel || labels[i] == ScoreLabel)
                {
                    labels[i].Font = new Font("Arial", 14);
                }
                else if (labels[i] == label17 || labels[i] == label18 || labels[i] == label19)
                {
                    labels[i].Font = new Font("Arial", 15);
                }
                (labels[i]).Width = (int)(labels[i].Width * resize_width_factor);
                labels[i].Height = (int)(labels[i].Height * resize_height_factor);
                (labels[i]).Left = (int)(labels[i].Location.X * resize_width_factor);
                labels[i].Top = (int)(labels[i].Location.Y * resize_height_factor);
            }

            player = new Player("Paras");
        }

        //If you want to stop the game it will ask if you really want to stop with yes and no.
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Weet je zeker dat je wilt stoppen?", "Stoppen", MessageBoxButtons.YesNo); //Approval if they player want to stop
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide(); //Hide form2.
                var form1 = new Form1();
                //Set location of form2 for form1. 
                form1.Left = this.Left;
                form1.Top = this.Top;
                form1.Size = this.Size; //Set size of form2 as for form1.
                form1.Closed += (s, args) => this.Close(); //Close form2.
                form1.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing.
            }
        }

        private void Color1_Click(object sender, EventArgs e)
        {

        }
        //Function to select a color. 
        private void colorSelect_Click(object sender, EventArgs e)
        {
            PictureBox clickedColor = (PictureBox)sender;
            current_color.Visible = true;
            label1.Visible = true;
            //File.Exists
            if (File.Exists(@"C:\Users\Paras\Documents\Visual Studio 2010\Projects\MasterMind\MasterMind\Resources\" + clickedColor.Tag + ".png"))
            {
                current_color.Image = Image.FromFile(@"C:\Users\Paras\Documents\Visual Studio 2010\Projects\MasterMind\MasterMind\Resources\" + clickedColor.Tag + ".png"); //Set current color
            }
            else if (File.Exists(@"C:\Users\Rijk\Documents\Visual Studio 2010\Projects\MasterMind\MasterMind\Resources\" + clickedColor.Tag + ".png"))
            {
                current_color.Image = Image.FromFile(@"C:\Users\Rijk\Documents\Visual Studio 2010\Projects\MasterMind\MasterMind\Resources\" + clickedColor.Tag + ".png"); //Set current color
            }
            current_color_name = clickedColor.Tag.ToString();
            //MessageBox.Show(clickedColor.Tag.ToString());
        }

        private void checkRow_Click(object sender, EventArgs e)
        {
            PictureBox clickedRow = (PictureBox)sender;
            string[] row = clickedRow.Tag.ToString().Split('-');
            int row_start = Int32.Parse(row[0]);
            int row_end = Int32.Parse(row[1]);
            check = new Check();
            int j = row_start;
            user_input = new String[] { dots[row_start].get_color(), dots[row_start + 1].get_color(), dots[row_end - 1].get_color(), dots[row_end].get_color() };
            user_input2 = new String[] { dots[row_start].get_color(), dots[row_start + 1].get_color(), dots[row_end - 1].get_color(), dots[row_end].get_color() };
            //This check if each dot in the current row has been filled.
            if (user_input[0] != "" && user_input[1] != "" && user_input[2] != "" && user_input[3] != "")
            {
                check.set_rowcheck_active();
            }

            if (check.check_each_dot_in_row() == true)
            {
                //This check if the solution has been guessed. The user won the game!!!
                if (user_input[0] == Solution1.Tag && user_input[1] == Solution2.Tag && user_input[2] == Solution3.Tag && user_input[3] == Solution4.Tag)
                {
                    //Set all dot to white.
                    for (int x = row_start; x <= row_end; x++)
                    {
                        if (checkdot_boxes[x].Tag == "")
                        {
                            checkdot_boxes[x].Image = Image.FromFile(check.get_row_right_dot("Right_Place"));
                            checkdot_boxes[x].Tag = "Right_Place";
                        }
                        else if (x < row_end)
                        {
                            x++;
                        }
                    }
                    Solution1.Image = Image.FromFile(solution.return_image(Solution1.Tag.ToString()));
                    Solution2.Image = Image.FromFile(solution.return_image(Solution2.Tag.ToString()));
                    Solution3.Image = Image.FromFile(solution.return_image(Solution3.Tag.ToString()));
                    Solution4.Image = Image.FromFile(solution.return_image(Solution4.Tag.ToString()));
                    //Stop the stopwatch and make it to the format 00:00.
                    stopWatch.Stop();
                    TimeSpan ts = stopWatch.Elapsed; // Get the elapsed time as a TimeSpan value 
                    time = String.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds); // Format and display the TimeSpan value.
                    MessageBox.Show("U heeft gewonnen!!!");
                    //POST the values to get_score.php
                    string URL = highscore.return_phpfile("get_score.php");
                    if (highscore.set_in_database(NameLabel.Text, ScoreLabel.Text, time, URL))
                    {
                        //Set values in database.
                    }
                    else
                    {
                        MessageBox.Show("Geen connectie met php server");
                    }
                    //Make a new solution from the class solution that has to been guess to restart the game.
                    for (int i = 0; i < solution.make_solutions().Length; i++)
                    {
                        Solution1.Tag = solution.make_solutions()[0];
                        Solution2.Tag = solution.make_solutions()[1];
                        Solution3.Tag = solution.make_solutions()[2];
                        Solution4.Tag = solution.make_solutions()[3];
                        Solution1.Image = Image.FromFile(check.set_dot_back(""));
                        Solution2.Image = Image.FromFile(check.set_dot_back(""));
                        Solution3.Image = Image.FromFile(check.set_dot_back(""));
                        Solution4.Image = Image.FromFile(check.set_dot_back(""));
                    }
                    //Set all to normal as in the beginning.
                    solution_input = new String[] { Solution1.Tag.ToString(), Solution2.Tag.ToString(), Solution3.Tag.ToString(), Solution4.Tag.ToString() };
                    solution_input2 = new String[] { Solution1.Tag.ToString(), Solution2.Tag.ToString(), Solution3.Tag.ToString(), Solution4.Tag.ToString() };
                    current_row = 0;
                    score = 10;
                    ScoreLabel.Text = score.ToString();
                    stopWatch.Restart();
                    for (int i = 0; i <= checkrow_boxes.Length - 1; i++)
                    {
                        if (i == 0)
                        {
                            checkrow_boxes[i].Enabled = true;
                            checkrow_boxes[i].Visible = true;
                        }
                        else
                        {
                            checkrow_boxes[i].Enabled = false;
                            checkrow_boxes[i].Visible = false;
                        }
                    }
                    for (int i = 0; i <= dot_boxes.Length - 1; i++)
                    {
                        if (i <= 3)
                        {
                            dot_boxes[i].Enabled = true;
                        }
                        else
                        {
                            dot_boxes[i].Enabled = false;
                        }
                        checkdot_boxes[i].Image = Image.FromFile(check.set_dot_back(""));
                        checkdot_boxes[i].Tag = "";
                        dot_boxes[i].Image = Image.FromFile(check.set_dot_back(""));
                        dot_boxes[i].Tag = "";
                        dots[i].set_color("");
                    }
                    //Send a request to the file called get_highscores_top3.php
                    string response = highscore.SendRequest(highscore.return_phpfile("get_highscores_top3.php"));
                    current_row = 0;
                    //set all labels to the highscore values from get_highscores_top3.php
                    if (response != null)
                    {
                        fooArray = response.Split(',');
                        Label[] highscorelabels = new Label[9] { label5, label6, label7, label9, label11, label12, label13, label15, label16 };
                        int highscoreresult = fooArray.Length;
                        for (int p = 0; p < highscorelabels.Length; p++)
                        {
                            if (p < highscoreresult)
                            {
                                highscorelabels[p].Text = fooArray[p].ToString();
                            }
                            else
                            {
                                highscorelabels[p].Text = "";
                            }
                        }
                        //MessageBox.Show(response, "Hey there!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    user_input = user_input2;
                    solution_input = solution_input2;
                    score = score - 1;
                    ScoreLabel.Text = score.ToString();
                    for (int i = 0; i < solution_input.Length; i++)
                    {
                        //MessageBox.Show(user_input[i]);
                        //MessageBox.Show("solution:" + solution_input[i]);
                        if (!string.IsNullOrWhiteSpace(solution_input[i]))
                        {
                            if (solution_input[i] == user_input[i])
                            {
                                for (int a = row_start; a <= row_end; a++)
                                {
                                    if (checkdot_boxes[a].Tag == "")
                                    {
                                        checkdot_boxes[a].Image = Image.FromFile(check.get_row_right_dot("Right_Place"));
                                        checkdot_boxes[a].Tag = "Right_Place";
                                        break;
                                    }
                                }
                                user_input = solution.removeEntry(user_input, i);
                                solution_input = solution.removeEntry(solution_input, i);
                            }
                        }
                    }
                    for (int i = 0; i < solution_input.Length; i++)
			        {
			            for (int x = 0; x < user_input.Length; x++)
			            {
                            if (!string.IsNullOrWhiteSpace(solution_input[i]))
                            {
                                if (solution_input[i] == user_input[x])
                                {
                                
                                    for (int a = row_start; a <= row_end; a++)
                                    {
                                        if (checkdot_boxes[a].Tag == "")
                                        {
                                            checkdot_boxes[a].Image = Image.FromFile(check.get_row_right_dot("Right_Color"));
                                            checkdot_boxes[a].Tag = "Right_Color";
                                            break;
                                        }
                                    }
                                    solution_input = solution.removeEntry(solution_input, i);
                                    user_input = solution.removeEntry(user_input, x);
                                }
                            }
			            }
			        }
                    for (int i = row_start; i <= row_end; i++)
                    {
                        //Reset the dots. 
                        dot_boxes[i].Enabled = false;
                        if ((i + 4) <= 39)
                        {
                            dot_boxes[i + 4].Enabled = true;
                            dot_boxes[i + 4].Click += new System.EventHandler(dot_Turn);
                        }
                    }
                    if (current_row < 9)
                    {
                        checkrow_boxes[current_row].Enabled = false;
                        checkrow_boxes[current_row].Visible = false;
                        current_row++;
                        checkrow_boxes[current_row].Enabled = true;
                        checkrow_boxes[current_row].Visible = true;
                    }
                    else
                    {
                        Solution1.Image = Image.FromFile(solution.return_image(Solution1.Tag.ToString()));
                        Solution2.Image = Image.FromFile(solution.return_image(Solution2.Tag.ToString()));
                        Solution3.Image = Image.FromFile(solution.return_image(Solution3.Tag.ToString()));
                        Solution4.Image = Image.FromFile(solution.return_image(Solution4.Tag.ToString()));
                        stopWatch.Stop();
                        MessageBox.Show("U heeft het helaas niet geraden!!!");
                        //Make a new solution from the class solution that has to been guess to restart the game.
                        for (int i = 0; i < solution.make_solutions().Length; i++)
                        {
                            Solution1.Tag = solution.make_solutions()[0];
                            Solution2.Tag = solution.make_solutions()[1];
                            Solution3.Tag = solution.make_solutions()[2];
                            Solution4.Tag = solution.make_solutions()[3];
                            Solution1.Image = Image.FromFile(check.set_dot_back(""));
                            Solution2.Image = Image.FromFile(check.set_dot_back(""));
                            Solution3.Image = Image.FromFile(check.set_dot_back(""));
                            Solution4.Image = Image.FromFile(check.set_dot_back(""));
                        }
                        solution_input = new String[] { Solution1.Tag.ToString(), Solution2.Tag.ToString(), Solution3.Tag.ToString(), Solution4.Tag.ToString() };
                        solution_input2 = new String[] { Solution1.Tag.ToString(), Solution2.Tag.ToString(), Solution3.Tag.ToString(), Solution4.Tag.ToString() };
                        //Set all to normal as in the beginning.
                        current_row = 0;
                        score = 10;
                        ScoreLabel.Text = score.ToString();
                        stopWatch.Restart();
                        for (int i = 0; i <= checkrow_boxes.Length - 1; i++)
                        {
                            if (i == 0)
                            {
                                checkrow_boxes[i].Enabled = true;
                                checkrow_boxes[i].Visible = true;
                            }
                            else
                            {
                                checkrow_boxes[i].Enabled = false;
                                checkrow_boxes[i].Visible = false;
                            }
                        }
                        for (int i = 0; i <= dot_boxes.Length - 1; i++)
                        {
                            if (i <= 3)
                            {
                                dot_boxes[i].Enabled = true;
                            }
                            else
                            {
                                dot_boxes[i].Enabled = false;
                            }
                            checkdot_boxes[i].Image = Image.FromFile(check.set_dot_back(""));
                            checkdot_boxes[i].Tag = "";
                            dot_boxes[i].Image = Image.FromFile(check.set_dot_back(""));
                            dot_boxes[i].Tag = "";
                            dots[i].set_color("");
                        }
                        //Send a request to the file called get_highscores_top3.php
                        string response = highscore.SendRequest(highscore.return_phpfile("get_highscores_top3.php"));
                        current_row = 0;
                        //set all labels to the highscore values from get_highscores_top3.php
                        if (response != null)
                        {
                            fooArray = response.Split(',');
                            Label[] highscorelabels = new Label[9] { label5, label6, label7, label9, label11, label12, label13, label15, label16 };
                            int highscoreresult = fooArray.Length;
                            for (int p = 0; p < highscorelabels.Length; p++)
                            {
                                if (p < highscoreresult)
                                {
                                    highscorelabels[p].Text = fooArray[p].ToString();
                                }
                                else
                                {
                                    highscorelabels[p].Text = "";
                                }
                            }
                            //MessageBox.Show(response, "Hey there!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("vul de rij volledig in!");
            }


        }
        //This function  sets the color of a dot to the current selected color.
        private void dot_Turn(object sender, EventArgs e)
        {
            if (current_color.Visible == true)
            {
                PictureBox clickedDot = (PictureBox)sender;
                clickedDot.Image = current_color.Image;
                int index = Array.IndexOf(dot_boxes, sender);
                dots[index].set_color(current_color_name);
            }
            else
            {
                MessageBox.Show("Selecteer alstublieft een kleur!");
            }
        }
    }
}
