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
    public partial class frmUserRegistration : Form
    {
        int uID, newID;
        SchoolsEntities db = new SchoolsEntities();
        List<User> users = new List<User>();
        User newUser;

        public const string epattern = @"^(([\w\.\d\-]+)@(\w\D+))$";
        public const string pattern = @"^\w[a-z,A-Z\'\-\.]+$";
        public const string ppattern = @"^[a-zA-Z]\w{7,12}$";

        string result;
        public frmUserRegistration()
        {
            InitializeComponent();
        }

        private void frmUserRegistration_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void LoadGrid()
        {
            UsersGV.DataSource = null;
            var uquery = from i in db.Users
                         select new
                         {
                             ID = i.UserID,
                             Name = i.FirstName + " " + i.LastName,
                             Account = i.AccessType,
                             Email = i.Email==null ? "N/A": i.Email,
                             Username = i.Username,
                             Password = i.Password
                         };

            UsersGV.DataSource = uquery.ToList();

            AccessTypeCB.DataSource = db.Users.Select(a => a.AccessType).Distinct().ToList();
            AccessTypeCB.DisplayMember = "AccessType";
            AccessTypeCB.SelectedIndex = -1;
        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            enable();   
	    }       
	    
        /// <summary>
        /// enables the textboxes so that 
        /// changes/updates can be applied to a 
        /// user's login information
        /// </summary>
        private void enable ()
        {
            FirstnameTB.ReadOnly = false;
            FirstnameTB.Focus();
            LastnameTB.ReadOnly = false;
            emailTB.ReadOnly = false;
            usernameTB.ReadOnly = false;
            PasswordTB.ReadOnly= false;
            AccessTypeCB.Enabled = true;

        }
        /// <summary>
        /// disable the textboxes so
        /// that no changes cannot be applied
        /// </summary>
        private void disable()
        {
            FirstnameTB.ReadOnly = true;
            LastnameTB.ReadOnly = true;
            emailTB.ReadOnly = true;
            usernameTB.ReadOnly = true;
            PasswordTB.ReadOnly = true;
            AccessTypeCB.Enabled = false;

        }
        
        private void UsersGV_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           uID = Int32.Parse(UsersGV.Rows[e.RowIndex].Cells["ID"].Value.ToString());
           LoadUser();
        }
        /// <summary>
        /// checks the ID to find out if a that user id
        /// exists 
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        private bool checkID(int i,string u)
        {
            bool res = false;
            var findID = db.Users.Where(x=> x.UserID == i && x.Username == u).ToList();
            if (findID.Count() != 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }

        private bool CheckName(string f, string l)
        {
            bool res = false;
            users = db.Users.Where(x => x.FirstName==f && x.LastName==l).ToList();
            if (users.Count() != 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (CheckTB())
            {
                if (checkID(Convert.ToInt32(UseridTB.Text), usernameTB.Text))
                {
                    try
                    {
                        UpdateUser();
                        MessageBox.Show("Changes Successful!");
                        LoadGrid();
                        disable();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Cannot commit changes, Please try again later", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    if (CheckTB())
                    {
                        try
                        {
                            SaveUser();
                            MessageBox.Show("Successful!");
                            LoadGrid();
                            disable();

                        }
                        catch
                        {
                            MessageBox.Show("Cannot Save User, Please try again later", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

          }
        /// <summary>
        /// checks textboxes for null values
        /// </summary>
        /// <returns></returns>
        private bool CheckTB()
        {
            bool result = true;
            if (String.IsNullOrEmpty(FirstnameTB.Text)) { errorMsg.SetError(FirstnameTB, "Firstname is missing."); result = false; FirstnameTB.Focus(); } else { errorMsg.SetError(FirstnameTB, ""); }
            if (String.IsNullOrEmpty(LastnameTB.Text)) { errorMsg.SetError(LastnameTB, "Lastname is missing."); result = false; LastnameTB.Focus(); } else { errorMsg.SetError(LastnameTB, ""); }
            if (String.IsNullOrEmpty(usernameTB.Text)) { errorMsg.SetError(usernameTB, "Username is missing."); result = false; usernameTB.Focus(); } else { errorMsg.SetError(usernameTB, ""); }
            if (String.IsNullOrEmpty(PasswordTB.Text)) { errorMsg.SetError(PasswordTB, " Password is missing."); result = false; PasswordTB.Focus(); } else { errorMsg.SetError(PasswordTB, ""); }
            if (String.IsNullOrEmpty(AccessTypeCB.Text)) { errorMsg.SetError(AccessTypeCB, "Access Type is missing."); result = false; AccessTypeCB.Focus(); } else { errorMsg.SetError(AccessTypeCB, ""); }
            
            return result;
        }
        /// <summary>
        /// loads all the user's information 
        /// within the fields on the form
        /// </summary>
        private void LoadUser()
        {
            users = db.Users.Where(u=> u.UserID == uID).ToList();

            foreach (var u in users)
            {
                UseridTB.Text = u.UserID.ToString();
                FirstnameTB.Text = u.FirstName.ToString();
                LastnameTB.Text = u.LastName.ToString();
                emailTB.Text = u.Email == null ? "N/A" : u.Email.ToString();
                usernameTB.Text = u.Username;
                PasswordTB.Text = u.Password;
                AccessTypeCB.Text = u.AccessType;
            }
        }

        /// <summary>
        /// saves a new user
        /// </summary>
        private void SaveUser()
        {
            newUser = new User
            {
                UserID = Convert.ToInt32(UseridTB.Text),
                FirstName = ValidateName(FirstnameTB.Text),
                LastName = ValidateName(LastnameTB.Text),
                Email = emailTB.Text == null ? null : ValidateEmail(emailTB.Text),
                Username = usernameTB.Text,
                Password = ValidatePassword(PasswordTB.Text),
                AccessType = AccessTypeCB.Text

            };
            db.Users.Add(newUser);
            db.SaveChanges();

        }
        /// <summary>
        /// queries the user to find the user data
        /// being saved to and upadating the data to the necessary
        /// changes
        /// </summary>
        private void UpdateUser()
        {
                users = db.Users.Where(u => u.UserID == uID).ToList();

                foreach (var u in users)
                {
                    u.FirstName = ValidateName(FirstnameTB.Text);
                    u.LastName = ValidateName(LastnameTB.Text);
                    u.Email = ValidateEmail(emailTB.Text);
                    u.Username = usernameTB.Text;
                    u.Password = ValidatePassword(PasswordTB.Text);
                    u.AccessType = AccessTypeCB.Text;
                }
                db.SaveChanges();
         }
        /// <summary>
        /// validates the text for the password to
        /// ensure the password is between 8-12 Characters long 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        /// 
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
                    ValidData();
                    emailTB.SelectAll();
                }
            }
            else
            {
                ValidData();
                emailTB.SelectAll();
            }

            return result;


        }
        /// <summary>
        /// validate that the email is a valid email entered
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string ValidateEmail(string input)
        {
            if (input != null)
            {

                if (Regex.IsMatch(input, epattern))
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
        /// <summary>
        /// ensures the name entered does not contains digits etc.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private string ValidateName(string input)
        {
          if (input != null)
            {

                if (Regex.IsMatch(input, pattern))
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
            MessageBox.Show("Please enter valid data");
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            disable();
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            NewClearTB();
        }
        /// <summary>
        /// clears the fields/textboxes
        /// to enter a new user's information
        /// </summary>
        private void NewClearTB()
        {
            newID = db.Users.Max(m => m.UserID) + 1;
            UseridTB.Text = newID.ToString();
            FirstnameTB.Clear();
            LastnameTB.Clear();
            emailTB.Clear();
            usernameTB.Clear();
            PasswordTB.Clear();
            usernameTB.ReadOnly = true;
            PasswordTB.ReadOnly = true;
            AccessTypeCB.Enabled = true;
            AccessTypeCB.SelectedIndex = -1;
            enable();

        }

        private void emailTB_Enter(object sender, EventArgs e)
        {
            if (CheckName(FirstnameTB.Text, LastnameTB.Text))
            {

                usernameTB.Text = usernameTB.Text = FirstnameTB.Text.ToLower() + "." + LastnameTB.Text.ToLower() + (users.Count()+1);
                PasswordTB.Text = "password";

            }
            else
            {
                usernameTB.Text = FirstnameTB.Text.ToLower() + "." + LastnameTB.Text.ToLower();
                PasswordTB.Text = "password";
            }
        }

        private void FirstnameTB_Enter(object sender, EventArgs e)
        {
            usernameTB.Clear();
        }

    }
}
