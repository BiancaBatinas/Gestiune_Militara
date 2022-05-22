
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAfisareSoldati)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridAfisareSoldati
            // 
            this.dataGridAfisareSoldati.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridAfisareSoldati.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridAfisareSoldati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAfisareSoldati.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridAfisareSoldati.Location = new System.Drawing.Point(0, 47);
            this.dataGridAfisareSoldati.Name = "dataGridAfisareSoldati";
            this.dataGridAfisareSoldati.RowHeadersWidth = 51;
            this.dataGridAfisareSoldati.RowTemplate.Height = 24;
            this.dataGridAfisareSoldati.Size = new System.Drawing.Size(814, 403);
            this.dataGridAfisareSoldati.TabIndex = 0;
            this.dataGridAfisareSoldati.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "ID",
            "Nume",
            "Prenume",
            "Data nasterii",
            "CNP",
            "Unitate"});
            this.listBox1.Location = new System.Drawing.Point(10, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(94, 20);
            this.listBox1.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(110, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 22);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AfisareSoldati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(814, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridAfisareSoldati);
            this.Name = "AfisareSoldati";
            this.Text = "Afisare";
            this.Load += new System.EventHandler(this.Afisare_Load);
            this.Resize += new System.EventHandler(this.Afisare_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAfisareSoldati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAfisareSoldati;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}