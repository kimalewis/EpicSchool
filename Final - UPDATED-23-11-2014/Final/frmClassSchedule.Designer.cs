namespace Final
{
    partial class frmClassSchedule
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
            this.ClassScheduleGV = new System.Windows.Forms.DataGridView();
            this.uIDlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ClassScheduleGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ClassScheduleGV
            // 
            this.ClassScheduleGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClassScheduleGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.ClassScheduleGV.BackgroundColor = System.Drawing.Color.White;
            this.ClassScheduleGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClassScheduleGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClassScheduleGV.GridColor = System.Drawing.Color.DarkRed;
            this.ClassScheduleGV.Location = new System.Drawing.Point(0, 0);
            this.ClassScheduleGV.Name = "ClassScheduleGV";
            this.ClassScheduleGV.Size = new System.Drawing.Size(284, 79);
            this.ClassScheduleGV.TabIndex = 2;
            // 
            // uIDlbl
            // 
            this.uIDlbl.AutoSize = true;
            this.uIDlbl.Location = new System.Drawing.Point(266, 0);
            this.uIDlbl.Name = "uIDlbl";
            this.uIDlbl.Size = new System.Drawing.Size(18, 13);
            this.uIDlbl.TabIndex = 44;
            this.uIDlbl.Text = "ID";
            this.uIDlbl.Visible = false;
            // 
            // frmClassSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 79);
            this.Controls.Add(this.uIDlbl);
            this.Controls.Add(this.ClassScheduleGV);
            this.Name = "frmClassSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ClassSchedule";
            this.Load += new System.EventHandler(this.frmClassSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClassScheduleGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView ClassScheduleGV;
        public System.Windows.Forms.Label uIDlbl;
    }
}