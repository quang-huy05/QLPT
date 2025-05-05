using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đồ_Án
{
    public partial class frmXemPhong : Form
    {

        public frmXemPhong()
        {
            InitializeComponent();

        }




        private void lblUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnUpAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                picAnhPhong.Image = Image.FromFile(filePath);

                picAnhPhong.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void frmXemPhong_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
