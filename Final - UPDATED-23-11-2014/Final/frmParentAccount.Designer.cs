namespace Final
{
    partial class frmParentAccount
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
            this.PCellTB = new System.Windows.Forms.MaskedTextBox();
            this.PWorkTB = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PHomeTB = new System.Windows.Forms.MaskedTextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.PEmailTB = new System.Windows.Forms.TextBox();
            this.pHomelbl = new System.Windows.Forms.Label();
            this.pCelllbl = new System.Windows.Forms.Label();
            this.pEmaillbl = new System.Windows.Forms.Label();
            this.pcontactHlbl = new System.Windows.Forms.Label();
            this.fnamelbl = new System.Windows.Forms.Label();
            this.parentidlbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChangePasswordBtn = new System.Windows.Forms.Button();
            this.lastnameTB = new System.Windows.Forms.TextBox();
            this.Lastnamelbl = new System.Windows.Forms.Label();
            this.uIDlbl = new System.Windows.Forms.Label();
            this.firstnameTB = new System.Windows.Forms.TextBox();
            this.ParentIDTB = new System.Windows.Forms.TextBox();
            this.ChildDataGB = new System.Windows.Forms.GroupBox();
            this.ChildGridView = new System.Windows.Forms.DataGridView();
            this.EditButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ControlGB = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ChildDataGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChildGridView)).BeginInit();
            this.ControlGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PCellTB
            // 
            this.PCellTB.Location = new System.Drawing.Point(335, 30);
            this.PCellTB.Mask = "(999) 000-0000";
            this.PCellTB.Name = "PCellTB";
            this.PCellTB.Size = new System.Drawing.Size(201, 20);
            this.PCellTB.TabIndex = 8;
            // 
            // PWorkTB
            // 
            this.PWorkTB.Location = new System.Drawing.Point(67, 55);
            this.PWorkTB.Mask = "(999) 000-0000";
            this.PWorkTB.Name = "PWorkTB";
            this.PWorkTB.Size = new System.Drawing.Size(201, 20);
            this.PWorkTB.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.PCellTB);
            this.groupBox2.Controls.Add(this.PWorkTB);
            this.groupBox2.Controls.Add(this.PHomeTB);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.PEmailTB);
            this.groupBox2.Controls.Add(this.pHomelbl);
            this.groupBox2.Controls.Add(this.pCelllbl);
            this.groupBox2.Controls.Add(this.pEmaillbl);
            this.groupBox2.Controls.Add(this.pcontactHlbl);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(13, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 103);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contact Information";
            // 
            // PHomeTB
            // 
            this.PHomeTB.Location = new System.Drawing.Point(67, 31);
            this.PHomeTB.Mask = "(999) 000-0000";
            this.PHomeTB.Name = "PHomeTB";
            this.PHomeTB.Size = new System.Drawing.Size(201, 20);
            this.PHomeTB.TabIndex = 6;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(16, 62);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(37, 13);
            this.label26.TabIndex = 95;
            this.label26.Text = "Work";
            // 
            // PEmailTB
            // 
            this.PEmailTB.Location = new System.Drawing.Point(335, 54);
            this.PEmailTB.Name = "PEmailTB";
            this.PEmailTB.Size = new System.Drawing.Size(201, 20);
            this.PEmailTB.TabIndex = 9;
            // 
            // pHomelbl
            // 
            this.pHomelbl.AutoSize = true;
            this.pHomelbl.Location = new System.Drawing.Point(15, 38);
            this.pHomelbl.Name = "pHomelbl";
            this.pHomelbl.Size = new System.Drawing.Size(39, 13);
            this.pHomelbl.TabIndex = 92;
            this.pHomelbl.Text = "Home";
            // 
            // pCelllbl
            // 
            this.pCelllbl.AutoSize = true;
            this.pCelllbl.Location = new System.Drawing.Point(283, 37);
            this.pCelllbl.Name = "pCelllbl";
            this.pCelllbl.Size = new System.Drawing.Size(28, 13);
            this.pCelllbl.TabIndex = 91;
            this.pCelllbl.Text = "Cell";
            // 
            // pEmaillbl
            // 
            this.pEmaillbl.AutoSize = true;
            this.pEmaillbl.Location = new System.Drawing.Point(283, 61);
            this.pEmaillbl.Name = "pEmaillbl";
            this.pEmaillbl.Size = new System.Drawing.Size(37, 13);
            this.pEmaillbl.TabIndex = 90;
            this.pEmaillbl.Text = "Email";
            // 
            // pcontactHlbl
            // 
            this.pcontactHlbl.AutoSize = true;
            this.pcontactHlbl.Location = new System.Drawing.Point(13, 16);
            this.pcontactHlbl.Name = "pcontactHlbl";
            this.pcontactHlbl.Size = new System.Drawing.Size(51, 13);
            this.pcontactHlbl.TabIndex = 89;
            this.pcontactHlbl.Text = "Contact";
            // 
            // fnamelbl
            // 
            this.fnamelbl.AutoSize = true;
            this.fnamelbl.Location = new System.Drawing.Point(18, 47);
            this.fnamelbl.Name = "fnamelbl";
            this.fnamelbl.Size = new System.Drawing.Size(61, 13);
            this.fnamelbl.TabIndex = 1;
            this.fnamelbl.Text = "Firstname";
            // 
            // parentidlbl
            // 
            this.parentidlbl.AutoSize = true;
            this.parentidlbl.Location = new System.Drawing.Point(18, 20);
            this.parentidlbl.Name = "parentidlbl";
            this.parentidlbl.Size = new System.Drawing.Size(61, 13);
            this.parentidlbl.TabIndex = 0;
            this.parentidlbl.Text = "Parent ID";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lastnameTB);
            this.groupBox1.Controls.Add(this.Lastnamelbl);
            this.groupBox1.Controls.Add(this.uIDlbl);
            this.groupBox1.Controls.Add(this.firstnameTB);
            this.groupBox1.Controls.Add(this.ParentIDTB);
            this.groupBox1.Controls.Add(this.fnamelbl);
            this.groupBox1.Controls.Add(this.parentidlbl);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(13, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 96);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic Information";
            // 
            // ChangePasswordBtn
            // 
            this.ChangePasswordBtn.Location = new System.Drawing.Point(27, 173);
            this.ChangePasswordBtn.Name = "ChangePasswordBtn";
            this.ChangePasswordBtn.Size = new System.Drawing.Size(129, 35);
            this.ChangePasswordBtn.TabIndex = 83;
            this.ChangePasswordBtn.Text = "Change Password";
            this.ChangePasswordBtn.UseVisualStyleBackColor = true;
            this.ChangePasswordBtn.Click += new System.EventHandler(this.ChangePasswordBtn_Click);
            // 
            // lastnameTB
            // 
            this.lastnameTB.Location = new System.Drawing.Point(76, 70);
            this.lastnameTB.Name = "lastnameTB";
            this.lastnameTB.Size = new System.Drawing.Size(199, 20);
            this.lastnameTB.TabIndex = 78;
            // 
            // Lastnamelbl
            // 
            this.Lastnamelbl.AutoSize = true;
            this.Lastnamelbl.Location = new System.Drawing.Point(17, 73);
            this.Lastnamelbl.Name = "Lastnamelbl";
            this.Lastnamelbl.Size = new System.Drawing.Size(61, 13);
            this.Lastnamelbl.TabIndex = 77;
            this.Lastnamelbl.Text = "Lastname";
            // 
            // uIDlbl
            // 
            this.uIDlbl.AutoSize = true;
            this.uIDlbl.Location = new System.Drawing.Point(216, 20);
            this.uIDlbl.Name = "uIDlbl";
            this.uIDlbl.Size = new System.Drawing.Size(20, 13);
            this.uIDlbl.TabIndex = 76;
            this.uIDlbl.Text = "ID";
            this.uIDlbl.Visible = false;
            // 
            // firstnameTB
            // 
            this.firstnameTB.Location = new System.Drawing.Point(76, 44);
            this.firstnameTB.Name = "firstnameTB";
            this.firstnameTB.Size = new System.Drawing.Size(199, 20);
            this.firstnameTB.TabIndex = 2;
            // 
            // ParentIDTB
            // 
            this.ParentIDTB.Location = new System.Drawing.Point(76, 17);
            this.ParentIDTB.Name = "ParentIDTB";
            this.ParentIDTB.Size = new System.Drawing.Size(134, 20);
            this.ParentIDTB.TabIndex = 1;
            // 
            // ChildDataGB
            // 
            this.ChildDataGB.BackColor = System.Drawing.Color.Transparent;
            this.ChildDataGB.Controls.Add(this.ChildGridView);
            this.ChildDataGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChildDataGB.ForeColor = System.Drawing.Color.Black;
            this.ChildDataGB.Location = new System.Drawing.Point(13, 228);
            this.ChildDataGB.Name = "ChildDataGB";
            this.ChildDataGB.Size = new System.Drawing.Size(550, 134);
            this.ChildDataGB.TabIndex = 77;
            this.ChildDataGB.TabStop = false;
            this.ChildDataGB.Text = "Child/Children";
            // 
            // ChildGridView
            // 
            this.ChildGridView.BackgroundColor = System.Drawing.Color.White;
            this.ChildGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChildGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.ChildGridView.Location = new System.Drawing.Point(3, 16);
            this.ChildGridView.Name = "ChildGridView";
            this.ChildGridView.Size = new System.Drawing.Size(544, 115);
            this.ChildGridView.TabIndex = 10;
            this.ChildGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChildGridView_CellContentClick);
            // 
            // EditButton
            // 
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.ForeColor = System.Drawing.Color.DarkRed;
            this.EditButton.Location = new System.Drawing.Point(11, 16);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 32);
            this.EditButton.TabIndex = 11;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.Color.DarkRed;
            this.CancelButton.Location = new System.Drawing.Point(11, 54);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 32);
            this.CancelButton.TabIndex = 12;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.DarkRed;
            this.SaveButton.Location = new System.Drawing.Point(11, 92);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 32);
            this.SaveButton.TabIndex = 13;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // ControlGB
            // 
            this.ControlGB.BackColor = System.Drawing.Color.Transparent;
            this.ControlGB.Controls.Add(this.EditButton);
            this.ControlGB.Controls.Add(this.SaveButton);
            this.ControlGB.Controls.Add(this.CancelButton);
            this.ControlGB.Location = new System.Drawing.Point(43, 216);
            this.ControlGB.Name = "ControlGB";
            this.ControlGB.Size = new System.Drawing.Size(102, 131);
            this.ControlGB.TabIndex = 81;
            this.ControlGB.TabStop = false;
            this.ControlGB.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = global::Final.Properties.Resources.chalkboard_apple_624x300;
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.ChangePasswordBtn);
            this.splitContainer1.Panel1.Controls.Add(this.ControlGB);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImage = global::Final.Properties.Resources.chalkboard_apple_624x300;
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.ChildDataGB);
            this.splitContainer1.Size = new System.Drawing.Size(756, 370);
            this.splitContainer1.SplitterDistance = 172;
            this.splitContainer1.TabIndex = 83;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Final.Properties.Resources.users_folder_black;
            this.pictureBox1.Location = new System.Drawing.Point(9, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
            // 
            // frmParentAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final.Properties.Resources.chalkboard_apple_624x300;
            this.ClientSize = new System.Drawing.Size(756, 370);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmParentAccount";
            this.Text = "frmParentAccount";
            this.Load += new System.EventHandler(this.frmParentAccount_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ChildDataGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChildGridView)).EndInit();
            this.ControlGB.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox PCellTB;
        private System.Windows.Forms.MaskedTextBox PWorkTB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox PHomeTB;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox PEmailTB;
        private System.Windows.Forms.Label pHomelbl;
        private System.Windows.Forms.Label pCelllbl;
        private System.Windows.Forms.Label pEmaillbl;
        private System.Windows.Forms.Label pcontactHlbl;
        private System.Windows.Forms.Label fnamelbl;
        private System.Windows.Forms.Label parentidlbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ParentIDTB;
        private System.Windows.Forms.GroupBox ChildDataGB;
        private System.Windows.Forms.DataGridView ChildGridView;
        public System.Windows.Forms.Label uIDlbl;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.GroupBox ControlGB;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button ChangePasswordBtn;
        private System.Windows.Forms.TextBox lastnameTB;
        private System.Windows.Forms.Label Lastnamelbl;
        private System.Windows.Forms.TextBox firstnameTB;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}