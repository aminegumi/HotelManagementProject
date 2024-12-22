namespace HotelRes1.User_Control
{
    partial class UserControlRoom
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
            tabControlRoom = new TabControl();
            tabPageAddRoom = new TabPage();
            radioButtonNo = new RadioButton();
            radioButtonYes = new RadioButton();
            comboBoxType = new ComboBox();
            button1 = new Button();
            textBoxPhoneNo = new TextBox();
            label4 = new Label();
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            tabPageSearchRoom = new TabPage();
            dataGridViewRoom = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            textBoxSearchRoomNo = new TextBox();
            label8 = new Label();
            label9 = new Label();
            tabPageUpdateAndDeleteRoom = new TabPage();
            radioButtonNo1 = new RadioButton();
            radioButtonYes1 = new RadioButton();
            comboBoxType1 = new ComboBox();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            textBoxPhoneNo1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label10 = new Label();
            tabControlRoom.SuspendLayout();
            tabPageAddRoom.SuspendLayout();
            tabPageSearchRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoom).BeginInit();
            tabPageUpdateAndDeleteRoom.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlRoom
            // 
            tabControlRoom.Alignment = TabAlignment.Bottom;
            tabControlRoom.Anchor = AnchorStyles.None;
            tabControlRoom.Controls.Add(tabPageAddRoom);
            tabControlRoom.Controls.Add(tabPageSearchRoom);
            tabControlRoom.Controls.Add(tabPageUpdateAndDeleteRoom);
            tabControlRoom.Location = new Point(31, 90);
            tabControlRoom.Name = "tabControlRoom";
            tabControlRoom.SelectedIndex = 0;
            tabControlRoom.Size = new Size(1562, 674);
            tabControlRoom.TabIndex = 0;
            // 
            // tabPageAddRoom
            // 
            tabPageAddRoom.Controls.Add(radioButtonNo);
            tabPageAddRoom.Controls.Add(radioButtonYes);
            tabPageAddRoom.Controls.Add(comboBoxType);
            tabPageAddRoom.Controls.Add(button1);
            tabPageAddRoom.Controls.Add(textBoxPhoneNo);
            tabPageAddRoom.Controls.Add(label4);
            tabPageAddRoom.Controls.Add(label7);
            tabPageAddRoom.Controls.Add(label5);
            tabPageAddRoom.Controls.Add(label6);
            tabPageAddRoom.Location = new Point(4, 4);
            tabPageAddRoom.Name = "tabPageAddRoom";
            tabPageAddRoom.Padding = new Padding(3);
            tabPageAddRoom.Size = new Size(1554, 641);
            tabPageAddRoom.TabIndex = 0;
            tabPageAddRoom.Text = "Add Room";
            tabPageAddRoom.UseVisualStyleBackColor = true;
            tabPageAddRoom.Leave += tabPageAddRoom_Leave;
            // 
            // radioButtonNo
            // 
            radioButtonNo.AutoSize = true;
            radioButtonNo.Location = new Point(160, 262);
            radioButtonNo.Name = "radioButtonNo";
            radioButtonNo.Size = new Size(51, 24);
            radioButtonNo.TabIndex = 13;
            radioButtonNo.TabStop = true;
            radioButtonNo.Text = "No";
            radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonYes
            // 
            radioButtonYes.AutoSize = true;
            radioButtonYes.Location = new Point(160, 232);
            radioButtonYes.Name = "radioButtonYes";
            radioButtonYes.Size = new Size(53, 24);
            radioButtonYes.TabIndex = 13;
            radioButtonYes.TabStop = true;
            radioButtonYes.Text = "Yes";
            radioButtonYes.UseVisualStyleBackColor = true;
            // 
            // comboBoxType
            // 
            comboBoxType.Anchor = AnchorStyles.None;
            comboBoxType.Cursor = Cursors.Hand;
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.FlatStyle = FlatStyle.Flat;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Single", "Double", "Family", "Suite" });
            comboBoxType.Location = new Point(76, 147);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(330, 28);
            comboBoxType.TabIndex = 12;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(175, 130, 96);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(76, 343);
            button1.Name = "button1";
            button1.Size = new Size(145, 45);
            button1.TabIndex = 11;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBoxPhoneNo
            // 
            textBoxPhoneNo.Anchor = AnchorStyles.None;
            textBoxPhoneNo.Location = new Point(559, 147);
            textBoxPhoneNo.Name = "textBoxPhoneNo";
            textBoxPhoneNo.Size = new Size(330, 26);
            textBoxPhoneNo.TabIndex = 10;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(559, 110);
            label4.Name = "label4";
            label4.Size = new Size(95, 19);
            label4.TabIndex = 9;
            label4.Text = "Phone No:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(76, 250);
            label7.Name = "label7";
            label7.Size = new Size(49, 19);
            label7.TabIndex = 7;
            label7.Text = "Free:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(76, 110);
            label5.Name = "label5";
            label5.Size = new Size(53, 19);
            label5.TabIndex = 7;
            label5.Text = "Type:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(175, 130, 96);
            label6.Location = new Point(6, 3);
            label6.Name = "label6";
            label6.Size = new Size(118, 23);
            label6.TabIndex = 6;
            label6.Text = "Add Room :";
            // 
            // tabPageSearchRoom
            // 
            tabPageSearchRoom.Controls.Add(dataGridViewRoom);
            tabPageSearchRoom.Controls.Add(textBoxSearchRoomNo);
            tabPageSearchRoom.Controls.Add(label8);
            tabPageSearchRoom.Controls.Add(label9);
            tabPageSearchRoom.Location = new Point(4, 4);
            tabPageSearchRoom.Name = "tabPageSearchRoom";
            tabPageSearchRoom.Padding = new Padding(3);
            tabPageSearchRoom.Size = new Size(1554, 641);
            tabPageSearchRoom.TabIndex = 1;
            tabPageSearchRoom.Text = "Search Room";
            tabPageSearchRoom.UseVisualStyleBackColor = true;
            tabPageSearchRoom.Enter += tabPageSearchRoom_Enter;
            tabPageSearchRoom.Leave += tabPageSearchRoom_Leave;
            // 
            // dataGridViewRoom
            // 
            dataGridViewRoom.AllowUserToAddRows = false;
            dataGridViewRoom.AllowUserToDeleteRows = false;
            dataGridViewRoom.Anchor = AnchorStyles.None;
            dataGridViewRoom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRoom.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewRoom.Location = new Point(46, 246);
            dataGridViewRoom.Name = "dataGridViewRoom";
            dataGridViewRoom.ReadOnly = true;
            dataGridViewRoom.RowHeadersWidth = 62;
            dataGridViewRoom.Size = new Size(1464, 298);
            dataGridViewRoom.TabIndex = 13;
            dataGridViewRoom.CellClick += dataGridViewRoom_CellClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Room_Number";
            Column1.HeaderText = "No.";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Room_Type";
            Column2.HeaderText = "Type";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Room_Phone";
            Column3.HeaderText = "Phone";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Room_Free";
            Column4.HeaderText = "Is Free?";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // textBoxSearchRoomNo
            // 
            textBoxSearchRoomNo.Anchor = AnchorStyles.None;
            textBoxSearchRoomNo.Location = new Point(579, 118);
            textBoxSearchRoomNo.Name = "textBoxSearchRoomNo";
            textBoxSearchRoomNo.Size = new Size(330, 26);
            textBoxSearchRoomNo.TabIndex = 12;
            textBoxSearchRoomNo.TextChanged += textBoxSearchRoomNo_TextChanged;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(579, 81);
            label8.Name = "label8";
            label8.Size = new Size(91, 19);
            label8.TabIndex = 11;
            label8.Text = "Room No:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(175, 130, 96);
            label9.Location = new Point(6, 3);
            label9.Name = "label9";
            label9.Size = new Size(137, 23);
            label9.TabIndex = 10;
            label9.Text = "Search Room:";
            // 
            // tabPageUpdateAndDeleteRoom
            // 
            tabPageUpdateAndDeleteRoom.Controls.Add(radioButtonNo1);
            tabPageUpdateAndDeleteRoom.Controls.Add(radioButtonYes1);
            tabPageUpdateAndDeleteRoom.Controls.Add(comboBoxType1);
            tabPageUpdateAndDeleteRoom.Controls.Add(buttonDelete);
            tabPageUpdateAndDeleteRoom.Controls.Add(buttonUpdate);
            tabPageUpdateAndDeleteRoom.Controls.Add(textBoxPhoneNo1);
            tabPageUpdateAndDeleteRoom.Controls.Add(label1);
            tabPageUpdateAndDeleteRoom.Controls.Add(label2);
            tabPageUpdateAndDeleteRoom.Controls.Add(label3);
            tabPageUpdateAndDeleteRoom.Controls.Add(label10);
            tabPageUpdateAndDeleteRoom.Location = new Point(4, 4);
            tabPageUpdateAndDeleteRoom.Name = "tabPageUpdateAndDeleteRoom";
            tabPageUpdateAndDeleteRoom.Padding = new Padding(3);
            tabPageUpdateAndDeleteRoom.Size = new Size(1554, 641);
            tabPageUpdateAndDeleteRoom.TabIndex = 2;
            tabPageUpdateAndDeleteRoom.Text = "Update and Delete Room";
            tabPageUpdateAndDeleteRoom.UseVisualStyleBackColor = true;
            // 
            // radioButtonNo1
            // 
            radioButtonNo1.AutoSize = true;
            radioButtonNo1.Location = new Point(157, 262);
            radioButtonNo1.Name = "radioButtonNo1";
            radioButtonNo1.Size = new Size(51, 24);
            radioButtonNo1.TabIndex = 21;
            radioButtonNo1.TabStop = true;
            radioButtonNo1.Text = "No";
            radioButtonNo1.UseVisualStyleBackColor = true;
            // 
            // radioButtonYes1
            // 
            radioButtonYes1.AutoSize = true;
            radioButtonYes1.Location = new Point(157, 232);
            radioButtonYes1.Name = "radioButtonYes1";
            radioButtonYes1.Size = new Size(53, 24);
            radioButtonYes1.TabIndex = 22;
            radioButtonYes1.TabStop = true;
            radioButtonYes1.Text = "Yes";
            radioButtonYes1.UseVisualStyleBackColor = true;
            // 
            // comboBoxType1
            // 
            comboBoxType1.Anchor = AnchorStyles.None;
            comboBoxType1.Cursor = Cursors.Hand;
            comboBoxType1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType1.FlatStyle = FlatStyle.Flat;
            comboBoxType1.FormattingEnabled = true;
            comboBoxType1.Items.AddRange(new object[] { "Single", "Double", "Family", "Suite" });
            comboBoxType1.Location = new Point(73, 147);
            comboBoxType1.Name = "comboBoxType1";
            comboBoxType1.Size = new Size(330, 28);
            comboBoxType1.TabIndex = 20;
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
            buttonDelete.Location = new Point(224, 343);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(145, 45);
            buttonDelete.TabIndex = 19;
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
            buttonUpdate.Location = new Point(73, 343);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(145, 45);
            buttonUpdate.TabIndex = 19;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // textBoxPhoneNo1
            // 
            textBoxPhoneNo1.Anchor = AnchorStyles.None;
            textBoxPhoneNo1.Location = new Point(556, 147);
            textBoxPhoneNo1.Name = "textBoxPhoneNo1";
            textBoxPhoneNo1.Size = new Size(330, 26);
            textBoxPhoneNo1.TabIndex = 18;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(556, 110);
            label1.Name = "label1";
            label1.Size = new Size(95, 19);
            label1.TabIndex = 17;
            label1.Text = "Phone No:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(73, 250);
            label2.Name = "label2";
            label2.Size = new Size(49, 19);
            label2.TabIndex = 15;
            label2.Text = "Free:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(73, 110);
            label3.Name = "label3";
            label3.Size = new Size(53, 19);
            label3.TabIndex = 16;
            label3.Text = "Type:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(175, 130, 96);
            label10.Location = new Point(3, 3);
            label10.Name = "label10";
            label10.Size = new Size(255, 23);
            label10.TabIndex = 14;
            label10.Text = "Update and Delete Room :";
            // 
            // UserControlRoom
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabControlRoom);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "UserControlRoom";
            Size = new Size(1630, 913);
            tabControlRoom.ResumeLayout(false);
            tabPageAddRoom.ResumeLayout(false);
            tabPageAddRoom.PerformLayout();
            tabPageSearchRoom.ResumeLayout(false);
            tabPageSearchRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoom).EndInit();
            tabPageUpdateAndDeleteRoom.ResumeLayout(false);
            tabPageUpdateAndDeleteRoom.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlRoom;
        private TabPage tabPageAddRoom;
        private TabPage tabPageSearchRoom;
        private TabPage tabPageUpdateAndDeleteRoom;
        private ComboBox comboBoxType;
        private Button button1;
        private TextBox textBoxPhoneNo;
        private Label label4;
        private Label label5;
        private Label label6;
        private RadioButton radioButtonNo;
        private RadioButton radioButtonYes;
        private Label label7;
        private DataGridView dataGridViewRoom;
        private TextBox textBoxSearchRoomNo;
        private Label label8;
        private Label label9;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private RadioButton radioButtonNo1;
        private RadioButton radioButtonYes1;
        private ComboBox comboBoxType1;
        private Button buttonDelete;
        private Button buttonUpdate;
        private TextBox textBoxPhoneNo1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label10;
    }
}
