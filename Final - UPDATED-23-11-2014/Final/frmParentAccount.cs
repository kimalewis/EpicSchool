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
    public partial class frmParentAccount : Form
    {
        SchoolsEntities db = new SchoolsEntities();
        int uID, studID;
        

        public frmParentAccount()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmParentAccount_Load(object sender, EventArgs e)
        {
            uID = Convert.ToInt32(uIDlbl.Text);
            LoadParentacc(uID);
            LoadChildren(uID);

        }

        private void LoadChildren(int uID)
        {
            var qchild = from p in db.Parents
                         join sp in db.StudentsParents on p.ParentID equals sp.ParentID
                         join s in db.Students on sp.StudentID equals s.StudentID
                         where p.UserID == uID && p.ParentID == sp.ParentID
                         select new 
                         { 
                             FirstName = s.FirstName, 
                             LastName = s.LastName, 
                             School = s.School.SchoolName, 
                             Userid = s.UserID 
                         };
                         
            ChildGridView.DataSource = qchild.ToList();
        }

        private void LoadParentacc(int uID)
        {

            var qprofile = from p in db.Parents
                           //join sp in db.StudentsParents on p.ParentID equals sp.ParentID
                           //join s in db.Students on sp.StudentID equals s.StudentID
                           where p.UserID == uID 
                           select new 
                           {
                              ID = p.ParentID, 
                              FirstName=p.FirstName,
                              Lastname =p.LastName, 
                              Home = p.HomePhone,
                              Email = p.Email,
                              Cell =  p.CellPhone,
                              Work = p.WorkPhone,
                              
                           };

            foreach (var i in qprofile)
            {
                //loading data into parent account tab
                ParentIDTB.Text = i.ID.ToString();
                firstnameTB.Text = i.FirstName;
                lastnameTB.Text = i.Lastname;
                PHomeTB.Text = i.Home == null ? "N/A" : i.Home.ToString();
                PWorkTB.Text = i.Work == null ? "N/A" : i.Work.ToString();
                PCellTB.Text = i.Cell == null ? "N/A" : i.Cell.ToString();
                PEmailTB.Text = i.Email == null ? "N/A" : i.Email.ToString();
                
            }

        }

        private void ChildGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            studID = Int32.Parse(ChildGridView.Rows[e.RowIndex].Cells["Userid"].Value.ToString());
            //selstud = db.Students.Where(s => s.StudentID == studID).ToList().Single();

            frmStudentAccount studentfrm = new frmStudentAccount();
            studentfrm.uIDlbl.Text = studID.ToString();
            studentfrm.Show();
        }

        private void ChildGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            studID = Int32.Parse(ChildGridView.Rows[e.RowIndex].Cells["Userid"].Value.ToString());
            
            frmStudentAccount studentfrm = new frmStudentAccount();
            studentfrm.uIDlbl.Text = studID.ToString();
            studentfrm.ParentsGB.Visible = false;
            studentfrm.Show();
        }

        private void ChangePasswordBtn_Click(object sender, EventArgs e)
        {
            frmChangePassword changepass = new frmChangePassword();
            changepass.uIDlbl.Text = this.uIDlbl.Text;
            changepass.Show();
        }
    }
}
