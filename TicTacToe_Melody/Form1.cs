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
            {
                you_win = true;
            }
            else if ((btnA3.Text == btnB2.Text) && (btnB2.Text == btnC3.Text) && (!btnC3.Enabled))
                you_win = true;

            if (you_win)
            {
                btnA1.Enabled = false;

                string winner = "YOU WIN";
                if (turn)
                    winner = "O";
                else
                    winner = "X";

                MessageBox.Show(winner + "YOU WIN!");
                newGameBtn.Enabled = true;
                helpBtn.Enabled = true;
                ExitBtn.Enabled = true;
            }
            else
            {
                if (turn_count == 9)
                    MessageBox.Show("Draw!");
                newGameBtn.Enabled = true;
                helpBtn.Enabled = true;
                ExitBtn.Enabled = true;
            }
        }
        private void disableButtons()
        {
            try
            {
                foreach (Control x in Controls)
                {
                    Button btnA1 = (Button)x;
                    btnA1.Enabled = false;
                }
            }
            catch { }
        }

        private void BtnA1_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            try
            {
                foreach (Control c in Controls)
                {
                    Button btnA1 = (Button)c;
                    btnA1.Enabled = true;
                    btnA1.Text = "sheesh";
                }
            }
            catch { }
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
            CheckTheWinner();
        }
        private void CheckTheWinner()
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
                btnA2.Enabled = false;

                string winner = "YOU WIN";
                if (turn)
                    winner = "O";
                else
                    winner = "X";

                MessageBox.Show(winner + "YOU WIN!");
                newGameBtn.Enabled = true;
                helpBtn.Enabled = true;
                ExitBtn.Enabled = true;
            }
            else
            {
                if (turn_count == 9)
                    MessageBox.Show("Draw!");
                newGameBtn.Enabled = true;
                helpBtn.Enabled = true;
                ExitBtn.Enabled = true;
            }
        }
        private void DisableButtons()
        {
            try
            {
                foreach (Control x in Controls)
                {
                    Button btnA2 = (Button)x;
                    btnA2.Enabled = false;
                }
            }
            catch { }
        }
        private void btnA3_Click_1(object sender, EventArgs e)
        {
            Button btnA3 = (Button)sender;

            if (turn)
                btnA3.Text = "X";
            else
                btnA3.Text = "O";

            turn = !turn;
            btnA3.Enabled = false;
            turn_count++;
            WinCheck();
        }
        private void WinCheck()
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
                btnA3.Enabled = false;

                string winner = "YOU WIN";
                if (turn)
                    winner = "O";
                else
                    winner = "X";

                MessageBox.Show(winner + "YOU WIN!");
                newGameBtn.Enabled = true;
                helpBtn.Enabled = true;
                ExitBtn.Enabled = true;
            }
            else
            {
                if (turn_count == 9)
                    MessageBox.Show("Draw!");
                newGameBtn.Enabled = true;
                helpBtn.Enabled = true;
                ExitBtn.Enabled = true;
            }
        }
        private void Buttons()
        {
            try
            {
                foreach (Control x in Controls)
                {
                    Button btnA3 = (Button)x;
                    btnA3.Enabled = false;
                }
            }
            catch { }
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. The first player are X, the next player is O.\n" + "Players take turns putting their marks in empty squares.\n" +
                "2. The first player to get 3 of her marks in a row (up, down, across, or diagonally) is the winner. ");
        }
        private void newGameBtn_Click(object sender, EventArgs e)
        {
            newGameBtn.Visible = false;
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            ExitBtn.Visible = false;
        }
    }
}
