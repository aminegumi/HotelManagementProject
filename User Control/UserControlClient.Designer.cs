namespace HotelRes1.User_Control
{
    partial class UserControlClient
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
            tabSearchlClient = new TabControl();
            tabPageAddClient = new TabPage();
            textBoxAddress = new TextBox();
            label5 = new Label();
            textBoxPhoneNo = new TextBox();
            label4 = new Label();
            buttonAdd = new Button();
            textBoxLastName = new TextBox();
            label3 = new Label();
            textBoxFirstName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabPageSearchClient = new TabPage();
            dataGridViewClient = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            textBoxSearchPhoneNo = new TextBox();
            label6 = new Label();
            label7 = new Label();
            tabPageUpdateAndDeleteClient = new TabPage();
            buttonDelete = new Button();
            textBoxAddress1 = new TextBox();
            label8 = new Label();
            textBoxPhoneNo1 = new TextBox();
            label9 = new Label();
            buttonUpdate = new Button();
            textBoxLastName1 = new TextBox();
            label10 = new Label();
            textBoxFirstName1 = new TextBox();
            label11 = new Label();
            label12 = new Label();
            tabSearchlClient.SuspendLayout();
            tabPageAddClient.SuspendLayout();
            tabPageSearchClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClient).BeginInit();
            tabPageUpdateAndDeleteClient.SuspendLayout();
            SuspendLayout();
            // 
            // tabSearchlClient
            // 
            tabSearchlClient.Alignment = TabAlignment.Bottom;
            tabSearchlClient.Anchor = AnchorStyles.None;
            tabSearchlClient.Controls.Add(tabPageAddClient);
            tabSearchlClient.Controls.Add(tabPageSearchClient);
            tabSearchlClient.Controls.Add(tabPageUpdateAndDeleteClient);
            tabSearchlClient.Location = new Point(31, 90);
            tabSearchlClient.Name = "tabSearchlClient";
            tabSearchlClient.SelectedIndex = 0;
            tabSearchlClient.Size = new Size(1562, 674);
            tabSearchlClient.TabIndex = 0;
            tabSearchlClient.Leave += tabSearchlClient_Leave;
            // 
            // tabPageAddClient
            // 
            tabPageAddClient.Controls.Add(textBoxAddress);
            tabPageAddClient.Controls.Add(label5);
            tabPageAddClient.Controls.Add(textBoxPhoneNo);
            tabPageAddClient.Controls.Add(label4);
            tabPageAddClient.Controls.Add(buttonAdd);
            tabPageAddClient.Controls.Add(textBoxLastName);
            tabPageAddClient.Controls.Add(label3);
            tabPageAddClient.Controls.Add(textBoxFirstName);
            tabPageAddClient.Controls.Add(label2);
            tabPageAddClient.Controls.Add(label1);
            tabPageAddClient.Location = new Point(4, 4);
            tabPageAddClient.Name = "tabPageAddClient";
            tabPageAddClient.Padding = new Padding(3);
            tabPageAddClient.Size = new Size(1554, 638);
            tabPageAddClient.TabIndex = 0;
            tabPageAddClient.Text = "Add Client";
            tabPageAddClient.UseVisualStyleBackColor = true;
            tabPageAddClient.Leave += tabPageAddClient_Leave;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Anchor = AnchorStyles.None;
            textBoxAddress.Location = new Point(342, 365);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(813, 90);
            textBoxAddress.TabIndex = 15;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(342, 328);
            label5.Name = "label5";
            label5.Size = new Size(94, 23);
            label5.TabIndex = 14;
            label5.Text = "Address:";
            // 
            // textBoxPhoneNo
            // 
            textBoxPhoneNo.Anchor = AnchorStyles.None;
            textBoxPhoneNo.Location = new Point(342, 270);
            textBoxPhoneNo.Name = "textBoxPhoneNo";
            textBoxPhoneNo.Size = new Size(330, 32);
            textBoxPhoneNo.TabIndex = 13;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(342, 233);
            label4.Name = "label4";
            label4.Size = new Size(111, 23);
            label4.TabIndex = 12;
            label4.Text = "Phone No:";
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
            buttonAdd.Location = new Point(342, 494);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(145, 45);
            buttonAdd.TabIndex = 11;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Anchor = AnchorStyles.None;
            textBoxLastName.Location = new Point(825, 180);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(330, 32);
            textBoxLastName.TabIndex = 10;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(825, 143);
            label3.Name = "label3";
            label3.Size = new Size(119, 23);
            label3.TabIndex = 9;
            label3.Text = "Last Name:";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Anchor = AnchorStyles.None;
            textBoxFirstName.Location = new Point(342, 180);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(330, 32);
            textBoxFirstName.TabIndex = 8;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(342, 143);
            label2.Name = "label2";
            label2.Size = new Size(118, 23);
            label2.TabIndex = 7;
            label2.Text = "First Name:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(175, 130, 96);
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(131, 26);
            label1.TabIndex = 6;
            label1.Text = "Add Client:";
            // 
            // tabPageSearchClient
            // 
            tabPageSearchClient.Controls.Add(dataGridViewClient);
            tabPageSearchClient.Controls.Add(textBoxSearchPhoneNo);
            tabPageSearchClient.Controls.Add(label6);
            tabPageSearchClient.Controls.Add(label7);
            tabPageSearchClient.Location = new Point(4, 4);
            tabPageSearchClient.Name = "tabPageSearchClient";
            tabPageSearchClient.Padding = new Padding(3);
            tabPageSearchClient.Size = new Size(1554, 638);
            tabPageSearchClient.TabIndex = 1;
            tabPageSearchClient.Text = "Search Client";
            tabPageSearchClient.UseVisualStyleBackColor = true;
            tabPageSearchClient.Enter += tabPageSearchClient_Enter;
            // 
            // dataGridViewClient
            // 
            dataGridViewClient.AllowUserToAddRows = false;
            dataGridViewClient.AllowUserToDeleteRows = false;
            dataGridViewClient.Anchor = AnchorStyles.None;
            dataGridViewClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClient.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridViewClient.Location = new Point(43, 249);
            dataGridViewClient.Name = "dataGridViewClient";
            dataGridViewClient.ReadOnly = true;
            dataGridViewClient.RowHeadersWidth = 62;
            dataGridViewClient.Size = new Size(1464, 298);
            dataGridViewClient.TabIndex = 9;
            dataGridViewClient.CellClick += dataGridViewClient_CellClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Client_ID";
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Client_FirstName";
            Column2.HeaderText = "First Name";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 300;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Client_LastName";
            Column3.HeaderText = "Last Name";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 300;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Client_Phone";
            Column4.HeaderText = "Phone No";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 300;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "Client_Address";
            Column5.HeaderText = "Address";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 400;
            // 
            // textBoxSearchPhoneNo
            // 
            textBoxSearchPhoneNo.Anchor = AnchorStyles.None;
            textBoxSearchPhoneNo.Location = new Point(576, 136);
            textBoxSearchPhoneNo.Name = "textBoxSearchPhoneNo";
            textBoxSearchPhoneNo.Size = new Size(330, 32);
            textBoxSearchPhoneNo.TabIndex = 8;
            textBoxSearchPhoneNo.TextChanged += textBoxSearchPhoneNo_TextChanged;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(576, 99);
            label6.Name = "label6";
            label6.Size = new Size(111, 23);
            label6.TabIndex = 7;
            label6.Text = "Phone No:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(175, 130, 96);
            label7.Location = new Point(3, 21);
            label7.Name = "label7";
            label7.Size = new Size(159, 26);
            label7.TabIndex = 6;
            label7.Text = "Search Client:";
            // 
            // tabPageUpdateAndDeleteClient
            // 
            tabPageUpdateAndDeleteClient.Controls.Add(buttonDelete);
            tabPageUpdateAndDeleteClient.Controls.Add(textBoxAddress1);
            tabPageUpdateAndDeleteClient.Controls.Add(label8);
            tabPageUpdateAndDeleteClient.Controls.Add(textBoxPhoneNo1);
            tabPageUpdateAndDeleteClient.Controls.Add(label9);
            tabPageUpdateAndDeleteClient.Controls.Add(buttonUpdate);
            tabPageUpdateAndDeleteClient.Controls.Add(textBoxLastName1);
            tabPageUpdateAndDeleteClient.Controls.Add(label10);
            tabPageUpdateAndDeleteClient.Controls.Add(textBoxFirstName1);
            tabPageUpdateAndDeleteClient.Controls.Add(label11);
            tabPageUpdateAndDeleteClient.Controls.Add(label12);
            tabPageUpdateAndDeleteClient.Location = new Point(4, 4);
            tabPageUpdateAndDeleteClient.Name = "tabPageUpdateAndDeleteClient";
            tabPageUpdateAndDeleteClient.Padding = new Padding(3);
            tabPageUpdateAndDeleteClient.Size = new Size(1554, 638);
            tabPageUpdateAndDeleteClient.TabIndex = 2;
            tabPageUpdateAndDeleteClient.Text = "Update and Delete Client";
            tabPageUpdateAndDeleteClient.UseVisualStyleBackColor = true;
            tabPageUpdateAndDeleteClient.Leave += tabPageUpdateAndDeleteClient_Leave;
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
            buttonDelete.Location = new Point(527, 518);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(145, 45);
            buttonDelete.TabIndex = 26;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            buttonDelete.Leave += buttonDelete_Leave;
            // 
            // textBoxAddress1
            // 
            textBoxAddress1.Anchor = AnchorStyles.None;
            textBoxAddress1.Location = new Point(342, 389);
            textBoxAddress1.Multiline = true;
            textBoxAddress1.Name = "textBoxAddress1";
            textBoxAddress1.Size = new Size(813, 90);
            textBoxAddress1.TabIndex = 25;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(342, 352);
            label8.Name = "label8";
            label8.Size = new Size(94, 23);
            label8.TabIndex = 24;
            label8.Text = "Address:";
            // 
            // textBoxPhoneNo1
            // 
            textBoxPhoneNo1.Anchor = AnchorStyles.None;
            textBoxPhoneNo1.Location = new Point(342, 294);
            textBoxPhoneNo1.Name = "textBoxPhoneNo1";
            textBoxPhoneNo1.Size = new Size(330, 32);
            textBoxPhoneNo1.TabIndex = 23;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(342, 257);
            label9.Name = "label9";
            label9.Size = new Size(111, 23);
            label9.TabIndex = 22;
            label9.Text = "Phone No:";
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
            buttonUpdate.Location = new Point(342, 518);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(145, 45);
            buttonUpdate.TabIndex = 21;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // textBoxLastName1
            // 
            textBoxLastName1.Anchor = AnchorStyles.None;
            textBoxLastName1.Location = new Point(825, 204);
            textBoxLastName1.Name = "textBoxLastName1";
            textBoxLastName1.Size = new Size(330, 32);
            textBoxLastName1.TabIndex = 20;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(825, 167);
            label10.Name = "label10";
            label10.Size = new Size(119, 23);
            label10.TabIndex = 19;
            label10.Text = "Last Name:";
            // 
            // textBoxFirstName1
            // 
            textBoxFirstName1.Anchor = AnchorStyles.None;
            textBoxFirstName1.Location = new Point(342, 204);
            textBoxFirstName1.Name = "textBoxFirstName1";
            textBoxFirstName1.Size = new Size(330, 32);
            textBoxFirstName1.TabIndex = 18;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(342, 167);
            label11.Name = "label11";
            label11.Size = new Size(118, 23);
            label11.TabIndex = 17;
            label11.Text = "First Name:";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(175, 130, 96);
            label12.Location = new Point(6, 27);
            label12.Name = "label12";
            label12.Size = new Size(289, 26);
            label12.TabIndex = 16;
            label12.Text = "Update and Delete Client:";
            // 
            // UserControlClient
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabSearchlClient);
            Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserControlClient";
            Size = new Size(1630, 913);
            tabSearchlClient.ResumeLayout(false);
            tabPageAddClient.ResumeLayout(false);
            tabPageAddClient.PerformLayout();
            tabPageSearchClient.ResumeLayout(false);
            tabPageSearchClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClient).EndInit();
            tabPageUpdateAndDeleteClient.ResumeLayout(false);
            tabPageUpdateAndDeleteClient.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabSearchlClient;
        private TabPage tabPageAddClient;
        private TabPage tabPageSearchClient;
        private Button buttonAdd;
        private TextBox textBoxLastName;
        private Label label3;
        private TextBox textBoxFirstName;
        private Label label2;
        private Label label1;
        private TextBox textBoxPhoneNo;
        private Label label4;
        private TextBox textBoxAddress;
        private Label label5;
        private TabPage tabPageUpdateAndDeleteClient;
        private DataGridView dataGridViewClient;
        private TextBox textBoxSearchPhoneNo;
        private Label label6;
        private Label label7;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button buttonDelete;
        private TextBox textBoxAddress1;
        private Label label8;
        private TextBox textBoxPhoneNo1;
        private Label label9;
        private Button buttonUpdate;
        private TextBox textBoxLastName1;
        private Label label10;
        private TextBox textBoxFirstName1;
        private Label label11;
        private Label label12;
    }
}
