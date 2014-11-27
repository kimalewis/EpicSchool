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
    public partial class frmNewVillage : Form
    {
        SchoolsEntities db = new SchoolsEntities();
        int vID;
        string result;
        Village newVillage;
        List<Village> upVillage = new List<Village>();
        public const string spattern = @"^([a-zA-Z'.\s]{1,50})$";

        public frmNewVillage()
        {
            InitializeComponent();
        }

        private void frmNewVillage_Load(object sender, EventArgs e)
        {
            loadfrm();
        }

        private void loadfrm()
        {            
            listbind();
            disable();
            
        }

        private void NewID()
        {
            vID = db.Villages.Max(v => v.VillageID) + 1;
            vidTB.Text = vID.ToString();

        }

        private void listbind()
        {
            villageLB.DataSource = null;
            villageLB.DataSource = db.Villages.OrderBy(x=> x.VillageName).ToList();
            villageLB.DisplayMember = "VillageName";
            villageLB.ValueMember = "VillageID";

            villageLB.ClearSelected();

        }

        
        private bool checkID(int i)
        {
            bool res = false;
            var findID = db.Villages.Where(x => x.VillageID == i).ToList();
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
        private bool CheckTB()
        {
            bool result = true;
            if (String.IsNullOrEmpty(vidTB.Text)) { errorMsg.SetError(vidTB, "Firstname is missing."); result = false; vidTB.Focus(); } else { errorMsg.SetError(vidTB, ""); }
            return result;
        }
        private void Validate(int i, string v)
        {
            if (CheckTB())
            {
                if (checkID(Convert.ToInt32(vidTB.Text)))
                {
                    try
                    {
                        UpdateVillage();
                        MessageBox.Show("Changes Successful!");
                        disable();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Cannot commit changes, Please try again later", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        disable();

                    }
                    finally
                    {
                        listbind();

                    }
                }
                else
                {
                    try
                    {
                        NewVillage();
                        MessageBox.Show("Successful!");
                        disable();

                    }
                    catch
                    {
                        MessageBox.Show("Cannot Save User, Please try again later", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        listbind();
                    }

                }
            }
        }

        private void UpdateVillage()
        {
            int ID = Convert.ToInt32(vidTB.Text);
            upVillage = db.Villages.Where(v => v.VillageID == ID ).ToList();

            foreach (var i in upVillage)
            {
                i.VillageName = ValidateName(VillageTB.Text);
            }
            db.SaveChanges();

        }

        private void SaveSubjbtn_Click(object sender, EventArgs e)
        {
            Validate(Convert.ToInt32(vidTB.Text), VillageTB.Text);                       
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
                    VillageTB.Clear();
                    VillageTB.Focus();
                }
            }
            else
            {
                ValidData();
                VillageTB.Clear();
                VillageTB.Focus();

            }
            return result;
        }


        private void NewVillage()
        {
            newVillage = new Village()
            {
                VillageID = Convert.ToInt32(vidTB.Text),
                VillageName = ValidateName(VillageTB.Text)         
            };

            db.Villages.Add(newVillage);
            db.SaveChanges();
            

        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.VillageTB.Clear();
            this.VillageTB.Clear();
            this.Close();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            enable();
        }

        private void enable()
        {
            VillageTB.ReadOnly = false;
        }

        private void disable()
        {
            VillageTB.ReadOnly = true;
            //VillageTB.Clear();
        }
        

        private void villageLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (villageLB.SelectedIndex != -1)
            {
                string vill = villageLB.SelectedItem.ToString();
                var item = db.Villages.Where(v => v.VillageName == vill).ToList();
                foreach (var i in item)
                {
                    vidTB.Text = i.VillageID.ToString();
                    VillageTB.Text = i.VillageName;


                }

            }
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            enable();
            NewID();
            
        }


        
    }
}
