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
    public partial class frmNewParish : Form
    {
        SchoolsEntities db = new SchoolsEntities();
        int pID;
        string result;
        Parish newParish;
        public const string spattern = @"^([a-zA-Z'.\s]{1,50})$";

        public frmNewParish()
        {
            InitializeComponent();
        }

        private void frmNewParish_Load(object sender, EventArgs e)
        {
            loadfrm();
        }
        private void loadfrm()
        {
            pID = db.Parishes.Max(p=> p.ParishID) + 1;
            pidTB.Text = pID.ToString();
            listbind();
        }

        private void listbind()
        {
            ParishLB.DataSource = db.Parishes.Distinct().ToList();
            ParishLB.DisplayMember = "ParishName";
            ParishLB.SelectedIndex = -1;
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.pidTB.Clear();
            this.ParishTB.Clear();
            this.Close();
        }

        private void SaveSubjbtn_Click(object sender, EventArgs e)
        {
            try
            {
                saveParish();
                loadfrm();
                ParishTB.Clear();

                MessageBox.Show("Successfully Added to Parishes!");

                ParishTB.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR"+"\n\n" +"Parish entered cannot be saved");
            }
        }

        private void saveParish()
        {

	    newParish = new Parish()
        {
            ParishID = Convert.ToInt32(pidTB.Text),
            ParishName = ValidateName(ParishTB.Text)
        };
            db.Parishes.Add(newParish);
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
                    ParishTB.Clear();
                    ParishTB.Focus();
                }
            }
            else
            {
                ValidData();
                ParishTB.Clear();
                ParishTB.Focus();

            }
            return result;
        }
    }
}
