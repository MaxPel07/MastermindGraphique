namespace Mastermind_Graphique
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.lblTitreAcceuil = new System.Windows.Forms.Label();
            this.btnModeNormal = new System.Windows.Forms.Button();
            this.btnRegles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitreAcceuil
            // 
            this.lblTitreAcceuil.AutoSize = true;
            this.lblTitreAcceuil.BackColor = System.Drawing.Color.Transparent;
            this.lblTitreAcceuil.Font = new System.Drawing.Font("Bauhaus 93", 45F);
            this.lblTitreAcceuil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitreAcceuil.Location = new System.Drawing.Point(194, 35);
            this.lblTitreAcceuil.Name = "lblTitreAcceuil";
            this.lblTitreAcceuil.Size = new System.Drawing.Size(337, 68);
            this.lblTitreAcceuil.TabIndex = 0;
            this.lblTitreAcceuil.Text = "Mastermind";
            // 
            // btnModeNormal
            // 
            this.btnModeNormal.Location = new System.Drawing.Point(206, 458);
            this.btnModeNormal.Name = "btnModeNormal";
            this.btnModeNormal.Size = new System.Drawing.Size(93, 23);
            this.btnModeNormal.TabIndex = 1;
            this.btnModeNormal.Text = "Mode Normal";
            this.btnModeNormal.UseVisualStyleBackColor = true;
            this.btnModeNormal.Click += new System.EventHandler(this.btnModeNormal_Click);
            // 
            // btnRegles
            // 
            this.btnRegles.Location = new System.Drawing.Point(456, 458);
            this.btnRegles.Name = "btnRegles";
            this.btnRegles.Size = new System.Drawing.Size(75, 23);
            this.btnRegles.TabIndex = 2;
            this.btnRegles.Text = "Règles";
            this.btnRegles.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mastermind_Graphique.Properties.Resources.Accueil;
            this.ClientSize = new System.Drawing.Size(747, 671);
            this.Controls.Add(this.btnRegles);
            this.Controls.Add(this.btnModeNormal);
            this.Controls.Add(this.lblTitreAcceuil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mastermind";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitreAcceuil;
        private System.Windows.Forms.Button btnModeNormal;
        private System.Windows.Forms.Button btnRegles;
    }
}