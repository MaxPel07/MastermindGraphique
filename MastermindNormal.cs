﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mastermind_Graphique
{

    


    public partial class MastermindNormal : System.Windows.Forms.Form
    {
        // conteur couleur
        int conteurCouleur = 0;
        public MastermindNormal()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Ferme le programme
            Application.Exit();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {   
            // ouvre une nouvelle fois l'application
            System.Diagnostics.Process.Start(Application.ExecutablePath);

            // ferme l'ancienne application
            this.Close();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            if (conteurCouleur == 0)
            {
                lbl1.BackColor = Color.Red;
            }

            if (conteurCouleur == 1)
            {
                lbl2.BackColor = Color.Red;
            }

            if (conteurCouleur == 2)
            {
                lbl3.BackColor = Color.Red;
            }

            if (conteurCouleur == 3)
            {
                lbl4.BackColor = Color.Red;
            }

            conteurCouleur++;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            if (conteurCouleur == 0)
            {
                lbl1.BackColor = Color.Chartreuse;
            }

            if (conteurCouleur == 1)
            {
                lbl2.BackColor = Color.Chartreuse;
            }

            if (conteurCouleur == 2)
            {
                lbl3.BackColor = Color.Chartreuse;
            }

            if (conteurCouleur == 3)
            {
                lbl4.BackColor = Color.Chartreuse;
            }

            conteurCouleur++;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            if (conteurCouleur == 0)
            {
                lbl1.BackColor = Color.DarkTurquoise;
            }

            if (conteurCouleur == 1)
            {
                lbl2.BackColor = Color.DarkTurquoise;
            }

            if (conteurCouleur == 2)
            {
                lbl3.BackColor = Color.DarkTurquoise;
            }

            if (conteurCouleur == 3)
            {
                lbl4.BackColor = Color.DarkTurquoise;
            }

            conteurCouleur++;
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            if (conteurCouleur == 0)
            {
                lbl1.BackColor = Color.Yellow;
            }

            if (conteurCouleur == 1)
            {
                lbl2.BackColor = Color.Yellow;
            }

            if (conteurCouleur == 2)
            {
                lbl3.BackColor = Color.Yellow;
            }

            if (conteurCouleur == 3)
            {
                lbl4.BackColor = Color.Yellow;
            }

            conteurCouleur++;
        }

        private void btnMagenta_Click(object sender, EventArgs e)
        {
            if (conteurCouleur == 0)
            {
                lbl1.BackColor = Color.Magenta;
            }

            if (conteurCouleur == 1)
            {
                lbl2.BackColor = Color.Magenta;
            }

            if (conteurCouleur == 2)
            {
                lbl3.BackColor = Color.Magenta;
            }

            if (conteurCouleur == 3)
            {
                lbl4.BackColor = Color.Magenta;
            }

            conteurCouleur++;
        }

        private void btnOrange_Click(object sender, EventArgs e)
        {
            if (conteurCouleur == 0)
            {
                lbl1.BackColor = Color.Orange;
            }

            if (conteurCouleur == 1)
            {
                lbl2.BackColor = Color.Orange;
            }

            if (conteurCouleur == 2)
            {
                lbl3.BackColor = Color.Orange;
            }

            if (conteurCouleur == 3)
            {
                lbl4.BackColor = Color.Orange;
            }

            conteurCouleur++;
        }

        private void btnPurple_Click(object sender, EventArgs e)
        {
            if (conteurCouleur == 0)
            {
                lbl1.BackColor = Color.Purple;
            }

            if (conteurCouleur == 1)
            {
                lbl2.BackColor = Color.Purple;
            }

            if (conteurCouleur == 2)
            {
                lbl3.BackColor = Color.Purple;
            }

            if (conteurCouleur == 3)
            {
                lbl4.BackColor = Color.Purple;
            }

            conteurCouleur++;
        }
    }
}
