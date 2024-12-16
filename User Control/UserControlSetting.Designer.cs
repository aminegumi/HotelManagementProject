namespace HotelRes1.User_Control
{
    partial class UserControlSetting
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControlUser = new TabControl();
            tabPageAddUser = new TabPage();
            buttonAdd = new Button();
            textBoxPassword = new TextBox();
            label3 = new Label();
            textBoxUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabPageSearchUser = new TabPage();
            dataGridViewUser = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            textBoxSearchUsername = new TextBox();
            label5 = new Label();
            label4 = new Label();
            tabPageUpdateAndDeleteUser = new TabPage();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            textBoxPassword1 = new TextBox();
            label6 = new Label();
            textBoxUsername1 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            tabControlUser.SuspendLayout();
            tabPageAddUser.SuspendLayout();
            tabPageSearchUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).BeginInit();
            tabPageUpdateAndDeleteUser.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlUser
            // 
            tabControlUser.Alignment = TabAlignment.Bottom;
            tabControlUser.Anchor = AnchorStyles.None;
            tabControlUser.Controls.Add(tabPageAddUser);
            tabControlUser.Controls.Add(tabPageSearchUser);
            tabControlUser.Controls.Add(tabPageUpdateAndDeleteUser);
            tabControlUser.Location = new Point(16, 21);
            tabControlUser.Name = "tabControlUser";
            tabControlUser.SelectedIndex = 0;
            tabControlUser.Size = new Size(1031, 402);
            tabControlUser.TabIndex = 0;
            // 
            // tabPageAddUser
            // 
            tabPageAddUser.Controls.Add(buttonAdd);
            tabPageAddUser.Controls.Add(textBoxPassword);
            tabPageAddUser.Controls.Add(label3);
            tabPageAddUser.Controls.Add(textBoxUsername);
            tabPageAddUser.Controls.Add(label2);
            tabPageAddUser.Controls.Add(label1);
            tabPageAddUser.Location = new Point(4, 4);
            tabPageAddUser.Name = "tabPageAddUser";
            tabPageAddUser.Padding = new Padding(3);
            tabPageAddUser.Size = new Size(1023, 366);
            tabPageAddUser.TabIndex = 0;
            tabPageAddUser.Text = "Add User";
            tabPageAddUser.UseVisualStyleBackColor = true;
            tabPageAddUser.Leave += tabPageAddUser_Leave;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.None;
            buttonAdd.BackColor = Color.FromArgb(175, 130, 96);
            buttonAdd.Cursor = Cursors.Hand;
            buttonAdd.FlatAppearance.BorderSize = 0;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(76, 238);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(145, 45);
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.None;
            textBoxPassword.Location = new Point(559, 147);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(330, 32);
            textBoxPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(559, 110);
            label3.Name = "label3";
            label3.Size = new Size(106, 23);
            label3.TabIndex = 3;
            label3.Text = "Password:";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Anchor = AnchorStyles.None;
            textBoxUsername.Location = new Point(76, 147);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(330, 32);
            textBoxUsername.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(76, 110);
            label2.Name = "label2";
            label2.Size = new Size(114, 23);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(175, 130, 96);
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(115, 26);
            label1.TabIndex = 0;
            label1.Text = "Add User:";
            // 
            // tabPageSearchUser
            // 
            tabPageSearchUser.Controls.Add(dataGridViewUser);
            tabPageSearchUser.Controls.Add(textBoxSearchUsername);
            tabPageSearchUser.Controls.Add(label5);
            tabPageSearchUser.Controls.Add(label4);
            tabPageSearchUser.Location = new Point(4, 4);
            tabPageSearchUser.Name = "tabPageSearchUser";
            tabPageSearchUser.Padding = new Padding(3);
            tabPageSearchUser.Size = new Size(1023, 366);
            tabPageSearchUser.TabIndex = 1;
            tabPageSearchUser.Text = "Search User";
            tabPageSearchUser.UseVisualStyleBackColor = true;
            tabPageSearchUser.Enter += tabPageSearchUser_Enter;
            tabPageSearchUser.Leave += tabPageSearchUser_Leave;
            // 
            // dataGridViewUser
            // 
            dataGridViewUser.AllowUserToAddRows = false;
            dataGridViewUser.AllowUserToDeleteRows = false;
            dataGridViewUser.Anchor = AnchorStyles.None;
            dataGridViewUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUser.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridViewUser.Location = new Point(28, 150);
            dataGridViewUser.Name = "dataGridViewUser";
            dataGridViewUser.ReadOnly = true;
            dataGridViewUser.RowHeadersWidth = 62;
            dataGridViewUser.Size = new Size(965, 202);
            dataGridViewUser.TabIndex = 5;
            dataGridViewUser.CellClick += dataGridViewUser_CellClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "User_ID";
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 200;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "User_Name";
            Column2.HeaderText = "Username";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 350;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "User_Password";
            Column3.HeaderText = "Password";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 350;
            // 
            // textBoxSearchUsername
            // 
            textBoxSearchUsername.Anchor = AnchorStyles.None;
            textBoxSearchUsername.Location = new Point(316, 90);
            textBoxSearchUsername.Name = "textBoxSearchUsername";
            textBoxSearchUsername.Size = new Size(330, 32);
            textBoxSearchUsername.TabIndex = 4;
            textBoxSearchUsername.TextChanged += textBoxSearchUsername_TextChanged;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(316, 53);
            label5.Name = "label5";
            label5.Size = new Size(114, 23);
            label5.TabIndex = 3;
            label5.Text = "Username:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(175, 130, 96);
            label4.Location = new Point(6, 17);
            label4.Name = "label4";
            label4.Size = new Size(143, 26);
            label4.TabIndex = 0;
            label4.Text = "Search User:";
            // 
            // tabPageUpdateAndDeleteUser
            // 
            tabPageUpdateAndDeleteUser.Controls.Add(buttonDelete);
            tabPageUpdateAndDeleteUser.Controls.Add(buttonUpdate);
            tabPageUpdateAndDeleteUser.Controls.Add(textBoxPassword1);
            tabPageUpdateAndDeleteUser.Controls.Add(label6);
            tabPageUpdateAndDeleteUser.Controls.Add(textBoxUsername1);
            tabPageUpdateAndDeleteUser.Controls.Add(label7);
            tabPageUpdateAndDeleteUser.Controls.Add(label8);
            tabPageUpdateAndDeleteUser.Location = new Point(4, 4);
            tabPageUpdateAndDeleteUser.Name = "tabPageUpdateAndDeleteUser";
            tabPageUpdateAndDeleteUser.Padding = new Padding(3);
            tabPageUpdateAndDeleteUser.Size = new Size(1023, 366);
            tabPageUpdateAndDeleteUser.TabIndex = 2;
            tabPageUpdateAndDeleteUser.Text = "Update and Delete User";
            tabPageUpdateAndDeleteUser.UseVisualStyleBackColor = true;
            tabPageUpdateAndDeleteUser.Leave += tabPageUpdateAndDeleteUser_Leave;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.None;
            buttonDelete.BackColor = Color.Firebrick;
            buttonDelete.Cursor = Cursors.Hand;
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(252, 249);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(145, 45);
            buttonDelete.TabIndex = 12;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Anchor = AnchorStyles.None;
            buttonUpdate.BackColor = Color.FromArgb(175, 130, 96);
            buttonUpdate.Cursor = Cursors.Hand;
            buttonUpdate.FlatAppearance.BorderSize = 0;
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUpdate.ForeColor = Color.White;
            buttonUpdate.Location = new Point(76, 249);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(145, 45);
            buttonUpdate.TabIndex = 11;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // textBoxPassword1
            // 
            textBoxPassword1.Anchor = AnchorStyles.None;
            textBoxPassword1.Location = new Point(559, 158);
            textBoxPassword1.Name = "textBoxPassword1";
            textBoxPassword1.Size = new Size(330, 32);
            textBoxPassword1.TabIndex = 10;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(559, 121);
            label6.Name = "label6";
            label6.Size = new Size(106, 23);
            label6.TabIndex = 9;
            label6.Text = "Password:";
            // 
            // textBoxUsername1
            // 
            textBoxUsername1.Anchor = AnchorStyles.None;
            textBoxUsername1.Location = new Point(76, 158);
            textBoxUsername1.Name = "textBoxUsername1";
            textBoxUsername1.Size = new Size(330, 32);
            textBoxUsername1.TabIndex = 8;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(76, 121);
            label7.Name = "label7";
            label7.Size = new Size(114, 23);
            label7.TabIndex = 7;
            label7.Text = "Username:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(175, 130, 96);
            label8.Location = new Point(6, 14);
            label8.Name = "label8";
            label8.Size = new Size(273, 26);
            label8.TabIndex = 6;
            label8.Text = "Update and Delete User:";
            // 
            // UserControlSetting
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabControlUser);
            Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UserControlSetting";
            Size = new Size(1102, 462);
            tabControlUser.ResumeLayout(false);
            tabPageAddUser.ResumeLayout(false);
            tabPageAddUser.PerformLayout();
            tabPageSearchUser.ResumeLayout(false);
            tabPageSearchUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).EndInit();
            tabPageUpdateAndDeleteUser.ResumeLayout(false);
            tabPageUpdateAndDeleteUser.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlUser;
        private TabPage tabPageAddUser;
        private TabPage tabPageSearchUser;
        private Label label1;
        private TextBox textBoxUsername;
        private Label label2;
        private Button buttonAdd;
        private TextBox textBoxPassword;
        private Label label3;
        private Label label4;
        private TextBox textBoxSearchUsername;
        private Label label5;
        private DataGridView dataGridViewUser;
        private TabPage tabPageUpdateAndDeleteUser;
        private Button buttonUpdate;
        private TextBox textBoxPassword1;
        private Label label6;
        private TextBox textBoxUsername1;
        private Label label7;
        private Label label8;
        private Button buttonDelete;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}
