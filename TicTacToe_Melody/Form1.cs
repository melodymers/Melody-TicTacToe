using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_Melody
{
    public partial class TicTacToe : Form
    {
        bool turn = true;
        int turn_count = 0;
        public TicTacToe()
        {
            InitializeComponent();
        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {

        }

        private void btnB1_Click(object sender, EventArgs e)
        {
            Button btnB1 = (Button)sender;

            if (turn)
                btnB1.Text = "X";
            else
                btnB1.Text = "O";

            turn = !turn;
            btnB1.Enabled = false;
            turn_count++;

  


        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            Button btnC2 = (Button)sender;

            if (turn)
                btnC2.Text = "X";
            else
                btnC2.Text = "O";

            turn = !turn;
            btnC2.Enabled = false;
            turn_count++;
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnA1_Click(object sender, EventArgs e)
        {
            Button btnA1 = (Button)sender;

            if (turn)
                btnA1.Text = "X";
            else
                btnA1.Text = "O";

            turn = !turn;
            btnA1.Enabled = false;
            turn_count++;

        }

        private void btnA2_Click(object sender, EventArgs e)
        {
            Button btnA2 = (Button)sender;

            if (turn)
                btnA2.Text = "X";
            else
                btnA2.Text = "O";

            turn = !turn;
            btnA2.Enabled = false;
            turn_count++;
        }

        private void btnA3_Click(object sender, EventArgs e)
        {
            Button btnA3 = (Button)sender;

            if (turn)
                btnA3.Text = "X";
            else
                btnA3.Text = "O";

            turn = !turn;
            btnA3.Enabled = false;
            turn_count++;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void newGameBtn_Click(object sender, EventArgs e)
        {

        }

        private void helpBtn_Click(object sender, EventArgs e)
        {

        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            Button btnB3 = (Button)sender;

            if (turn)
                btnB3.Text = "X";
            else
                btnB3.Text = "O";

            turn = !turn;
            btnB3.Enabled = false;
            turn_count++;
        }
    }
}
