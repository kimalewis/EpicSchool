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
    public partial class frmNewSubject : Form
    {
        SchoolsEntities db = new SchoolsEntities();
        int subID;
        string result;
        Subject newSubject;
        public const string spattern = @"^([a-zA-Z'.\s]{1,50})$";

        public frmNewSubject()
        {
            InitializeComponent();
        }

        private void frmnewSubject_Load(object sender, EventArgs e)
        {
            loadfrm();
            listbind();
            subNameTB.Focus();
        }

        private void loadfrm()
        {
            subID = db.Subjects.Max(s => s.SubjectCode) + 1;
            subIDTB.Text = subID.ToString();
        }

        private void listbind()
        {
            subjectLB.DataSource = null;
            subjectLB.DataSource = db.Subjects.Select(x => x.SubjectName).Distinct().ToList();
            subjectLB.DisplayMember = "SubjectName";
        }

        private void SaveSubjbtn_Click(object sender, EventArgs e)
        {
            saveSubject();
        }

        private void saveSubject()
        {
            newSubject = new Subject()
            {
            SubjectCode = Convert.ToInt32(subIDTB.Text),
            SubjectName = ValidateName(subNameTB.Text)
            };

            db.Subjects.Add(newSubject);
            db.SaveChanges();
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.subIDTB.Clear();
            this.subNameTB.Clear();
            this.Close();
        }

        private void SaveSubjbtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                saveSubject();
                loadfrm();
                subNameTB.Clear();

                MessageBox.Show("Contact Successfully Added to Villages!");

                subNameTB.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Village entered - Cannot Be Saved");
            }
        }

        private void ValidData()
        {
            MessageBox.Show("Please enter Valid Data");
        }

        public string ValidateName(string input)
        {

            if (input != null)
            {

                if (Regex.IsMatch(input, spattern) == true)
                {
                    result = input;
                }
                else
                {
                    ValidData();
                    subNameTB.Clear();
                    subNameTB.Focus();
                }
            }
            else
            {
                ValidData();
                subNameTB.Clear();
                subNameTB.Focus();

            }
            return result;
        }
    
    }
}
