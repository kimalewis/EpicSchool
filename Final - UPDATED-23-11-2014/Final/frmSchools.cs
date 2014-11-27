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
    public partial class frmSchools : Form
    {
        SchoolsEntities db = new SchoolsEntities();
        List<School> school = new List<School>();
        School newSchool;
        Village newVillage;
        int sID, newID, ID;
        string result;
        public const string pattern = @"^\w[a-z,A-Z\'\-\.\s]+$";
        public const string epattern = @"^(([\w\.\d\-]+)@(\w\D+))$";
        public const string ppattern = @"^\(\d{3}\)(\s)?\d{3}-\d{4}";
        public const string spattern = @"^[A-Za-z0-9\s\.\'\,]+$";
        public frmSchools()
        {
            InitializeComponent();
        }

        private void frmSchools_Load(object sender, EventArgs e)
        {
            fill();
        }

        private void fill()
        {
            VillageCB.DataSource = null;
            VillageCB.DataSource = db.Villages.OrderBy(x => x.VillageName).ToList();
            VillageCB.DisplayMember = "VillageName";
            VillageCB.ValueMember = "VillageID";
            VillageCB.SelectedIndex = -1;

            ParishCB.DataSource = db.Parishes.ToList();
            ParishCB.DisplayMember = "ParishName";
            ParishCB.ValueMember = "ParishID";
            ParishCB.SelectedIndex = -1;

            SchoolsListGV.DataSource = db.Schools.ToList();
            hidecols();
            
        }

        private void hidecols()
        {
            SchoolsListGV.Columns["OfficeNumber"].Visible = false;
            SchoolsListGV.Columns["VillageID"].Visible = false;
            SchoolsListGV.Columns["Village"].Visible = false;
            SchoolsListGV.Columns["ParishID"].Visible = false;
            SchoolsListGV.Columns["Parish"].Visible = false;
            SchoolsListGV.Columns["AdministrativeStaffs"].Visible = false;
            SchoolsListGV.Columns["Principals"].Visible = false;
            SchoolsListGV.Columns["Teachers"].Visible = false;
            SchoolsListGV.Columns["Students"].Visible = false;
            SchoolsListGV.Columns["Classes"].Visible = false;
        
        }

        private void NewSubbtn_Click(object sender, EventArgs e)
        {
            Validate(VillageCB.Text);
        }

        private void saveVillage()
        {
            newVillage = new Village()
            {
                VillageID = db.Villages.Max(v=>v.VillageID)+1,
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
                    MessageBox.Show("Village Entered - Cannot Be Saved");
                }
                
            }
        }

        private void NewParishBtn_Click(object sender, EventArgs e)
        {
            frmNewParish newPar = new frmNewParish();
            newPar.Show();
        }

        private void SeachTB_TextChanged(object sender, EventArgs e)
        {
            SchoolsListGV.DataSource = db.Schools.Where(s => s.SchoolName.ToLower().Contains(SearchTB.Text)).ToList();
        }

        private void SchoolsListGV_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void LoadSchool()
        {
            school = db.Schools.Where(s => s.SchoolCode == sID).ToList();
            foreach (var v in school)
            {
                skCodeTB.Text = v.SchoolCode.ToString();
                schoolTB.Text = v.SchoolName;
                EmailTB.Text = v.Email;
                OfficeTB.Text = v.OfficeNumber;
                VillageCB.Text = v.Village.ToString();
                ParishCB.Text = v.Parish.ToString();
            }

            var principal = from p in db.Principals
                            where p.SchoolCode == sID
                            select new
                            {
                                ID = p.PrincipalID,
                                Name = p.Firstname +" "+ p.Lastname,
                                Tenure = p.Tenure
                            };
           
            PrinicipalGV.DataSource = principal.ToList();
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            NewClearTB();
        }

        private void NewClearTB()
        {
            newID = db.Schools.Max(m => m.SchoolCode) + 1;
            skCodeTB.Text = newID.ToString();
            schoolTB.Clear();
            EmailTB.Clear();
            OfficeTB.Clear();
            ParishCB.SelectedIndex = -1;
            VillageCB.SelectedIndex = -1;
            NewVillagebtn.Visible = true;
           
                     
            enable();
            PrinicipalGV.DataSource = null;

        }
        private void enable()
        {
            skCodeTB.ReadOnly = true;
            schoolTB.Focus();
            schoolTB.ReadOnly = false;
            EmailTB.ReadOnly = false;
            OfficeTB.ReadOnly = false;
            VillageCB.Enabled = true;
            ParishCB.Enabled = true;
            
        }
        private void disable()
        {
            skCodeTB.ReadOnly = true;
            EmailTB.ReadOnly = true;
            OfficeTB.ReadOnly = true;
            VillageCB.Enabled = false;
            ParishCB.Enabled = false;

        }

        private bool CheckTB()
        {
            bool result = true;
            if (String.IsNullOrEmpty(skCodeTB.Text)) { errorMsg.SetError(skCodeTB, "Firstname is missing."); result = false; skCodeTB.Focus(); } else { errorMsg.SetError(skCodeTB, ""); }
            return result;
        }

        private bool checkID(int i)
        {
            bool res = false;
            var findID = db.Schools.Where(x => x.SchoolCode == i).ToList();
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

        public string ValidatePhone(string input)
        {
            if (input != null)
            {

                if (Regex.IsMatch(input, ppattern))
                {
                    result = input;
                }
                else
                {
                    ValidData();
                    OfficeTB.Focus();
                }
            }
            else
            {
                ValidData();
                OfficeTB.Focus();
            }
            return result;
        }

        private void ValidData()
        {
            MessageBox.Show("Please enter valid data");
        }

        private void SaveSchool()
        {
            newSchool = new School
            {
                ParishID = Convert.ToInt32(ParishCB.SelectedValue),
                SchoolCode = Convert.ToInt32(skCodeTB.Text),
                SchoolName = ValidateName(skCodeTB.Text),
                OfficeNumber = OfficeTB.Text == null ? null : ValidatePhone(OfficeTB.Text),
                Email = EmailTB.Text == null ? null : ValidateEmail(EmailTB.Text),
                VillageID = Convert.ToInt32(VillageCB.SelectedValue)                
            };
            db.Schools.Add(newSchool);
            db.SaveChanges();

        }
        private void UpdateUser()
        {
            school = db.Schools.Where(p => p.SchoolCode == sID).ToList();

            foreach (var u in school)
            {
                u.SchoolName = ValidateName(skCodeTB.Text);
                u.Email = EmailTB.Text == null ? null : ValidateEmail(EmailTB.Text);
                u.OfficeNumber = OfficeTB.Text == null ? null : ValidatePhone(OfficeTB.Text);
                u.VillageID = Convert.ToInt32(VillageCB.SelectedValue);
                u.ParishID = Convert.ToInt32(ParishCB.SelectedValue);
            }
            db.SaveChanges();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (CheckTB())
            {
                if (checkID(Convert.ToInt32(skCodeTB.Text)))
                {
                    try
                    {
                        UpdateUser();
                        MessageBox.Show("Changes Successful!");
                        fill();
                        disable();
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
                            SaveSchool();
                            MessageBox.Show("Successful!");
                            fill();
                            disable();

                        }
                        catch
                        {
                            MessageBox.Show("Cannot Save User, Please try again later", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    
                }
            }

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            enable();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            disable();
        }

        private void SchoolsListGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sID = Int32.Parse(SchoolsListGV.Rows[e.RowIndex].Cells["SchoolCode"].Value.ToString());
            LoadSchool();
        }
    }
}
