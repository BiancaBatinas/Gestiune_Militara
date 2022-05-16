
namespace Design_template.Forms
{
    partial class AfisareSoldati
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
            this.dataGridAfisareSoldati = new System.Windows.Forms.DataGridView();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAfisareSoldati)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridAfisareSoldati
            // 
            this.dataGridAfisareSoldati.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridAfisareSoldati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAfisareSoldati.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c1,
            this.c2,
            this.c3,
            this.c4,
            this.c5,
            this.c6});
            this.dataGridAfisareSoldati.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridAfisareSoldati.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridAfisareSoldati.Location = new System.Drawing.Point(0, 0);
            this.dataGridAfisareSoldati.Name = "dataGridAfisareSoldati";
            this.dataGridAfisareSoldati.RowHeadersWidth = 51;
            this.dataGridAfisareSoldati.RowTemplate.Height = 24;
            this.dataGridAfisareSoldati.Size = new System.Drawing.Size(814, 450);
            this.dataGridAfisareSoldati.TabIndex = 0;
            this.dataGridAfisareSoldati.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // c1
            // 
            this.c1.HeaderText = "ID";
            this.c1.MinimumWidth = 6;
            this.c1.Name = "c1";
            this.c1.Width = 125;
            // 
            // c2
            // 
            this.c2.HeaderText = "Nume";
            this.c2.MinimumWidth = 6;
            this.c2.Name = "c2";
            this.c2.Width = 125;
            // 
            // c3
            // 
            this.c3.HeaderText = "Prenume";
            this.c3.MinimumWidth = 6;
            this.c3.Name = "c3";
            this.c3.Width = 125;
            // 
            // c4
            // 
            this.c4.HeaderText = "Data Nasterii";
            this.c4.MinimumWidth = 6;
            this.c4.Name = "c4";
            this.c4.Width = 125;
            // 
            // c5
            // 
            this.c5.HeaderText = "CNP";
            this.c5.MinimumWidth = 6;
            this.c5.Name = "c5";
            this.c5.Width = 125;
            // 
            // c6
            // 
            this.c6.HeaderText = "Unitate";
            this.c6.MinimumWidth = 6;
            this.c6.Name = "c6";
            this.c6.Width = 200;
            // 
            // AfisareSoldati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(814, 450);
            this.Controls.Add(this.dataGridAfisareSoldati);
            this.Name = "AfisareSoldati";
            this.Text = "Afisare";
            this.Load += new System.EventHandler(this.Afisare_Load);
            this.Resize += new System.EventHandler(this.Afisare_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAfisareSoldati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAfisareSoldati;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2;
        private System.Windows.Forms.DataGridViewTextBoxColumn c3;
        private System.Windows.Forms.DataGridViewTextBoxColumn c4;
        private System.Windows.Forms.DataGridViewTextBoxColumn c5;
        private System.Windows.Forms.DataGridViewTextBoxColumn c6;
    }
}