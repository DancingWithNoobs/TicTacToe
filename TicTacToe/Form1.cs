using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool turnIndicator = false; // false == X ; true == O
        int turnCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tic Tac Toe\n\r2016\r\nBy Muszyński Paweł", "About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turnCount = 0;
            turnIndicator = false;

            foreach (Control item in Controls)
            {
                if (item is Button)
                {
                    item.Enabled = true;
                    item.Text = "";
                }
            }
        }

        private void button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            turnCount++;

            button.Enabled = false;

            if (turnIndicator) // if player O has clicked
            {
                button.Text = "O";
            }
            else // if player X has clicked
            {
                button.Text = "X";
            }
            if (CheckForWinners()) // If someone won
            {
                foreach (Control item in Controls)
                {
                    if (item is Button)
                    {
                        item.Enabled = false;
                    }
                }
                if (turnIndicator) // If Player O won
                {
                    MessageBox.Show("Player O won!", "Won!");
                }
                else // If player X won
                {
                    MessageBox.Show("Player X won!", "Won!");
                }
            }
            else if (turnCount == 9) // Draw
            {
                MessageBox.Show("Draw!", "Draw");
            }

            turnIndicator = !turnIndicator;
        }
        private bool CheckForWinners()
        {
            if (A1Button.Text == A2Button.Text && A2Button.Text == A3Button.Text && !A1Button.Enabled)
            {
                return true;
            }
            else if (B1Button.Text == B2Button.Text && B2Button.Text == B3Button.Text && !B1Button.Enabled)
            {
                return true;
            }
            else if (C1Button.Text == C2Button.Text && C2Button.Text == C3Button.Text && !C1Button.Enabled)
            {
                return true;
            }

            else if (A1Button.Text == B1Button.Text && B1Button.Text == C1Button.Text && !A1Button.Enabled)
            {
                return true;
            }
            else if (A2Button.Text == B2Button.Text && B2Button.Text == C2Button.Text && !A2Button.Enabled)
            {
                return true;
            }
            else if (A3Button.Text == B3Button.Text && B3Button.Text == C3Button.Text && !A3Button.Enabled)
            {
                return true;
            }

            else if (A1Button.Text == B2Button.Text && B2Button.Text == C3Button.Text && !A1Button.Enabled)
            {
                return true;
            }
            else if (C1Button.Text == B2Button.Text && B2Button.Text == A3Button.Text && !C1Button.Enabled)
            {
                return true;
            }

            return false;
        }
    }
}
