﻿namespace Presentation
{
    partial class FrmSuppVoiture
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_Voiture = new System.Windows.Forms.ComboBox();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(128, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supprimer une voiture";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Voiture :";
            // 
            // cbx_Voiture
            // 
            this.cbx_Voiture.FormattingEnabled = true;
            this.cbx_Voiture.Location = new System.Drawing.Point(181, 129);
            this.cbx_Voiture.Name = "cbx_Voiture";
            this.cbx_Voiture.Size = new System.Drawing.Size(180, 21);
            this.cbx_Voiture.TabIndex = 2;
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(133, 195);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(92, 36);
            this.btnFermer.TabIndex = 3;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnSupp
            // 
            this.btnSupp.Location = new System.Drawing.Point(278, 195);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(94, 36);
            this.btnSupp.TabIndex = 4;
            this.btnSupp.Text = "Supprimer";
            this.btnSupp.UseVisualStyleBackColor = true;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // FrmSuppVoiture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(488, 264);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.cbx_Voiture);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmSuppVoiture";
            this.Text = "FrmSuppVoiture";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_Voiture;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnSupp;
    }
}