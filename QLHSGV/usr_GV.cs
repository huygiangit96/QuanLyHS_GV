﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLHSGV.DAO;
using QLHSGV.EF;

namespace QLHSGV._GV
{
    public partial class usr_GV : UserControl
    {
        private static usr_GV _instance;
        

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
           

        }

        private void dtg_GiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien();
            gv.MaGV = tb_MaGV.Text;
            gv.HoTen = tb_HoTen.Text;
            gv.DiaChi = tb_DiaChi.Text;
            gv.MonHoc = cb_MonHoc.Text;
            gv.GT = cb_GT.Text;
            gv.NgaySinh = dt_NgaySinh.Value;
            bool add = new GiaoVienDAO().Insert(gv);
            if (!add) MessageBox.Show("Mã GV đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MessageBox.Show("Đã thêm giáo viên", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtg_GiaoVien.DataSource = new GiaoVienDAO().ListAll();
                tb_MaGV.Text = "";
                tb_HoTen.Text = "";
                tb_DiaChi.Text = "";

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dtg_GiaoVien.DataSource = new GiaoVienDAO().Search(textBox1.Text);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
