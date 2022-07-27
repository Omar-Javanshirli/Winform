namespace BakuAndLondonClock
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
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerIstanbul = new System.Windows.Forms.Timer(this.components);
            this.timerParis = new System.Windows.Forms.Timer(this.components);
            this.timerBaku = new System.Windows.Forms.Timer(this.components);
            this.bakuBtn = new System.Windows.Forms.Button();
            this.parisBtn = new System.Windows.Forms.Button();
            this.istanbulBtn = new System.Windows.Forms.Button();
            this.londonBtn = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.bakuBtn);
            this.panelMenu.Controls.Add(this.parisBtn);
            this.panelMenu.Controls.Add(this.istanbulBtn);
            this.panelMenu.Controls.Add(this.londonBtn);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 544);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.panelLogo.Size = new System.Drawing.Size(200, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerIstanbul
            // 
            this.timerIstanbul.Enabled = true;
            this.timerIstanbul.Tick += new System.EventHandler(this.timerIstanbul_Tick);
            // 
            // timerParis
            // 
            this.timerParis.Enabled = true;
            this.timerParis.Tick += new System.EventHandler(this.timerParis_Tick);
            // 
            // timerBaku
            // 
            this.timerBaku.Enabled = true;
            this.timerBaku.Tick += new System.EventHandler(this.timerBaku_Tick);
            // 
            // bakuBtn
            // 
            this.bakuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.bakuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.bakuBtn.FlatAppearance.BorderSize = 0;
            this.bakuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bakuBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.bakuBtn.Image = global::BakuAndLondonClock.Properties.Resources.baku1;
            this.bakuBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bakuBtn.Location = new System.Drawing.Point(0, 350);
            this.bakuBtn.Name = "bakuBtn";
            this.bakuBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.bakuBtn.Size = new System.Drawing.Size(200, 90);
            this.bakuBtn.TabIndex = 4;
            this.bakuBtn.Text = "Baku";
            this.bakuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bakuBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bakuBtn.UseVisualStyleBackColor = false;
            this.bakuBtn.Click += new System.EventHandler(this.bakuBtn_Click);
            // 
            // parisBtn
            // 
            this.parisBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.parisBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.parisBtn.FlatAppearance.BorderSize = 0;
            this.parisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parisBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.parisBtn.Image = global::BakuAndLondonClock.Properties.Resources.paris2;
            this.parisBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.parisBtn.Location = new System.Drawing.Point(0, 260);
            this.parisBtn.Name = "parisBtn";
            this.parisBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.parisBtn.Size = new System.Drawing.Size(200, 90);
            this.parisBtn.TabIndex = 3;
            this.parisBtn.Text = "Paris";
            this.parisBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.parisBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.parisBtn.UseVisualStyleBackColor = false;
            this.parisBtn.Click += new System.EventHandler(this.parisBtn_Click);
            // 
            // istanbulBtn
            // 
            this.istanbulBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.istanbulBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.istanbulBtn.FlatAppearance.BorderSize = 0;
            this.istanbulBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.istanbulBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.istanbulBtn.Image = global::BakuAndLondonClock.Properties.Resources.istanbul2;
            this.istanbulBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.istanbulBtn.Location = new System.Drawing.Point(0, 170);
            this.istanbulBtn.Name = "istanbulBtn";
            this.istanbulBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.istanbulBtn.Size = new System.Drawing.Size(200, 90);
            this.istanbulBtn.TabIndex = 2;
            this.istanbulBtn.Text = "Istanbul";
            this.istanbulBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.istanbulBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.istanbulBtn.UseVisualStyleBackColor = false;
            this.istanbulBtn.Click += new System.EventHandler(this.istanbulBtn_Click);
            // 
            // londonBtn
            // 
            this.londonBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.londonBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.londonBtn.FlatAppearance.BorderSize = 0;
            this.londonBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.londonBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.londonBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.londonBtn.Image = global::BakuAndLondonClock.Properties.Resources._2;
            this.londonBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.londonBtn.Location = new System.Drawing.Point(0, 80);
            this.londonBtn.Name = "londonBtn";
            this.londonBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.londonBtn.Size = new System.Drawing.Size(200, 90);
            this.londonBtn.TabIndex = 1;
            this.londonBtn.Text = "London";
            this.londonBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.londonBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.londonBtn.UseVisualStyleBackColor = false;
            this.londonBtn.Click += new System.EventHandler(this.londonBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button londonBtn;
        private System.Windows.Forms.Button bakuBtn;
        private System.Windows.Forms.Button parisBtn;
        private System.Windows.Forms.Button istanbulBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerIstanbul;
        private System.Windows.Forms.Timer timerParis;
        private System.Windows.Forms.Timer timerBaku;
    }
}

