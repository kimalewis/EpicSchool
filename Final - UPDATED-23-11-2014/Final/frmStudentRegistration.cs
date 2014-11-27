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
using System.Data.SqlClient;
using System.Data.Entity;

namespace Final
{
    
    public partial class frmStudentRegistration : Form
    {
        public const string spattern = @"^[A-Za-z0-9-'\s.]+$";
        public const string epattern = @"^(([\w\.\d\-]+)@(\w\D+))$";
        public const string ppattern = @"\(\d{3}\)(\s)?\d{3}-\d{4}";

        int ID;
        string result;

        SchoolsEntities db = new SchoolsEntities();

        Class cl = new Class();
        Village newVillage;
        //int Classid;
        int sID, pID, spID, suID, LoginID, Scode, uID;
        string dftpass = "password";
        string acctyp;
        List<Class> availClass = new List<Class>();
        List<Class> regisClass = new List<Class>();

        private static int scID;

        public frmStudentRegistration()
        {
            InitializeComponent();
            
        }

        private void frmStudentRegistration_Load(object sender, EventArgs e)
        {
            uID = Convert.ToInt32(this.uIDlbl.Text);
            Loadfrm();            
            addparentbtn.Visible = false;

        }

        public void Loadfrm()
        {
            formCB.DataSource = db.SchoolForms.ToList();
            formCB.DisplayMember = "FormName";
            formCB.ValueMember = "FormID";

            crFormCB.DataSource = db.SchoolForms.ToList();
            crFormCB.DisplayMember = "FormName";
            crFormCB.ValueMember = "FormID";
            crFormCB.SelectedIndex = -1;
            
            sID = db.Students.Max(m => m.StudentID) + 1;
            StudentIDTB.ReadOnly = true;
            StudentIDTB.Text = sID.ToString();

            parentdetailGB.Visible = false;

            relationshipCB.DataSource = db.StudentsParents.Select(x => x.Relationship).Distinct().ToList();
            relationshipCB.DisplayMember = "Relationship";
            relationshipCB.SelectedIndex = -1;

            VillageCB.DataSource = null;
            VillageCB.DataSource = db.Villages.OrderBy(x => x.VillageName).ToList();
            VillageCB.DisplayMember = "VillageName";
            VillageCB.ValueMember = "VillageID";
            VillageCB.SelectedIndex = -1;

            ParishCB.DataSource = db.Parishes.ToList();
            ParishCB.DisplayMember = "ParishName";
            ParishCB.ValueMember = "ParishID";
            ParishCB.SelectedIndex = -1;

            schoolsCB.DataSource = db.Schools.ToList();
            schoolsCB.DisplayMember = "SchoolName";
            schoolsCB.ValueMember = "SchoolCode";
            schoolsCB.SelectedIndex = -1;

            crTermCB.DataSource = db.Terms.ToList();
            crTermCB.DisplayMember = "TermName";
            crTermCB.ValueMember = "TermID";
            crTermCB.SelectedIndex = -1;

            crAcademicPCB.DataSource = db.Classes.Select(x => x.AcademicYear).Distinct().ToList();
            crAcademicPCB.DisplayMember = "AcademicYear";
            crAcademicPCB.SelectedIndex = -1;

            filllistbox();

        }

        private void filllistbox()
        {
            var school = from a in db.AdministrativeStaffs
                         where a.UserID == uID
                         select a.SchoolCode;

            foreach (var s in school)
            {
                uIDlbl.Text = s.ToString();

            }
            Scode = Convert.ToInt32(uIDlbl.Text);

            var student = from s in db.Students
                          where s.SchoolCode == Scode
                          select new
                          {
                              ID = s.StudentID,
                              Name = s.FirstName + " " + s.LastName
                          };
            StudentNameCB.DataSource = student.ToList();
            StudentNameCB.DisplayMember = "Name";
            StudentNameCB.ValueMember = "ID";

            LoadClasses(crAcademicPCB.Text, Convert.ToInt32(crTermCB.SelectedValue),Convert.ToInt32(crFormCB.SelectedValue));
                      
          }

        private void LoadClasses(string yr, int trm, int frm)
        {
            var source = db.Classes.Where(c => (c.SchoolCode==Scode) || (c.SchoolCode==Scode && c.FormID == frm) ).ToList();
            
            source.ForEach(s =>
            {
                availLS.Items.Add(new Class() { CID = s.ClassID, Sub = s.Subject.SubjectName, frm = s.SchoolForm.FormName });
            });

            availLS.DisplayMember = "Display";
            availLS.ValueMember = "CID";

            regLS.DisplayMember = availLS.DisplayMember;
            regLS.ValueMember = availLS.ValueMember;

        }
            

        private void addparentbtn_Click(object sender, EventArgs e)
        {
            addparentbtn.Enabled = false;

            parentdetailGB.Visible = true;
            pID = db.Parents.Max(m => m.ParentID) + 1;
            pidTB.Text = pID.ToString();
            pidTB.ReadOnly = true;

            spID = db.StudentsParents.Max(m => m.StudentParentsID) + 1;
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
                    Username = fn.ToLower() + "." + ln.ToLower(),
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

        private void sSaved()
        {
            StudentIDTB.ReadOnly = true;
            schoolsCB.Enabled = false;
            sfirstnameTB.ReadOnly = true;
            MITB.ReadOnly = true;
            slastnameTB.ReadOnly = false;
            formCB.Enabled = false;
            dobdatepicker.Enabled = false;
            admissiondatetimepicker.Enabled = false;
            gradedatetimepicker.Enabled = false;
            prioreduTB.ReadOnly = true;
            VillageCB.Enabled = false;
            ParishCB.Enabled = false;
            shomepTB.ReadOnly = true;
            semailTB.ReadOnly = true;

            crStudentIDTB.Text = StudentIDTB.Text;
            crFormTB.Text = formCB.SelectedValue.ToString();
            crSchoolTB.Text = schoolsCB.SelectedValue.ToString();
        }

        private void ParentSaved()
        {
            pidTB.Text = (db.Parents.Max(m => m.ParentID) + 1).ToString();
            pfirstnameTB.Clear();
            plastnameTB.Clear();

            pDOBdatepicker.Value = DateTime.Now;
            relationshipCB.SelectedIndex = -1;
            phomeTB.Clear();
            pworkTB.Clear();
            pcellTB.Clear();
            pemailTB.Clear();

            var pquery = from s in db.Students
                         join sp in db.StudentsParents on s.StudentID equals sp.StudentID
                         join p in db.Parents on sp.ParentID equals p.ParentID
                         where s.StudentID == sID
                         select new { FirstName = p.FirstName, LastName = p.LastName, Relationship = sp.Relationship };

            studentparentGV.DataSource = pquery.ToList();
        }

        private void saveParent()
        {
            LoginID = db.Users.Max(m => m.UserID) + 1;
            try
            {
                Parent newParent = new Parent
                {
                    ParentID = Convert.ToInt32(ValidateID(pidTB.Text)),
                    FirstName = ValidateName(pfirstnameTB.Text),
                    MiddleInitial = MITB.Text,
                    LastName = ValidateName(plastnameTB.Text),
                    HomePhone = ValidatePhone(shomepTB.Text),
                    CellPhone = ValidatePhone(pcellTB.Text),
                    WorkPhone = ValidatePhone(pworkTB.Text),
                    DOB = Convert.ToDateTime(pDOBdatepicker.Text),
                    Email = ValidateEmail(pemailTB.Text),
                    UserID = LoginID
                };

                db.Parents.Add(newParent);

                StudentsParent sparent = new StudentsParent
                {

                    StudentParentsID = spID,
                    ParentID = Convert.ToInt32(pidTB.Text),
                    StudentID = Convert.ToInt32(StudentIDTB.Text),
                    Relationship = relationshipCB.Text
                };

                db.StudentsParents.Add(sparent);

                acctyp = "Parent";
                generatepLogin(LoginID, pfirstnameTB.Text, plastnameTB.Text, Convert.ToDateTime(pDOBdatepicker.Text), pemailTB.Text, dftpass, acctyp);

                db.SaveChanges();

                MessageBox.Show("Parent Successfully Added");
                ParentSaved();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR - Cannot be Saved:" + "\n\n\n" + ex);
            }


        }

        private void saveStudent()
        {
            LoginID = db.Users.Max(m => m.UserID) + 1;
            try
            {
                suID = db.Students.Max(m => m.StudentID) + 1;
                acctyp = "Student";

                Student newStudent = new Student
                {
                    StudentID = Convert.ToInt32(ValidateID(StudentIDTB.Text)),
                    FirstName = ValidateName(sfirstnameTB.Text),
                    M_I_ = MITB.Text,
                    LastName = ValidateName(slastnameTB.Text),
                    DOB = Convert.ToDateTime(dobdatepicker.Text),
                    HomePhone = ValidatePhone(shomepTB.Text),
                    AdmissionDate = Convert.ToDateTime(admissiondatetimepicker.Text),
                    ExpectedGraduationDate = Convert.ToDateTime(gradedatetimepicker.Text),
                    FormID = Convert.ToInt32(formCB.SelectedValue),
                    SchoolCode = Convert.ToInt32(schoolsCB.SelectedValue),
                    VillageID = Convert.ToInt32(VillageCB.SelectedValue),
                    ParishID = Convert.ToInt32(ParishCB.SelectedValue),
                    PriorEducation = ValidateName(prioreduTB.Text),
                    Email = ValidateEmail(semailTB.Text),
                    UserID = LoginID

                };
                db.Students.Add(newStudent);

                //new User Login
                generatepLogin(LoginID, sfirstnameTB.Text, slastnameTB.Text, Convert.ToDateTime(dobdatepicker.Text), semailTB.Text, dftpass, acctyp);

                this.db.SaveChanges();

                MessageBox.Show("Student Successfully Registered");
                sSaved();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR - Cannot be Saved:" + "\n\n\n" + ex);
            }
        }

        private void AddStudentBtn_Click(object sender, EventArgs e)
        {
            saveStudent();
            addparentbtn.Visible = true;
           
        }

        private void addprecBtn_Click(object sender, EventArgs e)
        {
            saveParent();
        }

        private void NewVilbtn_Click(object sender, EventArgs e)
        {
            frmNewVillage nVillage = new frmNewVillage();
            nVillage.Show();

        }

        private void newParishbtn_Click(object sender, EventArgs e)
        {
            frmNewParish newPar = new frmNewParish();
            newPar.Show();
        }

        private void ValidData()
        {
            MessageBox.Show("Please enter Valid Data");
        }
        /// <summary>
        /// checks if the ID is a valid ID 
        /// and has no letters
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private int ValidateID(string id)
        {
            bool passid;
            if ((passid = Int32.TryParse(id, out ID)) == true)
            {
                ID = Convert.ToInt32(id);
            }
            else
            {
                ID = Convert.ToInt32(id);
            }

            return ID;


        }
        /// <summary>
        /// checks the name for speical characters
        /// and values
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
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

        /// <summary>
        /// verify if the email has a valid
        /// email structure
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
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
                    semaillbl.ForeColor = System.Drawing.Color.Red;
                    semaillbl.Text = "* Email: ";
                    semailTB.Clear();
                    semailTB.Focus();
                }
            }
            else
            {
                result = input;
            }
            return result;
        }

        /// <summary>
        /// checks the phone input for the 
        /// correct format
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
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

        

        private void rightBtn_Click(object sender, EventArgs e)
        {

        }
        

        

        private void left1Btn_Click(object sender, EventArgs e)
        {
            try
            {
                var items = availLS.SelectedItems;
                foreach (var i in items)
                {
                    regLS.Items.Add(i);
                }

                for (int i = 0; i < items.Count; i++)
                {
                    availLS.Items.Remove(items[i]);
                }
            }
            catch
            {
                MessageBox.Show("{0}", "Please select item");
            }
        }

        private void NewVillagebtn_Click(object sender, EventArgs e)
        {
            Validate(VillageCB.Text);
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {

            LoadClasses(crAcademicPCB.Text, Convert.ToInt32(crTermCB.SelectedValue), Convert.ToInt32(crFormCB.SelectedValue));
        }

        private void saveVillage()
        {
            newVillage = new Village()
            {
                VillageID = db.Villages.Max(v => v.VillageID) + 1,
                VillageName = ValidateName(VillageCB.Text)
            };

            db.Villages.Add(newVillage);
            db.SaveChanges();


        }
        private void Validate(string v)
        {
            var vill = db.Villages.Where(x => x.VillageName==v).Count();

            if (vill == 0)
            {
                try
                {

                    saveVillage();

                    MessageBox.Show("Successfully Added to Villages!");

                    VillageCB.Focus();


                }
                catch (Exception)
                {
                    MessageBox.Show("Village entered - Cannot Be Saved");
                }

            }
        }
        


        private void StudentNameCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void right1Btn_Click(object sender, EventArgs e)
        {
            try
            {
                var items = regLS.SelectedItems;
                foreach (var i in items)
                {
                    availLS.Items.Add(i);
                }

                for (int i = 0; i < items.Count; i++)
                {
                    regLS.Items.Remove(items[i]);
                }
            }
            catch
            {
                MessageBox.Show("{0}", "Please select item");
            }
         }

        private void StudentNameCB_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(StudentNameCB.SelectedValue);
            Studentfill(ID);
        }

        private void Studentfill(int i)
        {
            var data = from s in db.Students
                       where s.StudentID == i
                       select s;

            foreach (var st in data)
            {
                crStudentIDTB.Text = st.StudentID.ToString();
                crFormTB.Text = st.SchoolForm.FormName;
                crSchoolTB.Text = st.School.SchoolName;
            }
        }
        private void SaveClasses()
        {

            try
            {
                foreach (Class item in regLS.Items)
                {
                    var newStudentCl = new StudentClass()
                    {
                        ClassID = item.CID,
                        StudentClassesID = db.StudentClasses.Max(x => x.StudentClassesID) + 1,
                        StudentID = Convert.ToInt32(crStudentIDTB.Text),
                        Grade = null,
                        ApprovedBy = null,
                        SignOffBy = null
                    };
                    db.StudentClasses.Add(newStudentCl);
                    db.SaveChanges();
                   
                }
            }
            catch
            {
                MessageBox.Show("Error - Cannot Add Classes");
            }
            

        }

        private void crSaveBtn_Click(object sender, EventArgs e)
        {
            SaveClasses();
            MessageBox.Show("Classes Successfully added");
        }
          
        
    }
}
