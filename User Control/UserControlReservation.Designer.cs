namespace HotelRes1.User_Control
{
    partial class UserControlReservation
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
            tabControlReservation = new TabControl();
            tabPageAddReservation = new TabPage();
            label6 = new Label();
            dateTimePickerOut = new DateTimePicker();
            label5 = new Label();
            dateTimePickerIn = new DateTimePicker();
            comboBoxRoomNo = new ComboBox();
            comboBoxRoomType = new ComboBox();
            textBoxClientID = new TextBox();
            label4 = new Label();
            buttonAdd = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPageSearchReservation = new TabPage();
            dataGridViewReservation = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            textBoxSearchClientID = new TextBox();
            label7 = new Label();
            label8 = new Label();
            tabPageUpdateAndCancelReservation = new TabPage();
            buttonCancel = new Button();
            label9 = new Label();
            dateTimePickerOut1 = new DateTimePicker();
            label10 = new Label();
            dateTimePickerIn1 = new DateTimePicker();
            comboBoxNo1 = new ComboBox();
            comboBoxType1 = new ComboBox();
            textBoxClientID1 = new TextBox();
            label11 = new Label();
            buttonUpdate = new Button();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            tabControlReservation.SuspendLayout();
            tabPageAddReservation.SuspendLayout();
            tabPageSearchReservation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservation).BeginInit();
            tabPageUpdateAndCancelReservation.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlReservation
            // 
            tabControlReservation.Alignment = TabAlignment.Bottom;
            tabControlReservation.Anchor = AnchorStyles.None;
            tabControlReservation.Controls.Add(tabPageAddReservation);
            tabControlReservation.Controls.Add(tabPageSearchReservation);
            tabControlReservation.Controls.Add(tabPageUpdateAndCancelReservation);
            tabControlReservation.Location = new Point(31, 90);
            tabControlReservation.Name = "tabControlReservation";
            tabControlReservation.SelectedIndex = 0;
            tabControlReservation.Size = new Size(1554, 638);
            tabControlReservation.TabIndex = 0;
            // 
            // tabPageAddReservation
            // 
            tabPageAddReservation.Controls.Add(label6);
            tabPageAddReservation.Controls.Add(dateTimePickerOut);
            tabPageAddReservation.Controls.Add(label5);
            tabPageAddReservation.Controls.Add(dateTimePickerIn);
            tabPageAddReservation.Controls.Add(comboBoxRoomNo);
            tabPageAddReservation.Controls.Add(comboBoxRoomType);
            tabPageAddReservation.Controls.Add(textBoxClientID);
            tabPageAddReservation.Controls.Add(label4);
            tabPageAddReservation.Controls.Add(buttonAdd);
            tabPageAddReservation.Controls.Add(label3);
            tabPageAddReservation.Controls.Add(label2);
            tabPageAddReservation.Controls.Add(label1);
            tabPageAddReservation.Location = new Point(4, 4);
            tabPageAddReservation.Name = "tabPageAddReservation";
            tabPageAddReservation.Padding = new Padding(3);
            tabPageAddReservation.Size = new Size(1546, 600);
            tabPageAddReservation.TabIndex = 0;
            tabPageAddReservation.Text = "Add Reservation";
            tabPageAddReservation.UseVisualStyleBackColor = true;
            tabPageAddReservation.Leave += tabPageAddReservation_Leave;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(892, 311);
            label6.Name = "label6";
            label6.Size = new Size(45, 23);
            label6.TabIndex = 41;
            label6.Text = "Out";
            // 
            // dateTimePickerOut
            // 
            dateTimePickerOut.Location = new Point(892, 348);
            dateTimePickerOut.Name = "dateTimePickerOut";
            dateTimePickerOut.Size = new Size(330, 31);
            dateTimePickerOut.TabIndex = 40;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(332, 311);
            label5.Name = "label5";
            label5.Size = new Size(28, 23);
            label5.TabIndex = 39;
            label5.Text = "In";
            // 
            // dateTimePickerIn
            // 
            dateTimePickerIn.Location = new Point(332, 348);
            dateTimePickerIn.Name = "dateTimePickerIn";
            dateTimePickerIn.Size = new Size(330, 31);
            dateTimePickerIn.TabIndex = 38;
            // 
            // comboBoxRoomNo
            // 
            comboBoxRoomNo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRoomNo.FlatStyle = FlatStyle.System;
            comboBoxRoomNo.FormattingEnabled = true;
            comboBoxRoomNo.Items.AddRange(new object[] { "Please Select..." });
            comboBoxRoomNo.Location = new Point(815, 173);
            comboBoxRoomNo.Name = "comboBoxRoomNo";
            comboBoxRoomNo.Size = new Size(330, 33);
            comboBoxRoomNo.TabIndex = 37;
            comboBoxRoomNo.SelectedIndexChanged += comboBoxRoomNo_SelectedIndexChanged;
            // 
            // comboBoxRoomType
            // 
            comboBoxRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRoomType.FlatStyle = FlatStyle.System;
            comboBoxRoomType.FormattingEnabled = true;
            comboBoxRoomType.Items.AddRange(new object[] { "Please Select...", "Single", "Double", "Family", "Suite" });
            comboBoxRoomType.Location = new Point(332, 173);
            comboBoxRoomType.Name = "comboBoxRoomType";
            comboBoxRoomType.Size = new Size(330, 33);
            comboBoxRoomType.TabIndex = 36;
            comboBoxRoomType.SelectedIndexChanged += comboBoxRoomType_SelectedIndexChanged;
            // 
            // textBoxClientID
            // 
            textBoxClientID.Anchor = AnchorStyles.None;
            textBoxClientID.Location = new Point(332, 263);
            textBoxClientID.Name = "textBoxClientID";
            textBoxClientID.Size = new Size(330, 31);
            textBoxClientID.TabIndex = 33;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(332, 226);
            label4.Name = "label4";
            label4.Size = new Size(99, 23);
            label4.TabIndex = 32;
            label4.Text = "Client ID:";
            label4.Click += label4_Click;
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
            buttonAdd.Location = new Point(332, 487);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(145, 45);
            buttonAdd.TabIndex = 31;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(815, 136);
            label3.Name = "label3";
            label3.Size = new Size(107, 23);
            label3.TabIndex = 29;
            label3.Text = "Room No:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(332, 136);
            label2.Name = "label2";
            label2.Size = new Size(119, 23);
            label2.TabIndex = 27;
            label2.Text = "Room Type";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(175, 130, 96);
            label1.Location = new Point(-4, -4);
            label1.Name = "label1";
            label1.Size = new Size(194, 26);
            label1.TabIndex = 26;
            label1.Text = "Add Reservation:";
            // 
            // tabPageSearchReservation
            // 
            tabPageSearchReservation.Controls.Add(dataGridViewReservation);
            tabPageSearchReservation.Controls.Add(textBoxSearchClientID);
            tabPageSearchReservation.Controls.Add(label7);
            tabPageSearchReservation.Controls.Add(label8);
            tabPageSearchReservation.Location = new Point(4, 4);
            tabPageSearchReservation.Name = "tabPageSearchReservation";
            tabPageSearchReservation.Padding = new Padding(3);
            tabPageSearchReservation.Size = new Size(1546, 600);
            tabPageSearchReservation.TabIndex = 1;
            tabPageSearchReservation.Text = "Search Reservation";
            tabPageSearchReservation.UseVisualStyleBackColor = true;
            tabPageSearchReservation.Enter += tabPageSearchReservation_Enter;
            tabPageSearchReservation.Leave += tabPageSearchReservation_Leave;
            // 
            // dataGridViewReservation
            // 
            dataGridViewReservation.AllowUserToAddRows = false;
            dataGridViewReservation.AllowUserToDeleteRows = false;
            dataGridViewReservation.AllowUserToOrderColumns = true;
            dataGridViewReservation.Anchor = AnchorStyles.None;
            dataGridViewReservation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReservation.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridViewReservation.Location = new Point(43, 228);
            dataGridViewReservation.Name = "dataGridViewReservation";
            dataGridViewReservation.ReadOnly = true;
            dataGridViewReservation.RowHeadersWidth = 62;
            dataGridViewReservation.Size = new Size(1464, 298);
            dataGridViewReservation.TabIndex = 13;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Reservation_ID";
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Reservation_Room_Type";
            Column2.HeaderText = "Room Type";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Reservation_Room_Number";
            Column3.HeaderText = "Room No:";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Reservation_Client_ID";
            Column4.HeaderText = "Client ID";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 150;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "Reservation_In";
            Column5.HeaderText = "In";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 150;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "Reservation_Out";
            Column6.HeaderText = "Out";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 150;
            // 
            // textBoxSearchClientID
            // 
            textBoxSearchClientID.Anchor = AnchorStyles.None;
            textBoxSearchClientID.Location = new Point(576, 115);
            textBoxSearchClientID.Name = "textBoxSearchClientID";
            textBoxSearchClientID.Size = new Size(330, 31);
            textBoxSearchClientID.TabIndex = 12;
            textBoxSearchClientID.TextChanged += textBoxSearchClientID_TextChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(576, 78);
            label7.Name = "label7";
            label7.Size = new Size(99, 23);
            label7.TabIndex = 11;
            label7.Text = "Client ID:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(175, 130, 96);
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(222, 26);
            label8.TabIndex = 10;
            label8.Text = "Search Reservation:";
            // 
            // tabPageUpdateAndCancelReservation
            // 
            tabPageUpdateAndCancelReservation.Controls.Add(buttonCancel);
            tabPageUpdateAndCancelReservation.Controls.Add(label9);
            tabPageUpdateAndCancelReservation.Controls.Add(dateTimePickerOut1);
            tabPageUpdateAndCancelReservation.Controls.Add(label10);
            tabPageUpdateAndCancelReservation.Controls.Add(dateTimePickerIn1);
            tabPageUpdateAndCancelReservation.Controls.Add(comboBoxNo1);
            tabPageUpdateAndCancelReservation.Controls.Add(comboBoxType1);
            tabPageUpdateAndCancelReservation.Controls.Add(textBoxClientID1);
            tabPageUpdateAndCancelReservation.Controls.Add(label11);
            tabPageUpdateAndCancelReservation.Controls.Add(buttonUpdate);
            tabPageUpdateAndCancelReservation.Controls.Add(label12);
            tabPageUpdateAndCancelReservation.Controls.Add(label13);
            tabPageUpdateAndCancelReservation.Controls.Add(label14);
            tabPageUpdateAndCancelReservation.Location = new Point(4, 4);
            tabPageUpdateAndCancelReservation.Name = "tabPageUpdateAndCancelReservation";
            tabPageUpdateAndCancelReservation.Padding = new Padding(3);
            tabPageUpdateAndCancelReservation.Size = new Size(1546, 600);
            tabPageUpdateAndCancelReservation.TabIndex = 2;
            tabPageUpdateAndCancelReservation.Text = "Update and Cancel Reservation";
            tabPageUpdateAndCancelReservation.UseVisualStyleBackColor = true;
            tabPageUpdateAndCancelReservation.Leave += tabPageUpdateAndCancelReservation_Leave;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.None;
            buttonCancel.BackColor = Color.Firebrick;
            buttonCancel.Cursor = Cursors.Hand;
            buttonCancel.FlatAppearance.BorderSize = 0;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(498, 491);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(145, 45);
            buttonCancel.TabIndex = 54;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(896, 315);
            label9.Name = "label9";
            label9.Size = new Size(45, 23);
            label9.TabIndex = 53;
            label9.Text = "Out";
            // 
            // dateTimePickerOut1
            // 
            dateTimePickerOut1.Location = new Point(896, 352);
            dateTimePickerOut1.Name = "dateTimePickerOut1";
            dateTimePickerOut1.Size = new Size(330, 31);
            dateTimePickerOut1.TabIndex = 52;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(336, 315);
            label10.Name = "label10";
            label10.Size = new Size(28, 23);
            label10.TabIndex = 51;
            label10.Text = "In";
            // 
            // dateTimePickerIn1
            // 
            dateTimePickerIn1.Location = new Point(336, 352);
            dateTimePickerIn1.Name = "dateTimePickerIn1";
            dateTimePickerIn1.Size = new Size(330, 31);
            dateTimePickerIn1.TabIndex = 50;
            // 
            // comboBoxNo1
            // 
            comboBoxNo1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxNo1.FlatStyle = FlatStyle.System;
            comboBoxNo1.FormattingEnabled = true;
            comboBoxNo1.Items.AddRange(new object[] { "Please Select..." });
            comboBoxNo1.Location = new Point(819, 177);
            comboBoxNo1.Name = "comboBoxNo1";
            comboBoxNo1.Size = new Size(330, 33);
            comboBoxNo1.TabIndex = 49;
            // 
            // comboBoxType1
            // 
            comboBoxType1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType1.FlatStyle = FlatStyle.System;
            comboBoxType1.FormattingEnabled = true;
            comboBoxType1.Items.AddRange(new object[] { "Please Select...", "Single", "Double", "Family", "Suite" });
            comboBoxType1.Location = new Point(336, 177);
            comboBoxType1.Name = "comboBoxType1";
            comboBoxType1.Size = new Size(330, 33);
            comboBoxType1.TabIndex = 48;
            comboBoxType1.SelectedIndexChanged += comboBoxType1_SelectedIndexChanged;
            // 
            // textBoxClientID1
            // 
            textBoxClientID1.Anchor = AnchorStyles.None;
            textBoxClientID1.Location = new Point(336, 267);
            textBoxClientID1.Name = "textBoxClientID1";
            textBoxClientID1.Size = new Size(330, 31);
            textBoxClientID1.TabIndex = 47;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(336, 230);
            label11.Name = "label11";
            label11.Size = new Size(99, 23);
            label11.TabIndex = 46;
            label11.Text = "Client ID:";
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
            buttonUpdate.Location = new Point(336, 491);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(145, 45);
            buttonUpdate.TabIndex = 45;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(819, 140);
            label12.Name = "label12";
            label12.Size = new Size(107, 23);
            label12.TabIndex = 44;
            label12.Text = "Room No:";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(336, 140);
            label13.Name = "label13";
            label13.Size = new Size(119, 23);
            label13.TabIndex = 43;
            label13.Text = "Room Type";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(175, 130, 96);
            label14.Location = new Point(0, 0);
            label14.Name = "label14";
            label14.Size = new Size(355, 26);
            label14.TabIndex = 42;
            label14.Text = "Update and Cancel Reservation";
            // 
            // UserControlReservation
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabControlReservation);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserControlReservation";
            Size = new Size(1630, 913);
            Load += UserControlReservation_Load;
            tabControlReservation.ResumeLayout(false);
            tabPageAddReservation.ResumeLayout(false);
            tabPageAddReservation.PerformLayout();
            tabPageSearchReservation.ResumeLayout(false);
            tabPageSearchReservation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservation).EndInit();
            tabPageUpdateAndCancelReservation.ResumeLayout(false);
            tabPageUpdateAndCancelReservation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlReservation;
        private TabPage tabPageAddReservation;
        private TabPage tabPageSearchReservation;
        private TabPage tabPageUpdateAndCancelReservation;
        private TextBox textBoxClientID;
        private Label label4;
        private Button buttonAdd;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private DateTimePicker dateTimePickerOut;
        private Label label5;
        private DateTimePicker dateTimePickerIn;
        private ComboBox comboBoxRoomNo;
        private ComboBox comboBoxRoomType;
        private DataGridView dataGridViewReservation;
        private TextBox textBoxSearchClientID;
        private Label label7;
        private Label label8;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Button buttonCancel;
        private Label label9;
        private DateTimePicker dateTimePickerOut1;
        private Label label10;
        private DateTimePicker dateTimePickerIn1;
        private ComboBox comboBoxNo1;
        private ComboBox comboBoxType1;
        private TextBox textBoxClientID1;
        private Label label11;
        private Button buttonUpdate;
        private Label label12;
        private Label label13;
        private Label label14;
    }
}
