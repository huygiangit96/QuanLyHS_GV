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

namespace QLHSGV._HS
{
    public partial class usr_HS : UserControl
    {
        private static usr_HS _instance;
        private QLHSGVEntities dt = new QLHSGVEntities();

        public static usr_HS Instance
        {
            get
            {
                if (_instance == null) _instance = new usr_HS();
                return _instance;
            }

            set
            {
                _instance = value;
            }
        }

        public usr_HS()
        {
            InitializeComponent();
        }

        private void usr_HS_Load(object sender, EventArgs e)
        {
            var query = dt.HocSinhs;
           
            
        }
    }
}
