using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    public partial class Class
    {
        public int CID { get; set; }
        public string Sub { get; set; }
        public string frm { get; set; }

        public string Display { get { return string.Format("{0}  {1}", Sub, frm); } }

    }
}
