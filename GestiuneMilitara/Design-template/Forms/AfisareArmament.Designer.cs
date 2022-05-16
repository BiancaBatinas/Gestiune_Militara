
namespace Design_template.Forms
{
    partial class AfisareArmament
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
            this.dataGridAfisareArmament = new System.Windows.Forms.DataGridView();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAfisareArmament)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridAfisareArmament
            // 
            this.dataGridAfisareArmament.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridAfisareArmament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAfisareArmament.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c1,
            this.c2,
            this.c3,
            this.c4,
            this.c5,
            this.c6,
            this.c7});
            this.dataGridAfisareArmament.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridAfisareArmament.Location = new System.Drawing.Point(0, 0);
            this.dataGridAfisareArmament.Name = "dataGridAfisareArmament";
            this.dataGridAfisareArmament.RowHeadersWidth = 51;
            this.dataGridAfisareArmament.RowTemplate.Height = 24;
            this.dataGridAfisareArmament.Size = new System.Drawing.Size(905, 450);
            this.dataGridAfisareArmament.TabIndex = 0;
            // 
            // c1
            // 
            this.c1.HeaderText = "ID";
            this.c1.MinimumWidth = 6;
            this.c1.Name = "c1";
            this.c1.Width = 50;
            // 
            // c2
            // 
            this.c2.HeaderText = "Categorie";
            this.c2.MinimumWidth = 6;
            this.c2.Name = "c2";
            this.c2.Width = 125;
            // 
            // c3
            // 
            this.c3.HeaderText = "Model";
            this.c3.MinimumWidth = 6;
            this.c3.Name = "c3";
            this.c3.Width = 150;
            // 
            // c4
            // 
            this.c4.HeaderText = "Tip";
            this.c4.MinimumWidth = 6;
            this.c4.Name = "c4";
            this.c4.Width = 125;
            // 
            // c5
            // 
            this.c5.HeaderText = "Calibru";
            this.c5.MinimumWidth = 6;
            this.c5.Name = "c5";
            this.c5.Width = 125;
            // 
            // c6
            // 
            this.c6.HeaderText = "Detalii";
            this.c6.MinimumWidth = 6;
            this.c6.Name = "c6";
            this.c6.Width = 150;
            // 
            // c7
            // 
            this.c7.HeaderText = "Cantitate Armament";
            this.c7.MinimumWidth = 6;
            this.c7.Name = "c7";
            this.c7.Width = 125;
            // 
            // AfisareArmament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(905, 450);
            this.Controls.Add(this.dataGridAfisareArmament);
            this.Name = "AfisareArmament";
            this.Text = "AfisareArmament";
            this.Load += new System.EventHandler(this.AfisareArmament_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAfisareArmament)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAfisareArmament;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2;
        private System.Windows.Forms.DataGridViewTextBoxColumn c3;
        private System.Windows.Forms.DataGridViewTextBoxColumn c4;
        private System.Windows.Forms.DataGridViewTextBoxColumn c5;
        private System.Windows.Forms.DataGridViewTextBoxColumn c6;
        private System.Windows.Forms.DataGridViewTextBoxColumn c7;
    }
}