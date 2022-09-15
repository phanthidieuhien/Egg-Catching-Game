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
using System.IO;

namespace _09_HuynhKimLoan_1951052102
{ 
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            soundPlayer = new SoundPlayer("music2.wav");
            sPlGameOver = new SoundPlayer("gameover.wav");
        }

        #region Biến TC
        SoundPlayer soundPlayer, sPlGameOver;
        int tocDo, diemSo, soLanRoi, a, b, second;
        
        string path = Application.StartupPath + @"\Images\";
        Random randX = new Random();
        Random randY = new Random();
        Point viTriCu;
        StreamWriter w;
        string duongDan = @"D:\KetQua.txt";
        bool tatAm, tamDung;
        #endregion

        private void BatDau()
        {
            soundPlayer.PlayLooping();

            foreach (Control c in this.Controls)
            {
                if (c is PictureBox && (string)c.Tag == "picEgg")
                {
                    c.Top = randY.Next(80, 300) * -1;
                    c.Left = randX.Next(20, this.ClientRectangle.Width - c.Width);
                    c.BackColor = Color.Transparent;
                }
            }

            picHung.Left = this.ClientRectangle.Width / 2;
            tatAm = false;
            btTatAm.BackgroundImage = Properties.Resources.unmute2;
            tamDung = false;
            diemSo = 0;
            soLanRoi = 0;
            tocDo = 8;
            picSub2.Hide();
            picAdd2.Hide();
            lbMinute.Text = "02";
            lbSecond.Text = "00";
            a = 0;
            b = 2;
            timer1.Start();
            timerDH.Start();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            BatDau();
        }

        private void PicAdd()
        {
            picAdd2.Top = randY.Next(80, 300) * -1;
            picAdd2.Left = randX.Next(20, this.ClientRectangle.Width - picAdd2.Width);

        }

        private void PicSub()
        {
            picSub2.Top = randY.Next(80, 300) * -1;
            picSub2.Left = randX.Next(20, this.ClientRectangle.Width - picSub2.Width);

        }

        private void timerDH_Tick(object sender, EventArgs e)
        {
            a = Int32.Parse(lbSecond.Text);
            b = Int32.Parse(lbMinute.Text);
            //Đếm ngược
            if (a > 0)
            {
                a--;
            }
            if (a == 0 && b > 0)
            {
                a = 60;
                lbSecond.Text = a.ToString();
                b--;
                lbMinute.Text = "0" + b.ToString();
                a--;
            }
            //Hết thời gian
            if (b == 0 && a == 0)
            {
                HetGio();
            }
            //Thêm, giảm thời gian
            if (diemSo > 14)
            {
                timerRand.Enabled = true;
                timerRand.Start();
            }

            switch (soLanRoi)
            {
                case 5:
                case 10:
                case 15:
                case 20:
                case 25:

                    a -= 10;
                    second = a + b * 60;
                    b = second % 3600 / 60;
                    a = second % 3600 % 60;
                    lbMinute.Text = "0" + b.ToString();
                    lbSecond.Text = a.ToString();

                    if (b == 0 && a < 0)
                    {
                        lbMinute.Text = "00";
                        lbSecond.Text = "00";
                        HetGio();
                    }
                    break;
                case 30:
                    HetGio();
                    break;
            }
            //Định dạng thời gian
            if (a < 10)
            {
                lbSecond.Text = "0" + a;
            }
            else
            {
                lbSecond.Text = a + "";
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbDiem.Text = "Score: " + diemSo;
            lbVo.Text = "Missed: " + soLanRoi;

            foreach (Control c in this.Controls)
            {
                if (c is PictureBox && (string)c.Tag == "picEgg")
                {
                    c.Top += tocDo;

                    if (c.Top + c.Height > this.ClientRectangle.Height)
                    {
                        soLanRoi += 1;
                        c.Top = randY.Next(80, 300) * -1;
                        c.Left = randX.Next(20, this.ClientRectangle.Width - c.Width);

                    }

                    if (picHung.Bounds.IntersectsWith(c.Bounds))
                    {
                        diemSo += 1;
                        c.Top = randY.Next(80, 300) * -1;
                        c.Left = randX.Next(20, this.ClientRectangle.Width - c.Width);

                    }
                }
            }
            //Tăng tốc độ
            if (diemSo > 15)
            {
                tocDo = 11;
            }
        }

        private void timerRand_Tick(object sender, EventArgs e)
        {
            ShowAnh();
        }
        
        private void ShowAnh()
        {
            //Trứng thêm thời gian
            picAdd2.Show();
            picAdd2.Top += tocDo;

            //Trứng giảm thời gian
            picSub2.Show();
            picSub2.Top += tocDo;
            
            //Di chuyển
            if (picAdd2.Top + picAdd2.Height > this.ClientRectangle.Height)
            {
                soLanRoi += 1;
                PicAdd();
            }
            //Va chạm
            if (picHung.Bounds.IntersectsWith(picAdd2.Bounds))
            {
                if (picAdd2.Top <= picHung.Top)
                {
                    a += 10;
                    diemSo += 1;
                    PicAdd();
                    second = a + b * 60;
                    b = second % 3600 / 60;
                    a = second % 3600 % 60;
                    lbMinute.Text = "0" + b.ToString();
                    lbSecond.Text = a.ToString();
                }
            }
            
            if (picSub2.Top + picSub2.Height > this.ClientRectangle.Height)
            {
                PicSub();
            }
            if (picHung.Bounds.IntersectsWith(picSub2.Bounds))
            {
                if (picSub2.Top <= picHung.Top)
                {
                    diemSo += 1;
                    PicSub();
                    if (a > 0)
                    {
                        a -= 20;
                        second = a + b * 60;
                        b = second % 3600 / 60;
                        a = second % 3600 % 60;
                        lbMinute.Text = "0" + b.ToString();
                        lbSecond.Text = a.ToString();
                    }
                    if (b == 0 && a < 0)
                    {
                        lbMinute.Text = "00";
                        lbSecond.Text = "00";
                        HetGio();
                    }
                }
            }
        }
        
        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Left:
                    if (picHung.Left > 0)
                        picHung.Left -= 12;
                    return true;
                case Keys.Right:
                    if (picHung.Right < ClientRectangle.Width)
                        picHung.Left += 12;
                    return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void btTatAm_Click(object sender, EventArgs e)
        {
            tatAm = !tatAm;
            if (tatAm)
            {
                btTatAm.BackgroundImage = Properties.Resources.mute2;
                soundPlayer.Stop();
            }
            else
            {
                btTatAm.BackgroundImage = Properties.Resources.unmute2;
                soundPlayer.Play();
            }
        }

        private void btTamDung_Click(object sender, EventArgs e)
        {
            tamDung = !tamDung;
            if (tamDung)
            {
                timer1.Stop();
                timerDH.Stop();
                timerRand.Stop();
                soundPlayer.Stop();
                btTamDung.BackgroundImage = Properties.Resources.resume;
            }
            else
            {
                timer1.Start();
                timerDH.Start();
                timerRand.Start();
                soundPlayer.Play();
                btTamDung.BackgroundImage = Properties.Resources.playing;
            }
        }

        private void btPlay_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timerDH.Stop();
            timerRand.Stop();
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn chơi lại không??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                BatDau();
                soundPlayer.PlayLooping();
            }
            else
            {
                if (tamDung)
                {
                    timer1.Stop();
                    timerDH.Stop();
                    timerRand.Stop();
                    soundPlayer.Stop();
                }
                else
                {
                    timer1.Start();
                    timerDH.Start();
                    timerRand.Start();
                    soundPlayer.Play();
                }
            }

        }

        private void picHung_MouseDown(object sender, MouseEventArgs e)
        {
            viTriCu = e.Location;
        }

        private void picHung_MouseMove(object sender, MouseEventArgs e)
        {
            int dx;

            if (e.Button == MouseButtons.Left)
            {
                dx = e.X - viTriCu.X;
                picHung.Left += dx;
                if (picHung.Right >= ClientRectangle.Width)
                    picHung.Left = ClientRectangle.Width - picHung.Width;
                if (picHung.Left <= 0)
                    picHung.Left = 0;
            }
        }

        private void HetGio()
        {
            sPlGameOver.PlaySync();
            timerDH.Stop();
            timer1.Stop();
            timerRand.Stop();
            
            MessageBox.Show("Trò chơi kết thúc!!" + Environment.NewLine + "Điểm: " + diemSo +
                Environment.NewLine + "Số trứng bị rơi: " + soLanRoi);
            //Kiểm tra có file -> tạo mới
            if (MessageBox.Show("Bạn có muốn lưu lại điểm số?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (diemSo > ClassDiemCao.max)
                {
                    ClassDiemCao.max = diemSo;
                }

                if (!File.Exists(duongDan))
                {
                    using (w = File.CreateText(duongDan))//tạo mới 1 file)
                    {
                        w.WriteLine(lbDiem.Text + " " + lbVo.Text + " " + "DateTime: " +
                           DateTime.Now);
                    }
                }
                //Nếu có rồi ghi đè
                else
                {
                    using (w = File.AppendText(duongDan))
                    {
                        w.WriteLine(lbDiem.Text + " " + lbVo.Text + " " + "DateTime: " +
                            DateTime.Now);
                    }
                }
                MessageBox.Show("Lưu thành công");
            }
            if (MessageBox.Show("Bạn có muốn chơi lại không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                this.Close();
            }
            else
            {
                BatDau();
            }
            
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timerDH.Stop();
            timerRand.Stop();
            soundPlayer.Stop();
            this.Close();
        }
        
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát khỏi màn chơi này??", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
                BatDau();
            }
           
        }

        private void btPlay_MouseHover(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Size = new Size(45, 45);
        }

        private void btPlay_MouseLeave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Size = new Size(40, 40);
        }
    }
}
