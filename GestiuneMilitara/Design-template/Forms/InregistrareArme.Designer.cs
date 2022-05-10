
namespace Design_template.Forms
{
    partial class InregistrareArme
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
            this.button1 = new System.Windows.Forms.Button();
            this.Unitate = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.cnp = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Data = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Prenume = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Nume = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 52);
            this.button1.TabIndex = 21;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Unitate
            // 
            this.Unitate.AutoSize = true;
            this.Unitate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unitate.Location = new System.Drawing.Point(39, 231);
            this.Unitate.Name = "Unitate";
            this.Unitate.Size = new System.Drawing.Size(62, 20);
            this.Unitate.TabIndex = 20;
            this.Unitate.Text = "Detalii:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(137, 231);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(271, 22);
            this.textBox5.TabIndex = 19;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // cnp
            // 
            this.cnp.AutoSize = true;
            this.cnp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnp.Location = new System.Drawing.Point(45, 181);
            this.cnp.Name = "cnp";
            this.cnp.Size = new System.Drawing.Size(67, 20);
            this.cnp.TabIndex = 18;
            this.cnp.Text = "Calibru:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(137, 179);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(271, 22);
            this.textBox4.TabIndex = 17;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data.Location = new System.Drawing.Point(53, 133);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(37, 20);
            this.Data.TabIndex = 16;
            this.Data.Text = "Tip:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(137, 131);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(271, 22);
            this.textBox3.TabIndex = 15;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Prenume
            // 
            this.Prenume.AutoSize = true;
            this.Prenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prenume.Location = new System.Drawing.Point(50, 89);
            this.Prenume.Name = "Prenume";
            this.Prenume.Size = new System.Drawing.Size(59, 20);
            this.Prenume.TabIndex = 14;
            this.Prenume.Text = "Model:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(137, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(271, 22);
            this.textBox2.TabIndex = 13;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Nume
            // 
            this.Nume.AutoSize = true;
            this.Nume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nume.Location = new System.Drawing.Point(39, 45);
            this.Nume.Name = "Nume";
            this.Nume.Size = new System.Drawing.Size(86, 20);
            this.Nume.TabIndex = 12;
            this.Nume.Text = "Categorie:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 22);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Cantitate:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(137, 285);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(271, 22);
            this.textBox6.TabIndex = 22;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // InregistrareArme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox6);
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
            this.Name = "InregistrareArme";
            this.Text = "InregistrareArme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Unitate;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label cnp;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label Data;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label Prenume;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Nume;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox6;
    }
}