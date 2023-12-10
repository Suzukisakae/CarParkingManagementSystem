﻿using CarParkingManagementSystem.BSLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarParkingManagementSystem
{
    public partial class formCustomerOfAttendant : Form
    {
        Attendant attendant = new Attendant();
        public string IDNV;

        public formCustomerOfAttendant(string id)
        {
            InitializeComponent();
            IDNV = id;
        }

        public void LoadData()
        {
            try
            {
                this.dtgChitietCanhan.DataSource = attendant.GetAllThongTinCaNhan(IDNV);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table Khách hàng. Lỗi rồi!!!");
            }
        }

        private void formCustomerOfAttendant_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtFind_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = attendant.TimKiemThongTinCaNhan(IDNV, txtFind.Text);
                dtgChitietCanhan.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Không tìm thấy!");
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
