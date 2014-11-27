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
    public partial class frmClassScheduling : Form
    {
        SchoolsEntities db = new SchoolsEntities();
        int cID, skcode, csID, sID;

        ClassesSchedule newclasstime = new ClassesSchedule();
        List<Class> uClass = new List<Class>();
        Class nclass;
        Subject newSub;

        public const string spattern = @"^[A-Za-z0-9-'\s.]+$";
        string result;

        public frmClassScheduling()
        {
            InitializeComponent();
        }

        private void frmClassScheduling_Load(object sender, EventArgs e)
        {
            skcode = Convert.ToInt32(sklbl.Text);
            ClassdayGB.Visible = false;
            LoadCB();
            LoadGrid();
        }

        /// <summary>
        /// clear Gridview and load contents 
        /// from the query into the grid to be sorted
        /// and viewed
        /// </summary>
        private void LoadGrid()
        {
            SKLclasslistGV.DataSource = null;
            var query = (from s in db.Students
                         join sc in db.StudentClasses on s.StudentID equals sc.StudentID
                         where sc.Class.SchoolCode == skcode
                         orderby sc.Class.ClassID ascending, sc.Class.AcademicYear ascending
                         select new
                         {
                             ID = sc.Class.ClassID,
                             SID = sc.Class.SubjectCode,
                             Subject = sc.Class.Subject,
                             Teacher = (sc.Class.Teacher.FirstName + " " + sc.Class.Teacher.LastName),
                             Form = sc.Class.SchoolForm,
                             Term = sc.Class.Term,
                             Year = sc.Class.AcademicYear
                         });

            SKLclasslistGV.DataSource = query.ToList();

        }

        /// <summary>
        /// loading combo boxes with relevant
        /// data on the form
        /// </summary>
        private void LoadCB()
        {
            
            newsubjCB.DataSource = db.Subjects.ToList();
            newsubjCB.DisplayMember = "SubjectName";
            newsubjCB.ValueMember = "SubjectCode";
            newsubjCB.SelectedIndex = -1;

            clSubCB.DataSource = db.Classes.Where(s => s.SchoolCode == skcode).Select(sj => sj.Subject).Distinct().ToList();
            clSubCB.DisplayMember = "SubjectName";
            clSubCB.ValueMember = "SubjectCode";
            clSubCB.SelectedIndex = -1;

            var query = from t in db.Teachers
                        join sch in db.Schools on t.SchoolCode equals sch.SchoolCode
                        where t.SchoolCode == skcode
                        select new 
                        { 
                            ID = t.TeacherID,
                            Name = t.FirstName + " " + t.LastName 
                        };
            lecCB.DataSource = query.ToList();
            lecCB.DisplayMember ="Name";
            lecCB.ValueMember = "ID";
            lecCB.SelectedIndex = -1;

            clTeachCB.DataSource = query.ToList();
            clTeachCB.DisplayMember = "Name";
            clTeachCB.ValueMember = "ID";
            clTeachCB.SelectedIndex = -1;

            DaySelectionCB.DataSource = db.Days.ToList();
            DaySelectionCB.DisplayMember = "DayName";
            DaySelectionCB.ValueMember = "DayID";
            DaySelectionCB.SelectedIndex = -1;

            acadyrCB.DataSource = db.Classes.Select(y=> y.AcademicYear).Distinct().ToList();
            acadyrCB.DisplayMember = "AcademicYear";
            acadyrCB.SelectedIndex = -1;

            clYrCB.DataSource = db.Classes.Select(y => y.AcademicYear).Distinct().ToList();
            clYrCB.DisplayMember = "AcademicYear";
            clYrCB.SelectedIndex = -1;

            TermCB.DataSource = db.Terms.ToList();
            TermCB.DisplayMember = "TermName";
            TermCB.ValueMember = "TermID";
            TermCB.SelectedIndex = -1;

            clTermCB.DataSource = db.Terms.ToList();
            clTermCB.DisplayMember = "TermName";
            clTermCB.ValueMember = "TermID";
            clTermCB.SelectedIndex = -1;

            FormCB.DataSource = db.SchoolForms.ToList();
            FormCB.DisplayMember = "FormName";
            FormCB.ValueMember = "FormID";
            FormCB.SelectedIndex = -1;

            clFormCB.DataSource = db.SchoolForms.ToList();
            clFormCB.DisplayMember = "FormName";
            clFormCB.ValueMember = "FormID";
            clFormCB.SelectedIndex = -1;
            
        }

        /// <summary>
        /// method used to save a time slot for a class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void AddTimeBtn_Click(object sender, EventArgs e)
        {
            try
            {
            csID = db.ClassesSchedules.Max(x => x.ClassScheduleID) + 1;
            
            newclasstime =  new ClassesSchedule()
                {
                    ClassScheduleID = csID,
                    ClassID = Convert.ToInt32(classIDTB.Text),
                    DayID = Convert.ToInt32(DaySelectionCB.SelectedValue),
                    StartTime = startCB.Text,
                    EndTime = endCB.Text,
                 };
           
            db.ClassesSchedules.Add(newclasstime);
            db.SaveChanges();

            MessageBox.Show("Classes successfully saved");
            UpdateGrid();
            hidecols();
             }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR - Cannot be Saved:" + "\n\n\n" + ex);
            }

        }


        /// <summary>
        /// hiding unwanted columns from the user's 
        /// gui gridview
        /// </summary>
        private void hidecols()
        {
            CSGridView.Columns["Class"].Visible = false;
        }

        /// <summary>
        ///method used to save the contents within the fields 
        ///on the form to the database for record keeping purposes
        /// </summary>
        private void saveClass()
        {
            try
            {
                nclass = new Class()
                {
                    ClassID = Convert.ToInt32(classIDTB.Text),
                    SchoolCode = Convert.ToInt32(sklbl.Text),
                    SubjectCode = Convert.ToInt32(newsubjCB.SelectedValue),
                    TeacherID = Convert.ToInt32(lecCB.SelectedValue),
                    FormID = Convert.ToInt32(FormCB.SelectedValue),
                    TermID = Convert.ToInt32(TermCB.SelectedValue),
                    AcademicYear = acadyrCB.Text
                };
                db.Classes.Add(newclass);
                db.SaveChanges();

                MessageBox.Show("Saved!");

                ClassdayGB.Visible = true;
                readOnly();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR - Cannot be Saved:" + "\n\n\n" + ex);
            }

        }
        /// <summary>
        /// rebinding the grid when a class time slot has been added
        /// </summary>
        private void UpdateGrid()
        {
            CSGridView.DataSource = new BindingList<ClassesSchedule>(newclass.ClassesSchedules.ToList());
        }

        
        /// <summary>
        /// calling the form to create a new subject. 
        /// will be used if a subject is unabialbe for the current list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewSubbtn_Click(object sender, EventArgs e)
        {
            ValidateSubject(newsubjCB.Text);
        }
        /// <summary>
        /// saves a new subject added
        /// </summary>
        private void saveSubject()
        {
            newSub = new Subject()
            {
                SubjectCode = db.Subjects.Max(v => v.SubjectCode) + 1,
                SubjectName = ValidateName(newsubjCB.Text)
            };

            db.Subjects.Add(newSub);
            db.SaveChanges();


        }

        /// <summary>
        /// standard
        /// </summary>
        private void ValidData()
        {
            MessageBox.Show("Please enter Valid Data");
        }

        /// <summary>
        /// validates 
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
        /// checks for exsisting subject and updates or save a subject
        /// </summary>
        /// <param name="v"></param>
        private void ValidateSubject(string v)
        {
            var vill = db.Subjects.Where(x => x.SubjectName==v).Count();

            if (vill == 0)
            {
                try
                {
                    saveSubject();

                    MessageBox.Show("Successfull");

                    newsubjCB.Focus();                    

                }
                catch (Exception)
                {
                    MessageBox.Show("Error - Cannot Be Saved");
                }
                
                MessageBox.Show("Duplicate Error \n\n Subject Exists");
            }
        }
        /// <summary>
        /// checks the ensure that the combo boxes options are not null
        /// </summary>
        /// <returns></returns>
        private bool CheckTB()
        {
            bool result = true;
            if (String.IsNullOrEmpty(newsubjCB.Text)) { errorMsg.SetError(newsubjCB, "Subject is missing."); result = false; newsubjCB.Focus(); } else { errorMsg.SetError(newsubjCB, ""); }
            if (String.IsNullOrEmpty(lecCB.Text)) { errorMsg.SetError(lecCB, "Teacher is missing."); result = false; lecCB.Focus(); } else { errorMsg.SetError(lecCB, ""); }
            if (String.IsNullOrEmpty(acadyrCB.Text)) { errorMsg.SetError(acadyrCB, "Academic Year is missing."); result = false; acadyrCB.Focus(); } else { errorMsg.SetError(acadyrCB, ""); }
            if (String.IsNullOrEmpty(TermCB.Text)) { errorMsg.SetError(TermCB, "Term is missing."); result = false; TermCB.Focus(); } else { errorMsg.SetError(TermCB, ""); }
            if (String.IsNullOrEmpty(FormCB.Text)) { errorMsg.SetError(FormCB, "Form is missing."); result = false; FormCB.Focus(); } else { errorMsg.SetError(FormCB, ""); }
             return result;
        }
        /// <summary>
        /// checks to see if the class id exsists
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        private bool checkID(int i)
        {
            bool res = false;
            var findID = db.Classes.Where(x => x.ClassID == i).ToList();
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

        /// <summary>
        /// updates informaton for a class that already exists
        /// </summary>
        private void UpdateClass(int i)
        {
            uClass = db.Classes.Where(p => p.ClassID == i).ToList();

            foreach (var u in uClass)
            {
               u.AcademicYear = acadyrCB.Text;
               u.SubjectCode = Convert.ToInt32(newsubjCB.SelectedValue);
               u.TeacherID = Convert.ToInt32(lecCB.SelectedValue);
                u.FormID= Convert.ToInt32(FormCB.SelectedValue);
                u.TermID = Convert.ToInt32(TermCB.SelectedValue);
            }
            db.SaveChanges();
        }
        /// <summary>
        /// button to save contents of the form 
        /// for a particular class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (CheckTB())
            {
                if (checkID(Convert.ToInt32(classIDTB.Text)))
                {
                    try
                    {
                        UpdateClass(Convert.ToInt32(classIDTB.Text));
                        MessageBox.Show("Changes Successful!");
                        readOnly();

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Cannot commit changes, Please try again later", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    try
                    {
                        saveClass();
                        MessageBox.Show("Save Successful!");
                        readOnly();
                    }
                    catch
                    {
                        MessageBox.Show("Cannot Save, Please try again later", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            reset();
        }

        
        private void Clearbtn_Click(object sender, EventArgs e)
        {
            NewID();
            reset();
        }
        /// <summary>
        /// sets all objects on the form back to its
        /// default state
        /// </summary>
        private void reset()
        {            
            classIDTB.Clear();
            newsubjCB.SelectedIndex = -1;
            lecCB.SelectedIndex = -1;
            acadyrCB.SelectedIndex = -1;
            TermCB.SelectedItem = -1;
            FormCB.SelectedIndex = -1;
        }

        private void NewID()
        {
            cID = db.Classes.Max(x => x.ClassID) + 1;
            classIDTB.Text = cID.ToString();
        }
        /// <summary>
        /// sets text boxes and combo boxs to read only
        /// after saving to avoid changes unless editing is needed
        /// </summary>
        private void readOnly()
        {
            classIDTB.ReadOnly = true;
            newsubjCB.Enabled = false;
            lecCB.Enabled = false;
            acadyrCB.Enabled = false;
            TermCB.Enabled = false;
            FormCB.Enabled = false;
        }

        /// <summary>
        /// closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// once a content from a cell is clicked, the class id and subject id
        /// is stored in a variable and passes to the scheduling form which display the details
        /// of the class eg. days and times for that specific class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SKLclasslistGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //sID = Int32.Parse(SKLclasslistGV.Rows[e.RowIndex].Cells["SID"].Value.ToString());
            cID = Int32.Parse(SKLclasslistGV.Rows[e.RowIndex].Cells["ID"].Value.ToString());

            frmClassSchedule schedule = new frmClassSchedule();
            schedule.uIDlbl.Text = cID.ToString();
            schedule.Show();
        }

        private void hideIDs()
        {
            SKLclasslistGV.Columns["SID"].Visible = false;
            SKLclasslistGV.Columns["ID"].Visible = false;
        }

        private void SortBtn_Click(object sender, EventArgs e)
        {
            Filter(Convert.ToInt32(clSubCB.SelectedValue), Convert.ToInt32(clTeachCB.SelectedValue), clYrCB.Text, Convert.ToInt32(clTeachCB.SelectedValue), Convert.ToInt32(clFormCB.SelectedValue));
        }

        
        private void Filter(int sub,int lec, string yr, int trm, int frm)
        {
            var rSub = (from s in db.Students
                         join sc in db.StudentClasses on s.StudentID equals sc.StudentID
                         join c in db.Classes on sc.ClassID equals c.ClassID
                         where c.SchoolCode == skcode && c.SubjectCode == sub
                          orderby c.ClassID ascending, c.AcademicYear ascending
                         select new
                         {
                             ID = sc.Class.ClassID,
                             SID = sc.Class.SubjectCode,
                             Subject = sc.Class.Subject,
                             Teacher = (sc.Class.Teacher.FirstName + " " + sc.Class.Teacher.LastName),
                             Form = sc.Class.SchoolForm,
                             Term = sc.Class.Term,
                             Year = sc.Class.AcademicYear
                         });
            var rTeach = (from s in db.Students
                        join sc in db.StudentClasses on s.StudentID equals sc.StudentID
                        join c in db.Classes on sc.ClassID equals c.ClassID
                        where c.SchoolCode == skcode && c.TeacherID== lec
                        orderby c.ClassID ascending, c.AcademicYear ascending
                        select new
                        {
                            ID = sc.Class.ClassID,
                            SID = sc.Class.SubjectCode,
                            Subject = sc.Class.Subject,
                            Teacher = (sc.Class.Teacher.FirstName + " " + sc.Class.Teacher.LastName),
                            Form = sc.Class.SchoolForm,
                            Term = sc.Class.Term,
                            Year = sc.Class.AcademicYear
                        });
            var rYr = (from s in db.Students
                          join sc in db.StudentClasses on s.StudentID equals sc.StudentID
                          join c in db.Classes on sc.ClassID equals c.ClassID
                          where c.SchoolCode == skcode && c.AcademicYear == yr
                          orderby c.ClassID ascending, c.AcademicYear ascending
                          select new
                          {
                              ID = sc.Class.ClassID,
                              SID = sc.Class.SubjectCode,
                              Subject = sc.Class.Subject,
                              Teacher = (sc.Class.Teacher.FirstName + " " + sc.Class.Teacher.LastName),
                              Form = sc.Class.SchoolForm,
                              Term = sc.Class.Term,
                              Year = sc.Class.AcademicYear
                          });
            var rTrm= (from s in db.Students
                       join sc in db.StudentClasses on s.StudentID equals sc.StudentID
                       join c in db.Classes on sc.ClassID equals c.ClassID
                       where c.SchoolCode == skcode && c.TermID == trm
                       orderby c.ClassID ascending, c.AcademicYear ascending
                       select new
                       {
                           ID = sc.Class.ClassID,
                           SID = sc.Class.SubjectCode,
                           Subject = sc.Class.Subject,
                           Teacher = (sc.Class.Teacher.FirstName + " " + sc.Class.Teacher.LastName),
                           Form = sc.Class.SchoolForm,
                           Term = sc.Class.Term,
                           Year = sc.Class.AcademicYear
                       });
            var rFrm = (from s in db.Students
                        join sc in db.StudentClasses on s.StudentID equals sc.StudentID
                        join c in db.Classes on sc.ClassID equals c.ClassID
                        where c.SchoolCode == skcode && c.FormID == frm
                        orderby c.ClassID ascending, c.AcademicYear ascending
                        select new
                        {
                            ID = sc.Class.ClassID,
                            SID = sc.Class.SubjectCode,
                            Subject = sc.Class.Subject,
                            Teacher = (sc.Class.Teacher.FirstName + " " + sc.Class.Teacher.LastName),
                            Form = sc.Class.SchoolForm,
                            Term = sc.Class.Term,
                            Year = sc.Class.AcademicYear
                        });


            if (yr == "" || trm <= 0 || sub > 0 || lec <=0 || frm <0)
            {
                if (rSub.Count() != 0)
                {
                    SKLclasslistGV.DataSource = rSub.ToList();
                    
                }
                else
                {
                    Empty();
                }
            }

            if (yr != "" && trm <= 0 && sub <= 0 && lec <= 0 && frm < 0)
            {
                if (rYr.Count() != 0)
                {
                    SKLclasslistGV.DataSource = rYr.ToList();
                    
                }
                else
                {
                    Empty();
                }
            }

            if (yr == "" & trm > 0 & sub <= 0 & lec <= 0 & frm < 0)
            {
                if (rTrm.Count() != 0)
                {
                    SKLclasslistGV.DataSource = rTrm.ToList();
                    
                }
                else
                {
                    Empty();
                }
            }
            if (yr != "" & trm <= 0 & sub <= 0 & lec > 0 & frm < 0)
            {
                if (rTeach.Count() != 0)
                {
                    SKLclasslistGV.DataSource = rTeach.ToList();
                   
                }
                else
                {
                    Empty();
                }
            }

            if (yr != "" & trm <= 0 & sub <= 0 & lec <= 0 & frm > 0)
            {
                if (rFrm.Count() != 0)
                {
                    SKLclasslistGV.DataSource = rFrm.ToList();
                    
                }
                else
                {
                    Empty();
                }
            }
            
        }

        private void Empty()
        {
            MessageBox.Show("No Records Found");
        }

        /// <summary>
        /// sets the grid back to its unfiltered 
        /// state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }
        /// <summary>
        /// adding a new form that is not 
        /// found in the list of forms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newFormbtn_Click(object sender, EventArgs e)
        {
            Validate(FormCB.Text);
        }

        /// <summary>
        /// check to see if the form exsists
        /// before calling the method to save a new form
        /// </summary>
        /// <param name="v"></param>
        private void Validate(string v)
        {
            var vill = db.SchoolForms.Where(x => x.FormName == v).Count();

            if (vill == 0)
            {
                try
                {
                    saveForm();

                    MessageBox.Show("Successful!");

                    FormCB.Focus();

                }
                catch (Exception)
                {
                    MessageBox.Show("Error - Cannot Be Saved");
                }

                MessageBox.Show("Duplicate Error \n\n Subject Exists");
            }
        }

        /// <summary>
        /// saves a new form for a school if the 
        /// form is not available from the list
        /// </summary>
    private void saveForm()
            {
            SchoolForm newForm = new SchoolForm()
            {
                FormID = db.SchoolForms.Max(v => v.FormID) + 1,
                FormName = ValidateName(FormCB.Text)
            };

            db.SchoolForms.Add(newForm);
            db.SaveChanges();

            }

    private void NewBtn_Click(object sender, EventArgs e)
    {
        NewID();
        reset();
    }

    private void EditBtn_Click(object sender, EventArgs e)
    {

    }
    }

}
