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
    public partial class frmNewSchoolForm : Form
    {
        SchoolsEntities db = new SchoolsEntities();
        int sfID;
        string result;
        SchoolForm newForm;
        public const string spattern = @"^([A-Z,\d]{1,3})$";
        public frmNewSchoolForm()
        {
            InitializeComponent();
        }

        private void frmNewSchoolForm_Load(object sender, EventArgs e)
        {
            loadfrm();
        }

        private void loadfrm()
        {
            sfID = db.SchoolForms.Max(s => s.FormID) + 1;
            sFormIDTB.Text = sfID.ToString();
            listbind();
        }

        private void listbind()
        {
            SchoolfrmsLB.DataSource = db.SchoolForms.Distinct().ToList();
            SchoolfrmsLB.DisplayMember = "Forms";
            SchoolfrmsLB.SelectedIndex = -1;
        }

        private void SaveSubjbtn_Click(object sender, EventArgs e)
        {
            try
            {
                saveForm();
                loadfrm();
                sFormTB.Clear();

                MessageBox.Show("Successfully Added to Forms!");

                sFormTB.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR" + "\n\n" + "Form entered cannot be saved");
            }

        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.sFormIDTB.Clear();
            this.sFormTB.Clear();
            this.Close();
        }

        private void saveForm()
        {

            newForm = new SchoolForm()
            {
                FormID = Convert.ToInt32(sFormIDTB.Text),
                FormName = ValidateName(sFormTB.Text)
            };
            db.SchoolForms.Add(newForm);
            db.SaveChanges();
        }
        private void ValidData()
        {
            MessageBox.Show("Please enter Valid Data");
        }

        private string ValidateName(string input)
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
                    sFormTB.Clear();
                    sFormTB.Focus();
                }
            }
            else
            {
                ValidData();
                sFormTB.Clear();
                sFormTB.Focus();

            }
            return result;
        }
    }
}
