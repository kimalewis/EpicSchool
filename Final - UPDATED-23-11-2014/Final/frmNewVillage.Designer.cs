namespace Final
{
    partial class frmNewVillage
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
            this.villageLB = new System.Windows.Forms.ListBox();
            this.NewVillageGB = new System.Windows.Forms.GroupBox();
            this.NewBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.VillageTB = new System.Windows.Forms.TextBox();
            this.SaveSubjbtn = new System.Windows.Forms.Button();
            this.vidTB = new System.Windows.Forms.TextBox();
            this.Villagelbl = new System.Windows.Forms.Label();
            this.VillageIDlbl = new System.Windows.Forms.Label();
            this.errorMsg = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.NewVillageGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorMsg)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.villageLB);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.NewVillageGB);
            this.splitContainer1.Size = new System.Drawing.Size(468, 148);
            this.splitContainer1.SplitterDistance = 138;
            this.splitContainer1.TabIndex = 0;
            // 
            // villageLB
            // 
            this.villageLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.villageLB.FormattingEnabled = true;
            this.villageLB.Location = new System.Drawing.Point(0, 0);
            this.villageLB.Name = "villageLB";
            this.villageLB.Size = new System.Drawing.Size(138, 148);
            this.villageLB.TabIndex = 0;
            this.villageLB.SelectedIndexChanged += new System.EventHandler(this.villageLB_SelectedIndexChanged);
            // 
            // NewVillageGB
            // 
            this.NewVillageGB.BackColor = System.Drawing.Color.Transparent;
            this.NewVillageGB.BackgroundImage = global::Final.Properties.Resources.chalkboard_apple_624x300;
            this.NewVillageGB.Controls.Add(this.NewBtn);
            this.NewVillageGB.Controls.Add(this.EditBtn);
            this.NewVillageGB.Controls.Add(this.Cancelbtn);
            this.NewVillageGB.Controls.Add(this.VillageTB);
            this.NewVillageGB.Controls.Add(this.SaveSubjbtn);
            this.NewVillageGB.Controls.Add(this.vidTB);
            this.NewVillageGB.Controls.Add(this.Villagelbl);
            this.NewVillageGB.Controls.Add(this.VillageIDlbl);
            this.NewVillageGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewVillageGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewVillageGB.ForeColor = System.Drawing.Color.White;
            this.NewVillageGB.Location = new System.Drawing.Point(0, 0);
            this.NewVillageGB.Name = "NewVillageGB";
            this.NewVillageGB.Size = new System.Drawing.Size(326, 148);
            this.NewVillageGB.TabIndex = 3;
            this.NewVillageGB.TabStop = false;
            this.NewVillageGB.Text = "New Village";
            // 
            // NewBtn
            // 
            this.NewBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.NewBtn.Location = new System.Drawing.Point(24, 86);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(65, 30);
            this.NewBtn.TabIndex = 14;
            this.NewBtn.Text = "New";
            this.NewBtn.UseVisualStyleBackColor = true;
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.EditBtn.Location = new System.Drawing.Point(166, 86);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(65, 30);
            this.EditBtn.TabIndex = 13;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.ForeColor = System.Drawing.Color.DarkRed;
            this.Cancelbtn.Location = new System.Drawing.Point(237, 86);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(65, 30);
            this.Cancelbtn.TabIndex = 12;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // VillageTB
            // 
            this.VillageTB.Location = new System.Drawing.Point(83, 48);
            this.VillageTB.MaxLength = 50;
            this.VillageTB.Name = "VillageTB";
            this.VillageTB.Size = new System.Drawing.Size(195, 20);
            this.VillageTB.TabIndex = 11;
            // 
            // SaveSubjbtn
            // 
            this.SaveSubjbtn.ForeColor = System.Drawing.Color.DarkRed;
            this.SaveSubjbtn.Location = new System.Drawing.Point(95, 86);
            this.SaveSubjbtn.Name = "SaveSubjbtn";
            this.SaveSubjbtn.Size = new System.Drawing.Size(65, 30);
            this.SaveSubjbtn.TabIndex = 10;
            this.SaveSubjbtn.Text = "Save";
            this.SaveSubjbtn.UseVisualStyleBackColor = true;
            this.SaveSubjbtn.Click += new System.EventHandler(this.SaveSubjbtn_Click);
            // 
            // vidTB
            // 
            this.vidTB.Location = new System.Drawing.Point(83, 22);
            this.vidTB.Name = "vidTB";
            this.vidTB.ReadOnly = true;
            this.vidTB.Size = new System.Drawing.Size(100, 20);
            this.vidTB.TabIndex = 3;
            // 
            // Villagelbl
            // 
            this.Villagelbl.AutoSize = true;
            this.Villagelbl.Location = new System.Drawing.Point(34, 51);
            this.Villagelbl.Name = "Villagelbl";
            this.Villagelbl.Size = new System.Drawing.Size(45, 13);
            this.Villagelbl.TabIndex = 1;
            this.Villagelbl.Text = "Village";
            // 
            // VillageIDlbl
            // 
            this.VillageIDlbl.AutoSize = true;
            this.VillageIDlbl.Location = new System.Drawing.Point(20, 25);
            this.VillageIDlbl.Name = "VillageIDlbl";
            this.VillageIDlbl.Size = new System.Drawing.Size(62, 13);
            this.VillageIDlbl.TabIndex = 0;
            this.VillageIDlbl.Text = "Village ID";
            // 
            // errorMsg
            // 
            this.errorMsg.ContainerControl = this;
            // 
            // frmNewVillage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 148);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmNewVillage";
            this.Text = "Village";
            this.Load += new System.EventHandler(this.frmNewVillage_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.NewVillageGB.ResumeLayout(false);
            this.NewVillageGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorMsg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox NewVillageGB;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.TextBox VillageTB;
        private System.Windows.Forms.Button SaveSubjbtn;
        private System.Windows.Forms.TextBox vidTB;
        private System.Windows.Forms.Label Villagelbl;
        private System.Windows.Forms.Label VillageIDlbl;
        private System.Windows.Forms.ListBox villageLB;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button NewBtn;
        private System.Windows.Forms.ErrorProvider errorMsg;
    }
}