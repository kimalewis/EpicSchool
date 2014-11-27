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
    public partial class frmClassSchedule : Form
    {
        SchoolsEntities db = new SchoolsEntities();
        public int id, ccode, count;

        public frmClassSchedule()
        {
            InitializeComponent();
        }
        /// <summary>
        /// calls the method to load the form with data pertaining to a class
        /// such as a class day and time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmClassSchedule_Load(object sender, EventArgs e)
        {
            loadclassSchedule(Convert.ToInt32(uIDlbl.Text));
        }

        private void loadclassSchedule(int i)
        {
            var classSchedule = from cl in db.Classes
                                join cs in db.ClassesSchedules on cl.ClassID equals cs.ClassID
                                where cs.ClassID == i 
                                select new
                                {
                                    Day = cs.Day,
                                    Start = cs.StartTime,
                                    End = cs.EndTime
                                };
            count = classSchedule.Count();

            if (count == 0)
            {
                MessageBox.Show("No Classes scheduled");
                this.Close();
            }
            else
            {
                this.ClassScheduleGV.DataSource = classSchedule.OrderByDescending(d => d.ID).ToList();

            }

        }
    }
}
