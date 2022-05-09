
namespace Design_template
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.soldatiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.armamentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soldatiToolStripMenuItem1,
            this.armamentToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // soldatiToolStripMenuItem1
            // 
            this.soldatiToolStripMenuItem1.Name = "soldatiToolStripMenuItem1";
            this.soldatiToolStripMenuItem1.Size = new System.Drawing.Size(55, 20);
            this.soldatiToolStripMenuItem1.Text = "Soldati";
            this.soldatiToolStripMenuItem1.Click += new System.EventHandler(this.soldatiToolStripMenuItem1_Click);
            // 
            // armamentToolStripMenuItem1
            // 
            this.armamentToolStripMenuItem1.Name = "armamentToolStripMenuItem1";
            this.armamentToolStripMenuItem1.Size = new System.Drawing.Size(76, 20);
            this.armamentToolStripMenuItem1.Text = "Armament";
            this.armamentToolStripMenuItem1.Click += new System.EventHandler(this.armamentToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
 
        private System.Windows.Forms.ToolStripMenuItem soldatiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem armamentToolStripMenuItem1;
    }
}

