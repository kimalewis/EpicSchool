namespace Final
{
    partial class frmNewSchoolForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewSchoolForm));
            this.NewSchoolGB = new System.Windows.Forms.GroupBox();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.sFormTB = new System.Windows.Forms.TextBox();
            this.SaveSubjbtn = new System.Windows.Forms.Button();
            this.sFormIDTB = new System.Windows.Forms.TextBox();
            this.SchoolFormlbl = new System.Windows.Forms.Label();
            this.SchoolFormIDlbl = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.SchoolfrmsLB = new System.Windows.Forms.ListBox();
            this.NewSchoolGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewSchoolGB
            // 
            this.NewSchoolGB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NewSchoolGB.BackgroundImage")));
            this.NewSchoolGB.Controls.Add(this.Cancelbtn);
            this.NewSchoolGB.Controls.Add(this.sFormTB);
            this.NewSchoolGB.Controls.Add(this.SaveSubjbtn);
            this.NewSchoolGB.Controls.Add(this.sFormIDTB);
            this.NewSchoolGB.Controls.Add(this.SchoolFormlbl);
            this.NewSchoolGB.Controls.Add(this.SchoolFormIDlbl);
            this.NewSchoolGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewSchoolGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewSchoolGB.ForeColor = System.Drawing.Color.White;
            this.NewSchoolGB.Location = new System.Drawing.Point(0, 0);
            this.NewSchoolGB.Name = "NewSchoolGB";
            this.NewSchoolGB.Size = new System.Drawing.Size(282, 121);
            this.NewSchoolGB.TabIndex = 3;
            this.NewSchoolGB.TabStop = false;
            this.NewSchoolGB.Text = "New Form";
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.ForeColor = System.Drawing.Color.DarkRed;
            this.Cancelbtn.Location = new System.Drawing.Point(202, 51);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(65, 30);
            this.Cancelbtn.TabIndex = 12;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // sFormTB
            // 
            this.sFormTB.Location = new System.Drawing.Point(83, 48);
            this.sFormTB.MaxLength = 3;
            this.sFormTB.Name = "sFormTB";
            this.sFormTB.Size = new System.Drawing.Size(100, 20);
            this.sFormTB.TabIndex = 11;
            // 
            // SaveSubjbtn
            // 
            this.SaveSubjbtn.ForeColor = System.Drawing.Color.DarkRed;
            this.SaveSubjbtn.Location = new System.Drawing.Point(202, 12);
            this.SaveSubjbtn.Name = "SaveSubjbtn";
            this.SaveSubjbtn.Size = new System.Drawing.Size(65, 30);
            this.SaveSubjbtn.TabIndex = 10;
            this.SaveSubjbtn.Text = "Save";
            this.SaveSubjbtn.UseVisualStyleBackColor = true;
            this.SaveSubjbtn.Click += new System.EventHandler(this.SaveSubjbtn_Click);
            // 
            // sFormIDTB
            // 
            this.sFormIDTB.Location = new System.Drawing.Point(83, 22);
            this.sFormIDTB.Name = "sFormIDTB";
            this.sFormIDTB.ReadOnly = true;
            this.sFormIDTB.Size = new System.Drawing.Size(100, 20);
            this.sFormIDTB.TabIndex = 3;
            // 
            // SchoolFormlbl
            // 
            this.SchoolFormlbl.AutoSize = true;
            this.SchoolFormlbl.BackColor = System.Drawing.Color.Transparent;
            this.SchoolFormlbl.ForeColor = System.Drawing.Color.White;
            this.SchoolFormlbl.Location = new System.Drawing.Point(34, 51);
            this.SchoolFormlbl.Name = "SchoolFormlbl";
            this.SchoolFormlbl.Size = new System.Drawing.Size(34, 13);
            this.SchoolFormlbl.TabIndex = 1;
            this.SchoolFormlbl.Text = "Form";
            // 
            // SchoolFormIDlbl
            // 
            this.SchoolFormIDlbl.AutoSize = true;
            this.SchoolFormIDlbl.BackColor = System.Drawing.Color.Transparent;
            this.SchoolFormIDlbl.ForeColor = System.Drawing.Color.White;
            this.SchoolFormIDlbl.Location = new System.Drawing.Point(20, 25);
            this.SchoolFormIDlbl.Name = "SchoolFormIDlbl";
            this.SchoolFormIDlbl.Size = new System.Drawing.Size(51, 13);
            this.SchoolFormIDlbl.TabIndex = 0;
            this.SchoolFormIDlbl.Text = "Form ID";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.SchoolfrmsLB);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.NewSchoolGB);
            this.splitContainer1.Size = new System.Drawing.Size(388, 121);
            this.splitContainer1.SplitterDistance = 102;
            this.splitContainer1.TabIndex = 2;
            // 
            // SchoolfrmsLB
            // 
            this.SchoolfrmsLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SchoolfrmsLB.FormattingEnabled = true;
            this.SchoolfrmsLB.Location = new System.Drawing.Point(0, 0);
            this.SchoolfrmsLB.Name = "SchoolfrmsLB";
            this.SchoolfrmsLB.Size = new System.Drawing.Size(102, 121);
            this.SchoolfrmsLB.TabIndex = 0;
            // 
            // frmNewSchoolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 121);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmNewSchoolForm";
            this.Text = "New School Form";
            this.Load += new System.EventHandler(this.frmNewSchoolForm_Load);
            this.NewSchoolGB.ResumeLayout(false);
            this.NewSchoolGB.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox NewSchoolGB;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.TextBox sFormTB;
        private System.Windows.Forms.Button SaveSubjbtn;
        private System.Windows.Forms.TextBox sFormIDTB;
        private System.Windows.Forms.Label SchoolFormlbl;
        private System.Windows.Forms.Label SchoolFormIDlbl;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox SchoolfrmsLB;
    }
}