namespace Final
{
    partial class frmStudentAssessments
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
            this.studassGV = new System.Windows.Forms.DataGridView();
            this.uIDlbl = new System.Windows.Forms.Label();
            this.subID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studassGV)).BeginInit();
            this.SuspendLayout();
            // 
            // studassGV
            // 
            this.studassGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studassGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.studassGV.BackgroundColor = System.Drawing.Color.White;
            this.studassGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studassGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studassGV.GridColor = System.Drawing.Color.Maroon;
            this.studassGV.Location = new System.Drawing.Point(0, 0);
            this.studassGV.Name = "studassGV";
            this.studassGV.Size = new System.Drawing.Size(546, 148);
            this.studassGV.TabIndex = 1;
            this.studassGV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.studassGV_CellFormatting);
            // 
            // uIDlbl
            // 
            this.uIDlbl.AutoSize = true;
            this.uIDlbl.Location = new System.Drawing.Point(528, 0);
            this.uIDlbl.Name = "uIDlbl";
            this.uIDlbl.Size = new System.Drawing.Size(18, 13);
            this.uIDlbl.TabIndex = 42;
            this.uIDlbl.Text = "ID";
            this.uIDlbl.Visible = false;
            // 
            // subID
            // 
            this.subID.AutoSize = true;
            this.subID.Location = new System.Drawing.Point(528, 13);
            this.subID.Name = "subID";
            this.subID.Size = new System.Drawing.Size(24, 13);
            this.subID.TabIndex = 43;
            this.subID.Text = "sub";
            this.subID.Visible = false;
            // 
            // frmStudentAssessments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 148);
            this.Controls.Add(this.subID);
            this.Controls.Add(this.uIDlbl);
            this.Controls.Add(this.studassGV);
            this.Name = "frmStudentAssessments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmStudentAssessments";
            this.Load += new System.EventHandler(this.frmStudentAssessments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studassGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView studassGV;
        public System.Windows.Forms.Label uIDlbl;
        public System.Windows.Forms.Label subID;

    }
}