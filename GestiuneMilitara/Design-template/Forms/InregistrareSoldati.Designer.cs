
namespace Design_template.Forms
{
    partial class InregistrareSoldati
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Nume = new System.Windows.Forms.Label();
            this.Prenume = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Data = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cnp = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Unitate = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Nume
            // 
            this.Nume.AutoSize = true;
            this.Nume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nume.Location = new System.Drawing.Point(35, 45);
            this.Nume.Name = "Nume";
            this.Nume.Size = new System.Drawing.Size(58, 20);
            this.Nume.TabIndex = 1;
            this.Nume.Text = "Nume:";
            // 
            // Prenume
            // 
            this.Prenume.AutoSize = true;
            this.Prenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prenume.Location = new System.Drawing.Point(17, 91);
            this.Prenume.Name = "Prenume";
            this.Prenume.Size = new System.Drawing.Size(81, 20);
            this.Prenume.TabIndex = 3;
            this.Prenume.Text = "Prenume:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(133, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(271, 22);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data.Location = new System.Drawing.Point(17, 133);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(110, 20);
            this.Data.TabIndex = 5;
            this.Data.Text = "Data nasterii:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(133, 131);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(271, 22);
            this.textBox3.TabIndex = 4;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // cnp
            // 
            this.cnp.AutoSize = true;
            this.cnp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnp.Location = new System.Drawing.Point(49, 181);
            this.cnp.Name = "cnp";
            this.cnp.Size = new System.Drawing.Size(49, 20);
            this.cnp.TabIndex = 7;
            this.cnp.Text = "CNP:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(133, 179);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(271, 22);
            this.textBox4.TabIndex = 6;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Unitate
            // 
            this.Unitate.AutoSize = true;
            this.Unitate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unitate.Location = new System.Drawing.Point(46, 231);
            this.Unitate.Name = "Unitate";
            this.Unitate.Size = new System.Drawing.Size(67, 20);
            this.Unitate.TabIndex = 9;
            this.Unitate.Text = "Unitate:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(133, 231);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(271, 22);
            this.textBox5.TabIndex = 8;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 52);
            this.button1.TabIndex = 10;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InregistrareSoldati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Unitate);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.cnp);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Prenume);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Nume);
            this.Controls.Add(this.textBox1);
            this.Name = "InregistrareSoldati";
            this.Text = "InregistrareSoldati";
            this.Load += new System.EventHandler(this.InregistrareSoldati_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Nume;
        private System.Windows.Forms.Label Prenume;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Data;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label cnp;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label Unitate;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
    }
}