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
    public partial class frmPrincipalAccount : Form
    {
        SchoolsEntities db = new SchoolsEntities();
        int uID, sID, cID, aID, scID;

        Assessment newExam;


        public frmPrincipalAccount()
        {
            InitializeComponent();
        }

        private void frmTeacherAccount_Load(object sender, EventArgs e)
        {
            uID = Convert.ToInt32(uIDlbl.Text);
            LoadTeacherProfile();
            fillcombobox();
            results(CTAcademicperiodCB.Text, Convert.ToInt32(CTTermCB.SelectedValue), Convert.ToInt32(ctSubjectCB.SelectedValue), CTTeacherCB.Text);
            LoadStudentList();
            hideAdd();
        }

        private void fillcombobox()
        {
            var subjects = (from t in db.Principals
                            join c in db.Classes on t.SchoolCode equals c.SchoolCode
                            join sub in db.Subjects on c.SubjectCode equals sub.SubjectCode
                            where t.UserID == uID
                            select sub).Distinct();

            var teacherquery = (from t in db.Teachers
                                join sch in db.Schools on t.SchoolCode equals sch.SchoolCode
                                select new
                                {
                                    ID = t.TeacherID,
                                    Name = t.FirstName + " " + t.LastName
                                }).Distinct();

            var StudentQuery = (from t in db.Students
                                select new
                                {
                                    ID = t.StudentID,
                                    Name = t.FirstName + " " + t.LastName
                                }).Distinct();

            var year = db.Classes.Select(x => x.AcademicYear).Distinct();
            var terms = db.Terms.Distinct();
            var form = db.SchoolForms.Distinct();

            CTTeacherCB.DataSource = teacherquery.ToList();
            CTTeacherCB.DisplayMember = "Name";
            CTTeacherCB.SelectedIndex = -1;

            CStudentNameCB.DataSource = StudentQuery.ToList();
            CStudentNameCB.DisplayMember = "Name";
            CStudentNameCB.SelectedIndex = -1;

            CTAcademicperiodCB.DataSource = year.ToList();
            CTAcademicperiodCB.DisplayMember = "AcademicYear";
            CTAcademicperiodCB.SelectedIndex = -1;

            CTTermCB.DataSource = terms.ToList();
            CTTermCB.DisplayMember = "TermName";
            CTTermCB.ValueMember = "TermID";
            CTTermCB.SelectedIndex = -1;

            ctSubjectCB.DataSource = subjects.ToList();
            ctSubjectCB.DisplayMember = "SubjectName";
            ctSubjectCB.ValueMember = "SubjectCode";
            ctSubjectCB.SelectedIndex = -1;

            scFormCB.DataSource = form.ToList();
            scFormCB.DisplayMember = "FormName";
            scFormCB.ValueMember = "FormID";
            scFormCB.SelectedIndex = -1;

            scAcademicYrCB.DataSource = year.ToList();
            scAcademicYrCB.DisplayMember = "AcademicYear";
            scAcademicYrCB.SelectedIndex = -1;

            scTermCB.DataSource = terms.ToList();
            scTermCB.DisplayMember = "TermName";
            scTermCB.ValueMember = "TermID";
            scTermCB.SelectedIndex = -1;

            scSubjectCB.DataSource = subjects.ToList();
            scSubjectCB.DisplayMember = "SubjectName";
            scSubjectCB.ValueMember = "SubjectCode";
            scSubjectCB.SelectedIndex = -1;

            clAcademicYrCB.DataSource = year.ToList();
            clAcademicYrCB.DisplayMember = "AcademicYear";
            clAcademicYrCB.SelectedIndex = -1;

            clTermCB.DataSource = terms.ToList();
            clTermCB.DisplayMember = "TermName";
            clTermCB.ValueMember = "TermID";
            clTermCB.SelectedIndex = -1;


            clSubjectCB.DataSource = subjects.ToList();
            clSubjectCB.DisplayMember = "SubjectName";
            clSubjectCB.ValueMember = "SubjectCode";
            clSubjectCB.SelectedIndex = -1;

            gAcademicYrCB.DataSource = year.ToList();
            gAcademicYrCB.DisplayMember = "AcademicYear";
            gAcademicYrCB.SelectedIndex = -1;

            gTermCB.DataSource = terms.ToList();
            gTermCB.DisplayMember = "TermName";
            gTermCB.ValueMember = "TermID";
            gTermCB.SelectedIndex = -1;


            gSubjectCB.DataSource = subjects.ToList();
            gSubjectCB.DisplayMember = "SubjectName";
            gSubjectCB.ValueMember = "SubjectCode";
            gSubjectCB.SelectedIndex = -1;
        }

        private void LoadTeacherProfile()
        {
            var qprofile = from t in db.Principals
                           where t.UserID == uID
                           select t;

            foreach (var i in qprofile)
            {
                //loading data into student account tab
                TeacherIDTB.Text = i.PrincipalID.ToString();
                TFirsnameTB.Text = i.Firstname;
                TMItb.Text = i.MiddleInitial;
                TLastnameTB.Text = i.Lastname;
                tDOBtb.Text = i.DOB.ToShortDateString();
                TSchooltb.Text = i.School.ToString();
                TVillageTB.Text = i.Village.ToString();
                TParishTB.Text = i.Parish.ToString();
                THomeTB.Text = i.HomePhone;
                TCellTB.Text = i.CellPhone;
                TEmailTB.Text = i.Email;

                string id = i.PrincipalID.ToString();
                string name = i.Firstname + " " + i.Lastname;
                string skl = i.School.ToString();

                //load data into class approval list tab
                clTeacherIDTB.Text = id;
                clTeacherNameTB.Text = name;
                clSchoolTB.Text = skl;
                ctSchoolTB.Text = skl;
            }
        }

        /// <summary>
        /// what is displayed if there is not results 
        /// returned in a gridview
        /// </summary>
        private void Empty()
        {

            MessageBox.Show("No Records Found");

        }

        /// <summary>
        /// method used to filter data based on
        /// the Sort By criteria on forms
        /// </summary>
        /// 
        private void results(string yr, int trm, int sub, int frm)
        {
            var cbyID = from t in db.Teachers
                        join c in db.Classes on t.TeacherID equals c.TeacherID
                        where t.UserID == uID
                                  orderby c.AcademicYear descending, c.FormID descending
                                  select new
                                  {
                                      ID = c.ClassID,
                                      Subject = c.Subject,
                                      Form = c.SchoolForm,
                                      AcademicTerm = c.Term,
                                      AcademicYear = c.AcademicYear
                                  };

            var cbyIDYR = from t in db.Teachers
                                  join c in db.Classes on t.TeacherID equals c.TeacherID
                                  join f in db.SchoolForms on c.FormID equals f.FormID
                                  join su in db.Subjects on c.SubjectCode equals su.SubjectCode
                                  join tm in db.Terms on c.TermID equals tm.TermID
                                  where t.UserID == uID && c.AcademicYear == yr
                                  orderby c.AcademicYear descending, c.FormID descending
                                  select new
                                  {
                                      ID = c.ClassID,
                                      Subject = c.Subject,
                                      Form = c.SchoolForm,
                                      AcademicTerm = c.Term,
                                      AcademicYear = c.AcademicYear
                                  };

            var cbyFrm = from t in db.Teachers
                          join c in db.Classes on t.TeacherID equals c.TeacherID
                          join f in db.SchoolForms on c.FormID equals f.FormID
                          join su in db.Subjects on c.SubjectCode equals su.SubjectCode
                          join tm in db.Terms on c.TermID equals tm.TermID
                          where t.UserID == uID && c.FormID == frm
                          orderby c.AcademicYear descending, c.FormID descending
                          select new
                          {
                              ID = c.ClassID,
                              Subject = c.Subject,
                              Form = c.SchoolForm,
                              AcademicTerm = c.Term,
                              AcademicYear = c.AcademicYear
                          };
            var cbytrm = from t in db.Teachers
                          join c in db.Classes on t.TeacherID equals c.TeacherID
                          join f in db.SchoolForms on c.FormID equals f.FormID
                          join su in db.Subjects on c.SubjectCode equals su.SubjectCode
                          join tm in db.Terms on c.TermID equals tm.TermID
                          where t.UserID == uID && c.TermID== trm
                          orderby c.AcademicYear descending, c.FormID descending
                          select new
                          {
                              ID = c.ClassID,
                              Subject = c.Subject,
                              Form = c.SchoolForm,
                              AcademicTerm = c.Term,
                              AcademicYear = c.AcademicYear
                          };
            

            var cbyIDYRTM = from t in db.Teachers
                                  join c in db.Classes on t.TeacherID equals c.TeacherID
                                  join f in db.SchoolForms on c.FormID equals f.FormID
                                  join su in db.Subjects on c.SubjectCode equals su.SubjectCode
                                  join tm in db.Terms on c.TermID equals tm.TermID
                                  where t.UserID == uID && c.AcademicYear == yr && c.TermID == trm
                                  orderby c.AcademicYear descending, c.FormID descending
                                  select new
                                  {
                                      ID = c.ClassID,
                                      Subject = c.Subject,
                                      Form = c.SchoolForm,
                                      AcademicTerm = c.Term,
                                      AcademicYear = c.AcademicYear
                                  };

            var cbyIDYRTMSub = from t in db.Teachers
                            join c in db.Classes on t.TeacherID equals c.TeacherID
                            join f in db.SchoolForms on c.FormID equals f.FormID
                            join su in db.Subjects on c.SubjectCode equals su.SubjectCode
                            join tm in db.Terms on c.TermID equals tm.TermID
                            where t.UserID == uID && c.AcademicYear == yr && c.TermID == trm && c.SubjectCode == sub
                            orderby c.AcademicYear descending, c.FormID descending
                            select new
                            {
                                ID = c.ClassID,
                                Subject = c.Subject,
                                Form = c.SchoolForm,
                                AcademicTerm = c.Term,
                                AcademicYear = c.AcademicYear
                            };

           
            var cbysub = from t in db.Teachers
                         join c in db.Classes on t.TeacherID equals c.TeacherID
                         join f in db.SchoolForms on c.FormID equals f.FormID
                         join su in db.Subjects on c.SubjectCode equals su.SubjectCode
                         join tm in db.Terms on c.TermID equals tm.TermID
                         where t.UserID == uID && c.SubjectCode == sub
                         orderby c.AcademicYear descending, c.FormID descending
                         select new
                         {
                             ID = c.ClassID,
                             Subject = c.Subject,
                             Form = c.SchoolForm,
                             AcademicTerm = c.Term,
                             AcademicYear = c.AcademicYear
                         };
            
            var cbyAll = from t in db.Teachers
                                  join c in db.Classes on t.TeacherID equals c.TeacherID
                                  join f in db.SchoolForms on c.FormID equals f.FormID
                                  join su in db.Subjects on c.SubjectCode equals su.SubjectCode
                                  join tm in db.Terms on c.TermID equals tm.TermID
                                  where t.UserID == uID && c.AcademicYear == yr && c.TermID == trm && c.SubjectCode == sub && c.FormID == frm
                                  orderby c.AcademicYear descending, c.FormID descending
                                  select new
                                  {
                                      ID = c.ClassID,
                                      Subject = c.Subject,
                                      Form = c.SchoolForm,
                                      AcademicTerm = c.Term,
                                      AcademicYear = c.AcademicYear
                                  };
           
            var SbyID = from s in db.Students
                          join sc in db.StudentClasses on s.StudentID equals sc.StudentID
                          join c in db.Classes on sc.ClassID equals c.ClassID
                          join t in db.Teachers on c.TeacherID equals t.TeacherID
                          where t.UserID == uID
                          orderby c.AcademicYear descending, c.FormID descending
                          select new
                          {
                              ID = sc.StudentClassesID,
                              CID = sc.ClassID,
                              SID = sc.StudentID,
                              Student = s.FirstName + " " + s.LastName,
                              Subject = c.Subject,
                              Form = c.SchoolForm,
                              AcademicYear = c.AcademicYear,
                              AcademicTerm = c.Term
                          };

            var sbyIDYRTMSub = from s in db.Students
                               join sc in db.StudentClasses on s.StudentID equals sc.StudentID
                               join c in db.Classes on sc.ClassID equals c.ClassID
                               join t in db.Teachers on c.TeacherID equals t.TeacherID
                               where t.UserID == uID && c.AcademicYear == yr && c.TermID == trm && c.SubjectCode == sub
                               orderby c.AcademicYear descending, c.FormID descending
                               select new
                          {
                              ID = sc.StudentClassesID,
                              CID = sc.ClassID,
                              SID = sc.StudentID,
                              Student = s.FirstName + " " + s.LastName,
                              Subject = c.Subject,
                              Form = c.SchoolForm,
                              AcademicYear = c.AcademicYear,
                              AcademicTerm = c.Term
                          }
            var SbyFrm = from s in db.Students
                        join sc in db.StudentClasses on s.StudentID equals sc.StudentID
                        join c in db.Classes on sc.ClassID equals c.ClassID
                        join t in db.Teachers on c.TeacherID equals t.TeacherID
                        where t.UserID == uID && c.FormID == frm
                        orderby c.AcademicYear descending, c.FormID descending
                        select new
                        {
                            ID = sc.StudentClassesID,
                            CID = sc.ClassID,
                            SID = sc.StudentID,
                            Student = s.FirstName + " " + s.LastName,
                            Subject = c.Subject,
                            Form = c.SchoolForm,
                            AcademicYear = c.AcademicYear,
                            AcademicTerm = c.Term
                        };

            var SbyIDYR = from s in db.Students
                        join sc in db.StudentClasses on s.StudentID equals sc.StudentID
                        join c in db.Classes on sc.ClassID equals c.ClassID
                        join t in db.Teachers on c.TeacherID equals t.TeacherID
                        where t.UserID == uID && c.AcademicYear == yr
                        orderby c.AcademicYear descending, c.FormID descending
                        select new
                        {
                            ID = sc.StudentClassesID,
                            CID = sc.ClassID,
                            SID = sc.StudentID,
                            Student = s.FirstName + " " + s.LastName,
                            Subject = c.Subject,
                            Form = c.SchoolForm,
                            AcademicYear = c.AcademicYear,
                            AcademicTerm = c.Term
                        };

            var SbyIDYRTM = from s in db.Students
                          join sc in db.StudentClasses on s.StudentID equals sc.StudentID
                          join c in db.Classes on sc.ClassID equals c.ClassID
                          join t in db.Teachers on c.TeacherID equals t.TeacherID
                           where t.UserID == uID && c.AcademicYear == yr && c.TermID == trm
                          orderby c.AcademicYear descending, c.FormID descending
                          select new
                          {
                              ID = sc.StudentClassesID,
                              CID = sc.ClassID,
                              SID = sc.StudentID,
                              Student = s.FirstName + " " + s.LastName,
                              Subject = c.Subject,
                              Form = c.SchoolForm,
                              AcademicYear = c.AcademicYear,
                              AcademicTerm = c.Term
                          };

            var SbyAll = from s in db.Students
                           join sc in db.StudentClasses on s.StudentID equals sc.StudentID
                           join c in db.Classes on sc.ClassID equals c.ClassID
                           join t in db.Teachers on c.TeacherID equals t.TeacherID
                           where t.UserID == uID && c.AcademicYear == yr && c.TermID == trm && c.SubjectCode == sub && c.FormID == frm
                           orderby c.AcademicYear descending, c.FormID descending
                           select new
                           {
                               ID = sc.StudentClassesID,
                               CID = sc.ClassID,
                               SID = sc.StudentID,
                               Student = s.FirstName + " " + s.LastName,
                               Subject = c.Subject,
                               Form = c.SchoolForm,
                               AcademicYear = c.AcademicYear,
                               AcademicTerm = c.Term
                           };

            var SbyTrm = from s in db.Students
                         join sc in db.StudentClasses on s.StudentID equals sc.StudentID
                         join c in db.Classes on sc.ClassID equals c.ClassID
                         join t in db.Teachers on c.TeacherID equals t.TeacherID
                         where t.UserID == uID && c.TermID == trm
                         orderby c.AcademicYear descending, c.FormID descending
                         select new
                         {
                             ID = sc.StudentClassesID,
                             CID = sc.ClassID,
                             SID = sc.StudentID,
                             Student = s.FirstName + " " + s.LastName,
                             Subject = c.Subject,
                             Form = c.SchoolForm,
                             AcademicYear = c.AcademicYear,
                             AcademicTerm = c.Term
                         };

            var SbySub = from s in db.Students
                         join sc in db.StudentClasses on s.StudentID equals sc.StudentID
                         join c in db.Classes on sc.ClassID equals c.ClassID
                         join t in db.Teachers on c.TeacherID equals t.TeacherID
                         where t.UserID == uID &&  c.SubjectCode == sub 
                         orderby c.AcademicYear descending, c.FormID descending
                         select new
                         {
                             ID = sc.StudentClassesID,
                             CID = sc.ClassID,
                             SID = sc.StudentID,
                             Student = s.FirstName + " " + s.LastName,
                             Subject = c.Subject,
                             Form = c.SchoolForm,
                             AcademicYear = c.AcademicYear,
                             AcademicTerm = c.Term
                         };

            if (TeacherTabs.SelectedTab == TeacherTabs.TabPages["TAccountTab"] || TeacherTabs.SelectedTab == TeacherTabs.TabPages["ClassTaughtTab"])
            {
                if (yr == "" & trm <= 0 & sub <= 0 & frm <= 0)
                {
                    if (cbyID.Count() != 0)
                    {
                        teachercoursesGV.DataSource = cbyID.ToList();
                    }
                    else
                    {
                        Empty();
                    }

                }
                

                    if (yr != "" & trm != 0 & sub != 0 & frm <= 0)
                {
                    if (cbyIDYRTMSub.Count() != 0)
                    {
                        teachercoursesGV.DataSource = cbyIDYRTMSub.ToList();
                    }
                    else
                    {
                        Empty();
                    }

                }

                if (yr == "" & trm > 0 & sub <= 0 & frm <= 0)
                {
                    if (cbytrm.Count() != 0)
                    {
                        teachercoursesGV.DataSource = cbytrm.ToList();
                    }
                    else
                    {
                        Empty();
                    }

                }

                if (yr == "" & trm <= 0 & sub > 0 & frm <= 0)
                {
                    if (cbysub.Count() != 0)
                    {
                        teachercoursesGV.DataSource = cbysub.ToList();
                    }
                    else
                    {
                        Empty();
                    }
                }

                if (yr != "" & trm <= 0 & sub <= 0 & frm <= 0)
                {
                    if (cbyIDYR.Count() != 0)
                    {
                        teachercoursesGV.DataSource = cbyIDYR.ToList();
                    }
                    else
                    {
                        Empty();
                    }
                }

                if (yr != "" & trm != 0 & sub <= 0 & frm <= 0)
                {
                    if (cbyIDYRTM.Count() != 0)
                    {
                        teachercoursesGV.DataSource = cbyIDYRTM.ToList();
                    }
                    else
                    {
                        Empty();
                    }
                }

                if (yr != "" & trm != 0 & sub != 0 & frm > 0)
                {
                    if (cbyFrm.Count() != 0)
                    {
                        teachercoursesGV.DataSource = cbyFrm.ToList();
                    }
                    else
                    {
                        Empty();
                    }
                }
            }


            if (TeacherTabs.SelectedTab == TeacherTabs.TabPages["StudentsPerClassTab"])
            {
                if (yr == "" & trm <= 0 & sub <= 0)
                {
                    if (SbyID.Count() != 0)
                    {
                        teachercoursesGV.DataSource = SbyID.ToList();
                    }
                    else
                    {
                        Empty();
                    }
                }

                if (yr == "" & trm > 0 & sub <= 0 & frm <= 0)
                {
                    if (SbyTrm.Count() != 0)
                    {
                        teachercoursesGV.DataSource = SbyTrm.ToList();
                    }
                    else
                    {
                        Empty();
                    }

                }
                if (yr == "" & trm <= 0 & sub > 0 & frm <= 0)
                {
                    if (SbySub.Count() != 0)
                    {
                        teachercoursesGV.DataSource = SbySub.ToList();
                    }
                    else
                    {
                        Empty();
                    }
                }

                if (yr != "" & trm <= 0 & sub <= 0 & frm <= 0)
                {
                    if (SbyIDYR.Count() != 0)
                    {
                        teachercoursesGV.DataSource = SbyIDYR.ToList();
                    }
                    else
                    {
                        Empty();
                    }
                }

                if (yr != "" & trm != 0 & sub <= 0 & frm <= 0)
                {
                    if (SbyIDYRTM.Count() != 0)
                    {
                        teachercoursesGV.DataSource = SbyIDYRTM.ToList();
                    }
                    else
                    {
                        Empty();
                    }
                }
                
                    if (yr != "" & trm != 0 & sub != 0 & frm <= 0)
                {
                    if (sbyIDYRTMSub.Count() != 0)
                    {
                        teachercoursesGV.DataSource = sbyIDYRTMSub.ToList();
                    }
                    else
                    {
                        Empty();
                    }
                }

                if (yr != "" & trm != 0 & sub != 0 & frm > 0)
                {
                    if (SbyFrm.Count() != 0)
                    {
                        teachercoursesGV.DataSource = SbyFrm.ToList();
                    }
                    else
                    {
                        Empty();
                    }
                }
                               
            }
         

            if (TeacherTabs.SelectedTab == TeacherTabs.TabPages["ClassApprovalTab"])
            {
            if (yr == "" & trm <= 0 & sub <= 0)
                {
                    if (SbyID.Count() != 0)
                    {
                        classapprovallistGV.DataSource = SbyID.ToList();
                    }
                    else
                    {
                        Empty();
                    }
                }

                if (yr == "" & trm > 0 & sub <= 0 & frm <= 0)
                {
                    if (SbyTrm.Count() != 0)
                    {
                        classapprovallistGV.DataSource = SbyTrm.ToList();
                    }
                    else
                    {
                        Empty();
                    }

                }

                if (yr != "" & trm != 0 & sub <= 0 & frm <= 0)
                {
                    if (SbyIDYRTM.Count() != 0)
                    {
                        classapprovallistGV.DataSource = SbyIDYRTM.ToList();
                    }
                    else
                    {
                        Empty();
                    }
                }
                
                    if (yr != "" & trm != 0 & sub != 0 & frm <= 0)
                {
                    if (sbyIDYRTMSub.Count() != 0)
                    {
                        classapprovallistGV.DataSource = sbyIDYRTMSub.ToList();
                    }
                    else
                    {
                        Empty();
                    }
                }
                if (yr == "" & trm <= 0 & sub > 0 & frm <= 0)
                {
                    if (SbySub.Count() != 0)
                    {
                        classapprovallistGV.DataSource = SbySub.ToList();
                    }
                    else
                    {
                        Empty();
                    }
                }

                if (yr != "" & trm <= 0 & sub <= 0 & frm <= 0)
                {
                    if (SbyIDYR.Count() != 0)
                    {
                        classapprovallistGV.DataSource = SbyIDYR.ToList();
                    }
                    else
                    {
                        Empty();
                    }
                }

                if (yr != "" & trm != 0 & sub <= 0 & frm <= 0)
                {
                    if (SbyIDYRTM.Count() != 0)
                    {
                        classapprovallistGV.DataSource = SbyIDYRTM.ToList();
                    }
                    else
                    {
                        Empty();
                    }
                }

                if (yr != "" & trm != 0 & sub != 0 & frm > 0)
                {
                    if (SbyFrm.Count() != 0)
                    {
                        classapprovallistGV.DataSource = SbyFrm.ToList();
                    }
                    else
                    {
                        Empty();
                    }
                }
            }

            if (TeacherTabs.SelectedTab == TeacherTabs.TabPages["StudentGradesTab"])
            {
                if (yr == "" & trm <= 0 & sub <= 0)
                {
                    if (SbyID.Count() != 0)
                    {
                        gStudentsGV.DataSource = SbyID.ToList();
                        hidecols();
                    }
                    else
                    {
                        Empty();
                    }
                }

                if (yr != "" & trm != 0 & sub <= 0 & frm <= 0)
                {
                    if (SbyIDYRTM.Count() != 0)
                    {
                        gStudentsGV.DataSource = SbyIDYRTM.ToList();
                        hidecols();
                    }
                    else
                    {
                        Empty();
                    }
                }
                
                    if (yr != "" & trm != 0 & sub != 0 & frm <= 0)
                {
                    if (sbyIDYRTMSub.Count() != 0)
                    {
                        gStudentsGV.DataSource = sbyIDYRTMSub.ToList();
                        hidecols();
                    }
                    else
                    {
                        Empty();
                    }
                }

                if (yr == "" & trm > 0 & sub <= 0 & frm <= 0)
                {
                    if (SbyTrm.Count() != 0)
                    {
                        gStudentsGV.DataSource = SbyTrm.ToList();
                        hidecols();
                    }
                    else
                    {
                        Empty();
                    }

                }
                if (yr == "" & trm <= 0 & sub > 0 & frm <= 0)
                {
                    if (SbySub.Count() != 0)
                    {
                        gStudentsGV.DataSource = SbySub.ToList();
                        hidecols();
                    }
                    else
                    {
                        Empty();
                    }
                }

                if (yr != "" & trm <= 0 & sub <= 0 & frm <= 0)
                {
                    if (SbyIDYR.Count() != 0)
                    {
                        gStudentsGV.DataSource = SbyIDYR.ToList();
                        hidecols();
                    }
                    else
                    {
                        Empty();
                    }
                }

                if (yr != "" & trm != 0 & sub <= 0 & frm <= 0)
                {
                    if (SbyIDYRTM.Count() != 0)
                    {
                        gStudentsGV.DataSource = SbyIDYRTM.ToList();
                        hidecols();
                    }
                    else
                    {
                        Empty();
                    }
                }

                if (yr != "" & trm != 0 & sub != 0 & frm > 0)
                {
                    if (SbyFrm.Count() != 0)
                    {
                        gStudentsGV.DataSource = SbyFrm.ToList();
                        hidecols();
                    }
                    else
                    {
                        Empty();
                    }
                }
            }
        }
   



        private void ctGetDatabtn_Click(object sender, EventArgs e)
        {
            results(CTAcademicperiodCB.Text, Convert.ToInt32(CTTermCB.SelectedValue), Convert.ToInt32(ctSubjectCB.SelectedValue), CTTeacherCB.Text);
        }

        private void ctResetbtn_Click(object sender, EventArgs e)
        {
            refresh();
        }
        private void refresh()
        {
            fillcombobox();
            this.teachercoursesGV.DataSource = null;

            if (PrinicipalTabs.SelectedTab == PrinicipalTabs.TabPages["ClassTaughtTab"])
            {
                results(CTAcademicperiodCB.Text, Convert.ToInt32(CTTermCB.SelectedValue), Convert.ToInt32(ctSubjectCB.SelectedValue), CTTeacherCB.Text);
            }

            if (PrinicipalTabs.SelectedTab == PrinicipalTabs.TabPages["StudentsPerClassTab"])
            {
                results(CTAcademicperiodCB.Text, Convert.ToInt32(CTTermCB.SelectedValue), Convert.ToInt32(ctSubjectCB.SelectedValue), CTTeacherCB.Text);
            }

            if (PrinicipalTabs.SelectedTab == PrinicipalTabs.TabPages["ClassApprovalTab"])
            {
                results(CTAcademicperiodCB.Text, Convert.ToInt32(CTTermCB.SelectedValue), Convert.ToInt32(ctSubjectCB.SelectedValue), CTTeacherCB.Text);
            }

            if (PrinicipalTabs.SelectedTab == PrinicipalTabs.TabPages["StudentGradesTab"])
            {
                results(CTAcademicperiodCB.Text, Convert.ToInt32(CTTermCB.SelectedValue), Convert.ToInt32(ctSubjectCB.SelectedValue), CTTeacherCB.Text);
            }
        }
        private void LoadStudentList()
        {
            var ctquery = from s in db.Students
                          join sc in db.StudentClasses on s.StudentID equals sc.StudentID
                          join c in db.Classes on sc.ClassID equals c.ClassID
                          join f in db.SchoolForms on c.FormID equals f.FormID
                          join su in db.Subjects on c.SubjectCode equals su.SubjectCode
                          join tm in db.Terms on c.TermID equals tm.TermID
                          join t in db.Teachers on c.TeacherID equals t.TeacherID
                          join a in db.Assessments on sc.StudentClassesID equals a.StudentClassesID
                          where t.UserID == uID
                          orderby c.AcademicYear descending, c.FormID descending
                          select new
                          {
                              ID = sc.StudentClassesID,
                              CID = sc.ClassID,
                              SID = sc.StudentID,
                              Student = s.FirstName + " " + s.LastName,
                              Subject = c.Subject,
                              Form = f.FormName,
                              AcademicYear = c.AcademicYear,
                              AcademicTerm = c.Term,
                              AssessmentID = a.AssessmentID,
                              AssessmentDate = a.Date,
                              AssessmentGrade = a.Score
                          };
            studentclasslistGV.DataSource = ctquery.ToList();

            gStudentsGV.DataSource = ctquery.ToList();

            hidecols();
            classlist();

        }

        private void hidecols()
        {
            gStudentsGV.Columns["AcademicYear"].Visible = false;
            gStudentsGV.Columns["AcademicTerm"].Visible = false;

        }
        private void classlist()
        {
            var clist = from s in db.Students
                        join sc in db.StudentClasses on s.StudentID equals sc.StudentID
                        join c in db.Classes on sc.ClassID equals c.ClassID
                        //join f in db.SchoolForms on c.FormID equals f.FormID
                        //join su in db.Subjects on c.SubjectCode equals su.SubjectCode
                        //join tm in db.Terms on c.TermID equals tm.TermID
                        join t in db.Teachers on c.TeacherID equals t.TeacherID
                        where t.UserID == uID
                        orderby c.AcademicYear descending, c.FormID descending
                        select new
                        {
                            ID = sc.StudentClassesID,
                            CID = sc.ClassID,
                            SID = sc.StudentID,
                            Student = s.FirstName + " " + s.LastName,
                            Subject = c.Subject,
                            Form = c.SchoolForm.FormName,
                            //AcademicYear = c.AcademicYear,
                            // AcademicTerm = c.Term
                            Status = "Pending"
                        };
            classapprovallistGV.DataSource = clist.ToList();


        }

        private void sresults(string yr, int trm, int sub)
        {
            var clist = from s in db.Students
                        join sc in db.StudentClasses on s.StudentID equals sc.StudentID
                        join c in db.Classes on sc.ClassID equals c.ClassID
                        join t in db.Teachers on c.TeacherID equals t.TeacherID
                        where t.UserID == uID
                        orderby c.AcademicYear descending, c.FormID descending
                        select new
                        {
                            ID = sc.StudentClassesID,
                            CID = sc.ClassID,
                            SID = sc.StudentID,
                            Student = s.FirstName + " " + s.LastName,
                            Subject = c.Subject,
                            Form = c.SchoolForm.FormName,
                        };
            var clist2 = from s in db.Students
                         join sc in db.StudentClasses on s.StudentID equals sc.StudentID
                         join c in db.Classes on sc.ClassID equals c.ClassID
                         join t in db.Teachers on c.TeacherID equals t.TeacherID
                         where t.UserID == uID && c.AcademicYear == yr
                         orderby c.AcademicYear descending, c.FormID descending
                         select new
                         {
                             ID = sc.StudentClassesID,
                             CID = sc.ClassID,
                             SID = sc.StudentID,
                             Student = s.FirstName + " " + s.LastName,
                             Subject = c.Subject,
                             Form = c.SchoolForm.FormName,
                         };
            var clist3 = from s in db.Students
                         join sc in db.StudentClasses on s.StudentID equals sc.StudentID
                         join c in db.Classes on sc.ClassID equals c.ClassID
                         join t in db.Teachers on c.TeacherID equals t.TeacherID
                         where t.UserID == uID && c.AcademicYear == yr && c.TermID == trm
                         orderby c.AcademicYear descending, c.FormID descending
                         select new
                         {
                             ID = sc.StudentClassesID,
                             CID = sc.ClassID,
                             SID = sc.StudentID,
                             Student = s.FirstName + " " + s.LastName,
                             Subject = c.Subject,
                             Form = c.SchoolForm.FormName,
                         };
            var clist4 = from s in db.Students
                         join sc in db.StudentClasses on s.StudentID equals sc.StudentID
                         join c in db.Classes on sc.ClassID equals c.ClassID
                         join t in db.Teachers on c.TeacherID equals t.TeacherID
                         where t.UserID == uID && c.AcademicYear == yr && c.TermID == trm && c.SchoolCode == sub
                         orderby c.AcademicYear descending, c.FormID descending
                         select new
                         {
                             ID = sc.StudentClassesID,
                             CID = sc.ClassID,
                             SID = sc.StudentID,
                             Student = s.FirstName + " " + s.LastName,
                             Subject = c.Subject,
                             Form = c.SchoolForm.FormName,
                         };

            if (yr == "" & trm <= 0 & sub <= 0)
            {
                classapprovallistGV.DataSource = clist.ToList();
            }
            if (yr != "" & trm <= 0 & sub <= 0)
            {
                classapprovallistGV.DataSource = clist2.ToList();
            }
            if (yr != "" & trm != 0 & sub <= 0)
            {
                classapprovallistGV.DataSource = clist3.ToList();
            }

            if (yr != "" & trm != 0 & sub != 0)
            {
                classapprovallistGV.DataSource = clist4.ToList();
            }

        }


        private void loadAssessment(int s, int c)
        {
            gStudentAssGV.DataSource = null;

            var Aquery = from S in db.Students
                         join sC in db.StudentClasses on S.StudentID equals sC.StudentID
                         join C in db.Classes on sC.ClassID equals C.ClassID
                         join aS in db.Assessments on sC.StudentClassesID equals aS.StudentClassesID
                         where sC.StudentID == s && sC.ClassID == c
                         orderby aS.Date descending
                         select new
                         {
                             ExamDate = aS.Date,
                             Score = aS.Score
                         };


            if (Aquery.Count() == 0)
            {
                gStudentAssGV.DataSource = Aquery.ToList();
                MessageBox.Show("No Recorded Assessment(s)");

            }
            else
            {
                gStudentAssGV.DataSource = Aquery.ToList();

            }

        }

        private void gStudentsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            sID = Int32.Parse(gStudentsGV.Rows[e.RowIndex].Cells["SID"].Value.ToString());
            cID = Int32.Parse(gStudentsGV.Rows[e.RowIndex].Cells["CID"].Value.ToString());
            scID = Int32.Parse(gStudentsGV.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            loadAssessment(sID, cID);
            hidecols();
        }

        private void scGetDataBtn_Click(object sender, EventArgs e)
        {
            results(CTAcademicperiodCB.Text, Convert.ToInt32(CTTermCB.SelectedValue), Convert.ToInt32(ctSubjectCB.SelectedValue), CTTeacherCB.Text);
        }

        private void scResetBtn_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void hideAdd()
        {
            NewAssessmentGB.Visible = false;
        }

        private void SaveABtn_Click(object sender, EventArgs e)
        {
            saveAssess();
            hideAdd();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            NewAssessmentGB.Visible = true;
            aID = db.Assessments.Max(x => x.AssessmentID) + 1;
        }

        private void saveAssess()
        {
            try
            {
                newExam = new Assessment()
                {
                    AssessmentID = aID,
                    StudentClassesID = scID,
                    Date = Convert.ToDateTime(AssesDatePicker.Text),
                    Score = Convert.ToDecimal(ScoreTB.Text)

                };

                db.Assessments.Add(newExam);
                db.SaveChanges();
                MessageBox.Show("Assessment Successfully Added");
                //loadAssessment(sID, cID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Be Saved, {0}" + ex);
            }
            finally
            {
                loadAssessment(sID, cID);

            }
        }

        private void clRefreshBtn_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void clGetDataBtn_Click(object sender, EventArgs e)
        {
            sresults(clAcademicYrCB.Text, Convert.ToInt32(clTermCB.SelectedValue), Convert.ToInt32(clSubjectCB.SelectedValue));
        }

        private void gRefreshBtn_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void gGetDataBtn_Click(object sender, EventArgs e)
        {
            results(CTAcademicperiodCB.Text, Convert.ToInt32(CTTermCB.SelectedValue), Convert.ToInt32(ctSubjectCB.SelectedValue), CTTeacherCB.Text);

        }

        

        private void gCancelBtn_Click(object sender, EventArgs e)
        {
            ScoreTB.Clear();
            hideAdd();
        }

    }
}