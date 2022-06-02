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
            checkTheWinner();
        }
        private void checkTheWinner()
        {
            bool you_win = false;
            //horizontal
            if ((btnA1.Text == btnA2.Text) && (btnA2.Text == btnA3.Text) && (!btnA1.Enabled))
                you_win = true;
            else if ((btnB1.Text == btnB2.Text) && (btnB2.Text == btnB3.Text) && (!btnB1.Enabled))
                you_win = true;
            else if ((btnC1.Text == btnC2.Text) && (btnC2.Text == btnC3.Text) && (!btnC1.Enabled))
                you_win = true;

            //vertical
            if ((btnA1.Text == btnB3.Text) && (btnB3.Text == btnC3.Text) && (!btnA1.Enabled))
                you_win = true;
            else if ((btnA2.Text == btnB2.Text) && (btnB2.Text == btnC2.Text) && (!btnA2.Enabled))
                you_win = true;
            else if ((btnA3.Text == btnB1.Text) && (btnB1.Text == btnC1.Text) && (!btnA3.Enabled))
                you_win = true;

            //diagonal
            if ((btnA1.Text == btnB2.Text) && (btnB2.Text == btnC1.Text) && (!btnA1.Enabled))
                you_win = true;
            else if ((btnA3.Text == btnB2.Text) && (btnB2.Text == btnC3.Text) && (!btnC3.Enabled))
                you_win = true;

            if (you_win)
            {

                string winner = "YOU WIN";
                if (turn)
                    winner = "O";
                else
                    winner = "X";

            }
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
        private void btnB2_Click(object sender, EventArgs e)
        {
            Button btnB2 = (Button)sender;

            if (turn)
                btnB2.Text = "X";
            else
                btnB2.Text = "O";

            turn = !turn;
            btnB2.Enabled = false;
            turn_count++;
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
        private void btnC1_Click(object sender, EventArgs e)
        {
            Button btnC1 = (Button)sender;

            if (turn)
                btnC1.Text = "X";
            else
                btnC1.Text = "O";

            turn = !turn;
            btnC1.Enabled = false;
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
        private void btnC3_Click(object sender, EventArgs e)
        {
            Button btnB2 = (Button)sender;

            if (turn)
                btnC3.Text = "X";
            else
                btnC3.Text = "O";

            turn = !turn;
            btnC3.Enabled = false;
            turn_count++;
        }
        private void title_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void newGameBtn_Click(object sender, EventArgs e)
        {

        }

        private void helpBtn_Click(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
