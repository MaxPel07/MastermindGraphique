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
        Label[,] copieTableauLabel = new Label[LIGNES,COLONES];
        Label[,] choixUtilisateur = new Label[LIGNES,COLONES];
        Label[,] tableauLabelIndice;
        Label[] tableauLabelSolution;
        Color[] goal = new Color[nbCouleurMaxParEssaie];
        Color[] copieGoal = new Color[nbCouleurMaxParEssaie];

        const int COLONES = 4;
        const int LIGNES = 10;
        int conteurCouleur = 0;
        int conteurEssaie = 0;
        int positionY = 0;
        int bonnePosition = 0;
        int mauvaisePosition = 0;

        public const int nbCouleurMaxParEssaie = 4;
        public MastermindNormal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Permet de Fermer le programme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Ferme le programme
            Application.Exit();
        }

        /// <summary>
        /// Ferme le jeu et ouvre le menu du jeu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewGame_Click(object sender, EventArgs e)
        {   
            // ouvre une nouvelle fois l'application
            System.Diagnostics.Process.Start(Application.ExecutablePath);

            // ferme l'ancienne application
            this.Close();
        }

        /// <summary>
        /// Ajoute les couleur des boutons cliqué dans le tableau de label des essaies du joueur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ColorBouton_Click(object sender, EventArgs e)
        {
            Button colorBouton = (Button)sender;
            tableauLabel[conteurCouleur, positionY].BackColor = colorBouton.BackColor;

            
            conteurCouleur++;
        }

        /// <summary>
        /// Appelle les méthode permettant de : afficher le tableau de label pour les essais du joueur,
        /// afficher le tableau de label des indices et la création aléatoire de la solution.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MastermindNormal_Load(object sender, EventArgs e)
        {
            CreationLabelEssaie(panelEssaie);
            CreationLabelIndice(panelIndice);
            NouvelleCombinaisonAléatoire().CopyTo(copieGoal,0);
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

        /// <summary>
        /// Affichage dynamique du tableau de label que remplira le joueur pour ses essaies.
        /// </summary>
        /// <param name="panel"></param>
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

                    // Ajout du label au Panel
                    panel.Controls.Add(newLabel);

                }
            }
        }

        /// <summary>
        /// Affichage dynamique du tableau de label des Indices.
        /// </summary>
        /// <param name="panel"></param>
        private void CreationLabelIndice(Panel panel)
        {
            // création d'un tableau de label
            tableauLabelIndice = new Label[4, 10];

            for (int colonne = 0; colonne < 4; colonne++)
            {
                for (int ligne = 0; ligne < 10; ligne++)
                {
                    // création d'un label
                    Label newLabel = new Label();

                    // placement du label dans le tableau
                    tableauLabelIndice[colonne, ligne] = newLabel;


                    // paramètre label
                    newLabel.BackColor = Color.Gray;
                    newLabel.Size = new Size(10, 10);
                    newLabel.Location = new Point(20 * colonne + 2, 45 * ligne + 15);

                    // Ajout du label au Panel
                    panel.Controls.Add(newLabel);
                }
            }
        }

        /// <summary>
        /// Création aléatoire de la solution. 
        /// </summary>
        /// <returns></returns>
        private Color[] NouvelleCombinaisonAléatoire()
        {
            
            Random random = new Random();

            // Génération d'une combinaison aléatoire de 4 couleurs
            for (int i = 0; i < nbCouleurMaxParEssaie; i++)
            {
                // nombre tiré entre 0 et 6 compris
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
            // retourne le tableau de couleur "goal"
            return goal;
        }

        /// <summary>
        /// Affiche dans un tableau de label la solution
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       private void chkSolution_CheckedChanged(object sender, EventArgs e)
        {
            tableauLabelSolution = new Label[4];

            for (int ligne = 0; ligne < 4; ligne++)
            {
                // création d'un label
                Label newLabel = new Label();

                // placement du label dans le tableau
                tableauLabelSolution[ligne] = newLabel;

                // paramètre label
                newLabel.BackColor = goal[ligne];
                newLabel.Size = new Size(15, 15);
                newLabel.Location = new Point(20 * ligne + 0);

                // Ajout du label au Panel
                panelSolution.Controls.Add(newLabel);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //copieTableauLabel[conteurCouleur, positionY].BackColor = tableauLabel[].BackColor;

            for (int i = 0; i < COLONES; i++)
            {
                if (goal[i] == tableauLabel[i,positionY].BackColor)
                {
                    //copieGoal[i] = Color.Transparent;
                    //copieTableauLabel[i,positionY].BackColor = Color.Snow;

                    tableauLabelIndice[bonnePosition, positionY].BackColor = Color.White;
                    bonnePosition++;

                    if (bonnePosition == 4)
                    {
                        MessageBox.Show("Bravo ! Vous avez gagné");
                    }
                }

                mauvaisePosition = bonnePosition;
            }

            /*for (int i = 0; i < COLONES; i++)
            {
                for (int j = 0; j < copieGoal.Length; j++)
                {
                    if ()
                    {

                    }
                }
            }*/

            positionY++;
            conteurCouleur = 0;
            bonnePosition = 0;
            //conteurEssaie++;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            conteurCouleur--;
            tableauLabel[conteurCouleur, positionY].BackColor = Color.Gray;
            // changer les couleurs des labels de l'essaie en cours en gris
            
        }
    }
}