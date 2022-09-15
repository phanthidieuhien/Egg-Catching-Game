using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace _09_HuynhKimLoan_1951052102
{
    public partial class FormStart : Form
    {
        private SoundPlayer sPlClick;

        public FormStart()
        {
            InitializeComponent();
            sPlClick = new SoundPlayer("ting.wav");
        }

        private void btBatDau_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
            this.Show();
            f.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btGameTGian_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.ShowDialog();
            this.Show();
            f.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btDiemCao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Điểm cao nhất của màn chơi theo lượt là: " + ClassDiemCao.max2
                + "\nĐiểm cao nhất của màn chơi theo thời gian là: " + ClassDiemCao.max);
        }

        private void btHD_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHuongDan f = new FormHuongDan();
            f.ShowDialog();
            this.Show();
            f.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void FormStart_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát trò chơi??", "Thoát  trò chơi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btHD_MouseDown(object sender, MouseEventArgs e)
        {
            Button b = (Button)sender;
            sPlClick.Play();
        }

        private void btHD_MouseUp(object sender, MouseEventArgs e)
        {
            Button b = (Button)sender;
            sPlClick.Stop();
        }

        private void btHD_MouseHover(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Size = new Size(295,75);
        }

        private void btHD_MouseLeave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Size = new Size(286, 69);
        }

        private void btThoat_MouseHover(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Size = new Size(80, 60);
        }

        private void btThoat_MouseLeave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Size = new Size(72, 55);
        }

        
    }
}
