namespace Presentation
{
    partial class FrmConsulterPersonnes
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
            this.dgvPersonnes = new System.Windows.Forms.DataGridView();
            this.btn_Fermer = new System.Windows.Forms.Button();
            this.cbx_nomPersonneP = new System.Windows.Forms.ComboBox();
            this.cbx_trierSurP = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersonnes
            // 
            this.dgvPersonnes.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvPersonnes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnes.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvPersonnes.Location = new System.Drawing.Point(72, 165);
            this.dgvPersonnes.Name = "dgvPersonnes";
            this.dgvPersonnes.Size = new System.Drawing.Size(648, 215);
            this.dgvPersonnes.TabIndex = 14;
            // 
            // btn_Fermer
            // 
            this.btn_Fermer.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fermer.Location = new System.Drawing.Point(637, 424);
            this.btn_Fermer.Name = "btn_Fermer";
            this.btn_Fermer.Size = new System.Drawing.Size(102, 40);
            this.btn_Fermer.TabIndex = 13;
            this.btn_Fermer.Text = "Fermer";
            this.btn_Fermer.UseVisualStyleBackColor = true;
            this.btn_Fermer.Click += new System.EventHandler(this.btn_Fermer_Click);
            // 
            // cbx_nomPersonneP
            // 
            this.cbx_nomPersonneP.FormattingEnabled = true;
            this.cbx_nomPersonneP.Location = new System.Drawing.Point(265, 101);
            this.cbx_nomPersonneP.Name = "cbx_nomPersonneP";
            this.cbx_nomPersonneP.Size = new System.Drawing.Size(83, 21);
            this.cbx_nomPersonneP.TabIndex = 12;
            // 
            // cbx_trierSurP
            // 
            this.cbx_trierSurP.FormattingEnabled = true;
            this.cbx_trierSurP.Items.AddRange(new object[] {
            "Nom",
            "Immatriculation",
            "Puissance",
            "Date de mise en service",
            "Louée"});
            this.cbx_trierSurP.Location = new System.Drawing.Point(523, 101);
            this.cbx_trierSurP.Name = "cbx_trierSurP";
            this.cbx_trierSurP.Size = new System.Drawing.Size(120, 21);
            this.cbx_trierSurP.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(429, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Trier sur :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nom de la personne :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "Affichage des personnes";
            // 
            // FrmConsulterPersonnes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(820, 512);
            this.Controls.Add(this.dgvPersonnes);
            this.Controls.Add(this.btn_Fermer);
            this.Controls.Add(this.cbx_nomPersonneP);
            this.Controls.Add(this.cbx_trierSurP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmConsulterPersonnes";
            this.Text = "FrmConsulterPersonnes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonnes;
        private System.Windows.Forms.Button btn_Fermer;
        private System.Windows.Forms.ComboBox cbx_nomPersonneP;
        private System.Windows.Forms.ComboBox cbx_trierSurP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}