using Administrare;
using Armament;
using Soldat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;



namespace Design_template
{
    public partial class lblTitle : Form
    {
        Administrare_informatii adminMilitari, adminArmament;
        private Label lblContext;
        private Label lblNume;
        private Label lblPrenume;
        private Label lblCnp;
        private Label lblCategorie, lblModel, lblTip, lblCalibru, lblDetalii, lblNumarArmament;
        // private Label lblNote;

        private Label[] lblsNume;
        private Label[] lblsPrenume;
        private Label[] lblscnp;
        private Label[] lblsCategorie, lblsModel, lblsTip, lblsCalibru, lblsDetalii, lblsNumarArmament;
        private const int LATIME_CONTROL = 100;

        private const int DIMENSIUNE_PAS_Y = 50;

        private const int DIMENSIUNE_PAS_X = 120;
      

        int nrSoldati = 0;
        int nrArmament = 0;
        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;




        // private Label[] lblsNote;

       
        public lblTitle()
        {
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;

            string _numeFisier = ConfigurationManager.AppSettings["_NumeFisier"];
            string locatieFisierSolutie1 = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier_arme = locatieFisierSolutie1 + "\\" + _numeFisier;
            adminArmament = new Administrare_informatii(caleCompletaFisier_arme);

            adminMilitari = new Administrare_informatii(caleCompletaFisier);

            adminArmament.Get_Armament(out nrArmament);

            InitializeComponent();
            random = new Random();
           // btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            //setare proprietati
            this.Size = new Size(800, 500);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            this.Font = new Font("Arial", 10, FontStyle.Bold);
            this.ForeColor = Color.CornflowerBlue;
            this.Text = "Informatii ";

        }

        private Color SelectThemeColor()
        {
            int index = random.Next(CuloriTema.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(CuloriTema.ColorList.Count);
            }
            tempIndex = index;
            string color = CuloriTema.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = CuloriTema.ChangeColorBrightness(color, -0.3);
                    CuloriTema.PrimaryColor = color;
                    CuloriTema.SecondaryColor = CuloriTema.ChangeColorBrightness(color, -0.3);
                   // btnCloseChildForm.Visible = true;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelDesktopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCauta_Click(object sender, EventArgs e)
        {


            lblafisare.Text = adminMilitari.Cautare_in_fisier(txtBox.Text).ConversieLaSir_PentruFisier();
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAfisare_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AfisareSoldati(), sender);
           
           // AfiseazaSoldati();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AfisareArmament(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.InregistrareSoldati(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.InregistrareArme(), sender);
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitl.Text = childForm.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                            (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }

      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void armamentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
          

        }

        private void soldatiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }


    }
}
