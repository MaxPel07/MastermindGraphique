/// ETML
/// Auteur      : Maxime Pelloquin
/// Date        : 16.11.2023
/// Descritpion :
using System;
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
        Label[,] tableauLabel;


        // conteur couleur
        int conteurCouleur = 0;

        public const int nbCouleurMaxParEssaie = 4;
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
                //lbl1.BackColor = Color.Red;
            }

            if (conteurCouleur == 1)
            {
                //lbl2.BackColor = Color.Red;
            }

            if (conteurCouleur == 2)
            {
                //lbl3.BackColor = Color.Red;
            }

            if (conteurCouleur == 3)
            {
                //lbl4.BackColor = Color.Red;
            }

            conteurCouleur++;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            if (conteurCouleur == 0)
            {
                //lbl1.BackColor = Color.Chartreuse;
            }

            if (conteurCouleur == 1)
            {
                // lbl2.BackColor = Color.Chartreuse;
            }

            if (conteurCouleur == 2)
            {
                //lbl3.BackColor = Color.Chartreuse;
            }

            if (conteurCouleur == 3)
            {
                // lbl4.BackColor = Color.Chartreuse;
            }

            conteurCouleur++;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            if (conteurCouleur == 0)
            {
                // lbl1.BackColor = Color.DarkTurquoise;
            }

            if (conteurCouleur == 1)
            {
                // lbl2.BackColor = Color.DarkTurquoise;
            }

            if (conteurCouleur == 2)
            {
                // lbl3.BackColor = Color.DarkTurquoise;
            }

            if (conteurCouleur == 3)
            {
                // lbl4.BackColor = Color.DarkTurquoise;
            }

            conteurCouleur++;
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            if (conteurCouleur == 0)
            {
                // lbl1.BackColor = Color.Yellow;
            }

            if (conteurCouleur == 1)
            {
                // lbl2.BackColor = Color.Yellow;
            }

            if (conteurCouleur == 2)
            {
                // lbl3.BackColor = Color.Yellow;
            }

            if (conteurCouleur == 3)
            {
                // lbl4.BackColor = Color.Yellow;
            }

            conteurCouleur++;
        }

        private void btnMagenta_Click(object sender, EventArgs e)
        {
            if (conteurCouleur == 0)
            {
                //lbl1.BackColor = Color.Magenta;
            }

            if (conteurCouleur == 1)
            {
                // lbl2.BackColor = Color.Magenta;
            }

            if (conteurCouleur == 2)
            {
                // lbl3.BackColor = Color.Magenta;
            }

            if (conteurCouleur == 3)
            {
                //lbl4.BackColor = Color.Magenta;
            }

            conteurCouleur++;
        }

        private void btnOrange_Click(object sender, EventArgs e)
        {
            if (conteurCouleur == 0)
            {
                //  lbl1.BackColor = Color.Orange;
            }

            if (conteurCouleur == 1)
            {
                // lbl2.BackColor = Color.Orange;
            }

            if (conteurCouleur == 2)
            {
                // lbl3.BackColor = Color.Orange;
            }

            if (conteurCouleur == 3)
            {
                // lbl4.BackColor = Color.Orange;
            }

            conteurCouleur++;
        }

        private void btnPurple_Click(object sender, EventArgs e)
        {
            if (conteurCouleur == 0)
            {
                // lbl1.BackColor = Color.Purple;
            }

            if (conteurCouleur == 1)
            {
                // lbl2.BackColor = Color.Purple;
            }

            if (conteurCouleur == 2)
            {
                // lbl3.BackColor = Color.Purple;
            }

            if (conteurCouleur == 3)
            {
                // lbl4.BackColor = Color.Purple;
            }

            conteurCouleur++;
        }

        private void MastermindNormal_Load(object sender, EventArgs e)
        {
            CreationLabelEssaie(panelEssaie);
            CreationLabelIndice(panelIndice);
            NouvelleCombinaisonAléatoire();
        }

        private void tableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {   
            // création d'un tableau de label
            tableauLabel = new Label[10, 4];

            for (int ligne = 0; ligne < 10; ligne++)
            {
                for (int colonne = 0; colonne < 4; colonne++)
                {
                    // création d'un label
                    Label newLabel = new Label();

                    // placement du label dans le tableau
                    tableauLabel[ligne, colonne] = newLabel;

                    // paramètre label
                    newLabel.BackColor = Color.Yellow;
                    newLabel.Size = new Size(20, 20);
                    newLabel.Location = new Point(20*ligne, 20*colonne);

                    // Ajout du label au Panel
                    panelEssaie.Controls.Add(newLabel);
                }
            }
        }

        private void CreationLabelEssaie(Panel panel)
        {
            // création d'un tableau de label
            tableauLabel = new Label[4, 10];

            for (int colonne = 0; colonne < 4; colonne++)
            {
                for (int ligne = 0; ligne < 10; ligne++)
                {
                    // création d'un label
                    Label newLabel = new Label();

                    // placement du label dans le tableau
                    tableauLabel[colonne, ligne] = newLabel;


                    // paramètre label
                    newLabel.BackColor = Color.Gray;
                    newLabel.Size = new Size(36, 36);
                    newLabel.Location = new Point(45 * colonne + 2, 45 * ligne +2);
                    //newLabel.Padding = new Padding(5, 5, 5, 5);

                    // Ajout du label au Panel
                    panel.Controls.Add(newLabel);
                }
            }
        }

        private void CreationLabelIndice(Panel panel)
        {
            // création d'un tableau de label
            tableauLabel = new Label[4, 10];

            for (int colonne = 0; colonne < 4; colonne++)
            {
                for (int ligne = 0; ligne < 10; ligne++)
                {
                    // création d'un label
                    Label newLabel = new Label();

                    // placement du label dans le tableau
                    tableauLabel[colonne, ligne] = newLabel;


                    // paramètre label
                    newLabel.BackColor = Color.White;
                    newLabel.Size = new Size(10, 10);
                    newLabel.Location = new Point(20 * colonne + 2, 45 * ligne + 15);

                    // Ajout du label au Panel
                    panel.Controls.Add(newLabel);
                }
            }
        }

        private Color[] NouvelleCombinaisonAléatoire()
        {
            Color[] goal = new Color[nbCouleurMaxParEssaie];
            Random random = new Random();

            // Génération d'une combinaison aléatoire de 4 couleurs
            for (int i = 0; i < nbCouleurMaxParEssaie; i++)
            {
                int valeurDeCouleur = random.Next(6);
                Color color;

                // Conversion de la valeur aléatoire en couleur
                switch (valeurDeCouleur)
                {
                    case 0:
                        color = Color.Red;
                        break;
                    case 1:
                        color = Color.Chartreuse;
                        break;
                    case 2:
                        color = Color.DarkTurquoise;
                        break;
                    case 3:
                        color = Color.Yellow;
                        break;
                    case 4:
                        color = Color.Magenta;
                        break;
                    case 5:
                        color = Color.Orange;
                        break;
                    default:
                        color = Color.MediumPurple;
                        break;
                }

                goal[i] = color;
            }
            return goal;
        }

        private void chkSolution_CheckedChanged(object sender, EventArgs e)
        {
            /*
                POUR LA PROCHAINE FOIS : 1. créer le tableau de label sous la checkbox pour afficher la solution
                                         2. Changer la couleur de fond des labels pour voir la solution
            */
        }
    }
}
