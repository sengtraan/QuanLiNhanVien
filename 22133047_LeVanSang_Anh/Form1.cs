using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22133047_LeVanSang_Anh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_ThongTinNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void btn_ChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pic_Anh.Image = Image.FromFile(opf.FileName);
            }
        }

        KetNoiDL kn = new KetNoiDL();

        public void LoadDuLieu()
        {
            string sql = "Select * From QuanLiNV";
            dg_DanhSach.DataSource = kn.taobang(sql);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kn.myConnect();
            LoadDuLieu();
        }

        private void btn_XemDanhSach_Click(object sender, EventArgs e)
        {
            LoadDuLieu();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            kn.Luu(txt_MaNV.Text, txt_TenNV.Text, pic_Anh.Image);
            txt_MaNV.ResetText();
            txt_TenNV.ResetText();
            pic_Anh.Image = null;
        }
    }
}
