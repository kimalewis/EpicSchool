namespace Final
{
    partial class frmChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePassword));
            this.ChangePasswordGB = new System.Windows.Forms.GroupBox();
            this.viewpassCkBx = new System.Windows.Forms.CheckBox();
            this.ConfirmPassTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uIDlbl = new System.Windows.Forms.Label();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.NewPasswordTB = new System.Windows.Forms.TextBox();
            this.oldPasswordTB = new System.Windows.Forms.TextBox();
            this.oldpasswordlbl = new System.Windows.Forms.Label();
            this.newPasswordlbl = new System.Windows.Forms.Label();
            this.errorMsg = new System.Windows.Forms.ErrorProvider(this.components);
            this.ChangePasswordGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorMsg)).BeginInit();
            this.SuspendLayout();
            // 
            // ChangePasswordGB
            // 
            this.ChangePasswordGB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ChangePasswordGB.BackgroundImage")));
            this.ChangePasswordGB.Controls.Add(this.viewpassCkBx);
            this.ChangePasswordGB.Controls.Add(this.ConfirmPassTB);
            this.ChangePasswordGB.Controls.Add(this.label1);
            this.ChangePasswordGB.Controls.Add(this.uIDlbl);
            this.ChangePasswordGB.Controls.Add(this.UpdateBtn);
            this.ChangePasswordGB.Controls.Add(this.NewPasswordTB);
            this.ChangePasswordGB.Controls.Add(this.oldPasswordTB);
            this.ChangePasswordGB.Controls.Add(this.oldpasswordlbl);
            this.ChangePasswordGB.Controls.Add(this.newPasswordlbl);
            this.ChangePasswordGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChangePasswordGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePasswordGB.Location = new System.Drawing.Point(0, 0);
            this.ChangePasswordGB.Name = "ChangePasswordGB";
            this.ChangePasswordGB.Size = new System.Drawing.Size(429, 179);
            this.ChangePasswordGB.TabIndex = 0;
            this.ChangePasswordGB.TabStop = false;
            // 
            // viewpassCkBx
            // 
            this.viewpassCkBx.AutoSize = true;
            this.viewpassCkBx.BackColor = System.Drawing.Color.Transparent;
            this.viewpassCkBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewpassCkBx.ForeColor = System.Drawing.Color.White;
            this.viewpassCkBx.Location = new System.Drawing.Point(243, 16);
            this.viewpassCkBx.Name = "viewpassCkBx";
            this.viewpassCkBx.Size = new System.Drawing.Size(127, 19);
            this.viewpassCkBx.TabIndex = 45;
            this.viewpassCkBx.Text = "Show Password";
            this.viewpassCkBx.UseVisualStyleBackColor = false;
            this.viewpassCkBx.CheckStateChanged += new System.EventHandler(this.viewpassCkBx_CheckStateChanged);
            // 
            // ConfirmPassTB
            // 
            this.ConfirmPassTB.Location = new System.Drawing.Point(154, 101);
            this.ConfirmPassTB.MaxLength = 12;
            this.ConfirmPassTB.Name = "ConfirmPassTB";
            this.ConfirmPassTB.PasswordChar = '*';
            this.ConfirmPassTB.Size = new System.Drawing.Size(184, 21);
            this.ConfirmPassTB.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 43;
            this.label1.Text = "Confirm Password";
            // 
            // uIDlbl
            // 
            this.uIDlbl.AutoSize = true;
            this.uIDlbl.BackColor = System.Drawing.Color.Transparent;
            this.uIDlbl.ForeColor = System.Drawing.Color.White;
            this.uIDlbl.Location = new System.Drawing.Point(6, 144);
            this.uIDlbl.Name = "uIDlbl";
            this.uIDlbl.Size = new System.Drawing.Size(21, 15);
            this.uIDlbl.TabIndex = 42;
            this.uIDlbl.Text = "ID";
            this.uIDlbl.Visible = false;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.UpdateBtn.Location = new System.Drawing.Point(154, 128);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(82, 33);
            this.UpdateBtn.TabIndex = 4;
            this.UpdateBtn.Text = "Change";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // NewPasswordTB
            // 
            this.NewPasswordTB.Location = new System.Drawing.Point(154, 73);
            this.NewPasswordTB.MaxLength = 12;
            this.NewPasswordTB.Name = "NewPasswordTB";
            this.NewPasswordTB.PasswordChar = '*';
            this.NewPasswordTB.Size = new System.Drawing.Size(184, 21);
            this.NewPasswordTB.TabIndex = 3;
            // 
            // oldPasswordTB
            // 
            this.oldPasswordTB.Location = new System.Drawing.Point(154, 42);
            this.oldPasswordTB.MaxLength = 12;
            this.oldPasswordTB.Name = "oldPasswordTB";
            this.oldPasswordTB.PasswordChar = '*';
            this.oldPasswordTB.Size = new System.Drawing.Size(184, 21);
            this.oldPasswordTB.TabIndex = 2;
            // 
            // oldpasswordlbl
            // 
            this.oldpasswordlbl.AutoSize = true;
            this.oldpasswordlbl.BackColor = System.Drawing.Color.Transparent;
            this.oldpasswordlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldpasswordlbl.ForeColor = System.Drawing.Color.White;
            this.oldpasswordlbl.Location = new System.Drawing.Point(18, 42);
            this.oldpasswordlbl.Name = "oldpasswordlbl";
            this.oldpasswordlbl.Size = new System.Drawing.Size(120, 15);
            this.oldpasswordlbl.TabIndex = 1;
            this.oldpasswordlbl.Text = "Current Password";
            // 
            // newPasswordlbl
            // 
            this.newPasswordlbl.AutoSize = true;
            this.newPasswordlbl.BackColor = System.Drawing.Color.Transparent;
            this.newPasswordlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordlbl.ForeColor = System.Drawing.Color.White;
            this.newPasswordlbl.Location = new System.Drawing.Point(30, 73);
            this.newPasswordlbl.Name = "newPasswordlbl";
            this.newPasswordlbl.Size = new System.Drawing.Size(101, 15);
            this.newPasswordlbl.TabIndex = 0;
            this.newPasswordlbl.Text = "New Password";
            // 
            // errorMsg
            // 
            this.errorMsg.ContainerControl = this;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(429, 179);
            this.Controls.Add(this.ChangePasswordGB);
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            this.ChangePasswordGB.ResumeLayout(false);
            this.ChangePasswordGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorMsg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ChangePasswordGB;
        private System.Windows.Forms.TextBox NewPasswordTB;
        private System.Windows.Forms.TextBox oldPasswordTB;
        private System.Windows.Forms.Label oldpasswordlbl;
        private System.Windows.Forms.Label newPasswordlbl;
        private System.Windows.Forms.Button UpdateBtn;
        public System.Windows.Forms.Label uIDlbl;
        private System.Windows.Forms.TextBox ConfirmPassTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorMsg;
        private System.Windows.Forms.CheckBox viewpassCkBx;
    }
}