namespace Final
{
    partial class frmUserRegistration
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
            this.components = new System.ComponentModel.Container();
            this.UsersGB = new System.Windows.Forms.GroupBox();
            this.UsersGV = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DetailsGB = new System.Windows.Forms.GroupBox();
            this.AccessTypelbl = new System.Windows.Forms.Label();
            this.AccessTypeCB = new System.Windows.Forms.ComboBox();
            this.UserIDlbl = new System.Windows.Forms.Label();
            this.uIDlbl = new System.Windows.Forms.Label();
            this.FirstNamelbl = new System.Windows.Forms.Label();
            this.ControlsGB = new System.Windows.Forms.GroupBox();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.NewBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.LastNamelbl = new System.Windows.Forms.Label();
            this.FirstnameTB = new System.Windows.Forms.TextBox();
            this.Emaillbl = new System.Windows.Forms.Label();
            this.LastnameTB = new System.Windows.Forms.TextBox();
            this.LoginGB = new System.Windows.Forms.GroupBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.Passwordlbl = new System.Windows.Forms.Label();
            this.Usernamelbl = new System.Windows.Forms.Label();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.UseridTB = new System.Windows.Forms.TextBox();
            this.errorMsg = new System.Windows.Forms.ErrorProvider(this.components);
            this.UsersGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.DetailsGB.SuspendLayout();
            this.ControlsGB.SuspendLayout();
            this.LoginGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorMsg)).BeginInit();
            this.SuspendLayout();
            // 
            // UsersGB
            // 
            this.UsersGB.Controls.Add(this.UsersGV);
            this.UsersGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsersGB.ForeColor = System.Drawing.Color.Black;
            this.UsersGB.Location = new System.Drawing.Point(0, 0);
            this.UsersGB.Name = "UsersGB";
            this.UsersGB.Size = new System.Drawing.Size(477, 147);
            this.UsersGB.TabIndex = 78;
            this.UsersGB.TabStop = false;
            this.UsersGB.Text = "Users";
            // 
            // UsersGV
            // 
            this.UsersGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UsersGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.UsersGV.BackgroundColor = System.Drawing.Color.White;
            this.UsersGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsersGV.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.UsersGV.Location = new System.Drawing.Point(3, 16);
            this.UsersGV.Name = "UsersGV";
            this.UsersGV.Size = new System.Drawing.Size(471, 128);
            this.UsersGV.TabIndex = 0;
            this.UsersGV.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersGV_CellEnter);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.BackgroundImage = global::Final.Properties.Resources.chalkboard_apple_624x300;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.ForeColor = System.Drawing.Color.White;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.UsersGB);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DetailsGB);
            this.splitContainer1.Size = new System.Drawing.Size(477, 355);
            this.splitContainer1.SplitterDistance = 147;
            this.splitContainer1.TabIndex = 79;
            // 
            // DetailsGB
            // 
            this.DetailsGB.Controls.Add(this.AccessTypelbl);
            this.DetailsGB.Controls.Add(this.AccessTypeCB);
            this.DetailsGB.Controls.Add(this.UserIDlbl);
            this.DetailsGB.Controls.Add(this.uIDlbl);
            this.DetailsGB.Controls.Add(this.FirstNamelbl);
            this.DetailsGB.Controls.Add(this.ControlsGB);
            this.DetailsGB.Controls.Add(this.LastNamelbl);
            this.DetailsGB.Controls.Add(this.FirstnameTB);
            this.DetailsGB.Controls.Add(this.Emaillbl);
            this.DetailsGB.Controls.Add(this.LastnameTB);
            this.DetailsGB.Controls.Add(this.LoginGB);
            this.DetailsGB.Controls.Add(this.emailTB);
            this.DetailsGB.Controls.Add(this.UseridTB);
            this.DetailsGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetailsGB.ForeColor = System.Drawing.Color.White;
            this.DetailsGB.Location = new System.Drawing.Point(0, 0);
            this.DetailsGB.Name = "DetailsGB";
            this.DetailsGB.Size = new System.Drawing.Size(477, 204);
            this.DetailsGB.TabIndex = 0;
            this.DetailsGB.TabStop = false;
            this.DetailsGB.Text = "Details";
            // 
            // AccessTypelbl
            // 
            this.AccessTypelbl.AutoSize = true;
            this.AccessTypelbl.Location = new System.Drawing.Point(0, 123);
            this.AccessTypelbl.Name = "AccessTypelbl";
            this.AccessTypelbl.Size = new System.Drawing.Size(76, 13);
            this.AccessTypelbl.TabIndex = 90;
            this.AccessTypelbl.Text = "AccessType";
            // 
            // AccessTypeCB
            // 
            this.AccessTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AccessTypeCB.Enabled = false;
            this.AccessTypeCB.FormattingEnabled = true;
            this.AccessTypeCB.Location = new System.Drawing.Point(78, 119);
            this.AccessTypeCB.Name = "AccessTypeCB";
            this.AccessTypeCB.Size = new System.Drawing.Size(147, 21);
            this.AccessTypeCB.TabIndex = 89;
            // 
            // UserIDlbl
            // 
            this.UserIDlbl.AutoSize = true;
            this.UserIDlbl.Location = new System.Drawing.Point(22, 17);
            this.UserIDlbl.Name = "UserIDlbl";
            this.UserIDlbl.Size = new System.Drawing.Size(50, 13);
            this.UserIDlbl.TabIndex = 78;
            this.UserIDlbl.Text = "User ID";
            // 
            // uIDlbl
            // 
            this.uIDlbl.AutoSize = true;
            this.uIDlbl.Location = new System.Drawing.Point(177, 17);
            this.uIDlbl.Name = "uIDlbl";
            this.uIDlbl.Size = new System.Drawing.Size(20, 13);
            this.uIDlbl.TabIndex = 88;
            this.uIDlbl.Text = "ID";
            this.uIDlbl.Visible = false;
            // 
            // FirstNamelbl
            // 
            this.FirstNamelbl.AutoSize = true;
            this.FirstNamelbl.Location = new System.Drawing.Point(13, 42);
            this.FirstNamelbl.Name = "FirstNamelbl";
            this.FirstNamelbl.Size = new System.Drawing.Size(61, 13);
            this.FirstNamelbl.TabIndex = 79;
            this.FirstNamelbl.Text = "Firstname";
            // 
            // ControlsGB
            // 
            this.ControlsGB.Controls.Add(this.UpdateBtn);
            this.ControlsGB.Controls.Add(this.NewBtn);
            this.ControlsGB.Controls.Add(this.EditBtn);
            this.ControlsGB.Controls.Add(this.SaveBtn);
            this.ControlsGB.Controls.Add(this.CancelBtn);
            this.ControlsGB.Location = new System.Drawing.Point(16, 141);
            this.ControlsGB.Name = "ControlsGB";
            this.ControlsGB.Size = new System.Drawing.Size(442, 57);
            this.ControlsGB.TabIndex = 87;
            this.ControlsGB.TabStop = false;
            this.ControlsGB.Text = "  ";
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.UpdateBtn.Location = new System.Drawing.Point(274, 15);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 32);
            this.UpdateBtn.TabIndex = 10;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            // 
            // NewBtn
            // 
            this.NewBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.NewBtn.Location = new System.Drawing.Point(31, 15);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(75, 32);
            this.NewBtn.TabIndex = 9;
            this.NewBtn.Text = "New";
            this.NewBtn.UseVisualStyleBackColor = true;
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.EditBtn.Location = new System.Drawing.Point(193, 15);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(75, 32);
            this.EditBtn.TabIndex = 8;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.SaveBtn.Location = new System.Drawing.Point(112, 15);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 32);
            this.SaveBtn.TabIndex = 6;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.CancelBtn.Location = new System.Drawing.Point(355, 15);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 32);
            this.CancelBtn.TabIndex = 7;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // LastNamelbl
            // 
            this.LastNamelbl.AutoSize = true;
            this.LastNamelbl.Location = new System.Drawing.Point(13, 69);
            this.LastNamelbl.Name = "LastNamelbl";
            this.LastNamelbl.Size = new System.Drawing.Size(61, 13);
            this.LastNamelbl.TabIndex = 80;
            this.LastNamelbl.Text = "Lastname";
            // 
            // FirstnameTB
            // 
            this.FirstnameTB.Location = new System.Drawing.Point(78, 40);
            this.FirstnameTB.MaxLength = 50;
            this.FirstnameTB.Name = "FirstnameTB";
            this.FirstnameTB.ReadOnly = true;
            this.FirstnameTB.Size = new System.Drawing.Size(148, 20);
            this.FirstnameTB.TabIndex = 86;
            this.FirstnameTB.Enter += new System.EventHandler(this.FirstnameTB_Enter);
            // 
            // Emaillbl
            // 
            this.Emaillbl.AutoSize = true;
            this.Emaillbl.Location = new System.Drawing.Point(33, 95);
            this.Emaillbl.Name = "Emaillbl";
            this.Emaillbl.Size = new System.Drawing.Size(37, 13);
            this.Emaillbl.TabIndex = 81;
            this.Emaillbl.Text = "Email";
            // 
            // LastnameTB
            // 
            this.LastnameTB.Location = new System.Drawing.Point(78, 66);
            this.LastnameTB.MaxLength = 50;
            this.LastnameTB.Name = "LastnameTB";
            this.LastnameTB.ReadOnly = true;
            this.LastnameTB.Size = new System.Drawing.Size(147, 20);
            this.LastnameTB.TabIndex = 85;
            // 
            // LoginGB
            // 
            this.LoginGB.Controls.Add(this.PasswordTB);
            this.LoginGB.Controls.Add(this.Passwordlbl);
            this.LoginGB.Controls.Add(this.Usernamelbl);
            this.LoginGB.Controls.Add(this.usernameTB);
            this.LoginGB.ForeColor = System.Drawing.Color.White;
            this.LoginGB.Location = new System.Drawing.Point(246, 32);
            this.LoginGB.Name = "LoginGB";
            this.LoginGB.Size = new System.Drawing.Size(200, 80);
            this.LoginGB.TabIndex = 82;
            this.LoginGB.TabStop = false;
            this.LoginGB.Text = "Login Details";
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(84, 47);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.ReadOnly = true;
            this.PasswordTB.Size = new System.Drawing.Size(100, 20);
            this.PasswordTB.TabIndex = 12;
            // 
            // Passwordlbl
            // 
            this.Passwordlbl.AutoSize = true;
            this.Passwordlbl.Location = new System.Drawing.Point(15, 50);
            this.Passwordlbl.Name = "Passwordlbl";
            this.Passwordlbl.Size = new System.Drawing.Size(61, 13);
            this.Passwordlbl.TabIndex = 11;
            this.Passwordlbl.Text = "Password";
            // 
            // Usernamelbl
            // 
            this.Usernamelbl.AutoSize = true;
            this.Usernamelbl.Location = new System.Drawing.Point(15, 22);
            this.Usernamelbl.Name = "Usernamelbl";
            this.Usernamelbl.Size = new System.Drawing.Size(63, 13);
            this.Usernamelbl.TabIndex = 3;
            this.Usernamelbl.Text = "Username";
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(84, 19);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.ReadOnly = true;
            this.usernameTB.Size = new System.Drawing.Size(100, 20);
            this.usernameTB.TabIndex = 10;
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(77, 92);
            this.emailTB.MaxLength = 50;
            this.emailTB.Name = "emailTB";
            this.emailTB.ReadOnly = true;
            this.emailTB.Size = new System.Drawing.Size(148, 20);
            this.emailTB.TabIndex = 84;
            this.emailTB.Enter += new System.EventHandler(this.emailTB_Enter);
            // 
            // UseridTB
            // 
            this.UseridTB.Location = new System.Drawing.Point(73, 14);
            this.UseridTB.Name = "UseridTB";
            this.UseridTB.ReadOnly = true;
            this.UseridTB.Size = new System.Drawing.Size(100, 20);
            this.UseridTB.TabIndex = 83;
            // 
            // errorMsg
            // 
            this.errorMsg.ContainerControl = this;
            // 
            // frmUserRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 355);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmUserRegistration";
            this.Text = "User ";
            this.Load += new System.EventHandler(this.frmUserRegistration_Load);
            this.UsersGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UsersGV)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.DetailsGB.ResumeLayout(false);
            this.DetailsGB.PerformLayout();
            this.ControlsGB.ResumeLayout(false);
            this.LoginGB.ResumeLayout(false);
            this.LoginGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorMsg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UsersGB;
        public System.Windows.Forms.DataGridView UsersGV;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox DetailsGB;
        private System.Windows.Forms.Label UserIDlbl;
        public System.Windows.Forms.Label uIDlbl;
        private System.Windows.Forms.Label FirstNamelbl;
        public System.Windows.Forms.GroupBox ControlsGB;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label LastNamelbl;
        public System.Windows.Forms.TextBox FirstnameTB;
        private System.Windows.Forms.Label Emaillbl;
        public System.Windows.Forms.TextBox LastnameTB;
        private System.Windows.Forms.GroupBox LoginGB;
        public System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Label Passwordlbl;
        private System.Windows.Forms.Label Usernamelbl;
        public System.Windows.Forms.TextBox usernameTB;
        public System.Windows.Forms.TextBox emailTB;
        public System.Windows.Forms.TextBox UseridTB;
        private System.Windows.Forms.Button NewBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.ErrorProvider errorMsg;
        private System.Windows.Forms.Label AccessTypelbl;
        private System.Windows.Forms.ComboBox AccessTypeCB;
    }
}