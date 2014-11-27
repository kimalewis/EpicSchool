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
    public partial class frmAdministrator : Form
    {
        SchoolsEntities db = new SchoolsEntities();

        public frmAdministrator()
        {
            InitializeComponent();
        }

        private void frmAdministrator_Load(object sender, EventArgs e)
        {
            loadCB();
        }

        /// <summary>
        /// binds combo boxes according to which tab is selected on the form
        /// </summary>
        private void loadCB()
        {
            if (AllUsersTabs.SelectedTab == AllUsersTabs.TabPages["TeacherTab"])
            {
                BindTeachers();
            }

            if (AllUsersTabs.SelectedTab == AllUsersTabs.TabPages["StudentTab"])
            {
                BindStudents();

            }

            if (AllUsersTabs.SelectedTab == AllUsersTabs.TabPages["SubjectsClassesTab"])
            {
                BindClasses();
            }

            if (AllUsersTabs.SelectedTab == AllUsersTabs.TabPages["LoginAccountTab"])
            {
                BindUsers();
            }
            if (AllUsersTabs.SelectedTab == AllUsersTabs.TabPages["SchoolTab"])
            {
                BindSchool();
            } 

        }

        private void BindSchool()
        {
            ParishCB.DataSource = db.Parishes.ToList();
            ParishCB.DisplayMember = "ParishID";
            ParishCB.ValueMember = "ParishName";
            ParishCB.SelectedIndex = -1;

            SchoolsGV.DataSource = null;
            SchoolsGV.DataSource = db.Schools.ToList();
                
               


        }

        /// <summary>
        /// calling the method to sort the grid 
        /// by displaying all students based on the school
        /// selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SortBtn_Click(object sender, EventArgs e)
        {
            SortByTeacher(Convert.ToInt32(TSchoolsCB.SelectedValue));
        }
        
        
        /// <summary>
        /// method that conducts the filtering of the 
        /// gridview based on the selection of the school combo box
        /// for Teachers
        /// </summary>
        /// <param name="sCode"></param>
        private void SortByTeacher(int sCode)
        {
            TeacherGV.DataSource = null;
            TeacherGV.DataSource = db.Teachers.Where(t => t.SchoolCode == sCode).Select
                (x=> new {
                    ID = x.TeacherID,
                    Name = x.Prefix + " " + x.FirstName + " " + x.LastName,
                    Address = x.Village.VillageName + "," + x.Parish.ParishName,
                    HomePhone = x.Homephone == null ? "N/A" : x.Homephone,
                    CellPhone = x.Cellphone == null ? "N/A" : x.Cellphone,
                    Email = x.Email == null ? "N/A" : x.Email,
                    LoginID = x.User.UserID
                }).ToList();

            if (TeacherGV.RowCount == 0)
            {
                MessageBox.Show("No Teacher's Data Recorded");
            }

        }

        private void SortByLogin(string uType)
        {
            UserLoginGV.DataSource = null;
            
            UserLoginGV.DataSource = db.Users.Where(i=> i.AccessType == uType).Select
                (x => new
                {
                    ID = x.UserID,
                    Name = x.FirstName + " " + x.LastName,
                    Username = x.Username,
                    Password = x.Password,
                    Email = x.Email == null ? "N/A" : x.Email,
                    AccessType = x.AccessType
                }).ToList();

            if (UserLoginGV.RowCount == 0)
            {
                MessageBox.Show("No User Data Recorded");
            }

        }
        
        /// <summary>
        /// method that conducts the filtering of the 
        /// gridview based on the selection of the school combo box
        /// for Students
        /// </summary>
        /// <param name="sCode"></param>
        private void SortByStudent(int sCode)
        {
            StudentsGV.DataSource = null;
            StudentsGV.DataSource = db.Students.Where(t => t.SchoolCode == sCode).Select
                (x => new
                {
                    ID = x.StudentID,
                    Name = x.FirstName + " " + x.LastName,
                    Address = x.Village.VillageName + "," + x.Parish.ParishName,
                    HomePhone = x.HomePhone == null ? "N/A" : x.HomePhone,
                    Email = x.Email == null ? "N/A" : x.Email,
                    LoginID = x.User.UserID
                }).ToList();

            if (StudentsGV.RowCount == 0)
            {
                MessageBox.Show("No Student's Registered");
            }
        }

        private void SortBySubClass(int sCode, int subCode)
        {
            cSubjectClassGV.DataSource = null;

            cSubjectClassGV.DataSource = db.Classes.Where(c =>
                (c.SchoolCode == sCode || c.SubjectCode == subCode) ||
                (c.SchoolCode == sCode && c.SubjectCode == subCode))
                .Select
                (x => new
                {
                    ID = x.ClassID,
                    Teacher = x.Teacher.FirstName + " " + x.Teacher.LastName,
                    Subject = x.Subject.SubjectName,
                    Form = x.SchoolForm.FormName,
                    Term = x.Term.TermName,
                    Year = x.AcademicYear,

                }).ToList();
            
            if (cSubjectClassGV.RowCount == 0 )
            {
                MessageBox.Show("No Classes scheduled for that subject");
            }
            countlbl.Text = cSubjectClassGV.Rows.Count.ToString();

        }

                  
        
        /// <summary>
        /// when this button is clicked,
        /// it rebinds the gridview to its original state without a filter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            BindTeachers();
        }
                
        /// <summary>
        /// binding the Gridview will all Teacher's information
        /// </summary>
        private void BindTeachers()
        {
            TSchoolsCB.DataSource = db.Schools.ToList();
            TSchoolsCB.DisplayMember = "SchoolName";
            TSchoolsCB.ValueMember = "SchoolCode";
            TSchoolsCB.SelectedIndex = -1;

            TeacherGV.DataSource = null;
            TeacherGV.DataSource = db.Teachers.Select
                (x => new
                {
                    ID = x.TeacherID,
                    Name = x.Prefix + " " + x.FirstName + " " + x.LastName,
                    Address = x.Village.VillageName + "," + x.Parish.ParishName,
                    HomePhone = x.Homephone == null ? "N/A" : x.Homephone,
                    CellPhone = x.Cellphone == null ? "N/A" : x.Cellphone,
                    Email = x.Email == null ? "N/A" : x.Email,
                    LoginID = x.User.UserID
                }).ToList();


        }

        /// <summary>
        /// binding the Gridview will all student's information
        /// </summary>
        private void BindStudents()
        {
            sSchoolCB.DataSource = db.Schools.ToList();
            sSchoolCB.DisplayMember = "SchoolName";
            sSchoolCB.ValueMember = "SchoolCode";
            sSchoolCB.SelectedIndex = -1;

            StudentsGV.DataSource = null;
            StudentsGV.DataSource = db.Students.Select
                (x => new
                {
                    ID = x.StudentID,
                    Name = x.FirstName + " " + x.LastName,
                    Address = x.Village.VillageName + "," + x.Parish.ParishName,
                    HomePhone = x.HomePhone == null ? "N/A" : x.HomePhone,
                    Email = x.Email == null ? "N/A" : x.Email,
                    LoginID = x.User.UserID
                }).ToList();
        }

        private void BindClasses()
        {
            cSchoolCB.DataSource = db.Schools.ToList();
            cSchoolCB.DisplayMember = "SchoolName";
            cSchoolCB.ValueMember = "SchoolCode";
            cSchoolCB.SelectedIndex = -1;

            cSubjectCB.DataSource = db.Subjects.ToList();
            cSubjectCB.DisplayMember = "SubjectName";
            cSubjectCB.ValueMember = "SubjectCode";
            cSubjectCB.SelectedIndex = -1;

            cSubjectClassGV.DataSource = null;
            
            cSubjectClassGV.DataSource = db.Classes.Select
                (x => new
                {
                    ID = x.ClassID,
                    Teacher = x.Teacher.FirstName + " " + x.Teacher.LastName,
                    Subject = x.Subject.SubjectName,
                    Form = x.SchoolForm.FormName,
                    Term = x.Term.TermName,
                    Year = x.AcademicYear,        
                    
                }).ToList();
            countlbl.Text = cSubjectClassGV.Rows.Count.ToString();

        }

        private void BindUsers()
        {
            lAccessTypeCB.DataSource = db.Users.Select(u => u.AccessType).Distinct().ToList();
            lAccessTypeCB.DisplayMember = "AccessType";
            lAccessTypeCB.SelectedIndex = -1;

            
            UserLoginGV.DataSource = null;
            UserLoginGV.DataSource = db.Users.Select
                (x => new
                {
                    ID = x.UserID,
                    Name = x.FirstName + " " + x.LastName,
                    Username = x.Username,
                    Password = x.Password,
                    Email = x.Email == null ? "N/A" : x.Email,
                    AccessType = x.AccessType
                }).ToList();
        }
        
        /// <summary>
        /// event that occurs when the user click on the
        /// contents on the cell. In this instance, when the admin. 
        /// clicks on the cell for a teacher, it shows the teacher's account
        /// form and all its related forms.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TeacherGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmTeacherAccount teacher = new frmTeacherAccount();
            teacher.uIDlbl.Text = (Int32.Parse(TeacherGV.Rows[e.RowIndex].Cells["LoginID"].Value.ToString())).ToString();

            teacher.Show();
        }
        
        /// <summary>
        /// calling the method to sort the grid 
        /// by displaying all students based on the school
        /// selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sSortBtn_Click(object sender, EventArgs e)
        {
            SortByStudent(Convert.ToInt32(sSchoolCB.SelectedValue));
        }
        
        /// <summary>
        /// when this "Click" event occurs or each tab is clicked on the form
        /// the load method is called to fill the combo boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AllUsersTabs_Click(object sender, EventArgs e)
        {
            loadCB();
        }

        private void sResetBtn_Click(object sender, EventArgs e)
        {
            BindStudents();
        }

        private void cResetBtn_Click(object sender, EventArgs e)
        {
            BindClasses();
        }

        private void cSortBtn_Click(object sender, EventArgs e)
        {
            if (cSchoolCB.SelectedIndex != -1 && cSubjectCB.SelectedIndex == -1)
            {
                SortBySubClass(Convert.ToInt32(cSchoolCB.SelectedValue), Convert.ToInt32(cSubjectCB.SelectedValue));
            }

            if (cSchoolCB.SelectedIndex != -1 && cSubjectCB.SelectedIndex != -1)
            {
                SortBySubClass(Convert.ToInt32(cSchoolCB.SelectedValue), Convert.ToInt32(cSubjectCB.SelectedValue));
            }

            if (cSchoolCB.SelectedIndex == -1 && cSubjectCB.SelectedIndex != -1)
            {
                SortBySubClass(Convert.ToInt32(cSchoolCB.SelectedValue), Convert.ToInt32(cSubjectCB.SelectedValue));
            }
        }

        private void cSubjectClassGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmClassSchedule schedule = new frmClassSchedule();
            schedule.uIDlbl.Text = (Int32.Parse(cSubjectClassGV.Rows[e.RowIndex].Cells["ID"].Value.ToString())).ToString();

            schedule.Show();
        }

        private void StudentsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmStudentAccount student = new frmStudentAccount();
            student.uIDlbl.Text = (Int32.Parse(StudentsGV.Rows[e.RowIndex].Cells["LoginID"].Value.ToString())).ToString();
            student.Show();

        }

        private void lSortBtn_Click(object sender, EventArgs e)
        {
            SortByLogin(lAccessTypeCB.Text);
        }

        private void UserLoginGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmUserRegistration user = new frmUserRegistration();
            user.uIDlbl.Text = (Int32.Parse(UserLoginGV.Rows[e.RowIndex].Cells["ID"].Value.ToString())).ToString();
            user.ControlsGB.Visible = true;
            user.Show();
        }

        private void SchoolsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmSchools school = new frmSchools();
            school.uIDlbl.Text = (Int32.Parse(UserLoginGV.Rows[e.RowIndex].Cells["ID"].Value.ToString())).ToString();
            school.Show();
        }

        private void skSortBtn_Click(object sender, EventArgs e)
        {
            SortBySchool(Convert.ToInt32(ParishCB.SelectedValue));
        }

        private void SortBySchool(int pID)
        {
            SchoolsGV.DataSource = null;

            SchoolsGV.DataSource = db.Schools.Where(p => p.ParishID == pID).ToList();

            if (SchoolsGV.RowCount == 0)
            {
                MessageBox.Show("No Schools Recorded for that Parish");
            }
        }

        private void tPrintBtn_Click(object sender, EventArgs e)
        {
            PrintReport.Print_DataGridView(TeacherGV);
        }

        private void sPrintBtn_Click(object sender, EventArgs e)
        {
            PrintReport.Print_DataGridView(StudentsGV);
        }

        private void scPrintBtn_Click(object sender, EventArgs e)
        {
            PrintReport.Print_DataGridView(cSubjectClassGV);
            
        }

        private void lgPrintBtn_Click(object sender, EventArgs e)
        {
            PrintReport.Print_DataGridView(UserLoginGV);
            
        }
    }
}
