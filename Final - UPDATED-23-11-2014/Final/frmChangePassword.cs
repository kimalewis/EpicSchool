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
    public partial class frmChangePassword : Form
    {
        SchoolsEntities db = new SchoolsEntities();
        Alerts alert = new Alerts();
        public const string ppattern = @"^[a-zA-Z]\w{7,12}$";

        int uID = 2021;
        string result;

        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (CheckTB())
            {
                ValidateNSave(uID, oldPasswordTB.Text, NewPasswordTB.Text, ConfirmPassTB.Text);
            }
        }

        private void PasswordError()
        {
            MessageBox.Show("Passwords does not match. \n  Please enter a Valid Password of 8-12 characters.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
            NewPasswordTB.SelectAll();
            NewPasswordTB.Focus();
            ConfirmPassTB.Clear();
        }


        private string ValidatePassword(string input)
        {
            if (input != null)
            {
                if (Regex.IsMatch(input, ppattern) == true)
                {
                    result = input;
                }
                else
                {
                    PasswordError();
                }
            }
            else
            {
                PasswordError();
            }

            return result;


        }

        private bool CheckTB()
        {
            bool result = true;
            if (String.IsNullOrEmpty(oldPasswordTB.Text)) { errorMsg.SetError(oldPasswordTB, "Old Password is missing."); result = false; oldPasswordTB.Focus(); } else { errorMsg.SetError(oldPasswordTB, ""); }
            if (String.IsNullOrEmpty(NewPasswordTB.Text)) { errorMsg.SetError(NewPasswordTB, "New Password is missing."); result = false; NewPasswordTB.Focus(); } else { errorMsg.SetError(NewPasswordTB, ""); }
            if (String.IsNullOrEmpty(ConfirmPassTB.Text)) { errorMsg.SetError(ConfirmPassTB, "Confirm Password is missing."); result = false; ConfirmPassTB.Focus(); } else { errorMsg.SetError(ConfirmPassTB, ""); }

            return result;
        }

        private bool compPassword()
        {
            bool result = false;
            if (string.Compare(ValidatePassword(NewPasswordTB.Text.Trim()), ConfirmPassTB.Text.Trim()) == 0)
            { result = true; }
            return result;
        }

        private bool CheckUser()
        {
            bool result = false;
            var user = db.Users.Where(u => u.UserID == uID).ToList();
            if (user.Count > 0)
            {
                result = true;
            }

            return result;
        }
        /// <summary>
        /// calls the method to change the password for a user from the alerts class
        /// </summary>
        /// <param name="i"></param>
        /// <param name="o"></param>
        /// <param name="n"></param>
        private void ChangePassword(int i, string o, string n)
        {
            alert.passChange(i, o, n);
        }
        private void ValidateNSave(int i, string o, string n, string c)
        {
            if (compPassword())
            {
                if (CheckUser())
                {
                    try
                    {
                        ChangePassword(i, o, n);
                        MessageBox.Show("Password Changed!");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("System Error - Cannot Commit Changes \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Old Password does not match.  Please try again.", "Old Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    oldPasswordTB.Focus();
                }
            }
        }

        /// <summary>
        /// adds the userid to a the variable when the form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            uID = Convert.ToInt32(this.uIDlbl.Text);
        }

        private void viewpassCkBx_CheckStateChanged(object sender, EventArgs e)
        {
            if (viewpassCkBx.Checked == true )
            {
                oldPasswordTB.PasswordChar = '\0';
                NewPasswordTB.PasswordChar = '\0';
                ConfirmPassTB.PasswordChar = '\0'; 

            }

            if (viewpassCkBx.Checked == false)
            {
                oldPasswordTB.PasswordChar = '*';
                NewPasswordTB.PasswordChar = '*';
                ConfirmPassTB.PasswordChar = '*';

            }
        }
    }
}
    