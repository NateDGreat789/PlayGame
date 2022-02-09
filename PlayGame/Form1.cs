using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace PlayGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void playbutton_Click(object sender, EventArgs e)
        {
            playbutton.Text = "GAME STARTING IN";

            Refresh();
            Thread.Sleep(1000);

            gamestartingtext.Text = "3...";

            Refresh();
            Thread.Sleep(1000);

            gamestartingtext.Text = "2...";

            Refresh();
            Thread.Sleep(1000);

            gamestartingtext.Text = "1...";

            Refresh();
            Thread.Sleep(1000);

            gamestartingtext.Location = new Point(94, 180);
            gamestartingtext.Text = "GO!";
            playbutton.Visible = false;
            this.BackColor = Color.Green;

        }
    }
}
