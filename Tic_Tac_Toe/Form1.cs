using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        bool turn = true;
        int turn_count =0;
        public Form1()
        {
            InitializeComponent();
        }

        private void creatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creator: Rifat Hossain\nit is a open sourse practice progrum so, dont judge this or compare this with other deveoper's work", "Tic Tac Toe");
        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Creator: Rifat Hossain \nE-mail: rifathossain328663@gmai.com");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn) { 


            b.Text = "X";
        }
            else { b.Text = "O"; }
            
           
                turn = !turn;
            b.Enabled = false;
            turn_count++;
            CheckForWinner();
            
            

        }
       private void CheckForWinner()
        {
            bool Winner = false;
            //horizontal checking
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                Winner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                Winner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                Winner = true;
            //vertical checking
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                Winner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                Winner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                Winner = true;
            //diagonal checking
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                Winner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
                Winner = true;

            if (Winner)
            {
                disableButton();
                string realWinner = "";
                if (turn)
                    realWinner = "O";
                else
                    realWinner = "X";

                    MessageBox.Show(realWinner+" Wins"," \tYOOO ");

            }
            else
            {
                if (turn_count == 9)
                {
                    MessageBox.Show("It was a Draw", "Bummer");
                }
            }

        }

        private void disableButton()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }
           
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
            }
            catch { }
        }

        
    }
}
