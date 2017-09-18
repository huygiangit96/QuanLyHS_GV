using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLHSGV.EF;
using QLHSGV.DAO;

namespace QLHSGV._TTGD
{
    public partial class usr_TTGD : UserControl
    {
        private static usr_TTGD _instance;
        private HSGVContext dt = new HSGVContext();

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
          
        }

        private void dtg_TTGD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
