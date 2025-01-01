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
            label4 = new Label();
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
            panel1.BackColor = Color.FromArgb(70, 90, 100);
            panel1.Controls.Add(labelUserCount);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(337, 178);
            panel1.Name = "panel1";
            panel1.Size = new Size(361, 147);
            panel1.TabIndex = 0;
            // 
            // labelUserCount
            // 
            labelUserCount.AutoSize = true;
            labelUserCount.Location = new Point(159, 96);
            labelUserCount.Name = "labelUserCount";
            labelUserCount.Size = new Size(25, 29);
            labelUserCount.TabIndex = 0;
            labelUserCount.Text = "?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 67);
            label1.Name = "label1";
            label1.Size = new Size(70, 29);
            label1.TabIndex = 4;
            label1.Text = "User:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user_icon_vector;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(181, 236, 255);
            panel2.Controls.Add(labelClientCount);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(848, 178);
            panel2.Name = "panel2";
            panel2.Size = new Size(361, 147);
            panel2.TabIndex = 1;
            // 
            // labelClientCount
            // 
            labelClientCount.AutoSize = true;
            labelClientCount.Location = new Point(165, 96);
            labelClientCount.Name = "labelClientCount";
            labelClientCount.Size = new Size(25, 29);
            labelClientCount.TabIndex = 0;
            labelClientCount.Text = "?";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.OIP1;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(111, 59);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 67);
            label2.Name = "label2";
            label2.Size = new Size(81, 29);
            label2.TabIndex = 6;
            label2.Text = "Client:";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.FromArgb(207, 147, 217);
            panel3.Controls.Add(labelRoomCount);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(582, 473);
            panel3.Name = "panel3";
            panel3.Size = new Size(361, 147);
            panel3.TabIndex = 2;
            // 
            // labelRoomCount
            // 
            labelRoomCount.AutoSize = true;
            labelRoomCount.Location = new Point(165, 96);
            labelRoomCount.Name = "labelRoomCount";
            labelRoomCount.Size = new Size(25, 29);
            labelRoomCount.TabIndex = 8;
            labelRoomCount.Text = "?";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.rooms_icon_style_free_vector;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(111, 59);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(138, 67);
            label4.Name = "label4";
            label4.Size = new Size(84, 29);
            label4.TabIndex = 9;
            label4.Text = "Room:";
            // 
            // UserControlDashboard
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
        private Label label4;
    }
}
