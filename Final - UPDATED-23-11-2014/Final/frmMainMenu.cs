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
    public partial class frmMainMenu : Form
    {
        SchoolsEntities db = new SchoolsEntities();
        
        public frmMainMenu()
        {
            InitializeComponent();
        }
        /// <summary>
        /// when a user clicks on the items of the menu item
        /// it calls the form and passes their User ID
        /// from the main menu to the other form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region
        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentAccount studentfrm = new frmStudentAccount();
            studentfrm.uIDlbl.Text = this.uIDlbl.Text;
            studentfrm.StudentScheduleTab.SelectedIndex = 0;
            studentfrm.Show();
            
        }

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentAccount studentfrm = new frmStudentAccount();
            studentfrm.uIDlbl.Text = this.uIDlbl.Text;
            studentfrm.StudentScheduleTab.SelectedIndex=1;
            studentfrm.Show();
        }

        private void gradeBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentAccount studentfrm = new frmStudentAccount();
            studentfrm.uIDlbl.Text = this.uIDlbl.Text;
            studentfrm.StudentScheduleTab.SelectedIndex = 2;
            studentfrm.Show();

        }

        private void accountToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmTeacherAccount teacherfrm = new frmTeacherAccount();
            teacherfrm.uIDlbl.Text = this.uIDlbl.Text;
            teacherfrm.Show();            
        }

        private void accountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmParentAccount parentfrm = new frmParentAccount();
            parentfrm.uIDlbl.Text = this.uIDlbl.Text;
            parentfrm.Show();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentRegistration newStudent = new frmStudentRegistration();
            newStudent.uIDlbl.Text = this.uIDlbl.Text;
            newStudent.RegistrationTabs.SelectedIndex = 0;
            newStudent.Show();

        }

        private void registerUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserRegistration newUser = new frmUserRegistration();
            newUser.uIDlbl.Text = this.uIDlbl.Text;
            newUser.Show();
        }

        private void newClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClassScheduling newClass = new frmClassScheduling();
            newClass.Show();
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserRegistration users = new frmUserRegistration();
            users.ControlsGB.Visible = true;
            users.Show();
        }

        private void manageSchoolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSchools schools = new frmSchools();
            schools.ControlsGB.Visible = true;
            schools.Show();
        }

        private void viewsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewTeacher newTeach = new frmNewTeacher();
            newTeach.Show();
        }

        private void teachersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdministrator teachers = new frmAdministrator();
            teachers.AllUsersTabs.SelectedIndex = 0;
            teachers.Show();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdministrator stud = new frmAdministrator();
            stud.AllUsersTabs.SelectedIndex = 1;
            stud.Show();
        }

        private void subjectsClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdministrator classes = new frmAdministrator();
            classes.AllUsersTabs.SelectedIndex = 2;
            classes.Show();
        }

        private void accountToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //frmPrincipalAccount prin = new frmPrincipalAccount();
            //prin.Show();
        }

        private void classesTaughtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeacherAccount teacherfrm = new frmTeacherAccount();
            teacherfrm.uIDlbl.Text = this.uIDlbl.Text;
            teacherfrm.TeacherTabs.SelectedIndex = 1;
            teacherfrm.Show();
        }

        private void ApprovalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeacherAccount teacherfrm = new frmTeacherAccount();
            teacherfrm.uIDlbl.Text = this.uIDlbl.Text;
            teacherfrm.TeacherTabs.SelectedIndex = 3;
            teacherfrm.Show();
        }

        private void studentListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTeacherAccount teacherfrm = new frmTeacherAccount();
            teacherfrm.uIDlbl.Text = this.uIDlbl.Text;
            teacherfrm.TeacherTabs.SelectedIndex = 2;
            teacherfrm.Show();
        }

        private void gradingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeacherAccount teacherfrm = new frmTeacherAccount();
            teacherfrm.uIDlbl.Text = this.uIDlbl.Text;
            teacherfrm.TeacherTabs.SelectedIndex = 4;
            teacherfrm.Show();
        }

        private void villageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewVillage newV = new frmNewVillage();
            newV.Show();
        }

        private void parishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewParish newP = new frmNewParish();
            newP.Show();
        }

        private void subjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewSubject newSub = new frmNewSubject();
            newSub.Show();

        }

        private void formsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewSchoolForm newForm = new frmNewSchoolForm();
            newForm.Show();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            MainMenuContextStrip.ForeColor = System.Drawing.Color.DarkRed;

        }
#endregion
    }
}