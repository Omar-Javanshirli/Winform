using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakuAndLondonClock
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        Label londonLbl = new Label();
        Label istanbulLbl = new Label();
        Label parisLbl=new Label();
        Label bakuLbl=new Label();
        PictureBox londonImage=new PictureBox();
        PictureBox istanbulImage=new PictureBox();
        PictureBox bakuImage=new PictureBox();
        PictureBox parisImage=new PictureBox();
        //Constructur
        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }
        public Color MyColor { get; set; }
        //Methods
        private Color SelectThemColor()
        {
            int index =random.Next(ThemColors.ColorList.Count);
            while (tempIndex == index)
            {
               index= random.Next(ThemColors.ColorList.Count);
            }
            tempIndex = index;
            string color= ThemColors.ColorList[index];
            MyColor= ColorTranslator.FromHtml(color);
            return MyColor;
        }
        private void ActivateButton(object sender)
        {
            if (sender != null)
            {
                if (currentButton != (Button)sender)
                {
                    DisableButton();
                    MyColor=SelectThemColor();
                    currentButton = (Button)sender;
                    currentButton.BackColor = MyColor;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font= new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));

                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51,51,76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font= new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void londonBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            istanbulLbl.Dispose();
            bakuLbl.Dispose();
            parisLbl.Dispose();
            bakuImage.Dispose();
            parisImage.Dispose();
            istanbulImage.Dispose();
            londonLbl=new Label();
            londonLbl.Location = new Point(298,40);
            londonLbl.ForeColor = MyColor ;
            londonLbl.Font = new Font("Comic Sans MS", 20, FontStyle.Bold);
            londonLbl.Text = DateTime.Now.AddHours(-6).ToLongTimeString();
            londonLbl.AutoSize = true;
            
            londonImage=new PictureBox();
            londonImage.SizeMode=PictureBoxSizeMode.AutoSize;
            londonImage.Location = new Point(200, 100);
            Image image = Properties.Resources.londonImage;
            londonImage.Image = image;
            this.Controls.Add(londonLbl);
            this.Controls.Add(londonImage);
        }


        private void istanbulBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            londonLbl.Dispose();
            parisLbl.Dispose();
            bakuLbl.Dispose();
            londonImage.Dispose();
            bakuImage.Dispose();
            parisImage.Dispose();
            istanbulLbl=new Label();
            istanbulLbl.Location = new Point(298, 40);
            istanbulLbl.ForeColor = MyColor;
            istanbulLbl.Text = DateTime.Now.AddHours(-1).ToLongTimeString();
            istanbulLbl.Font = new Font("Comic Sans MS", 20, FontStyle.Bold);
            istanbulLbl.AutoSize = true;

            istanbulImage=new PictureBox();
            istanbulImage.SizeMode=PictureBoxSizeMode.AutoSize;
            Image image = Properties.Resources.istanbul25;
            istanbulImage.Location = new Point(200, 80);
            istanbulImage.Image = image;
            this.Controls.Add(istanbulImage);
            this.Controls.Add(istanbulLbl);
        }

        private void parisBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            londonLbl.Dispose();
            istanbulLbl.Dispose();
            bakuLbl.Dispose();
            londonImage.Dispose();
            istanbulImage.Dispose();
            bakuImage.Dispose();
            parisLbl = new Label();
            parisLbl.Location = new Point(298, 40);
            parisLbl.ForeColor = MyColor;
            parisLbl.Text = DateTime.Now.AddHours(-2).ToLongTimeString();
            parisLbl.Font = new Font("Comic Sans MS", 20, FontStyle.Bold);
            parisLbl.AutoSize = true;

            parisImage = new PictureBox();
            parisImage.SizeMode=PictureBoxSizeMode.AutoSize;
            parisImage.Location = new Point(200, 80);
            Image imgae = Properties.Resources.paris21;
            parisImage.Image = imgae;

            this.Controls.Add(parisImage);
            this.Controls.Add(parisLbl);
        }

        private void bakuBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            londonLbl.Dispose();
            parisLbl.Dispose();
            istanbulLbl.Dispose();
            istanbulImage.Dispose();
            londonImage.Dispose();
            parisImage.Dispose();

            bakuLbl = new Label();
            bakuLbl.Location = new Point(298, 40);
            bakuLbl.ForeColor = MyColor;
            bakuLbl.Text = DateTime.Now.ToLongTimeString();
            bakuLbl.Font = new Font("Comic Sans MS", 20, FontStyle.Bold);
            bakuLbl.AutoSize = true;
            
            bakuImage = new PictureBox();
            Image image= Properties.Resources.baku25;
            bakuImage.Location = new Point(200, 80);
            bakuImage.SizeMode = PictureBoxSizeMode.AutoSize;
            bakuImage.Image = image;

            this.Controls.Add(bakuImage);
            this.Controls.Add(bakuLbl);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            londonLbl.Text = DateTime.Now.AddHours(-4).ToLongTimeString();
            timer1.Start();
        }

        private void timerIstanbul_Tick(object sender, EventArgs e)
        {
            istanbulLbl.Text = DateTime.Now.AddHours(-1).ToLongTimeString();
            timerIstanbul.Start();
        }

        private void timerParis_Tick(object sender, EventArgs e)
        {
            parisLbl.Text = DateTime.Now.AddHours(-2).ToLongTimeString();
            timerParis.Start();
        }

        private void timerBaku_Tick(object sender, EventArgs e)
        {
            bakuLbl.Text = DateTime.Now.ToLongTimeString();
            timerBaku.Start();
        }
    }
}
