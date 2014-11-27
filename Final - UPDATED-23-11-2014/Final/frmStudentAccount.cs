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
using System.Data.Entity;
using System.Net;
using System.Net.Mail;

namespace Final
{
    public partial class frmStudentAccount : Form
    {
        
        SchoolsEntities db = new SchoolsEntities();
        int uID, sID, studID, ccode, mth;
        string result, yr, Term;
        

        public frmStudentAccount()
        {
            InitializeComponent();
        }

        private void frmStudentAccount_Load(object sender, EventArgs e)
        {
           Term =  findCurrentTerm(DateTime.Now);
            LoadStudentProfile();
            LoadStudentParents();
            fillcombobox();
            LoadStudentClasses(Convert.ToInt32(TermCB.SelectedValue), AcademicPCB.Text);
            //hidecols();
            LoadGradeBook();

        }

        //private void hidecols()
        //{
        //    studentclassesGV.Columns["ID"].Visible = false;
        //    studentclassesGV.Columns["SubjectCode"].Visible = false;
        //}

        private void LoadStudentProfile()
        {
            uID = Convert.ToInt32(uIDlbl.Text);

            var qprofile = from s in db.Students
                           join sp in db.StudentsParents on s.StudentID equals sp.StudentID
                           join p in db.Parents on sp.ParentID equals p.ParentID
                           where s.UserID == uID
                           select s;

            foreach (var i in qprofile)
            {
                //loading data into student account tab
                studentidTB.Text = i.StudentID.ToString();
                sID = i.StudentID;
                SfirstnameTB.Text = i.FirstName;
                SlastnameTB.Text = i.LastName;
                dobTB.Text = i.DOB.ToShortDateString();
                AdmissionTB.Text = i.AdmissionDate.ToShortDateString();
                expectgradTB.Text = i.ExpectedGraduationDate.ToString();
                SchoolTB.Text = i.School.ToString();
                FormTB.Text = i.SchoolForm.ToString();
                prioreducTB.Text = i.PriorEducation;
                VillageTB.Text = i.Village.ToString();
                ParishTB.Text = i.Parish.ToString();
                HomePHoneTB.Text = i.HomePhone.ToString();
                EmailTB.Text = i.Email;

                //loading data in student classes tab
                SCStudentTB.Text = i.FirstName + " " + i.LastName;
                SCsklTB.Text = i.School.ToString();
                SCFormTB.Text = i.SchoolForm.ToString();

                //load data into GradeBook tab
                GBStudentNameTB.Text = i.FirstName + " " + i.LastName;
                GBSchoolTB.Text = i.School.ToString();
                GBAdmDateTB.Text = i.AdmissionDate.ToShortDateString();
                GBGradDateTB.Text = i.ExpectedGraduationDate.ToString();
                GBFormTB.Text = i.SchoolForm.ToString();

            }
                  
            
        }

        private void LoadStudentParents()
        {
            var pquery = from s in db.Students
                         join sp in db.StudentsParents on s.StudentID equals sp.StudentID
                         join p in db.Parents on sp.ParentID equals p.ParentID
                         where s.UserID == uID
                         select new { FirstName = p.FirstName, LastName = p.LastName, Relationship = sp.Relationship };

            studentparentGridView.DataSource = pquery.ToList();
            
            
        }
        
        private void LoadStudentClasses(int term, string year)
        {
            
            if (TermCB.SelectedIndex == -1 &&  AcademicPCB.SelectedIndex == -1)
            {
                var classquery = from s in db.Students
                                 join sc in db.StudentClasses on s.StudentID equals sc.StudentID
                                 where s.UserID == uID 
                                 select new
                                 {
                                     SID = s.StudentID,
                                     CID = sc.ClassID,
                                     Subject = sc.Class.Subject,
                                     Lecturer = sc.Class.Teacher.FirstName + " " + sc.Class.Teacher.LastName,
                                     Form = sc.Class.SchoolForm,
                                     AcademicTerm = sc.Class.Term,
                                     AcademicYear = sc.Class.AcademicYear
                                 };

                
                studentclassesGV.DataSource = classquery.OrderByDescending(x => x.AcademicYear).ToList();
                
            }

            if (TermCB.SelectedIndex != -1 && AcademicPCB.SelectedIndex == -1)
            {
                var classquery = from s in db.Students
                                 join sc in db.StudentClasses on s.StudentID equals sc.StudentID
                                 where (s.UserID == uID && sc.Class.TermID == term && sc.Class.AcademicYear == year) ||
                             (s.UserID == uID && sc.Class.TermID == term || sc.Class.AcademicYear == year)
                             select new
                             {
                                 SID = s.StudentID,
                                 CID = sc.ClassID,
                                 Subject = sc.Class.Subject,
                                 Lecturer = sc.Class.Teacher.FirstName + " " + sc.Class.Teacher.LastName,
                                 Form = sc.Class.SchoolForm,
                                 AcademicTerm = sc.Class.Term,
                                 AcademicYear = sc.Class.AcademicYear
                             };

            studentclassesGV.DataSource = classquery.OrderByDescending(x=> x.AcademicYear).ToList();
            }

            if (TermCB.SelectedIndex == -1 && AcademicPCB.SelectedIndex != -1)
            {
                var classquery = from s in db.Students
                                 join sc in db.StudentClasses on s.StudentID equals sc.StudentID
                                 where (s.UserID == uID && sc.Class.TermID == term && sc.Class.AcademicYear == year) ||
                                 (s.UserID == uID && sc.Class.AcademicYear == year || sc.Class.TermID == term)
                                 select new
                                 {
                                     SID = s.StudentID,
                                     CID = sc.ClassID,
                                     Subject = sc.Class.Subject,
                                     Lecturer = sc.Class.Teacher.FirstName + " " + sc.Class.Teacher.LastName,
                                     Form = sc.Class.SchoolForm,
                                     AcademicTerm = sc.Class.Term,
                                     AcademicYear = sc.Class.AcademicYear
                                 };

                studentclassesGV.DataSource = classquery.OrderByDescending(x => x.AcademicYear).ToList();
            }

            if (TermCB.SelectedIndex != -1 && AcademicPCB.SelectedIndex != -1)
            {
                var classquery = from s in db.Students
                                 join sc in db.StudentClasses on s.StudentID equals sc.StudentID
                                 where (s.UserID == uID && sc.Class.TermID == term && sc.Class.AcademicYear == year)
                                 select new
                                 {
                                     SID = s.StudentID,
                                     CID = sc.ClassID,
                                     Subject = sc.Class.Subject,
                                     Lecturer = sc.Class.Teacher.FirstName + " " + sc.Class.Teacher.LastName,
                                     Form = sc.Class.SchoolForm,
                                     AcademicTerm = sc.Class.Term,
                                     AcademicYear = sc.Class.AcademicYear
                                 };

                studentclassesGV.DataSource = classquery.OrderByDescending(x => x.AcademicYear).ToList();

                //hidecols();
            }

        }

        private void StudentClassesTab_Click(object sender, EventArgs e)
        {
            LoadStudentClasses(Convert.ToInt32(TermCB.SelectedValue), AcademicPCB.Text);
        }
        
        private void Searchbtn_Click(object sender, EventArgs e)
        {
            LoadStudentClasses(Convert.ToInt32(TermCB.SelectedValue), AcademicPCB.Text);
        }

        private void fillcombobox()
        {
            TermCB.DataSource = db.Terms.ToList();
            TermCB.DisplayMember = "TermName";
            TermCB.ValueMember = "TermID";
            TermCB.SelectedIndex = -1;
            
            AcademicPCB.DataSource = db.Classes.Select ( x => x.AcademicYear).Distinct().ToList();
            AcademicPCB.DisplayMember = "AcademicYear";
            AcademicPCB.SelectedIndex = -1;

                       
        }
       
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            fillcombobox();

            this.studentclassesGV.DataSource = null;

            var classquery = from s in db.Students
                             join sc in db.StudentClasses on s.StudentID equals sc.StudentID
                             where s.UserID == uID
                             select new
                             {
                                 SID = s.StudentID,
                                 CID = sc.ClassID,
                                 Subject = sc.Class.Subject,
                                 Lecturer = sc.Class.Teacher.FirstName + " " + sc.Class.Teacher.LastName,
                                 Form = sc.Class.SchoolForm,
                                 AcademicTerm = sc.Class.Term,
                                 AcademicYear = sc.Class.AcademicYear
                              };


            studentclassesGV.DataSource = classquery.OrderByDescending(x => x.AcademicYear).ToList();
                    
            
        }

        private void LoadGradeBook()
        {
            int ID = Convert.ToInt32(uIDlbl.Text);
            var grades = from sc in db.StudentClasses
                         where sc.Student.UserID == ID
                         select new
                         {
                            Subject = sc.Class.Subject,
                            Form = sc.Class.SchoolForm,
                            Term= sc.Class.Term,
                            Year = sc.Class.AcademicYear,
                            Grade = sc.Grade

                         };

            GradeBookGV.DataSource = grades.ToList();           
            
            
        }
                     
        private void PrintBtn_Click(object sender, EventArgs e)
        {
            printReport();
        }

        private void EmailBtn_Click(object sender, EventArgs e)
        {
            //sendEmail();
            MessageBox.Show("Feature to be released in later version");
        }

        private void printReport()
        {
           




        }
        private void studentclassesGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            studID = Convert.ToInt32(studentidTB.Text);
            ccode = Int32.Parse(studentclassesGV.Rows[e.RowIndex].Cells["CID"].Value.ToString());

            frmStudentAssessments assessments = new frmStudentAssessments();
            assessments.uIDlbl.Text = studID.ToString();
            assessments.subID.Text = ccode.ToString();
            assessments.Show();
            

        }

        private string findCurrentTerm(DateTime now)
        {
            
            now  = DateTime.Now;

            yr = now.Year.ToString();
            mth = now.Month; 
            string filter;
            
            if (mth > 8)
            {
               filter = yr+'-';
               result = db.Classes.Where(x=> x.AcademicYear.Contains(filter)).ToString();
                    
                    //from c in db.Classes
                    //    where c.AcademicYear.Contains(yr+"-")
                    //    select c.AcademicYear;

            }
            else
            {
                filter = '-' + yr;
               result = (from c in db.Classes
                         where c.AcademicYear.Contains(filter)
                         select c.AcademicYear).ToString();
            }

            
            return result;
        }

       

        private void sendEmail()
        {
            try
            {
                var email = db.Users.Where(u=> u.UserID == Convert.ToInt32(uIDlbl.Text)).Select(e=> e.Email).ToString();
                MailMessage mail = new MailMessage();
                SmtpClient Server = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("xora.nedd@gmail.com");
                mail.To.Add(email);
                mail.Subject = "Student's Grades";
                mail.Body = "Dear Parent," + " \n\n" + "Please be advised that final grades have been posted for this current semester.";

                Server.Port = 587;
                Server.Credentials = new System.Net.NetworkCredential("Usernamer", "password");
                Server.EnableSsl = true;

                Server.Send(mail);
                MessageBox.Show("Message Successfully Sent");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot be Sent" + ex);
            }




        }

        private void ChangepassBtn_Click(object sender, EventArgs e)
        {
            frmChangePassword changepass = new frmChangePassword();
            changepass.uIDlbl.Text = this.uIDlbl.Text;
            changepass.Show();
        }

        private void cPrintBtn_Click(object sender, EventArgs e)
        {
            PrintReport.Print_DataGridView(studentclassesGV);
        }

        private void PrintBtn_Click_1(object sender, EventArgs e)
        {
            PrintReport.Print_DataGridView(GradeBookGV);
        }
            
           
    } 
}
