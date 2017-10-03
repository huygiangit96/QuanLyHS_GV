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

namespace QLHSGV._LH
{
    public partial class usr_LH : UserControl
    {
        private static usr_LH _instance;
        private QLHSGVEntities dt = new QLHSGVEntities();

        public static usr_LH Instance
        {
            get
            {
                if (_instance == null) _instance = new usr_LH();
                return _instance;
            }

            set
            {
                _instance = value;
            }
        }

        public usr_LH()
        {
            InitializeComponent();
        }

        private void usr_LH_Load(object sender, EventArgs e)
        {
            var query = dt.LopHocs;
        }
    }
}
