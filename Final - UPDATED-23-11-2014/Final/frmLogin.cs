using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Final
{
    public partial class frmLogin : Form
    {
        SchoolsEntities db = new SchoolsEntities();
        User user = new User();
        int UID;

        public frmLogin()
        {
            InitializeComponent();
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            fillcombobox();
        }
        /// <summary>
        /// fills combo boxes with data from DB
        /// </summary>
        private void fillcombobox()
        {
            accesstypeCB.DataSource = db.Users.Select(x => x.AccessType).Distinct().ToList();
            accesstypeCB.DisplayMember = "AccessType";
            accesstypeCB.SelectedIndex = -1;
        }

        /// <summary>
        /// clears the boxes on the screen
        /// </summary>
        private void reset()
        {
            usernameTB.Clear();
            passwordTB.Clear();
            usernameTB.Focus();
            accesstypeCB.SelectedIndex = -1;            

        }

        /// <summary>
        /// exposes the appropriate menus based on the user's
        /// access type
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="accesstype"></param>
        private void UserAccesss(string username, string password, string accesstype)
        {
            var query = from u in db.Users
                        where u.Username == username && u.Password == password && u.AccessType == accesstype
                        select new { uName = u.FirstName + " " + u.LastName, uType = accesstype, uID = u.UserID };

            foreach (var u in query)
            {
                user.uId = u.uID;
                user.uName = u.uName;
                user.uType = u.uType;
            }

            frmMainMenu MainMenu = new frmMainMenu();
            MainMenu.Show();
            this.Hide();

            if (query != null && user.uType == "Student")
            {

                
                MainMenu.uNamelbl.Text = user.uName;
                MainMenu.uTypelbl.Text = user.uType;
                MainMenu.uIDlbl.Text = user.uId.ToString();
                MainMenu.parentToolStripMenuItem.Enabled = false;
                MainMenu.teacherToolStripMenuItem.Enabled = false;
                MainMenu.administrativeStaffToolStripMenuItem.Enabled = false;
                MainMenu.administratorToolStripMenuItem.Enabled = false;
            }

            if (query != null && user.uType == "Parent")
            {

                MainMenu.uNamelbl.Text = user.uName;
                MainMenu.uTypelbl.Text = user.uType;
                MainMenu.uIDlbl.Text = user.uId.ToString();
                MainMenu.studentToolStripMenuItem.Enabled = false;
                MainMenu.teacherToolStripMenuItem.Enabled = false;
                MainMenu.administrativeStaffToolStripMenuItem.Enabled = false;
                MainMenu.administratorToolStripMenuItem.Enabled = false;
            }

            if (query != null && user.uType == "Principal")
            {

                MainMenu.uNamelbl.Text = user.uName;
                MainMenu.uTypelbl.Text = user.uType;
                MainMenu.uIDlbl.Text = user.uId.ToString();
                MainMenu.parentToolStripMenuItem.Enabled = false;
                MainMenu.studentToolStripMenuItem.Enabled = false;
                MainMenu.teacherToolStripMenuItem.Enabled = false;
                MainMenu.administrativeStaffToolStripMenuItem.Enabled = false;
                MainMenu.administratorToolStripMenuItem.Enabled = false;
            }

            if (query != null && user.uType == "Teacher")
            {

                MainMenu.uNamelbl.Text = user.uName;
                MainMenu.uTypelbl.Text = user.uType;
                MainMenu.uIDlbl.Text = user.uId.ToString();
                MainMenu.parentToolStripMenuItem.Enabled = false;
                MainMenu.studentToolStripMenuItem.Enabled = false;
                MainMenu.administrativeStaffToolStripMenuItem.Enabled = false;
                MainMenu.administratorToolStripMenuItem.Enabled = false;
            }

            if (query != null && user.uType == "Administrative Staff")
            {

                MainMenu.uNamelbl.Text = user.uName;
                MainMenu.uTypelbl.Text = user.uType;
                MainMenu.uIDlbl.Text = user.uId.ToString();
                MainMenu.parentToolStripMenuItem.Enabled = false;
                MainMenu.teacherToolStripMenuItem.Enabled = false;
                MainMenu.studentToolStripMenuItem.Enabled = false;
                MainMenu.administratorToolStripMenuItem.Enabled = false;
            }

            if (query != null && user.uType == "Administrator")
            {

                MainMenu.uNamelbl.Text = user.uName;
                MainMenu.uTypelbl.Text = user.uType;
                MainMenu.uIDlbl.Text = user.uId.ToString();
                MainMenu.parentToolStripMenuItem.Enabled = false;
                MainMenu.teacherToolStripMenuItem.Enabled = false;
                MainMenu.studentToolStripMenuItem.Enabled = false;
                MainMenu.administratorToolStripMenuItem.Enabled = true;
                MainMenu.administrativeStaffToolStripMenuItem.Enabled = false;
            }
        }
        /// <summary>
        /// checks to see if a user exists in the database
        /// </summary>
        /// <param name="u"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        private bool CheckUser(string u, string p)
        {
            bool result = false;
            var user = db.Users.Where(x=> x.Username == u && x.Password == p).Select(x=> x.UserID).ToList();
            
            if (user.Count > 0)
            {
                foreach (var i in user)
                {
                    UID = i;
                }
                result = true;
            }

            return result;
        }

        private void validateLogin(string username, string password, string accesstype)
        {
            if (CheckUser (username, password))
            {
                try
                 {               
                        UserAccesss(username, password, accesstype);
                 }
                catch
                {
                    ErrorLogin();
                }  
            }
            else
            {
                ErrorLogin();
            }
         }

        /// <summary>
        /// standard error message for login errors
        /// </summary>
        private void ErrorLogin()
        {
            MessageBox.Show("Invalid Login Credentials");
            reset();
            fillcombobox();

        }
        /// <summary>
        /// calls the method to check for empty textboxes
        /// and call the method to check if a user with the credentials
        /// exsists and exposes their access accordingly on the main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (CheckTB())
            {
                validateLogin(usernameTB.Text, passwordTB.Text, accesstypeCB.Text);
            }
        }
        /// <summary>
        /// closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// checks for empty checkboxes
        /// </summary>
        /// <returns></returns>
        private bool CheckTB()
        {
            bool result = true;
            if (String.IsNullOrEmpty(usernameTB.Text)) { errorMsg.SetError(usernameTB, "Username is missing."); result = false; usernameTB.Focus(); } else { errorMsg.SetError(usernameTB, ""); }
            if (String.IsNullOrEmpty(passwordTB.Text)) { errorMsg.SetError(passwordTB, "Password is missing."); result = false; passwordTB.Focus(); } else { errorMsg.SetError(passwordTB, ""); }
            if (String.IsNullOrEmpty(accesstypeCB.Text)) { errorMsg.SetError(accesstypeCB, "Access Type is missing."); result = false; accesstypeCB.Focus(); } else { errorMsg.SetError(accesstypeCB, ""); }

            return result;
        }
    }
}
