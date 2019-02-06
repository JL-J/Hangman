﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class lives : Form
    {
        public lives()
        {
            InitializeComponent();
        }

        string word = "pot";
        int livesRemaining = 10;
        string currentDisplay = "***";
        string guess = String.Empty; 

        private void TakeTurn(string guess)
        {
            GuessWord(guess);
            UpdateLives();
            HasWon();
        }

        private void GuessWord(string letter)
        {
            if (word.Contains(letter))
            {
                int index = word.IndexOf(letter);
                StringBuilder updateDisplay = new StringBuilder(currentDisplay);
                updateDisplay[index] = Convert.ToChar(letter);
                currentDisplay = updateDisplay.ToString();
                display.Text = currentDisplay;
            }
        }

        private void UpdateLives()
        {
            livesRemaining -= 1;
            textBox1.Text = livesRemaining.ToString();

            if (livesRemaining == 0)
            {
                MessageBox.Show("You lose!!");
            }
        }

        private void HasWon()
        {
            if (!currentDisplay.Contains("*"))
            {
                MessageBox.Show("You've won!! Congratulations");
            }
        }

        private void a_Click(object sender, EventArgs e)
        {
            guess = a.Text;
            TakeTurn(guess);
        }

        private void b_Click(object sender, EventArgs e)
        {
            guess = b.Text;
            TakeTurn(guess);
        }

        private void c_Click(object sender, EventArgs e)
        {
            guess = c.Text;
            TakeTurn(guess); ;
        }

        private void d_Click(object sender, EventArgs e)
        {
            guess = d.Text;
            TakeTurn(guess);
        }

        private void e_Click(object sender, EventArgs e)
        {
            guess = "e";
            TakeTurn(guess);
        }

        private void f_Click(object sender, EventArgs e)
        {
            guess = f.Text;
            TakeTurn(guess);
        }

        private void g_Click(object sender, EventArgs e)
        {
            guess = g.Text;
            TakeTurn(guess);
        }

        private void h_Click(object sender, EventArgs e)
        {
            guess = h.Text;
            TakeTurn(guess);
        }

        private void i_Click(object sender, EventArgs e)
        {
            guess = i.Text;
            TakeTurn(guess);
        }

        private void j_Click(object sender, EventArgs e)
        {
            guess = j.Text;
            TakeTurn(guess);
        }

        private void k_Click(object sender, EventArgs e)
        {
            guess = k.Text;
            TakeTurn(guess);
        }

        private void l_Click(object sender, EventArgs e)
        {
            guess = l.Text;
            TakeTurn(guess);
        }

        private void m_Click(object sender, EventArgs e)
        {
            guess = m.Text;
            TakeTurn(guess);
        }

        private void n_Click(object sender, EventArgs e)
        {
            guess = n.Text;
            TakeTurn(guess);
        }

        private void o_Click(object sender, EventArgs e)
        {
            guess = o.Text;
            TakeTurn(guess);
        }

        private void p_Click(object sender, EventArgs e)
        {
            guess = p.Text;
            TakeTurn(guess);
        }

        private void q_Click(object sender, EventArgs e)
        {
            guess = q.Text;
            TakeTurn(guess);
        }

        private void r_Click(object sender, EventArgs e)
        {
            guess = r.Text;
            TakeTurn(guess);
        }

        private void s_Click(object sender, EventArgs e)
        {
            guess = s.Text;
            TakeTurn(guess);
        }

        private void t_Click(object sender, EventArgs e)
        {
            guess = t.Text;
            TakeTurn(guess);
        }

        private void u_Click(object sender, EventArgs e)
        {
            guess = u.Text;
            TakeTurn(guess);
        }

        private void v_Click(object sender, EventArgs e)
        {
            guess = v.Text;
            TakeTurn(guess);
        }

        private void w_Click(object sender, EventArgs e)
        {
            guess = w.Text;
            TakeTurn(guess);
        }

        private void x_Click(object sender, EventArgs e)
        {
            guess = x.Text;
            TakeTurn(guess);
        }

        private void y_Click(object sender, EventArgs e)
        {
            guess = y.Text;
            TakeTurn(guess);
        }

        private void z_Click(object sender, EventArgs e)
        {
            guess = z.Text;
            TakeTurn(guess);
        }
    }
}