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
    public partial class Home : System.Windows.Forms.Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnModeNormal_Click(object sender, EventArgs e)
        {
            Form MastermindNormal = new MastermindNormal();
            MastermindNormal.Show();
            this.Hide();
        }
    }
}
