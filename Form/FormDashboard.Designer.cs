namespace HotelRes1
{
    partial class FormDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            panel1 = new Panel();
            panelSlide = new Panel();
            buttonSetting = new Button();
            buttonReservation = new Button();
            buttonRoom = new Button();
            buttonClient = new Button();
            buttonDashboard = new Button();
            panel3 = new Panel();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            labelUsername = new Label();
            label4 = new Label();
            panel5 = new Panel();
            labelDateTime = new Label();
            linkLabelLogout = new LinkLabel();
            pictureBox2 = new PictureBox();
            panel6 = new Panel();
            userControlReservation1 = new User_Control.UserControlReservation();
            userControlSetting1 = new User_Control.UserControlSetting();
            userControlClient1 = new User_Control.UserControlClient();
            timer1 = new System.Windows.Forms.Timer(components);
            userControlRoom1 = new User_Control.UserControlRoom();
            userControlRoom2 = new User_Control.UserControlRoom();
            userControlDashboard1 = new User_Control.UserControlDashboard();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(175, 130, 96);
            panel1.Controls.Add(panelSlide);
            panel1.Controls.Add(buttonSetting);
            panel1.Controls.Add(buttonReservation);
            panel1.Controls.Add(buttonRoom);
            panel1.Controls.Add(buttonClient);
            panel1.Controls.Add(buttonDashboard);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(315, 826);
            panel1.TabIndex = 0;
            // 
            // panelSlide
            // 
            panelSlide.BackColor = Color.Black;
            panelSlide.Location = new Point(12, 239);
            panelSlide.Name = "panelSlide";
            panelSlide.Size = new Size(11, 48);
            panelSlide.TabIndex = 0;
            // 
            // buttonSetting
            // 
            buttonSetting.Cursor = Cursors.Hand;
            buttonSetting.FlatAppearance.BorderSize = 0;
            buttonSetting.FlatStyle = FlatStyle.Flat;
            buttonSetting.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSetting.Image = (Image)resources.GetObject("buttonSetting.Image");
            buttonSetting.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSetting.Location = new Point(29, 455);
            buttonSetting.Name = "buttonSetting";
            buttonSetting.Size = new Size(254, 48);
            buttonSetting.TabIndex = 5;
            buttonSetting.Text = "  Setting";
            buttonSetting.UseVisualStyleBackColor = true;
            buttonSetting.Click += buttonSetting_Click;
            // 
            // buttonReservation
            // 
            buttonReservation.Cursor = Cursors.Hand;
            buttonReservation.FlatAppearance.BorderSize = 0;
            buttonReservation.FlatStyle = FlatStyle.Flat;
            buttonReservation.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonReservation.Image = (Image)resources.GetObject("buttonReservation.Image");
            buttonReservation.ImageAlign = ContentAlignment.MiddleLeft;
            buttonReservation.Location = new Point(29, 401);
            buttonReservation.Name = "buttonReservation";
            buttonReservation.Size = new Size(254, 48);
            buttonReservation.TabIndex = 4;
            buttonReservation.Text = "          Reservation";
            buttonReservation.UseVisualStyleBackColor = true;
            buttonReservation.Click += buttonReservation_Click;
            // 
            // buttonRoom
            // 
            buttonRoom.Cursor = Cursors.Hand;
            buttonRoom.FlatAppearance.BorderSize = 0;
            buttonRoom.FlatStyle = FlatStyle.Flat;
            buttonRoom.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRoom.Image = (Image)resources.GetObject("buttonRoom.Image");
            buttonRoom.ImageAlign = ContentAlignment.MiddleLeft;
            buttonRoom.Location = new Point(29, 347);
            buttonRoom.Name = "buttonRoom";
            buttonRoom.Size = new Size(254, 48);
            buttonRoom.TabIndex = 3;
            buttonRoom.Text = "Room";
            buttonRoom.UseVisualStyleBackColor = true;
            buttonRoom.Click += buttonRoom_Click;
            // 
            // buttonClient
            // 
            buttonClient.Cursor = Cursors.Hand;
            buttonClient.FlatAppearance.BorderSize = 0;
            buttonClient.FlatStyle = FlatStyle.Flat;
            buttonClient.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonClient.Image = (Image)resources.GetObject("buttonClient.Image");
            buttonClient.ImageAlign = ContentAlignment.MiddleLeft;
            buttonClient.Location = new Point(29, 293);
            buttonClient.Name = "buttonClient";
            buttonClient.Size = new Size(254, 48);
            buttonClient.TabIndex = 2;
            buttonClient.Text = "Client";
            buttonClient.UseVisualStyleBackColor = true;
            buttonClient.Click += buttonClient_Click;
            // 
            // buttonDashboard
            // 
            buttonDashboard.Cursor = Cursors.Hand;
            buttonDashboard.FlatAppearance.BorderSize = 0;
            buttonDashboard.FlatStyle = FlatStyle.Flat;
            buttonDashboard.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDashboard.Location = new Point(29, 239);
            buttonDashboard.Name = "buttonDashboard";
            buttonDashboard.Size = new Size(254, 48);
            buttonDashboard.TabIndex = 1;
            buttonDashboard.Text = "         Dashboard";
            buttonDashboard.UseVisualStyleBackColor = true;
            buttonDashboard.Click += buttonDashboard_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(175, 130, 96);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(315, 192);
            panel3.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(9, 86);
            label3.Name = "label3";
            label3.Size = new Size(327, 39);
            label3.TabIndex = 0;
            label3.Text = "Hotel Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(92, 119);
            label2.Name = "label2";
            label2.Size = new Size(130, 39);
            label2.TabIndex = 0;
            label2.Text = "System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(107, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(315, 771);
            panel2.Name = "panel2";
            panel2.Size = new Size(1221, 55);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(198, 16);
            label1.Name = "label1";
            label1.Size = new Size(865, 24);
            label1.TabIndex = 1;
            label1.Text = "ISSAME IMAD - AGOUMI MOHAMMED AMINE - MAAROUFI AMINE - GHAOURI ZOUHAIR";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(175, 130, 96);
            panel4.Controls.Add(labelUsername);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(315, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1221, 192);
            panel4.TabIndex = 0;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.ForeColor = Color.White;
            labelUsername.Location = new Point(152, 119);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(31, 34);
            labelUsername.TabIndex = 2;
            labelUsername.Text = "?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(19, 119);
            label4.Name = "label4";
            label4.Size = new Size(153, 34);
            label4.TabIndex = 1;
            label4.Text = "Welcome:";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(labelDateTime);
            panel5.Controls.Add(linkLabelLogout);
            panel5.Controls.Add(pictureBox2);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1221, 81);
            panel5.TabIndex = 2;
            // 
            // labelDateTime
            // 
            labelDateTime.AutoSize = true;
            labelDateTime.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDateTime.ForeColor = Color.FromArgb(193, 154, 107);
            labelDateTime.Location = new Point(19, 47);
            labelDateTime.Name = "labelDateTime";
            labelDateTime.Size = new Size(25, 28);
            labelDateTime.TabIndex = 0;
            labelDateTime.Text = "?";
            // 
            // linkLabelLogout
            // 
            linkLabelLogout.ActiveLinkColor = Color.FromArgb(175, 130, 96);
            linkLabelLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            linkLabelLogout.AutoSize = true;
            linkLabelLogout.Cursor = Cursors.Hand;
            linkLabelLogout.DisabledLinkColor = Color.FromArgb(175, 130, 96);
            linkLabelLogout.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabelLogout.ForeColor = Color.FromArgb(175, 130, 96);
            linkLabelLogout.LinkColor = Color.FromArgb(175, 130, 96);
            linkLabelLogout.Location = new Point(1141, 47);
            linkLabelLogout.Name = "linkLabelLogout";
            linkLabelLogout.Size = new Size(86, 25);
            linkLabelLogout.TabIndex = 0;
            linkLabelLogout.TabStop = true;
            linkLabelLogout.Text = "Log out";
            linkLabelLogout.VisitedLinkColor = Color.FromArgb(175, 130, 96);
            linkLabelLogout.LinkClicked += linkLabelLogout_LinkClicked;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Location = new Point(1070, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(65, 65);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(userControlRoom2);
            panel6.Controls.Add(userControlReservation1);
            panel6.Controls.Add(userControlDashboard1);
            panel6.Controls.Add(userControlSetting1);
            panel6.Controls.Add(userControlClient1);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(315, 192);
            panel6.Name = "panel6";
            panel6.Size = new Size(1221, 579);
            panel6.TabIndex = 0;
            // 
            // userControlReservation1
            // 
            userControlReservation1.BackColor = Color.White;
            userControlReservation1.Dock = DockStyle.Fill;
            userControlReservation1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userControlReservation1.Location = new Point(0, 0);
            userControlReservation1.Margin = new Padding(4, 3, 4, 3);
            userControlReservation1.Name = "userControlReservation1";
            userControlReservation1.Size = new Size(1221, 579);
            userControlReservation1.TabIndex = 0;
            userControlReservation1.Visible = false;
            // 
            // userControlSetting1
            // 
            userControlSetting1.BackColor = Color.White;
            userControlSetting1.Dock = DockStyle.Fill;
            userControlSetting1.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userControlSetting1.Location = new Point(0, 0);
            userControlSetting1.Margin = new Padding(4, 3, 4, 3);
            userControlSetting1.Name = "userControlSetting1";
            userControlSetting1.Size = new Size(1221, 579);
            userControlSetting1.TabIndex = 0;
            userControlSetting1.Visible = false;
            // 
            // userControlClient1
            // 
            userControlClient1.BackColor = Color.White;
            userControlClient1.Dock = DockStyle.Fill;
            userControlClient1.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userControlClient1.Location = new Point(0, 0);
            userControlClient1.Margin = new Padding(3, 2, 3, 2);
            userControlClient1.Name = "userControlClient1";
            userControlClient1.Size = new Size(1221, 579);
            userControlClient1.TabIndex = 0;
            userControlClient1.Visible = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // userControlRoom1
            // 
            userControlRoom1.BackColor = Color.White;
            userControlRoom1.Dock = DockStyle.Fill;
            userControlRoom1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userControlRoom1.Location = new Point(0, 0);
            userControlRoom1.Name = "userControlRoom1";
            userControlRoom1.Size = new Size(1536, 826);
            userControlRoom1.TabIndex = 0;
            userControlRoom1.Visible = false;
            // 
            // userControlRoom2
            // 
            userControlRoom2.BackColor = Color.White;
            userControlRoom2.Dock = DockStyle.Fill;
            userControlRoom2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userControlRoom2.Location = new Point(0, 0);
            userControlRoom2.Name = "userControlRoom2";
            userControlRoom2.Size = new Size(1221, 579);
            userControlRoom2.TabIndex = 0;
            userControlRoom2.Visible = false;
            //
            // userControlDashboard1
            // 
            userControlDashboard1.BackColor = Color.White;
            userControlDashboard1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userControlDashboard1.Location = new Point(71, 20);
            userControlDashboard1.Margin = new Padding(4, 3, 4, 3);
            userControlDashboard1.Name = "userControlDashboard1";
            userControlDashboard1.Size = new Size(1137, 614);
            userControlDashboard1.TabIndex = 6;
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1536, 826);
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(userControlRoom1);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hotel_Management_System | Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += FormDashboard_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label1;
        private PictureBox pictureBox2;
        private LinkLabel linkLabelLogout;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private Label labelDateTime;
        private Label labelUsername;
        private Label label4;
        private Button buttonDashboard;
        private Button buttonSetting;
        private Button buttonReservation;
        private Button buttonRoom;
        private Button buttonClient;
        private Panel panelSlide;
        private Panel panel6;
        private System.Windows.Forms.Timer timer1;
        private User_Control.UserControlSetting userControlSetting1;
        private User_Control.UserControlClient userControlClient1;
        private User_Control.UserControlRoom userControlRoom1;
        private User_Control.UserControlReservation userControlReservation1;
        private User_Control.UserControlRoom userControlRoom2;
        private User_Control.UserControlDashboard userControlDashboard1;
    }
}