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

namespace QLHSGV._TTGD
{
    public partial class usr_TTGD : UserControl
    {
        private static usr_TTGD _instance;
        private QLHSGVEntities dt = new QLHSGVEntities();

        public static usr_TTGD Instance
        {
            get
            {
                if (_instance == null) _instance = new usr_TTGD();
                return _instance;
            }

            set
            {
                _instance = value;
            }
        }

        public usr_TTGD()
        {
            InitializeComponent();
        }

        private void usr_TTGD_Load(object sender, EventArgs e)
        {
            var query = dt.ThongTinGiangDays;
        }
    }
}
