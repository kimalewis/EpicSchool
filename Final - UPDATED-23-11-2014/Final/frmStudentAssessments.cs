using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class frmStudentAssessments : Form
    {
        
        SchoolsEntities db = new SchoolsEntities();
        public int id, ccode, count;

        public frmStudentAssessments()
        {
            InitializeComponent();
        }

        private void frmStudentAssessments_Load(object sender, EventArgs e)
        {
            
            id = Convert.ToInt32(uIDlbl.Text);
            ccode = Convert.ToInt32(subID.Text);
            loadassessments();
            
        }

        public void loadassessments()
        {

            var classAssign = from a in db.Assessments
                              where a.StudentClass.StudentID == id && a.StudentClass.ClassID == ccode
                              select new
                              {
                                  AssessmentDate = a.Date,
                                  Score = a.Score 
                              };
            count = classAssign.Count();
            this.studassGV.DataSource = classAssign.OrderByDescending(x => x.AssessmentDate).ToList();
                                
            
            if (count == 0)
            {
                MessageBox.Show("No assessments recorded");
                this.Close();
            }
            else
            {
                this.studassGV.DataSource = classAssign.OrderByDescending(x => x.AssessmentDate).ToList();
                //this.Show();
            }
            
        }

        public void studassGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //checking the columns in the grid for the score column
            if (this.studassGV.Columns[e.ColumnIndex].Name == "Score")
            {
                //ads the object value to a variable to compare
                decimal score = (decimal)e.Value;

                //check the contents in the cells.
                if (score == 0.00m || score < 50m)
                {
                    //e.CellStyle.ForeColor = Color.Blue;
                    studassGV.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                    studassGV.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
                }

            }
        }
    }
}
