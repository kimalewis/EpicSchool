namespace Final
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.userloginGB = new System.Windows.Forms.GroupBox();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.accesstypeCB = new System.Windows.Forms.ComboBox();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.loginbtn = new System.Windows.Forms.Button();
            this.accesstypelbl = new System.Windows.Forms.Label();
            this.passwordlbl = new System.Windows.Forms.Label();
            this.usernamelbl = new System.Windows.Forms.Label();
            this.errorMsg = new System.Windows.Forms.ErrorProvider(this.components);
            this.userloginGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorMsg)).BeginInit();
            this.SuspendLayout();
            // 
            // userloginGB
            // 
            this.userloginGB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userloginGB.BackColor = System.Drawing.Color.Transparent;
            this.userloginGB.Controls.Add(this.usernameTB);
            this.userloginGB.Controls.Add(this.passwordTB);
            this.userloginGB.Controls.Add(this.accesstypeCB);
            this.userloginGB.Controls.Add(this.cancelbtn);
            this.userloginGB.Controls.Add(this.loginbtn);
            this.userloginGB.Controls.Add(this.accesstypelbl);
            this.userloginGB.Controls.Add(this.passwordlbl);
            this.userloginGB.Controls.Add(this.usernamelbl);
            this.userloginGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userloginGB.ForeColor = System.Drawing.Color.White;
            this.userloginGB.Location = new System.Drawing.Point(0, 0);
            this.userloginGB.Name = "userloginGB";
            this.userloginGB.Size = new System.Drawing.Size(651, 316);
            this.userloginGB.TabIndex = 11;
            this.userloginGB.TabStop = false;
            this.userloginGB.Text = "User Login";
            // 
            // usernameTB
            // 
            this.usernameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.usernameTB.Location = new System.Drawing.Point(197, 59);
            this.usernameTB.MaxLength = 30;
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(200, 20);
            this.usernameTB.TabIndex = 1;
            // 
            // passwordTB
            // 
            this.passwordTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.passwordTB.Location = new System.Drawing.Point(197, 97);
            this.passwordTB.MaxLength = 12;
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.Size = new System.Drawing.Size(200, 20);
            this.passwordTB.TabIndex = 2;
            // 
            // accesstypeCB
            // 
            this.accesstypeCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.accesstypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accesstypeCB.FormattingEnabled = true;
            this.accesstypeCB.Location = new System.Drawing.Point(197, 135);
            this.accesstypeCB.Name = "accesstypeCB";
            this.accesstypeCB.Size = new System.Drawing.Size(200, 21);
            this.accesstypeCB.TabIndex = 3;
            // 
            // cancelbtn
            // 
            this.cancelbtn.ForeColor = System.Drawing.Color.DarkRed;
            this.cancelbtn.Location = new System.Drawing.Point(322, 179);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 30);
            this.cancelbtn.TabIndex = 5;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // loginbtn
            // 
            this.loginbtn.ForeColor = System.Drawing.Color.DarkRed;
            this.loginbtn.Location = new System.Drawing.Point(192, 179);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(75, 30);
            this.loginbtn.TabIndex = 4;
            this.loginbtn.Text = "LOGIN";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // accesstypelbl
            // 
            this.accesstypelbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accesstypelbl.AutoSize = true;
            this.accesstypelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accesstypelbl.ForeColor = System.Drawing.Color.White;
            this.accesstypelbl.Location = new System.Drawing.Point(81, 136);
            this.accesstypelbl.Name = "accesstypelbl";
            this.accesstypelbl.Size = new System.Drawing.Size(103, 16);
            this.accesstypelbl.TabIndex = 8;
            this.accesstypelbl.Text = "AccessType: ";
            // 
            // passwordlbl
            // 
            this.passwordlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordlbl.AutoSize = true;
            this.passwordlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlbl.ForeColor = System.Drawing.Color.White;
            this.passwordlbl.Location = new System.Drawing.Point(100, 97);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(84, 16);
            this.passwordlbl.TabIndex = 7;
            this.passwordlbl.Text = "Password: ";
            // 
            // usernamelbl
            // 
            this.usernamelbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernamelbl.AutoSize = true;
            this.usernamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelbl.ForeColor = System.Drawing.Color.White;
            this.usernamelbl.Location = new System.Drawing.Point(97, 60);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(87, 16);
            this.usernamelbl.TabIndex = 6;
            this.usernamelbl.Text = "Username: ";
            // 
            // errorMsg
            // 
            this.errorMsg.ContainerControl = this;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(651, 316);
            this.Controls.Add(this.userloginGB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmLogin";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EPIC - Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.userloginGB.ResumeLayout(false);
            this.userloginGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorMsg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox userloginGB;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.ComboBox accesstypeCB;
        private System.Windows.Forms.Label accesstypelbl;
        private System.Windows.Forms.Label passwordlbl;
        private System.Windows.Forms.Label usernamelbl;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.ErrorProvider errorMsg;
        
    }
}

