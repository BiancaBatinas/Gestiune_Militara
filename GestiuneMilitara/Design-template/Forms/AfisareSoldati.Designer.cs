
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
            this.components = new System.ComponentModel.Container();
            this.dataGridAfisareSoldati = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelRefresh = new System.Windows.Forms.Panel();
            this.panelRefreshContinut = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textNume = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textPrenume = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textData = new System.Windows.Forms.TextBox();
            this.textUnitate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Update_gridCell = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAfisareSoldati)).BeginInit();
            this.panelRefresh.SuspendLayout();
            this.panelRefreshContinut.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.dataGridAfisareSoldati.Size = new System.Drawing.Size(723, 480);
            this.dataGridAfisareSoldati.TabIndex = 0;
            this.dataGridAfisareSoldati.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAfisareSoldati_CellClick);
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
            // panelRefresh
            // 
            this.panelRefresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelRefresh.Controls.Add(this.panelRefreshContinut);
            this.panelRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRefresh.Location = new System.Drawing.Point(729, 0);
            this.panelRefresh.Name = "panelRefresh";
            this.panelRefresh.Size = new System.Drawing.Size(230, 527);
            this.panelRefresh.TabIndex = 20;
            // 
            // panelRefreshContinut
            // 
            this.panelRefreshContinut.AutoScroll = true;
            this.panelRefreshContinut.Controls.Add(this.tableLayoutPanel1);
            this.panelRefreshContinut.Controls.Add(this.panel2);
            this.panelRefreshContinut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRefreshContinut.Location = new System.Drawing.Point(0, 0);
            this.panelRefreshContinut.Name = "panelRefreshContinut";
            this.panelRefreshContinut.Size = new System.Drawing.Size(230, 527);
            this.panelRefreshContinut.TabIndex = 20;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.textID, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textNume, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.textPrenume, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.textData, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.textUnitate, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 12);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 71);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.tableLayoutPanel1.RowCount = 14;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(230, 456);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textID
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textID, 2);
            this.textID.Location = new System.Drawing.Point(13, 38);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(128, 22);
            this.textID.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(13, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textNume
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textNume, 3);
            this.textNume.Location = new System.Drawing.Point(13, 128);
            this.textNume.Name = "textNume";
            this.textNume.Size = new System.Drawing.Size(196, 22);
            this.textNume.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label3, 2);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(13, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nume";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label4, 2);
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(13, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Prenume";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textPrenume
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textPrenume, 3);
            this.textPrenume.Location = new System.Drawing.Point(13, 218);
            this.textPrenume.Name = "textPrenume";
            this.textPrenume.Size = new System.Drawing.Size(196, 22);
            this.textPrenume.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label5, 2);
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(13, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Data  nasterii";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textData
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textData, 3);
            this.textData.Location = new System.Drawing.Point(13, 308);
            this.textData.Name = "textData";
            this.textData.Size = new System.Drawing.Size(196, 22);
            this.textData.TabIndex = 25;
            // 
            // textUnitate
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textUnitate, 3);
            this.textUnitate.Location = new System.Drawing.Point(13, 398);
            this.textUnitate.Name = "textUnitate";
            this.textUnitate.Size = new System.Drawing.Size(196, 22);
            this.textUnitate.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label6, 2);
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(13, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Unitate";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Update_gridCell);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 71);
            this.panel2.TabIndex = 19;
            // 
            // Update_gridCell
            // 
            this.Update_gridCell.Location = new System.Drawing.Point(6, 15);
            this.Update_gridCell.Name = "Update_gridCell";
            this.Update_gridCell.Size = new System.Drawing.Size(70, 30);
            this.Update_gridCell.TabIndex = 26;
            this.Update_gridCell.Text = "Modifica";
            this.Update_gridCell.UseVisualStyleBackColor = true;
            this.Update_gridCell.Click += new System.EventHandler(this.Update_gridCell_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(98, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Modificare continut";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(609, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 30);
            this.button1.TabIndex = 26;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AfisareSoldati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(959, 527);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelRefresh);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridAfisareSoldati);
            this.Name = "AfisareSoldati";
            this.Text = "Afisare";
            this.Load += new System.EventHandler(this.Afisare_Load);
            this.Resize += new System.EventHandler(this.Afisare_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAfisareSoldati)).EndInit();
            this.panelRefresh.ResumeLayout(false);
            this.panelRefreshContinut.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAfisareSoldati;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panelRefresh;
        private System.Windows.Forms.Panel panelRefreshContinut;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textPrenume;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textData;
        private System.Windows.Forms.TextBox textUnitate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Update_gridCell;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}