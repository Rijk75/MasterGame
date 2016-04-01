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
    public partial class Name : Form
    {
        public Name()
        {
            InitializeComponent();
            this.ControlBox = false;
            label1.Font = new Font("Arial", 28);
        }

        //This will return the filled name to form2.
        public string TheValue
        {
            get { return NameInput.Text; }
        }

        //When button1 is clicked it will check if you have written something else it will show an error.
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameInput.Text))
            {
                MessageBox.Show("Vul uw naam in!");
            }
            else
            {
                this.Close();
            }
        }

        //You can press the button enter to submit the form.
        private void NameInput_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click_1(this, new EventArgs());
            }
        }
    }
}
