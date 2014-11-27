namespace Final
{
    partial class frmNewSubject
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.subjectLB = new System.Windows.Forms.ListBox();
            this.NewVillageGB = new System.Windows.Forms.GroupBox();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.subNameTB = new System.Windows.Forms.TextBox();
            this.SaveSubjbtn = new System.Windows.Forms.Button();
            this.subIDTB = new System.Windows.Forms.TextBox();
            this.Subjectlbl = new System.Windows.Forms.Label();
            this.SubjectIDlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.NewVillageGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.subjectLB);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.NewVillageGB);
            this.splitContainer1.Size = new System.Drawing.Size(467, 121);
            this.splitContainer1.SplitterDistance = 176;
            this.splitContainer1.TabIndex = 20;
            // 
            // subjectLB
            // 
            this.subjectLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subjectLB.FormattingEnabled = true;
            this.subjectLB.Location = new System.Drawing.Point(0, 0);
            this.subjectLB.Name = "subjectLB";
            this.subjectLB.Size = new System.Drawing.Size(176, 121);
            this.subjectLB.TabIndex = 0;
            // 
            // NewVillageGB
            // 
            this.NewVillageGB.BackColor = System.Drawing.Color.Transparent;
            this.NewVillageGB.BackgroundImage = global::Final.Properties.Resources.chalkboard_apple_624x300;
            this.NewVillageGB.Controls.Add(this.Cancelbtn);
            this.NewVillageGB.Controls.Add(this.subNameTB);
            this.NewVillageGB.Controls.Add(this.SaveSubjbtn);
            this.NewVillageGB.Controls.Add(this.subIDTB);
            this.NewVillageGB.Controls.Add(this.Subjectlbl);
            this.NewVillageGB.Controls.Add(this.SubjectIDlbl);
            this.NewVillageGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewVillageGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewVillageGB.ForeColor = System.Drawing.Color.White;
            this.NewVillageGB.Location = new System.Drawing.Point(0, 0);
            this.NewVillageGB.Name = "NewVillageGB";
            this.NewVillageGB.Size = new System.Drawing.Size(287, 121);
            this.NewVillageGB.TabIndex = 3;
            this.NewVillageGB.TabStop = false;
            this.NewVillageGB.Text = "New Subject";
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.ForeColor = System.Drawing.Color.DarkRed;
            this.Cancelbtn.Location = new System.Drawing.Point(138, 84);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(65, 30);
            this.Cancelbtn.TabIndex = 24;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // subNameTB
            // 
            this.subNameTB.Location = new System.Drawing.Point(79, 49);
            this.subNameTB.MaxLength = 50;
            this.subNameTB.Name = "subNameTB";
            this.subNameTB.Size = new System.Drawing.Size(195, 20);
            this.subNameTB.TabIndex = 23;
            // 
            // SaveSubjbtn
            // 
            this.SaveSubjbtn.ForeColor = System.Drawing.Color.DarkRed;
            this.SaveSubjbtn.Location = new System.Drawing.Point(209, 84);
            this.SaveSubjbtn.Name = "SaveSubjbtn";
            this.SaveSubjbtn.Size = new System.Drawing.Size(65, 30);
            this.SaveSubjbtn.TabIndex = 22;
            this.SaveSubjbtn.Text = "Save";
            this.SaveSubjbtn.UseVisualStyleBackColor = true;
            this.SaveSubjbtn.Click += new System.EventHandler(this.SaveSubjbtn_Click_1);
            // 
            // subIDTB
            // 
            this.subIDTB.Location = new System.Drawing.Point(79, 23);
            this.subIDTB.Name = "subIDTB";
            this.subIDTB.ReadOnly = true;
            this.subIDTB.Size = new System.Drawing.Size(100, 20);
            this.subIDTB.TabIndex = 21;
            // 
            // Subjectlbl
            // 
            this.Subjectlbl.AutoSize = true;
            this.Subjectlbl.Location = new System.Drawing.Point(30, 52);
            this.Subjectlbl.Name = "Subjectlbl";
            this.Subjectlbl.Size = new System.Drawing.Size(50, 13);
            this.Subjectlbl.TabIndex = 20;
            this.Subjectlbl.Text = "Subject";
            // 
            // SubjectIDlbl
            // 
            this.SubjectIDlbl.AutoSize = true;
            this.SubjectIDlbl.Location = new System.Drawing.Point(16, 26);
            this.SubjectIDlbl.Name = "SubjectIDlbl";
            this.SubjectIDlbl.Size = new System.Drawing.Size(67, 13);
            this.SubjectIDlbl.TabIndex = 19;
            this.SubjectIDlbl.Text = "Subject ID";
            // 
            // frmNewSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 121);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmNewSubject";
            this.Text = "New Subject";
            this.Load += new System.EventHandler(this.frmnewSubject_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.NewVillageGB.ResumeLayout(false);
            this.NewVillageGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox subjectLB;
        private System.Windows.Forms.GroupBox NewVillageGB;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.TextBox subNameTB;
        private System.Windows.Forms.Button SaveSubjbtn;
        private System.Windows.Forms.TextBox subIDTB;
        private System.Windows.Forms.Label Subjectlbl;
        private System.Windows.Forms.Label SubjectIDlbl;


    }
}