namespace Final
{
    partial class frmSchools
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.SearchTB = new System.Windows.Forms.TextBox();
            this.Searchlbl = new System.Windows.Forms.Label();
            this.uIDlbl = new System.Windows.Forms.Label();
            this.SchoolsListGV = new System.Windows.Forms.DataGridView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.SchoolinfoGB = new System.Windows.Forms.GroupBox();
            this.NewVillagebtn = new System.Windows.Forms.Button();
            this.ControlsGB = new System.Windows.Forms.GroupBox();
            this.NewBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.ParishCB = new System.Windows.Forms.ComboBox();
            this.VillageCB = new System.Windows.Forms.ComboBox();
            this.Parishlbl = new System.Windows.Forms.Label();
            this.Villagelbl = new System.Windows.Forms.Label();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.Emaillbl = new System.Windows.Forms.Label();
            this.OfficeTB = new System.Windows.Forms.MaskedTextBox();
            this.phonelbl = new System.Windows.Forms.Label();
            this.schoolTB = new System.Windows.Forms.TextBox();
            this.schoollbl = new System.Windows.Forms.Label();
            this.skCodeTB = new System.Windows.Forms.TextBox();
            this.skCodelbl = new System.Windows.Forms.Label();
            this.PrinicipalGV = new System.Windows.Forms.DataGridView();
            this.errorMsg = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SchoolsListGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SchoolinfoGB.SuspendLayout();
            this.ControlsGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrinicipalGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMsg)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.BackgroundImage = global::Final.Properties.Resources.chalkboard_apple_624x300;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(486, 388);
            this.splitContainer1.SplitterDistance = 151;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.SearchTB);
            this.splitContainer3.Panel1.Controls.Add(this.Searchlbl);
            this.splitContainer3.Panel1.Controls.Add(this.uIDlbl);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.SchoolsListGV);
            this.splitContainer3.Size = new System.Drawing.Size(486, 151);
            this.splitContainer3.SplitterDistance = 41;
            this.splitContainer3.TabIndex = 0;
            // 
            // SearchTB
            // 
            this.SearchTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTB.Location = new System.Drawing.Point(143, 18);
            this.SearchTB.Name = "SearchTB";
            this.SearchTB.Size = new System.Drawing.Size(194, 20);
            this.SearchTB.TabIndex = 3;
            this.SearchTB.TextChanged += new System.EventHandler(this.SeachTB_TextChanged);
            // 
            // Searchlbl
            // 
            this.Searchlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Searchlbl.AutoSize = true;
            this.Searchlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchlbl.ForeColor = System.Drawing.Color.White;
            this.Searchlbl.Location = new System.Drawing.Point(90, 21);
            this.Searchlbl.Name = "Searchlbl";
            this.Searchlbl.Size = new System.Drawing.Size(47, 13);
            this.Searchlbl.TabIndex = 2;
            this.Searchlbl.Text = "Search";
            // 
            // uIDlbl
            // 
            this.uIDlbl.AutoSize = true;
            this.uIDlbl.Location = new System.Drawing.Point(6, 9);
            this.uIDlbl.Name = "uIDlbl";
            this.uIDlbl.Size = new System.Drawing.Size(18, 13);
            this.uIDlbl.TabIndex = 42;
            this.uIDlbl.Text = "ID";
            this.uIDlbl.Visible = false;
            // 
            // SchoolsListGV
            // 
            this.SchoolsListGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SchoolsListGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.SchoolsListGV.BackgroundColor = System.Drawing.Color.White;
            this.SchoolsListGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SchoolsListGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SchoolsListGV.Location = new System.Drawing.Point(0, 0);
            this.SchoolsListGV.Name = "SchoolsListGV";
            this.SchoolsListGV.Size = new System.Drawing.Size(486, 106);
            this.SchoolsListGV.TabIndex = 1;
            this.SchoolsListGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SchoolsListGV_CellClick);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.SchoolinfoGB);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.PrinicipalGV);
            this.splitContainer2.Size = new System.Drawing.Size(486, 233);
            this.splitContainer2.SplitterDistance = 159;
            this.splitContainer2.TabIndex = 1;
            // 
            // SchoolinfoGB
            // 
            this.SchoolinfoGB.Controls.Add(this.NewVillagebtn);
            this.SchoolinfoGB.Controls.Add(this.ControlsGB);
            this.SchoolinfoGB.Controls.Add(this.ParishCB);
            this.SchoolinfoGB.Controls.Add(this.VillageCB);
            this.SchoolinfoGB.Controls.Add(this.Parishlbl);
            this.SchoolinfoGB.Controls.Add(this.Villagelbl);
            this.SchoolinfoGB.Controls.Add(this.EmailTB);
            this.SchoolinfoGB.Controls.Add(this.Emaillbl);
            this.SchoolinfoGB.Controls.Add(this.OfficeTB);
            this.SchoolinfoGB.Controls.Add(this.phonelbl);
            this.SchoolinfoGB.Controls.Add(this.schoolTB);
            this.SchoolinfoGB.Controls.Add(this.schoollbl);
            this.SchoolinfoGB.Controls.Add(this.skCodeTB);
            this.SchoolinfoGB.Controls.Add(this.skCodelbl);
            this.SchoolinfoGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SchoolinfoGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SchoolinfoGB.ForeColor = System.Drawing.Color.White;
            this.SchoolinfoGB.Location = new System.Drawing.Point(0, 0);
            this.SchoolinfoGB.Name = "SchoolinfoGB";
            this.SchoolinfoGB.Size = new System.Drawing.Size(486, 159);
            this.SchoolinfoGB.TabIndex = 1;
            this.SchoolinfoGB.TabStop = false;
            this.SchoolinfoGB.Text = "School Information";
            // 
            // NewVillagebtn
            // 
            this.NewVillagebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewVillagebtn.ForeColor = System.Drawing.Color.DarkRed;
            this.NewVillagebtn.Location = new System.Drawing.Point(208, 69);
            this.NewVillagebtn.Name = "NewVillagebtn";
            this.NewVillagebtn.Size = new System.Drawing.Size(27, 21);
            this.NewVillagebtn.TabIndex = 92;
            this.NewVillagebtn.Text = ">>";
            this.NewVillagebtn.UseVisualStyleBackColor = true;
            this.NewVillagebtn.Visible = false;
            this.NewVillagebtn.Click += new System.EventHandler(this.NewSubbtn_Click);
            // 
            // ControlsGB
            // 
            this.ControlsGB.Controls.Add(this.NewBtn);
            this.ControlsGB.Controls.Add(this.SaveBtn);
            this.ControlsGB.Controls.Add(this.EditBtn);
            this.ControlsGB.Controls.Add(this.CancelBtn);
            this.ControlsGB.Location = new System.Drawing.Point(50, 93);
            this.ControlsGB.Name = "ControlsGB";
            this.ControlsGB.Size = new System.Drawing.Size(363, 47);
            this.ControlsGB.TabIndex = 45;
            this.ControlsGB.TabStop = false;
            // 
            // NewBtn
            // 
            this.NewBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.NewBtn.Location = new System.Drawing.Point(16, 14);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(75, 29);
            this.NewBtn.TabIndex = 14;
            this.NewBtn.Text = "New";
            this.NewBtn.UseVisualStyleBackColor = true;
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.SaveBtn.Location = new System.Drawing.Point(101, 14);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 30);
            this.SaveBtn.TabIndex = 11;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.EditBtn.Location = new System.Drawing.Point(190, 14);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(75, 30);
            this.EditBtn.TabIndex = 13;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.CancelBtn.Location = new System.Drawing.Point(275, 14);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 30);
            this.CancelBtn.TabIndex = 12;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // ParishCB
            // 
            this.ParishCB.Enabled = false;
            this.ParishCB.FormattingEnabled = true;
            this.ParishCB.Location = new System.Drawing.Point(308, 69);
            this.ParishCB.Name = "ParishCB";
            this.ParishCB.Size = new System.Drawing.Size(121, 21);
            this.ParishCB.TabIndex = 44;
            // 
            // VillageCB
            // 
            this.VillageCB.Enabled = false;
            this.VillageCB.FormattingEnabled = true;
            this.VillageCB.Location = new System.Drawing.Point(81, 69);
            this.VillageCB.Name = "VillageCB";
            this.VillageCB.Size = new System.Drawing.Size(121, 21);
            this.VillageCB.TabIndex = 43;
            // 
            // Parishlbl
            // 
            this.Parishlbl.AutoSize = true;
            this.Parishlbl.Location = new System.Drawing.Point(263, 72);
            this.Parishlbl.Name = "Parishlbl";
            this.Parishlbl.Size = new System.Drawing.Size(42, 13);
            this.Parishlbl.TabIndex = 10;
            this.Parishlbl.Text = "Parish";
            // 
            // Villagelbl
            // 
            this.Villagelbl.AutoSize = true;
            this.Villagelbl.Location = new System.Drawing.Point(34, 72);
            this.Villagelbl.Name = "Villagelbl";
            this.Villagelbl.Size = new System.Drawing.Size(45, 13);
            this.Villagelbl.TabIndex = 8;
            this.Villagelbl.Text = "Village";
            // 
            // EmailTB
            // 
            this.EmailTB.Location = new System.Drawing.Point(81, 43);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.ReadOnly = true;
            this.EmailTB.Size = new System.Drawing.Size(174, 20);
            this.EmailTB.TabIndex = 7;
            // 
            // Emaillbl
            // 
            this.Emaillbl.AutoSize = true;
            this.Emaillbl.Location = new System.Drawing.Point(34, 47);
            this.Emaillbl.Name = "Emaillbl";
            this.Emaillbl.Size = new System.Drawing.Size(37, 13);
            this.Emaillbl.TabIndex = 6;
            this.Emaillbl.Text = "Email";
            // 
            // OfficeTB
            // 
            this.OfficeTB.Location = new System.Drawing.Point(308, 42);
            this.OfficeTB.Mask = "(999) 000-0000";
            this.OfficeTB.Name = "OfficeTB";
            this.OfficeTB.ReadOnly = true;
            this.OfficeTB.Size = new System.Drawing.Size(127, 20);
            this.OfficeTB.TabIndex = 5;
            // 
            // phonelbl
            // 
            this.phonelbl.AutoSize = true;
            this.phonelbl.Location = new System.Drawing.Point(261, 46);
            this.phonelbl.Name = "phonelbl";
            this.phonelbl.Size = new System.Drawing.Size(53, 13);
            this.phonelbl.TabIndex = 4;
            this.phonelbl.Text = "Office #";
            // 
            // schoolTB
            // 
            this.schoolTB.Location = new System.Drawing.Point(240, 17);
            this.schoolTB.Name = "schoolTB";
            this.schoolTB.ReadOnly = true;
            this.schoolTB.Size = new System.Drawing.Size(230, 20);
            this.schoolTB.TabIndex = 3;
            // 
            // schoollbl
            // 
            this.schoollbl.AutoSize = true;
            this.schoollbl.Location = new System.Drawing.Point(194, 21);
            this.schoollbl.Name = "schoollbl";
            this.schoollbl.Size = new System.Drawing.Size(46, 13);
            this.schoollbl.TabIndex = 2;
            this.schoollbl.Text = "School";
            // 
            // skCodeTB
            // 
            this.skCodeTB.Location = new System.Drawing.Point(81, 17);
            this.skCodeTB.Name = "skCodeTB";
            this.skCodeTB.ReadOnly = true;
            this.skCodeTB.Size = new System.Drawing.Size(100, 20);
            this.skCodeTB.TabIndex = 1;
            // 
            // skCodelbl
            // 
            this.skCodelbl.AutoSize = true;
            this.skCodelbl.Location = new System.Drawing.Point(6, 20);
            this.skCodelbl.Name = "skCodelbl";
            this.skCodelbl.Size = new System.Drawing.Size(79, 13);
            this.skCodelbl.TabIndex = 0;
            this.skCodelbl.Text = "School Code";
            // 
            // PrinicipalGV
            // 
            this.PrinicipalGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PrinicipalGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.PrinicipalGV.BackgroundColor = System.Drawing.Color.White;
            this.PrinicipalGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrinicipalGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrinicipalGV.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.PrinicipalGV.Location = new System.Drawing.Point(0, 0);
            this.PrinicipalGV.Name = "PrinicipalGV";
            this.PrinicipalGV.Size = new System.Drawing.Size(486, 70);
            this.PrinicipalGV.TabIndex = 0;
            // 
            // errorMsg
            // 
            this.errorMsg.ContainerControl = this;
            // 
            // frmSchools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final.Properties.Resources.chalkboard_apple_624x300;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(486, 388);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmSchools";
            this.Text = "frmSchools";
            this.Load += new System.EventHandler(this.frmSchools_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SchoolsListGV)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.SchoolinfoGB.ResumeLayout(false);
            this.SchoolinfoGB.PerformLayout();
            this.ControlsGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PrinicipalGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMsg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox SchoolinfoGB;
        public System.Windows.Forms.Label uIDlbl;
        private System.Windows.Forms.Label Parishlbl;
        private System.Windows.Forms.Label Villagelbl;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.Label Emaillbl;
        private System.Windows.Forms.MaskedTextBox OfficeTB;
        private System.Windows.Forms.Label phonelbl;
        private System.Windows.Forms.TextBox schoolTB;
        private System.Windows.Forms.Label schoollbl;
        private System.Windows.Forms.TextBox skCodeTB;
        private System.Windows.Forms.Label skCodelbl;
        private System.Windows.Forms.DataGridView PrinicipalGV;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataGridView SchoolsListGV;
        private System.Windows.Forms.TextBox SearchTB;
        private System.Windows.Forms.Label Searchlbl;
        public System.Windows.Forms.ComboBox VillageCB;
        public System.Windows.Forms.ComboBox ParishCB;
        public System.Windows.Forms.GroupBox ControlsGB;
        private System.Windows.Forms.Button NewBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button NewVillagebtn;
        private System.Windows.Forms.ErrorProvider errorMsg;
    }
}