using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLHSGV.Data;

namespace QLHSGV._GV
{
    public partial class usr_GV : UserControl
    {
        private static usr_GV _instance;
        private QLHSGVEntities dt = new QLHSGVEntities();

        public static usr_GV Instance
        {
            get
            {
                if (_instance == null) _instance = new usr_GV();
                return _instance;
            }

            set
            {
                _instance = value;
            }
        }

        public usr_GV()
        {
            InitializeComponent();
        }

        private void usr_GV_Load(object sender, EventArgs e)
        {
            var query = dt.GiaoViens;
        }
    }
}
