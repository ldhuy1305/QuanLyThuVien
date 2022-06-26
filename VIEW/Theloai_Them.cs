﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVien.BLL;

namespace QuanLyThuVien.VIEW
{
    public partial class Theloai_Them : Form
    {
        public delegate void reload();
        public reload _reload;
        public Theloai_Them()
        {
            InitializeComponent();
            GUI();
        }

        public void GUI()
        {
            string matheloaimoi = BLL_ID.Instance.convertInt2Ma(BLL_ID.Instance.kiemTraViTriCoTheThem(BLL_SACH.Instance.getAllMaTheLoai()));
            lbMaTheLoaiMoi.Text = matheloaimoi;
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {

            //
            _reload();
            GUI();
        }
    }
}
