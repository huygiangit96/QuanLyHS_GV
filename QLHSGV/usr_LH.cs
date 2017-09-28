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

namespace QLHSGV._LH
{
    public partial class usr_LH : UserControl
    {
        private static usr_LH _instance;
        private HSGVContext dt = new HSGVContext();

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
           

        }

        private void dtg_LopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LopHoc gv = new LopHoc();
            gv.TenLop = textBox1.Text;
            gv.QSo = Convert.ToInt32(textBox2.Text);

            bool add = new LopHocDAO().Insert(gv);
            if (!add) MessageBox.Show("Lớp đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MessageBox.Show("Đã thêm lớp", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtg_LopHoc.DataSource = new LopHocDAO().ListAll();
                textBox1.Text = "";
                textBox2.Text = "";
            }

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
    }
}
