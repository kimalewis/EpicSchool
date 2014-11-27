using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class Alerts
    {
        SchoolsEntities db = new SchoolsEntities();

        /// <summary>
        /// updates a student's Approval Status by a Teacher
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status"></param>
        /// <param name="aBy"></param>
        public void Change(int id, string status, int aBy)
        {
            foreach (var i in db.StudentClasses)
            {
                if (i.StudentClassesID == id)
                {
                    i.Status = status;
                    i.ApprovedBy = aBy;

                }
            }
            db.SaveChanges();
        }
        /// <summary>
        /// changes a user's password
        /// </summary>
        /// <param name="id"></param>
        /// <param name="oldp"></param>
        /// <param name="newp"></param>
        public void passChange (int id, string oldp, string newp)
        {
            foreach (var i in db.Users)
            {
                if (i.UserID == id && oldp != newp)
                {
                    i.Password = newp;
                }             
            }
            db.SaveChanges();
           
            
        }
    }
}
