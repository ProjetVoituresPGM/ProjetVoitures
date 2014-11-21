namespace Presentation
{
    partial class FrmConsulterVoitures
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
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_trierSur = new System.Windows.Forms.ComboBox();
            this.cbx_nomPersonne = new System.Windows.Forms.ComboBox();
            this.btn_Fermer = new System.Windows.Forms.Button();
            this.dgvVoitures = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoitures)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Affichage des voitures";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom de la personne :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(421, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Trier sur :";
            // 
            // cbx_trierSur
            // 
            this.cbx_trierSur.FormattingEnabled = true;
            this.cbx_trierSur.Items.AddRange(new object[] {
            "Nom",
            "Immatriculation",
            "Puissance",
            "Date de mise en service",
            "Louée"});
            this.cbx_trierSur.Location = new System.Drawing.Point(515, 86);
            this.cbx_trierSur.Name = "cbx_trierSur";
            this.cbx_trierSur.Size = new System.Drawing.Size(120, 21);
            this.cbx_trierSur.TabIndex = 4;
            // 
            // cbx_nomPersonne
            // 
            this.cbx_nomPersonne.FormattingEnabled = true;
            this.cbx_nomPersonne.Location = new System.Drawing.Point(257, 86);
            this.cbx_nomPersonne.Name = "cbx_nomPersonne";
            this.cbx_nomPersonne.Size = new System.Drawing.Size(83, 21);
            this.cbx_nomPersonne.TabIndex = 5;
            // 
            // btn_Fermer
            // 
            this.btn_Fermer.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fermer.Location = new System.Drawing.Point(611, 375);
            this.btn_Fermer.Name = "btn_Fermer";
            this.btn_Fermer.Size = new System.Drawing.Size(102, 40);
            this.btn_Fermer.TabIndex = 6;
            this.btn_Fermer.Text = "Fermer";
            this.btn_Fermer.UseVisualStyleBackColor = true;
            this.btn_Fermer.Click += new System.EventHandler(this.btn_Fermer_Click);
            // 
            // dgvVoitures
            // 
            this.dgvVoitures.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvVoitures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVoitures.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvVoitures.Location = new System.Drawing.Point(49, 138);
            this.dgvVoitures.Name = "dgvVoitures";
            this.dgvVoitures.Size = new System.Drawing.Size(648, 215);
            this.dgvVoitures.TabIndex = 7;
            // 
            // FrmConsulterVoitures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(745, 436);
            this.Controls.Add(this.dgvVoitures);
            this.Controls.Add(this.btn_Fermer);
            this.Controls.Add(this.cbx_nomPersonne);
            this.Controls.Add(this.cbx_trierSur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmConsulterVoitures";
            this.Text = "FrmConsulterVoitures";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoitures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_trierSur;
        private System.Windows.Forms.ComboBox cbx_nomPersonne;
        private System.Windows.Forms.Button btn_Fermer;
        private System.Windows.Forms.DataGridView dgvVoitures;
    }
}