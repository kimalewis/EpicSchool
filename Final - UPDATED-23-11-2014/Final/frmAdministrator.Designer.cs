namespace Final
{
    partial class frmAdministrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdministrator));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AllUsersTabs = new System.Windows.Forms.TabControl();
            this.TeacherTab = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tPrintBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.SortBtn = new System.Windows.Forms.Button();
            this.TSchoolsCB = new System.Windows.Forms.ComboBox();
            this.Schoolslbl = new System.Windows.Forms.Label();
            this.TeacherGV = new System.Windows.Forms.DataGridView();
            this.StudentTab = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.sPrintBtn = new System.Windows.Forms.Button();
            this.sResetBtn = new System.Windows.Forms.Button();
            this.sSortBtn = new System.Windows.Forms.Button();
            this.sSchoolCB = new System.Windows.Forms.ComboBox();
            this.sSchoollbl = new System.Windows.Forms.Label();
            this.StudentsGV = new System.Windows.Forms.DataGridView();
            this.SubjectsClassesTab = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.scPrintBtn = new System.Windows.Forms.Button();
            this.countlbl = new System.Windows.Forms.Label();
            this.quantitylbl = new System.Windows.Forms.Label();
            this.cSubjectCB = new System.Windows.Forms.ComboBox();
            this.cSubjectlbl = new System.Windows.Forms.Label();
            this.cResetBtn = new System.Windows.Forms.Button();
            this.cSortBtn = new System.Windows.Forms.Button();
            this.cSchoolCB = new System.Windows.Forms.ComboBox();
            this.cSchoollbl = new System.Windows.Forms.Label();
            this.cSubjectClassGV = new System.Windows.Forms.DataGridView();
            this.LoginAccountTab = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.lgPrintBtn = new System.Windows.Forms.Button();
            this.lResetBtn = new System.Windows.Forms.Button();
            this.lSortBtn = new System.Windows.Forms.Button();
            this.lAccessTypeCB = new System.Windows.Forms.ComboBox();
            this.lAccesstypelbl = new System.Windows.Forms.Label();
            this.UserLoginGV = new System.Windows.Forms.DataGridView();
            this.SchoolTab = new System.Windows.Forms.TabPage();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.ParishCB = new System.Windows.Forms.ComboBox();
            this.Parishlbl = new System.Windows.Forms.Label();
            this.skResetBtn = new System.Windows.Forms.Button();
            this.skSortBtn = new System.Windows.Forms.Button();
            this.SchoolsGV = new System.Windows.Forms.DataGridView();
            this.AllUsersTabs.SuspendLayout();
            this.TeacherTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherGV)).BeginInit();
            this.StudentTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsGV)).BeginInit();
            this.SubjectsClassesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cSubjectClassGV)).BeginInit();
            this.LoginAccountTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserLoginGV)).BeginInit();
            this.SchoolTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SchoolsGV)).BeginInit();
            this.SuspendLayout();
            // 
            // AllUsersTabs
            // 
            this.AllUsersTabs.Controls.Add(this.TeacherTab);
            this.AllUsersTabs.Controls.Add(this.StudentTab);
            this.AllUsersTabs.Controls.Add(this.SubjectsClassesTab);
            this.AllUsersTabs.Controls.Add(this.LoginAccountTab);
            this.AllUsersTabs.Controls.Add(this.SchoolTab);
            this.AllUsersTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllUsersTabs.Location = new System.Drawing.Point(0, 0);
            this.AllUsersTabs.Name = "AllUsersTabs";
            this.AllUsersTabs.SelectedIndex = 0;
            this.AllUsersTabs.Size = new System.Drawing.Size(571, 456);
            this.AllUsersTabs.TabIndex = 0;
            this.AllUsersTabs.Click += new System.EventHandler(this.AllUsersTabs_Click);
            // 
            // TeacherTab
            // 
            this.TeacherTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TeacherTab.BackgroundImage")));
            this.TeacherTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TeacherTab.Controls.Add(this.splitContainer1);
            this.TeacherTab.Location = new System.Drawing.Point(4, 22);
            this.TeacherTab.Name = "TeacherTab";
            this.TeacherTab.Padding = new System.Windows.Forms.Padding(3);
            this.TeacherTab.Size = new System.Drawing.Size(563, 430);
            this.TeacherTab.TabIndex = 0;
            this.TeacherTab.Text = "Teachers";
            this.TeacherTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tPrintBtn);
            this.splitContainer1.Panel1.Controls.Add(this.ResetBtn);
            this.splitContainer1.Panel1.Controls.Add(this.SortBtn);
            this.splitContainer1.Panel1.Controls.Add(this.TSchoolsCB);
            this.splitContainer1.Panel1.Controls.Add(this.Schoolslbl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TeacherGV);
            this.splitContainer1.Size = new System.Drawing.Size(557, 424);
            this.splitContainer1.SplitterDistance = 68;
            this.splitContainer1.TabIndex = 0;
            // 
            // tPrintBtn
            // 
            this.tPrintBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPrintBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.tPrintBtn.Location = new System.Drawing.Point(478, 15);
            this.tPrintBtn.Name = "tPrintBtn";
            this.tPrintBtn.Size = new System.Drawing.Size(75, 31);
            this.tPrintBtn.TabIndex = 4;
            this.tPrintBtn.Text = "Print";
            this.tPrintBtn.UseVisualStyleBackColor = true;
            this.tPrintBtn.Click += new System.EventHandler(this.tPrintBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.ResetBtn.Location = new System.Drawing.Point(397, 16);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(75, 31);
            this.ResetBtn.TabIndex = 3;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // SortBtn
            // 
            this.SortBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.SortBtn.Location = new System.Drawing.Point(316, 15);
            this.SortBtn.Name = "SortBtn";
            this.SortBtn.Size = new System.Drawing.Size(75, 32);
            this.SortBtn.TabIndex = 2;
            this.SortBtn.Text = "Sort";
            this.SortBtn.UseVisualStyleBackColor = true;
            this.SortBtn.Click += new System.EventHandler(this.SortBtn_Click);
            // 
            // TSchoolsCB
            // 
            this.TSchoolsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TSchoolsCB.FormattingEnabled = true;
            this.TSchoolsCB.Location = new System.Drawing.Point(61, 21);
            this.TSchoolsCB.Name = "TSchoolsCB";
            this.TSchoolsCB.Size = new System.Drawing.Size(244, 21);
            this.TSchoolsCB.TabIndex = 1;
            // 
            // Schoolslbl
            // 
            this.Schoolslbl.AutoSize = true;
            this.Schoolslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Schoolslbl.ForeColor = System.Drawing.Color.White;
            this.Schoolslbl.Location = new System.Drawing.Point(15, 24);
            this.Schoolslbl.Name = "Schoolslbl";
            this.Schoolslbl.Size = new System.Drawing.Size(46, 13);
            this.Schoolslbl.TabIndex = 0;
            this.Schoolslbl.Text = "School";
            // 
            // TeacherGV
            // 
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TeacherGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TeacherGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TeacherGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.TeacherGV.BackgroundColor = System.Drawing.Color.White;
            this.TeacherGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeacherGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TeacherGV.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.TeacherGV.Location = new System.Drawing.Point(0, 0);
            this.TeacherGV.Name = "TeacherGV";
            this.TeacherGV.Size = new System.Drawing.Size(557, 352);
            this.TeacherGV.TabIndex = 0;
            this.TeacherGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TeacherGV_CellContentClick);
            // 
            // StudentTab
            // 
            this.StudentTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StudentTab.BackgroundImage")));
            this.StudentTab.Controls.Add(this.splitContainer2);
            this.StudentTab.Location = new System.Drawing.Point(4, 22);
            this.StudentTab.Name = "StudentTab";
            this.StudentTab.Padding = new System.Windows.Forms.Padding(3);
            this.StudentTab.Size = new System.Drawing.Size(563, 430);
            this.StudentTab.TabIndex = 1;
            this.StudentTab.Text = "Students";
            this.StudentTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.sPrintBtn);
            this.splitContainer2.Panel1.Controls.Add(this.sResetBtn);
            this.splitContainer2.Panel1.Controls.Add(this.sSortBtn);
            this.splitContainer2.Panel1.Controls.Add(this.sSchoolCB);
            this.splitContainer2.Panel1.Controls.Add(this.sSchoollbl);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.StudentsGV);
            this.splitContainer2.Size = new System.Drawing.Size(557, 424);
            this.splitContainer2.SplitterDistance = 67;
            this.splitContainer2.TabIndex = 0;
            // 
            // sPrintBtn
            // 
            this.sPrintBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sPrintBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.sPrintBtn.Location = new System.Drawing.Point(476, 18);
            this.sPrintBtn.Name = "sPrintBtn";
            this.sPrintBtn.Size = new System.Drawing.Size(75, 31);
            this.sPrintBtn.TabIndex = 8;
            this.sPrintBtn.Text = "Print";
            this.sPrintBtn.UseVisualStyleBackColor = true;
            this.sPrintBtn.Click += new System.EventHandler(this.sPrintBtn_Click);
            // 
            // sResetBtn
            // 
            this.sResetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sResetBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.sResetBtn.Location = new System.Drawing.Point(397, 18);
            this.sResetBtn.Name = "sResetBtn";
            this.sResetBtn.Size = new System.Drawing.Size(75, 31);
            this.sResetBtn.TabIndex = 7;
            this.sResetBtn.Text = "Reset";
            this.sResetBtn.UseVisualStyleBackColor = true;
            this.sResetBtn.Click += new System.EventHandler(this.sResetBtn_Click);
            // 
            // sSortBtn
            // 
            this.sSortBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sSortBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.sSortBtn.Location = new System.Drawing.Point(319, 17);
            this.sSortBtn.Name = "sSortBtn";
            this.sSortBtn.Size = new System.Drawing.Size(75, 32);
            this.sSortBtn.TabIndex = 6;
            this.sSortBtn.Text = "Sort";
            this.sSortBtn.UseVisualStyleBackColor = true;
            this.sSortBtn.Click += new System.EventHandler(this.sSortBtn_Click);
            // 
            // sSchoolCB
            // 
            this.sSchoolCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sSchoolCB.FormattingEnabled = true;
            this.sSchoolCB.Location = new System.Drawing.Point(56, 24);
            this.sSchoolCB.Name = "sSchoolCB";
            this.sSchoolCB.Size = new System.Drawing.Size(244, 21);
            this.sSchoolCB.TabIndex = 5;
            // 
            // sSchoollbl
            // 
            this.sSchoollbl.AutoSize = true;
            this.sSchoollbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sSchoollbl.ForeColor = System.Drawing.Color.Transparent;
            this.sSchoollbl.Location = new System.Drawing.Point(10, 27);
            this.sSchoollbl.Name = "sSchoollbl";
            this.sSchoollbl.Size = new System.Drawing.Size(46, 13);
            this.sSchoollbl.TabIndex = 4;
            this.sSchoollbl.Text = "School";
            // 
            // StudentsGV
            // 
            this.StudentsGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentsGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.StudentsGV.BackgroundColor = System.Drawing.Color.White;
            this.StudentsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentsGV.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.StudentsGV.Location = new System.Drawing.Point(0, 0);
            this.StudentsGV.Name = "StudentsGV";
            this.StudentsGV.Size = new System.Drawing.Size(557, 353);
            this.StudentsGV.TabIndex = 0;
            this.StudentsGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentsGV_CellContentClick);
            // 
            // SubjectsClassesTab
            // 
            this.SubjectsClassesTab.Controls.Add(this.splitContainer3);
            this.SubjectsClassesTab.Location = new System.Drawing.Point(4, 22);
            this.SubjectsClassesTab.Name = "SubjectsClassesTab";
            this.SubjectsClassesTab.Size = new System.Drawing.Size(563, 430);
            this.SubjectsClassesTab.TabIndex = 2;
            this.SubjectsClassesTab.Text = "Subjects/Classes";
            this.SubjectsClassesTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer3.BackgroundImage")));
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.scPrintBtn);
            this.splitContainer3.Panel1.Controls.Add(this.countlbl);
            this.splitContainer3.Panel1.Controls.Add(this.quantitylbl);
            this.splitContainer3.Panel1.Controls.Add(this.cSubjectCB);
            this.splitContainer3.Panel1.Controls.Add(this.cSubjectlbl);
            this.splitContainer3.Panel1.Controls.Add(this.cResetBtn);
            this.splitContainer3.Panel1.Controls.Add(this.cSortBtn);
            this.splitContainer3.Panel1.Controls.Add(this.cSchoolCB);
            this.splitContainer3.Panel1.Controls.Add(this.cSchoollbl);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.cSubjectClassGV);
            this.splitContainer3.Size = new System.Drawing.Size(563, 430);
            this.splitContainer3.SplitterDistance = 68;
            this.splitContainer3.TabIndex = 0;
            // 
            // scPrintBtn
            // 
            this.scPrintBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scPrintBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.scPrintBtn.Location = new System.Drawing.Point(485, 10);
            this.scPrintBtn.Name = "scPrintBtn";
            this.scPrintBtn.Size = new System.Drawing.Size(75, 31);
            this.scPrintBtn.TabIndex = 16;
            this.scPrintBtn.Text = "Print";
            this.scPrintBtn.UseVisualStyleBackColor = true;
            this.scPrintBtn.Click += new System.EventHandler(this.scPrintBtn_Click);
            // 
            // countlbl
            // 
            this.countlbl.AutoSize = true;
            this.countlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countlbl.ForeColor = System.Drawing.Color.White;
            this.countlbl.Location = new System.Drawing.Point(373, 46);
            this.countlbl.Name = "countlbl";
            this.countlbl.Size = new System.Drawing.Size(14, 13);
            this.countlbl.TabIndex = 15;
            this.countlbl.Text = "0";
            // 
            // quantitylbl
            // 
            this.quantitylbl.AutoSize = true;
            this.quantitylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitylbl.ForeColor = System.Drawing.Color.White;
            this.quantitylbl.Location = new System.Drawing.Point(317, 46);
            this.quantitylbl.Name = "quantitylbl";
            this.quantitylbl.Size = new System.Drawing.Size(54, 13);
            this.quantitylbl.TabIndex = 14;
            this.quantitylbl.Text = "Quantity";
            // 
            // cSubjectCB
            // 
            this.cSubjectCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cSubjectCB.FormattingEnabled = true;
            this.cSubjectCB.Location = new System.Drawing.Point(63, 38);
            this.cSubjectCB.Name = "cSubjectCB";
            this.cSubjectCB.Size = new System.Drawing.Size(244, 21);
            this.cSubjectCB.TabIndex = 13;
            // 
            // cSubjectlbl
            // 
            this.cSubjectlbl.AutoSize = true;
            this.cSubjectlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cSubjectlbl.ForeColor = System.Drawing.Color.White;
            this.cSubjectlbl.Location = new System.Drawing.Point(11, 41);
            this.cSubjectlbl.Name = "cSubjectlbl";
            this.cSubjectlbl.Size = new System.Drawing.Size(50, 13);
            this.cSubjectlbl.TabIndex = 12;
            this.cSubjectlbl.Text = "Subject";
            // 
            // cResetBtn
            // 
            this.cResetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cResetBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.cResetBtn.Location = new System.Drawing.Point(407, 10);
            this.cResetBtn.Name = "cResetBtn";
            this.cResetBtn.Size = new System.Drawing.Size(75, 31);
            this.cResetBtn.TabIndex = 11;
            this.cResetBtn.Text = "Reset";
            this.cResetBtn.UseVisualStyleBackColor = true;
            this.cResetBtn.Click += new System.EventHandler(this.cResetBtn_Click);
            // 
            // cSortBtn
            // 
            this.cSortBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cSortBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.cSortBtn.Location = new System.Drawing.Point(326, 10);
            this.cSortBtn.Name = "cSortBtn";
            this.cSortBtn.Size = new System.Drawing.Size(75, 32);
            this.cSortBtn.TabIndex = 10;
            this.cSortBtn.Text = "Sort";
            this.cSortBtn.UseVisualStyleBackColor = true;
            this.cSortBtn.Click += new System.EventHandler(this.cSortBtn_Click);
            // 
            // cSchoolCB
            // 
            this.cSchoolCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cSchoolCB.FormattingEnabled = true;
            this.cSchoolCB.Location = new System.Drawing.Point(63, 11);
            this.cSchoolCB.Name = "cSchoolCB";
            this.cSchoolCB.Size = new System.Drawing.Size(244, 21);
            this.cSchoolCB.TabIndex = 9;
            // 
            // cSchoollbl
            // 
            this.cSchoollbl.AutoSize = true;
            this.cSchoollbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cSchoollbl.ForeColor = System.Drawing.Color.White;
            this.cSchoollbl.Location = new System.Drawing.Point(11, 14);
            this.cSchoollbl.Name = "cSchoollbl";
            this.cSchoollbl.Size = new System.Drawing.Size(46, 13);
            this.cSchoollbl.TabIndex = 8;
            this.cSchoollbl.Text = "School";
            // 
            // cSubjectClassGV
            // 
            this.cSubjectClassGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cSubjectClassGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.cSubjectClassGV.BackgroundColor = System.Drawing.Color.White;
            this.cSubjectClassGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cSubjectClassGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cSubjectClassGV.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.cSubjectClassGV.Location = new System.Drawing.Point(0, 0);
            this.cSubjectClassGV.Name = "cSubjectClassGV";
            this.cSubjectClassGV.Size = new System.Drawing.Size(563, 358);
            this.cSubjectClassGV.TabIndex = 0;
            this.cSubjectClassGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cSubjectClassGV_CellContentClick);
            // 
            // LoginAccountTab
            // 
            this.LoginAccountTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginAccountTab.BackgroundImage")));
            this.LoginAccountTab.Controls.Add(this.splitContainer4);
            this.LoginAccountTab.Location = new System.Drawing.Point(4, 22);
            this.LoginAccountTab.Name = "LoginAccountTab";
            this.LoginAccountTab.Size = new System.Drawing.Size(563, 430);
            this.LoginAccountTab.TabIndex = 3;
            this.LoginAccountTab.Text = "Logins";
            this.LoginAccountTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.lgPrintBtn);
            this.splitContainer4.Panel1.Controls.Add(this.lResetBtn);
            this.splitContainer4.Panel1.Controls.Add(this.lSortBtn);
            this.splitContainer4.Panel1.Controls.Add(this.lAccessTypeCB);
            this.splitContainer4.Panel1.Controls.Add(this.lAccesstypelbl);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.UserLoginGV);
            this.splitContainer4.Size = new System.Drawing.Size(563, 430);
            this.splitContainer4.SplitterDistance = 72;
            this.splitContainer4.TabIndex = 0;
            // 
            // lgPrintBtn
            // 
            this.lgPrintBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgPrintBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.lgPrintBtn.Location = new System.Drawing.Point(473, 20);
            this.lgPrintBtn.Name = "lgPrintBtn";
            this.lgPrintBtn.Size = new System.Drawing.Size(75, 31);
            this.lgPrintBtn.TabIndex = 17;
            this.lgPrintBtn.Text = "Print";
            this.lgPrintBtn.UseVisualStyleBackColor = true;
            this.lgPrintBtn.Click += new System.EventHandler(this.lgPrintBtn_Click);
            // 
            // lResetBtn
            // 
            this.lResetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lResetBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.lResetBtn.Location = new System.Drawing.Point(392, 20);
            this.lResetBtn.Name = "lResetBtn";
            this.lResetBtn.Size = new System.Drawing.Size(75, 31);
            this.lResetBtn.TabIndex = 11;
            this.lResetBtn.Text = "Reset";
            this.lResetBtn.UseVisualStyleBackColor = true;
            // 
            // lSortBtn
            // 
            this.lSortBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSortBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.lSortBtn.Location = new System.Drawing.Point(311, 19);
            this.lSortBtn.Name = "lSortBtn";
            this.lSortBtn.Size = new System.Drawing.Size(75, 32);
            this.lSortBtn.TabIndex = 10;
            this.lSortBtn.Text = "Sort";
            this.lSortBtn.UseVisualStyleBackColor = true;
            this.lSortBtn.Click += new System.EventHandler(this.lSortBtn_Click);
            // 
            // lAccessTypeCB
            // 
            this.lAccessTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lAccessTypeCB.FormattingEnabled = true;
            this.lAccessTypeCB.Location = new System.Drawing.Point(90, 26);
            this.lAccessTypeCB.Name = "lAccessTypeCB";
            this.lAccessTypeCB.Size = new System.Drawing.Size(207, 21);
            this.lAccessTypeCB.TabIndex = 9;
            // 
            // lAccesstypelbl
            // 
            this.lAccesstypelbl.AutoSize = true;
            this.lAccesstypelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAccesstypelbl.ForeColor = System.Drawing.Color.White;
            this.lAccesstypelbl.Location = new System.Drawing.Point(5, 29);
            this.lAccesstypelbl.Name = "lAccesstypelbl";
            this.lAccesstypelbl.Size = new System.Drawing.Size(82, 13);
            this.lAccesstypelbl.TabIndex = 8;
            this.lAccesstypelbl.Text = "AccessTypes";
            // 
            // UserLoginGV
            // 
            this.UserLoginGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserLoginGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.UserLoginGV.BackgroundColor = System.Drawing.Color.White;
            this.UserLoginGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserLoginGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserLoginGV.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.UserLoginGV.Location = new System.Drawing.Point(0, 0);
            this.UserLoginGV.Name = "UserLoginGV";
            this.UserLoginGV.Size = new System.Drawing.Size(563, 354);
            this.UserLoginGV.TabIndex = 0;
            this.UserLoginGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserLoginGV_CellContentClick);
            // 
            // SchoolTab
            // 
            this.SchoolTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SchoolTab.BackgroundImage")));
            this.SchoolTab.Controls.Add(this.splitContainer5);
            this.SchoolTab.Location = new System.Drawing.Point(4, 22);
            this.SchoolTab.Name = "SchoolTab";
            this.SchoolTab.Padding = new System.Windows.Forms.Padding(3);
            this.SchoolTab.Size = new System.Drawing.Size(563, 430);
            this.SchoolTab.TabIndex = 4;
            this.SchoolTab.Text = "Schools";
            this.SchoolTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(3, 3);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.ParishCB);
            this.splitContainer5.Panel1.Controls.Add(this.Parishlbl);
            this.splitContainer5.Panel1.Controls.Add(this.skResetBtn);
            this.splitContainer5.Panel1.Controls.Add(this.skSortBtn);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.SchoolsGV);
            this.splitContainer5.Size = new System.Drawing.Size(557, 424);
            this.splitContainer5.SplitterDistance = 70;
            this.splitContainer5.TabIndex = 1;
            // 
            // ParishCB
            // 
            this.ParishCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ParishCB.FormattingEnabled = true;
            this.ParishCB.Location = new System.Drawing.Point(78, 26);
            this.ParishCB.Name = "ParishCB";
            this.ParishCB.Size = new System.Drawing.Size(244, 21);
            this.ParishCB.TabIndex = 13;
            // 
            // Parishlbl
            // 
            this.Parishlbl.AutoSize = true;
            this.Parishlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Parishlbl.ForeColor = System.Drawing.Color.White;
            this.Parishlbl.Location = new System.Drawing.Point(32, 29);
            this.Parishlbl.Name = "Parishlbl";
            this.Parishlbl.Size = new System.Drawing.Size(42, 13);
            this.Parishlbl.TabIndex = 12;
            this.Parishlbl.Text = "Parish";
            // 
            // skResetBtn
            // 
            this.skResetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skResetBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.skResetBtn.Location = new System.Drawing.Point(458, 20);
            this.skResetBtn.Name = "skResetBtn";
            this.skResetBtn.Size = new System.Drawing.Size(75, 31);
            this.skResetBtn.TabIndex = 11;
            this.skResetBtn.Text = "Reset";
            this.skResetBtn.UseVisualStyleBackColor = true;
            // 
            // skSortBtn
            // 
            this.skSortBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skSortBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.skSortBtn.Location = new System.Drawing.Point(359, 20);
            this.skSortBtn.Name = "skSortBtn";
            this.skSortBtn.Size = new System.Drawing.Size(75, 32);
            this.skSortBtn.TabIndex = 10;
            this.skSortBtn.Text = "Sort";
            this.skSortBtn.UseVisualStyleBackColor = true;
            this.skSortBtn.Click += new System.EventHandler(this.skSortBtn_Click);
            // 
            // SchoolsGV
            // 
            this.SchoolsGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SchoolsGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.SchoolsGV.BackgroundColor = System.Drawing.Color.White;
            this.SchoolsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SchoolsGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SchoolsGV.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.SchoolsGV.Location = new System.Drawing.Point(0, 0);
            this.SchoolsGV.Name = "SchoolsGV";
            this.SchoolsGV.Size = new System.Drawing.Size(557, 350);
            this.SchoolsGV.TabIndex = 0;
            this.SchoolsGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SchoolsGV_CellContentClick);
            // 
            // frmAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 456);
            this.Controls.Add(this.AllUsersTabs);
            this.Name = "frmAdministrator";
            this.Text = "frmAdministrator";
            this.Load += new System.EventHandler(this.frmAdministrator_Load);
            this.AllUsersTabs.ResumeLayout(false);
            this.TeacherTab.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TeacherGV)).EndInit();
            this.StudentTab.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudentsGV)).EndInit();
            this.SubjectsClassesTab.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cSubjectClassGV)).EndInit();
            this.LoginAccountTab.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserLoginGV)).EndInit();
            this.SchoolTab.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel1.PerformLayout();
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SchoolsGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl AllUsersTabs;
        private System.Windows.Forms.TabPage TeacherTab;
        private System.Windows.Forms.TabPage StudentTab;
        private System.Windows.Forms.TabPage SubjectsClassesTab;
        private System.Windows.Forms.TabPage LoginAccountTab;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button SortBtn;
        private System.Windows.Forms.ComboBox TSchoolsCB;
        private System.Windows.Forms.Label Schoolslbl;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.DataGridView TeacherGV;
        private System.Windows.Forms.Button sResetBtn;
        private System.Windows.Forms.Button sSortBtn;
        private System.Windows.Forms.ComboBox sSchoolCB;
        private System.Windows.Forms.Label sSchoollbl;
        private System.Windows.Forms.DataGridView StudentsGV;
        private System.Windows.Forms.Button cResetBtn;
        private System.Windows.Forms.Button cSortBtn;
        private System.Windows.Forms.ComboBox cSchoolCB;
        private System.Windows.Forms.Label cSchoollbl;
        private System.Windows.Forms.ComboBox cSubjectCB;
        private System.Windows.Forms.Label cSubjectlbl;
        private System.Windows.Forms.DataGridView cSubjectClassGV;
        private System.Windows.Forms.Label quantitylbl;
        private System.Windows.Forms.Label countlbl;
        private System.Windows.Forms.Button lResetBtn;
        private System.Windows.Forms.Button lSortBtn;
        private System.Windows.Forms.ComboBox lAccessTypeCB;
        private System.Windows.Forms.Label lAccesstypelbl;
        private System.Windows.Forms.DataGridView UserLoginGV;
        private System.Windows.Forms.TabPage SchoolTab;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.Button skResetBtn;
        private System.Windows.Forms.Button skSortBtn;
        private System.Windows.Forms.DataGridView SchoolsGV;
        private System.Windows.Forms.ComboBox ParishCB;
        private System.Windows.Forms.Label Parishlbl;
        private System.Windows.Forms.Button tPrintBtn;
        private System.Windows.Forms.Button sPrintBtn;
        private System.Windows.Forms.Button scPrintBtn;
        private System.Windows.Forms.Button lgPrintBtn;
    }
}