
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAfisareArmament)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridAfisareArmament
            // 
            this.dataGridAfisareArmament.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridAfisareArmament.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridAfisareArmament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAfisareArmament.Location = new System.Drawing.Point(0, 40);
            this.dataGridAfisareArmament.Name = "dataGridAfisareArmament";
            this.dataGridAfisareArmament.RowHeadersWidth = 51;
            this.dataGridAfisareArmament.RowTemplate.Height = 24;
            this.dataGridAfisareArmament.Size = new System.Drawing.Size(834, 453);
            this.dataGridAfisareArmament.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(112, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 22);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "ID",
            "Categorie",
            "Model",
            "Tip",
            "Calibru",
            "Detalii",
            "Cantitate"});
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(94, 20);
            this.listBox1.TabIndex = 17;
            // 
            // AfisareArmament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(859, 505);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridAfisareArmament);
            this.Name = "AfisareArmament";
            this.Text = "AfisareArmament";
            this.Load += new System.EventHandler(this.AfisareArmament_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAfisareArmament)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAfisareArmament;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}