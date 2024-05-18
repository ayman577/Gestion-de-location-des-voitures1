namespace Gestion_de_location_des_voitures1
{
    partial class letsStart
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(letsStart));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            perc = new Label();
            label3 = new Label();
            prog = new Guna.UI2.WinForms.Guna2ProgressBar();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(179, 46);
            label1.Name = "label1";
            label1.Size = new Size(284, 38);
            label1.TabIndex = 0;
            label1.Text = "ApolloCarRentals";
            label1.Click += label1_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(535, 394);
            label2.Name = "label2";
            label2.Size = new Size(89, 19);
            label2.TabIndex = 3;
            label2.Text = "let's drive....";
            label2.Click += timer1_Tick;
            // 
            // perc
            // 
            perc.AutoSize = true;
            perc.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            perc.ForeColor = Color.FromArgb(94, 148, 255);
            perc.Location = new Point(494, 118);
            perc.Name = "perc";
            perc.Size = new Size(63, 20);
            perc.TabIndex = 8;
            perc.Text = "label3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 12F);
            label3.ForeColor = Color.FromArgb(94, 148, 255);
            label3.Location = new Point(535, 118);
            label3.Name = "label3";
            label3.Size = new Size(22, 20);
            label3.TabIndex = 9;
            label3.Text = "%";
            // 
            // prog
            // 
            prog.CustomizableEdges = customizableEdges1;
            prog.FillColor = SystemColors.HotTrack;
            prog.Location = new Point(163, 108);
            prog.Name = "prog";
            prog.ProgressColor = Color.CornflowerBlue;
            prog.ProgressColor2 = Color.CornflowerBlue;
            prog.ShadowDecoration.CustomizableEdges = customizableEdges2;
            prog.Size = new Size(300, 30);
            prog.TabIndex = 11;
            prog.Text = "guna2ProgressBar1";
            prog.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.Image = (Image)resources.GetObject("guna2CirclePictureBox1.Image");
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(195, 156);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(247, 221);
            guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2CirclePictureBox1.TabIndex = 12;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // letsStart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(652, 450);
            Controls.Add(guna2CirclePictureBox1);
            Controls.Add(prog);
            Controls.Add(label3);
            Controls.Add(perc);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "letsStart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "letsStart";
            Load += letsStart_Load;
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private Label Percentage;
        private Label perc;
        private Label label3;
        private Guna.UI2.WinForms.Guna2ProgressBar prog;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
    }
}