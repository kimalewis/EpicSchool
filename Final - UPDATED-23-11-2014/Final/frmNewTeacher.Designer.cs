namespace Final
{
    partial class frmNewTeacher
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
            this.homepTB = new System.Windows.Forms.MaskedTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.basicdataGB = new System.Windows.Forms.GroupBox();
            this.schoolsCB = new System.Windows.Forms.ComboBox();
            this.Schoollbl = new System.Windows.Forms.Label();
            this.MITB = new System.Windows.Forms.TextBox();
            this.MIlbl = new System.Windows.Forms.Label();
            this.dobdatepicker = new System.Windows.Forms.DateTimePicker();
            this.DOBlbl = new System.Windows.Forms.Label();
            this.slastnamelbl = new System.Windows.Forms.Label();
            this.tFNlbl = new System.Windows.Forms.Label();
            this.tLNtb = new System.Windows.Forms.TextBox();
            this.tFNtb = new System.Windows.Forms.TextBox();
            this.tIdTB = new System.Windows.Forms.TextBox();
            this.tIDlbl = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.contactdetailGB = new System.Windows.Forms.GroupBox();
            this.ParishCB = new System.Windows.Forms.ComboBox();
            this.VillageCB = new System.Windows.Forms.ComboBox();
            this.parishlbl = new System.Windows.Forms.Label();
            this.villagelbl = new System.Windows.Forms.Label();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.homelbl = new System.Windows.Forms.Label();
            this.emaillbl = new System.Windows.Forms.Label();
            this.contacthlbl = new System.Windows.Forms.Label();
            this.saddresshlbl = new System.Windows.Forms.Label();
            this.sCancelBtn = new System.Windows.Forms.Button();
            this.AddStudentBtn = new System.Windows.Forms.Button();
            this.studentPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.basicdataGB.SuspendLayout();
            this.contactdetailGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // homepTB
            // 
            this.homepTB.Location = new System.Drawing.Point(326, 31);
            this.homepTB.Mask = "(999) 000-0000";
            this.homepTB.Name = "homepTB";
            this.homepTB.Size = new System.Drawing.Size(188, 20);
            this.homepTB.TabIndex = 88;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackgroundImage = global::Final.Properties.Resources.chalkboard_apple_624x300;
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImage = global::Final.Properties.Resources.chalkboard_apple_624x300;
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel2.Controls.Add(this.basicdataGB);
            this.splitContainer1.Panel2.Controls.Add(this.ClearButton);
            this.splitContainer1.Panel2.Controls.Add(this.contactdetailGB);
            this.splitContainer1.Panel2.Controls.Add(this.sCancelBtn);
            this.splitContainer1.Panel2.Controls.Add(this.AddStudentBtn);
            this.splitContainer1.Size = new System.Drawing.Size(691, 323);
            this.splitContainer1.SplitterDistance = 149;
            this.splitContainer1.TabIndex = 95;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.studentPicture);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackgroundImage = global::Final.Properties.Resources.chalkboard_apple_624x300;
            this.splitContainer2.Size = new System.Drawing.Size(149, 323);
            this.splitContainer2.SplitterDistance = 150;
            this.splitContainer2.TabIndex = 0;
            // 
            // basicdataGB
            // 
            this.basicdataGB.BackColor = System.Drawing.Color.Transparent;
            this.basicdataGB.Controls.Add(this.schoolsCB);
            this.basicdataGB.Controls.Add(this.Schoollbl);
            this.basicdataGB.Controls.Add(this.MITB);
            this.basicdataGB.Controls.Add(this.MIlbl);
            this.basicdataGB.Controls.Add(this.dobdatepicker);
            this.basicdataGB.Controls.Add(this.DOBlbl);
            this.basicdataGB.Controls.Add(this.slastnamelbl);
            this.basicdataGB.Controls.Add(this.tFNlbl);
            this.basicdataGB.Controls.Add(this.tLNtb);
            this.basicdataGB.Controls.Add(this.tFNtb);
            this.basicdataGB.Controls.Add(this.tIdTB);
            this.basicdataGB.Controls.Add(this.tIDlbl);
            this.basicdataGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basicdataGB.ForeColor = System.Drawing.Color.White;
            this.basicdataGB.Location = new System.Drawing.Point(2, 3);
            this.basicdataGB.Name = "basicdataGB";
            this.basicdataGB.Size = new System.Drawing.Size(530, 114);
            this.basicdataGB.TabIndex = 1;
            this.basicdataGB.TabStop = false;
            this.basicdataGB.Text = "Basic Information";
            // 
            // schoolsCB
            // 
            this.schoolsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.schoolsCB.FormattingEnabled = true;
            this.schoolsCB.Location = new System.Drawing.Point(252, 18);
            this.schoolsCB.Name = "schoolsCB";
            this.schoolsCB.Size = new System.Drawing.Size(272, 21);
            this.schoolsCB.TabIndex = 91;
            // 
            // Schoollbl
            // 
            this.Schoollbl.AutoSize = true;
            this.Schoollbl.Location = new System.Drawing.Point(206, 22);
            this.Schoollbl.Name = "Schoollbl";
            this.Schoollbl.Size = new System.Drawing.Size(46, 13);
            this.Schoollbl.TabIndex = 41;
            this.Schoollbl.Text = "School";
            // 
            // MITB
            // 
            this.MITB.Location = new System.Drawing.Point(274, 46);
            this.MITB.MaxLength = 1;
            this.MITB.Name = "MITB";
            this.MITB.Size = new System.Drawing.Size(44, 20);
            this.MITB.TabIndex = 40;
            // 
            // MIlbl
            // 
            this.MIlbl.AutoSize = true;
            this.MIlbl.Location = new System.Drawing.Point(240, 49);
            this.MIlbl.Name = "MIlbl";
            this.MIlbl.Size = new System.Drawing.Size(29, 13);
            this.MIlbl.TabIndex = 39;
            this.MIlbl.Text = "M.I.";
            // 
            // dobdatepicker
            // 
            this.dobdatepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobdatepicker.Location = new System.Drawing.Point(90, 72);
            this.dobdatepicker.Name = "dobdatepicker";
            this.dobdatepicker.Size = new System.Drawing.Size(131, 20);
            this.dobdatepicker.TabIndex = 30;
            // 
            // DOBlbl
            // 
            this.DOBlbl.AutoSize = true;
            this.DOBlbl.Location = new System.Drawing.Point(10, 78);
            this.DOBlbl.Name = "DOBlbl";
            this.DOBlbl.Size = new System.Drawing.Size(79, 13);
            this.DOBlbl.TabIndex = 27;
            this.DOBlbl.Text = "Date of Birth";
            // 
            // slastnamelbl
            // 
            this.slastnamelbl.AutoSize = true;
            this.slastnamelbl.Location = new System.Drawing.Point(328, 49);
            this.slastnamelbl.Name = "slastnamelbl";
            this.slastnamelbl.Size = new System.Drawing.Size(61, 13);
            this.slastnamelbl.TabIndex = 26;
            this.slastnamelbl.Text = "Lastname";
            // 
            // tFNlbl
            // 
            this.tFNlbl.AutoSize = true;
            this.tFNlbl.Location = new System.Drawing.Point(19, 49);
            this.tFNlbl.Name = "tFNlbl";
            this.tFNlbl.Size = new System.Drawing.Size(61, 13);
            this.tFNlbl.TabIndex = 25;
            this.tFNlbl.Text = "Firstname";
            // 
            // tLNtb
            // 
            this.tLNtb.Location = new System.Drawing.Point(393, 45);
            this.tLNtb.MaxLength = 5;
            this.tLNtb.Name = "tLNtb";
            this.tLNtb.Size = new System.Drawing.Size(131, 20);
            this.tLNtb.TabIndex = 24;
            // 
            // tFNtb
            // 
            this.tFNtb.Location = new System.Drawing.Point(90, 46);
            this.tFNtb.MaxLength = 50;
            this.tFNtb.Name = "tFNtb";
            this.tFNtb.Size = new System.Drawing.Size(131, 20);
            this.tFNtb.TabIndex = 21;
            // 
            // tIdTB
            // 
            this.tIdTB.Location = new System.Drawing.Point(90, 20);
            this.tIdTB.Name = "tIdTB";
            this.tIdTB.ReadOnly = true;
            this.tIdTB.Size = new System.Drawing.Size(90, 20);
            this.tIdTB.TabIndex = 20;
            // 
            // tIDlbl
            // 
            this.tIDlbl.AutoSize = true;
            this.tIDlbl.Location = new System.Drawing.Point(10, 22);
            this.tIDlbl.Name = "tIDlbl";
            this.tIDlbl.Size = new System.Drawing.Size(71, 13);
            this.tIDlbl.TabIndex = 19;
            this.tIDlbl.Text = "Teacher ID";
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.Color.DarkRed;
            this.ClearButton.Location = new System.Drawing.Point(346, 262);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 39);
            this.ClearButton.TabIndex = 94;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // contactdetailGB
            // 
            this.contactdetailGB.BackColor = System.Drawing.Color.Transparent;
            this.contactdetailGB.Controls.Add(this.ParishCB);
            this.contactdetailGB.Controls.Add(this.VillageCB);
            this.contactdetailGB.Controls.Add(this.parishlbl);
            this.contactdetailGB.Controls.Add(this.villagelbl);
            this.contactdetailGB.Controls.Add(this.homepTB);
            this.contactdetailGB.Controls.Add(this.emailTB);
            this.contactdetailGB.Controls.Add(this.homelbl);
            this.contactdetailGB.Controls.Add(this.emaillbl);
            this.contactdetailGB.Controls.Add(this.contacthlbl);
            this.contactdetailGB.Controls.Add(this.saddresshlbl);
            this.contactdetailGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactdetailGB.ForeColor = System.Drawing.Color.White;
            this.contactdetailGB.Location = new System.Drawing.Point(2, 123);
            this.contactdetailGB.Name = "contactdetailGB";
            this.contactdetailGB.Size = new System.Drawing.Size(530, 115);
            this.contactdetailGB.TabIndex = 91;
            this.contactdetailGB.TabStop = false;
            this.contactdetailGB.Text = "Contact Details";
            // 
            // ParishCB
            // 
            this.ParishCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ParishCB.FormattingEnabled = true;
            this.ParishCB.Location = new System.Drawing.Point(82, 58);
            this.ParishCB.Name = "ParishCB";
            this.ParishCB.Size = new System.Drawing.Size(121, 21);
            this.ParishCB.TabIndex = 96;
            // 
            // VillageCB
            // 
            this.VillageCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VillageCB.FormattingEnabled = true;
            this.VillageCB.Location = new System.Drawing.Point(82, 30);
            this.VillageCB.Name = "VillageCB";
            this.VillageCB.Size = new System.Drawing.Size(121, 21);
            this.VillageCB.TabIndex = 95;
            // 
            // parishlbl
            // 
            this.parishlbl.AutoSize = true;
            this.parishlbl.Location = new System.Drawing.Point(37, 60);
            this.parishlbl.Name = "parishlbl";
            this.parishlbl.Size = new System.Drawing.Size(42, 13);
            this.parishlbl.TabIndex = 94;
            this.parishlbl.Text = "Parish";
            // 
            // villagelbl
            // 
            this.villagelbl.AutoSize = true;
            this.villagelbl.Location = new System.Drawing.Point(37, 34);
            this.villagelbl.Name = "villagelbl";
            this.villagelbl.Size = new System.Drawing.Size(45, 13);
            this.villagelbl.TabIndex = 93;
            this.villagelbl.Text = "Village";
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(326, 63);
            this.emailTB.MaxLength = 50;
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(188, 20);
            this.emailTB.TabIndex = 68;
            // 
            // homelbl
            // 
            this.homelbl.AutoSize = true;
            this.homelbl.Location = new System.Drawing.Point(271, 37);
            this.homelbl.Name = "homelbl";
            this.homelbl.Size = new System.Drawing.Size(39, 13);
            this.homelbl.TabIndex = 67;
            this.homelbl.Text = "Home";
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.Location = new System.Drawing.Point(274, 66);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(37, 13);
            this.emaillbl.TabIndex = 65;
            this.emaillbl.Text = "Email";
            // 
            // contacthlbl
            // 
            this.contacthlbl.AutoSize = true;
            this.contacthlbl.Location = new System.Drawing.Point(258, 17);
            this.contacthlbl.Name = "contacthlbl";
            this.contacthlbl.Size = new System.Drawing.Size(51, 13);
            this.contacthlbl.TabIndex = 64;
            this.contacthlbl.Text = "Contact";
            // 
            // saddresshlbl
            // 
            this.saddresshlbl.AutoSize = true;
            this.saddresshlbl.Location = new System.Drawing.Point(11, 17);
            this.saddresshlbl.Name = "saddresshlbl";
            this.saddresshlbl.Size = new System.Drawing.Size(52, 13);
            this.saddresshlbl.TabIndex = 53;
            this.saddresshlbl.Text = "Address";
            // 
            // sCancelBtn
            // 
            this.sCancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sCancelBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.sCancelBtn.Location = new System.Drawing.Point(229, 262);
            this.sCancelBtn.Name = "sCancelBtn";
            this.sCancelBtn.Size = new System.Drawing.Size(75, 39);
            this.sCancelBtn.TabIndex = 98;
            this.sCancelBtn.Text = "Cancel";
            this.sCancelBtn.UseVisualStyleBackColor = true;
            // 
            // AddStudentBtn
            // 
            this.AddStudentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStudentBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.AddStudentBtn.Location = new System.Drawing.Point(110, 262);
            this.AddStudentBtn.Name = "AddStudentBtn";
            this.AddStudentBtn.Size = new System.Drawing.Size(75, 39);
            this.AddStudentBtn.TabIndex = 97;
            this.AddStudentBtn.Text = "Save";
            this.AddStudentBtn.UseVisualStyleBackColor = true;
            this.AddStudentBtn.Click += new System.EventHandler(this.AddStudentBtn_Click);
            // 
            // studentPicture
            // 
            this.studentPicture.BackColor = System.Drawing.Color.White;
            this.studentPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentPicture.Image = global::Final.Properties.Resources.users_folder_black;
            this.studentPicture.Location = new System.Drawing.Point(0, 0);
            this.studentPicture.Name = "studentPicture";
            this.studentPicture.Size = new System.Drawing.Size(149, 150);
            this.studentPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.studentPicture.TabIndex = 1;
            this.studentPicture.TabStop = false;
            // 
            // frmNewTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final.Properties.Resources.chalkboard_apple_624x300;
            this.ClientSize = new System.Drawing.Size(709, 347);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmNewTeacher";
            this.Text = "New Teacher Registration";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.basicdataGB.ResumeLayout(false);
            this.basicdataGB.PerformLayout();
            this.contactdetailGB.ResumeLayout(false);
            this.contactdetailGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox homepTB;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PictureBox studentPicture;
        private System.Windows.Forms.GroupBox basicdataGB;
        private System.Windows.Forms.ComboBox schoolsCB;
        private System.Windows.Forms.Label Schoollbl;
        private System.Windows.Forms.TextBox MITB;
        private System.Windows.Forms.Label MIlbl;
        private System.Windows.Forms.DateTimePicker dobdatepicker;
        private System.Windows.Forms.Label DOBlbl;
        private System.Windows.Forms.Label slastnamelbl;
        private System.Windows.Forms.Label tFNlbl;
        private System.Windows.Forms.TextBox tLNtb;
        private System.Windows.Forms.TextBox tFNtb;
        private System.Windows.Forms.TextBox tIdTB;
        private System.Windows.Forms.Label tIDlbl;
        private System.Windows.Forms.GroupBox contactdetailGB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.Label homelbl;
        private System.Windows.Forms.Label emaillbl;
        private System.Windows.Forms.Label contacthlbl;
        private System.Windows.Forms.Label saddresshlbl;
        private System.Windows.Forms.Button AddStudentBtn;
        private System.Windows.Forms.Button sCancelBtn;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.ComboBox ParishCB;
        private System.Windows.Forms.ComboBox VillageCB;
        private System.Windows.Forms.Label parishlbl;
        private System.Windows.Forms.Label villagelbl;
    }
}