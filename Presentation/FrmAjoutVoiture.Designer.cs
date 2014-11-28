namespace Presentation
{
    partial class FrmAjoutVoiture
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbx_loueeOui = new System.Windows.Forms.CheckBox();
            this.cbx_loueeNon = new System.Windows.Forms.CheckBox();
            this.tbx_nomVoiture = new System.Windows.Forms.TextBox();
            this.tbx_ImmatriculationVoiture = new System.Windows.Forms.TextBox();
            this.tbx_puissanceVoiture = new System.Windows.Forms.TextBox();
            this.tbx_dateMiseServiceVoiture = new System.Windows.Forms.TextBox();
            this.tbx_categorieVoiture = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_fermer = new System.Windows.Forms.Button();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Immatriculation :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Puissance :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date de mise en service :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Catégorie :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Louée :";
            // 
            // cbx_loueeOui
            // 
            this.cbx_loueeOui.AutoSize = true;
            this.cbx_loueeOui.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_loueeOui.Location = new System.Drawing.Point(313, 361);
            this.cbx_loueeOui.Name = "cbx_loueeOui";
            this.cbx_loueeOui.Size = new System.Drawing.Size(49, 24);
            this.cbx_loueeOui.TabIndex = 7;
            this.cbx_loueeOui.Text = "oui";
            this.cbx_loueeOui.UseVisualStyleBackColor = true;
            this.cbx_loueeOui.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbx_loueeNon
            // 
            this.cbx_loueeNon.AutoSize = true;
            this.cbx_loueeNon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_loueeNon.Location = new System.Drawing.Point(428, 361);
            this.cbx_loueeNon.Name = "cbx_loueeNon";
            this.cbx_loueeNon.Size = new System.Drawing.Size(55, 24);
            this.cbx_loueeNon.TabIndex = 8;
            this.cbx_loueeNon.Text = "non";
            this.cbx_loueeNon.UseVisualStyleBackColor = true;
            // 
            // tbx_nomVoiture
            // 
            this.tbx_nomVoiture.Location = new System.Drawing.Point(313, 121);
            this.tbx_nomVoiture.Name = "tbx_nomVoiture";
            this.tbx_nomVoiture.Size = new System.Drawing.Size(159, 20);
            this.tbx_nomVoiture.TabIndex = 9;
            // 
            // tbx_ImmatriculationVoiture
            // 
            this.tbx_ImmatriculationVoiture.Location = new System.Drawing.Point(313, 167);
            this.tbx_ImmatriculationVoiture.Name = "tbx_ImmatriculationVoiture";
            this.tbx_ImmatriculationVoiture.Size = new System.Drawing.Size(159, 20);
            this.tbx_ImmatriculationVoiture.TabIndex = 10;
            // 
            // tbx_puissanceVoiture
            // 
            this.tbx_puissanceVoiture.Location = new System.Drawing.Point(313, 209);
            this.tbx_puissanceVoiture.Name = "tbx_puissanceVoiture";
            this.tbx_puissanceVoiture.Size = new System.Drawing.Size(159, 20);
            this.tbx_puissanceVoiture.TabIndex = 11;
            // 
            // tbx_dateMiseServiceVoiture
            // 
            this.tbx_dateMiseServiceVoiture.Location = new System.Drawing.Point(313, 261);
            this.tbx_dateMiseServiceVoiture.Name = "tbx_dateMiseServiceVoiture";
            this.tbx_dateMiseServiceVoiture.Size = new System.Drawing.Size(159, 20);
            this.tbx_dateMiseServiceVoiture.TabIndex = 12;
            // 
            // tbx_categorieVoiture
            // 
            this.tbx_categorieVoiture.Location = new System.Drawing.Point(313, 311);
            this.tbx_categorieVoiture.Name = "tbx_categorieVoiture";
            this.tbx_categorieVoiture.Size = new System.Drawing.Size(159, 20);
            this.tbx_categorieVoiture.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(101, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 55);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ajouter une voiture";
            // 
            // btn_fermer
            // 
            this.btn_fermer.Location = new System.Drawing.Point(168, 438);
            this.btn_fermer.Name = "btn_fermer";
            this.btn_fermer.Size = new System.Drawing.Size(114, 35);
            this.btn_fermer.TabIndex = 15;
            this.btn_fermer.Text = "Fermer";
            this.btn_fermer.UseVisualStyleBackColor = true;
            this.btn_fermer.Click += new System.EventHandler(this.btn_fermer_Click);
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(397, 438);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(114, 35);
            this.btn_ajouter.TabIndex = 16;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // FrmAjoutVoiture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(669, 509);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.btn_fermer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_categorieVoiture);
            this.Controls.Add(this.tbx_dateMiseServiceVoiture);
            this.Controls.Add(this.tbx_puissanceVoiture);
            this.Controls.Add(this.tbx_ImmatriculationVoiture);
            this.Controls.Add(this.tbx_nomVoiture);
            this.Controls.Add(this.cbx_loueeNon);
            this.Controls.Add(this.cbx_loueeOui);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FrmAjoutVoiture";
            this.Text = "FrmAjoutVoiture";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbx_loueeOui;
        private System.Windows.Forms.CheckBox cbx_loueeNon;
        private System.Windows.Forms.TextBox tbx_nomVoiture;
        private System.Windows.Forms.TextBox tbx_ImmatriculationVoiture;
        private System.Windows.Forms.TextBox tbx_puissanceVoiture;
        private System.Windows.Forms.TextBox tbx_dateMiseServiceVoiture;
        private System.Windows.Forms.TextBox tbx_categorieVoiture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_fermer;
        private System.Windows.Forms.Button btn_ajouter;
    }
}