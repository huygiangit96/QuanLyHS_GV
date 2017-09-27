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
        //duc hung
        private void button1_Click(object sender, EventArgs e)
        {
          
           ThongTinGiangDay gv = new ThongTinGiangDay();
            bool add = false;
            try
            {
                gv.MaKip = textBox1.Text;
                gv.MaGV = new GiaoVienDAO().GetIDbyName(comboBox1.Text);
                gv.SoTiet = Convert.ToInt32(textBox3.Text);
                gv.TenLop = comboBox2.Text;
                gv.MonHoc = textBox2.Text;
                gv.Ngay = dateTimePicker1.Value;
                add = new ThongTinGiangDayDAO().Insert(gv);
            }
            catch
            {

            }
            if (!add) MessageBox.Show("Mã kíp đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MessageBox.Show("Đã thêm lịch", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtg_TTGD.DataSource = new ThongTinGiangDayDAO().ListAll();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
           ThongTinGiangDay gv = new ThongTinGiangDay();
            bool edit =false;
            try
            {
                gv.MaKip = textBox1.Text;
                gv.MaGV = new GiaoVienDAO().GetIDbyName(comboBox1.Text);
                gv.SoTiet = Convert.ToInt32(textBox3.Text);
                gv.TenLop = comboBox2.Text;
                gv.MonHoc = textBox2.Text;
                gv.Ngay = dateTimePicker1.Value;
                edit = new ThongTinGiangDayDAO().Update(gv);
            }
            catch
            {

            }
            if (!edit) MessageBox.Show("Không tồn tại kíp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MessageBox.Show("Đã sửa", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtg_TTGD.DataSource = new ThongTinGiangDayDAO().ListAll();
            }

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
