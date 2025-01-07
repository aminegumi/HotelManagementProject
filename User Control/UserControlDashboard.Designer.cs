namespace HotelRes1.User_Control
{
    partial class UserControlDashboard
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            labelUserCount = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            labelClientCount = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            panel3 = new Panel();
            labelRoomCount = new Label();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(185, 156, 107);
            panel1.Controls.Add(labelUserCount);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(248, 160);
            panel1.Name = "panel1";
            panel1.Size = new Size(420, 153);
            panel1.TabIndex = 0;
            // 
            // labelUserCount
            // 
            labelUserCount.AutoSize = true;
            labelUserCount.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUserCount.Location = new Point(183, 83);
            labelUserCount.Name = "labelUserCount";
            labelUserCount.Size = new Size(21, 23);
            labelUserCount.TabIndex = 0;
            labelUserCount.Text = "?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(114, 83);
            label1.Name = "label1";
            label1.Size = new Size(63, 23);
            label1.TabIndex = 1;
            label1.Text = "User: ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.people;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(185, 156, 107);
            panel2.Controls.Add(labelClientCount);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(986, 160);
            panel2.Name = "panel2";
            panel2.Size = new Size(420, 153);
            panel2.TabIndex = 1;
            // 
            // labelClientCount
            // 
            labelClientCount.AutoSize = true;
            labelClientCount.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelClientCount.Location = new Point(212, 83);
            labelClientCount.Name = "labelClientCount";
            labelClientCount.Size = new Size(21, 23);
            labelClientCount.TabIndex = 0;
            labelClientCount.Text = "?";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.rating;
            pictureBox2.Location = new Point(4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(115, 83);
            label2.Name = "label2";
            label2.Size = new Size(79, 23);
            label2.TabIndex = 1;
            label2.Text = "Client: ";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.FromArgb(185, 156, 107);
            panel3.Controls.Add(labelRoomCount);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(622, 453);
            panel3.Name = "panel3";
            panel3.Size = new Size(420, 153);
            panel3.TabIndex = 1;
            // 
            // labelRoomCount
            // 
            labelRoomCount.AutoSize = true;
            labelRoomCount.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRoomCount.Location = new Point(212, 83);
            labelRoomCount.Name = "labelRoomCount";
            labelRoomCount.Size = new Size(21, 23);
            labelRoomCount.TabIndex = 0;
            labelRoomCount.Text = "?";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.hotel__2_;
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 62);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(115, 83);
            label3.Name = "label3";
            label3.Size = new Size(79, 23);
            label3.TabIndex = 1;
            label3.Text = "Room: ";
            // 
            // UserControlDashboard
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UserControlDashboard";
            Size = new Size(1630, 913);
            Load += UserControlDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private PictureBox pictureBox1;
        private Label labelUserCount;
        private Label labelClientCount;
        private PictureBox pictureBox2;
        private Label label2;
        private Label labelRoomCount;
        private PictureBox pictureBox3;
        private Label label3;
    }
}
