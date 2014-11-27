using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Final
{
    public partial class frmNewTeacher : Form
    {
        SchoolsEntities db = new SchoolsEntities();
        int LoginID;
        //ID, tID;

       public const string spattern = @"^[A-Za-z0-9-'\s.]+$";
       public const string epattern = @"^(([\w\.\d\-]+)@(\w\D+))$";
       public const string ppattern = @"\(\d{3}\)(\s)?\d{3}-\d{4}";
       string result;
       string dftpass = "password";
       //string acctyp;
       

        public frmNewTeacher()
        {
            InitializeComponent();
        }

        private void NewSubbtn_Click(object sender, EventArgs e)
        {
            
        }

        
        private void AddStudentBtn_Click(object sender, EventArgs e)
        {
            saveTeacher();
        }
        private void generatepLogin(int ID, string fn, string ln, DateTime dob, string email, string pass, string at)
        {
            try
            {
                User newUser = new User
                {
                    UserID = ID,
                    FirstName = fn,
                    LastName = ln,
                    Username = fn.ToLower() + "." + ln.ToLower() + "." + dob.Day + dob.Month,
                    Password = pass,
                    AccessType = at,
                    Email = email
                };

                db.Users.Add(newUser);
                db.SaveChanges();

                MessageBox.Show("New Login Details:" + "\n\n" + "Username: " + newUser.Username + "\n" + "Password:  " + newUser.Password);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n\n - Cannot generate New Login Details" + ex);
            }
        }
        private void saveTeacher()
        {
            LoginID = db.Users.Max(m => m.UserID) + 1;
                 try
                     {
                         Teacher newTeacher = new Teacher
                         {
                             TeacherID = Convert.ToInt32(tIdTB.Text),
                             FirstName = ValidateName(tFNtb.Text),
                             MiddleInitial = ValidateName(MITB.Text),
                             LastName = ValidateName(tLNtb.Text),
                             DOB = Convert.ToDateTime(dobdatepicker.Text),
                             SchoolCode = Convert.ToInt32(schoolsCB.SelectedValue),
                             VillageID = Convert.ToInt32(VillageCB.SelectedValue),
                             ParishID = Convert.ToInt32(ParishCB.SelectedValue),
                             Homephone = ValidatePhone(homepTB.Text),
                             Email = ValidateEmail (emailTB.Text)
                         };
                         db.Teachers.Add(newTeacher);

                         generatepLogin(LoginID, tFNtb.Text, tLNtb.Text, Convert.ToDateTime(dobdatepicker.Text), emailTB.Text, dftpass, "Teacher");

                         this.db.SaveChanges();

                         MessageBox.Show("Student Successfully Registered");

                         tSaved();

                 }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR - Cannot be Saved:" + "\n\n\n" + ex);
                    }

        }

        private void tSaved()
        {
            tIdTB.Text = (db.Teachers.Max(x => x.TeacherID) + 1).ToString();
            tFNtb.Clear();
            MITB.Clear();
            tLNtb.Clear();
            dobdatepicker.Value = DateTime.Now;
            schoolsCB.SelectedIndex = -1;
            VillageCB.SelectedIndex = -1;
            ParishCB.SelectedValue = -1;
            homepTB.Clear();
            emailTB.Clear();
            
        }

        public string ValidateName(string input)
        {

            if (input != "")
            {

                if (Regex.IsMatch(input, spattern) == true)
                {
                    result = input;
                }
                else
                {
                    ValidData();
                }
            }
            else
            {
                ValidData();
                
            }
            return result;
        }

        private void ValidData()
        {
            MessageBox.Show("Please enter Valid Data");
        }

        public string ValidateEmail(string input)
        {
            if (input != "")
            {

                if (Regex.IsMatch(input, epattern) == true)
                {
                    result = input;
                }
                else
                {
                    ValidData();

                    emailTB.ForeColor = System.Drawing.Color.Red;
                    emailTB.Text = "* Email: ";
                    emailTB.Clear();
                    emailTB.Focus();
                }
            }
            else
            {
                result = input;
            }
            return result;
        }


        public string ValidatePhone(string input)
        {
            if (input != "(   )    -")
            {
                if (Regex.IsMatch(input, ppattern) == true)
                {
                    result = input;
                }
                else
                {
                    ValidData();
                }
            }
            else
            {
                result = null;

            }
            return result;
        }

    }
}
