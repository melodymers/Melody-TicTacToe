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

                string winner = "";
                if (turn)
                    winner = "PLAYER O, ";
                else
                    winner = "PLAYER X, ";

                MessageBox.Show(winner + "YOU WIN!");
                btnA1.Enabled = false;
                newGameBtn.Enabled = true;
                helpBtn.Enabled = true;
                ExitBtn.Enabled = true;
            }
            else
            {
                if (turn_count == 9)
                    MessageBox.Show("Draw!");
                btnA1.Enabled = false;
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
                    btnA1.Text = "";
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

                string winner = "YOU WIN";
                if (turn)
                    winner = "PLAYER O, ";
                else
                    winner = "PLAYER X, ";

                MessageBox.Show(winner + "YOU WIN!");
                btnA2.Enabled = false;
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

                string winner = "YOU WIN";
                if (turn)
                    winner = "PLAYER O, ";
                else
                    winner = "PLAYER X, ";

                MessageBox.Show(winner + "YOU WIN!");
                btnA3.Enabled = false;
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
        private void btnB1_Click_1(object sender, EventArgs e)
        {
            Button btnB1 = (Button)sender;

            if (turn)
                btnB1.Text = "X";
            else
                btnB1.Text = "O";

            turn = !turn;
            btnB1.Enabled = false;
            turn_count++;
            WinnerCheck();
        }
        private void WinnerCheck()
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
                    winner = "PLAYER O, ";
                else
                    winner = "PLAYER X, ";

                MessageBox.Show(winner + "YOU WIN!");
                btnB1.Enabled = false;
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
        private void ButtonsB1()
        {
            try
            {
                foreach (Control x in Controls)
                {
                    Button btnB1 = (Button)x;
                    btnB1.Enabled = false;
                }
            }
            catch { }
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
            WinnerChecked();
        }
        private void WinnerChecked()
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
                    winner = "PLAYER O, ";
                else
                    winner = "PLAYER X, ";

                MessageBox.Show(winner + "YOU WIN!");
                btnB1.Enabled = false;
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
        private void ButtonsB2()
        {
            try
            {
                foreach (Control x in Controls)
                {
                    Button btnB2 = (Button)x;
                    btnB2.Enabled = false;
                }
            }
            catch { }
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
            checkwinner();
        }
        private void checkwinner()
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
                    winner = "PLAYER O, ";
                else
                    winner = "PLAYER X, ";

                MessageBox.Show(winner + "YOU WIN!");
                btnB1.Enabled = false;
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
        private void ButtonsB3()
        {
            try
            {
                foreach (Control x in Controls)
                {
                    Button btnB3 = (Button)x;
                    btnB3.Enabled = false;
                }
            }
            catch { }
        }
        private void btnC1_Click(object sender, EventArgs e)
        {
            Button btnB3 = (Button)sender;

            if (turn)
                btnC1.Text = "X";
            else
                btnC1.Text = "O";

            turn = !turn;
            btnC1.Enabled = false;
            turn_count++;
            checkingwinner();
        }
        private void checkingwinner()
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
                    winner = "PLAYER O, ";
                else
                    winner = "PLAYER X, ";

                MessageBox.Show(winner + "YOU WIN!");
                btnB1.Enabled = false;
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
        private void ButtonsC1()
        {
            try
            {
                foreach (Control x in Controls)
                {
                    Button btnC1 = (Button)x;
                    btnC1.Enabled = false;
                }
            }
            catch { }
        }
        private void HelpBtn_Click(object sender, EventArgs e)
        {
            helpBtn.Visible = false;
            MessageBox.Show("-Decide on who will tick a box first .\n" + "-Players will take turn ticking X and O to their chosen boxes.\n" +
                "-The first player who completes a 3 in a row, column, diagonal pattern will be the game's winner. ");
        }
        private void ExitBtn_Click_1(object sender, EventArgs e)
        {
            {
                ExitBtn.Visible = false;
                Environment.Exit(0);
            }
        }

        private void newGameBtn_Click_1(object sender, EventArgs e)
        {
            newGameBtn.Visible = false;
            Application.Restart();
            Environment.Exit(0);
        }
    }
}
    
    