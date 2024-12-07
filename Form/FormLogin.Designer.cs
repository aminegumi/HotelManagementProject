namespace HotelRes1
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            pictureBoxClose = new PictureBox();
            pictureBoxMinimize = new PictureBox();
            toolTip1 = new ToolTip(components);
            panel1 = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            textBoxPassword = new TextBox();
            label4 = new Label();
            label3 = new Label();
            buttonLogIn = new Button();
            textBoxUsername = new TextBox();
            label2 = new Label();
            pictureBoxHide = new PictureBox();
            pictureBoxShow = new PictureBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxClose.Image = Properties.Resources.icons8_fermer_la_fenêtre_50;
            pictureBoxClose.Location = new Point(1319, 2);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(35, 35);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxClose.TabIndex = 0;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            pictureBoxClose.MouseHover += pictureBoxClose_MouseHover;
            // 
            // pictureBoxMinimize
            // 
            pictureBoxMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxMinimize.Image = (Image)resources.GetObject("pictureBoxMinimize.Image");
            pictureBoxMinimize.Location = new Point(1278, 2);
            pictureBoxMinimize.Name = "pictureBoxMinimize";
            pictureBoxMinimize.Size = new Size(35, 35);
            pictureBoxMinimize.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMinimize.TabIndex = 1;
            pictureBoxMinimize.TabStop = false;
            pictureBoxMinimize.Click += pictureBoxMinimize_Click;
            pictureBoxMinimize.MouseHover += pictureBoxMinimize_MouseHover;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 666);
            panel1.Name = "panel1";
            panel1.Size = new Size(1366, 54);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(410, 25);
            label1.Name = "label1";
            label1.Size = new Size(603, 20);
            label1.TabIndex = 0;
            label1.Text = "ISSAME IMAD - AGOUMI MOHAMMED AMINE - MAAROUFI AMINE - GHAOURI ZOUHAIR";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(textBoxPassword);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(buttonLogIn);
            groupBox1.Controls.Add(textBoxUsername);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(pictureBoxHide);
            groupBox1.Controls.Add(pictureBoxShow);
            groupBox1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            groupBox1.Location = new Point(79, 127);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(433, 382);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login Form";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.None;
            textBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassword.Location = new Point(60, 173);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(287, 28);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(128, 64, 0);
            label4.Location = new Point(144, 268);
            label4.Name = "label4";
            label4.Size = new Size(152, 19);
            label4.TabIndex = 5;
            label4.Text = "Forgot Password?";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label3.Location = new Point(60, 143);
            label3.Name = "label3";
            label3.Size = new Size(97, 19);
            label3.TabIndex = 3;
            label3.Text = "Password :";
            // 
            // buttonLogIn
            // 
            buttonLogIn.Anchor = AnchorStyles.None;
            buttonLogIn.BackColor = Color.FromArgb(128, 64, 0);
            buttonLogIn.FlatAppearance.BorderSize = 0;
            buttonLogIn.FlatStyle = FlatStyle.Flat;
            buttonLogIn.ForeColor = Color.White;
            buttonLogIn.Location = new Point(60, 298);
            buttonLogIn.Name = "buttonLogIn";
            buttonLogIn.Size = new Size(318, 46);
            buttonLogIn.TabIndex = 3;
            buttonLogIn.Text = "Log In";
            buttonLogIn.UseVisualStyleBackColor = false;
            buttonLogIn.Click += buttonLogIn_Click;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Anchor = AnchorStyles.None;
            textBoxUsername.BorderStyle = BorderStyle.FixedSingle;
            textBoxUsername.Location = new Point(60, 82);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(318, 28);
            textBoxUsername.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label2.Location = new Point(60, 52);
            label2.Name = "label2";
            label2.Size = new Size(104, 19);
            label2.TabIndex = 0;
            label2.Text = "UserName :";
            // 
            // pictureBoxHide
            // 
            pictureBoxHide.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxHide.Image = Properties.Resources.monkey;
            pictureBoxHide.Location = new Point(346, 173);
            pictureBoxHide.Name = "pictureBoxHide";
            pictureBoxHide.Size = new Size(32, 28);
            pictureBoxHide.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxHide.TabIndex = 6;
            pictureBoxHide.TabStop = false;
            pictureBoxHide.Click += pictureBoxHide_Click;
            pictureBoxHide.MouseHover += pictureBoxHide_MouseHover;
            // 
            // pictureBoxShow
            // 
            pictureBoxShow.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxShow.Image = (Image)resources.GetObject("pictureBoxShow.Image");
            pictureBoxShow.Location = new Point(346, 173);
            pictureBoxShow.Name = "pictureBoxShow";
            pictureBoxShow.Size = new Size(32, 28);
            pictureBoxShow.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxShow.TabIndex = 7;
            pictureBoxShow.TabStop = false;
            pictureBoxShow.Click += pictureBoxShow_Click;
            pictureBoxShow.MouseHover += pictureBoxShow_MouseHover;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(128, 64, 0);
            panel2.Location = new Point(661, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(5, 534);
            panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(809, 127);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(490, 382);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1366, 720);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(pictureBoxMinimize);
            Controls.Add(pictureBoxClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHide).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShow).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxClose;
        private PictureBox pictureBoxMinimize;
        private ToolTip toolTip1;
        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBoxUsername;
        private Label label2;
        private Button buttonLogIn;
        private TextBox textBoxPassword;
        private Label label3;
        private Label label4;
        private PictureBox pictureBoxHide;
        private PictureBox pictureBoxShow;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}
