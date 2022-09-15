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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            soundPlayer = new SoundPlayer("Little-Girl-Beat.wav");
            sPlBoom = new SoundPlayer("boom1.wav");
            sPlGameOver = new SoundPlayer("gameover.wav");
        }

        #region Biến TC
        SoundPlayer soundPlayer, sPlBoom, sPlGameOver;
        PictureBox[] picTrung = new PictureBox[4];
        PictureBox picTrung1 = new PictureBox(), picTrung2 = new PictureBox(), picTrung3 = new PictureBox(), picTrung4 = new PictureBox();
        PictureBox broken, boom;
        Random rand;
        Point viTriRoCu;
        string path;
        int tocDo, diem, mang;
        bool tamDung, tatAm;
        StreamWriter w;
        string duongDan = @"D:\KetQua.txt";
        #endregion

        private void picRoTrung_MouseDown(object sender, MouseEventArgs e)
        {
            viTriRoCu = e.Location;
        }

        private void picRoTrung_MouseMove(object sender, MouseEventArgs e)
        {
            int dx;
            if (e.Button == MouseButtons.Left)
            {
                dx = e.X - viTriRoCu.X;
                picRoTrung.Left += dx;

                if (picRoTrung.Right >= panelGame.Width)
                    picRoTrung.Left = panelGame.Width - picRoTrung.Width;
                if (picRoTrung.Left <= 0)
                    picRoTrung.Left = 0;
            }
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            soundPlayer.PlayLooping();
            rand = new Random();
            path = Application.StartupPath + @"\Images\";
            picRoTrung.Image = Image.FromFile(path + "RoTrung.png");
            picRoTrung.SizeMode = PictureBoxSizeMode.StretchImage;
            picRoTrung.BackColor = Color.Transparent;

            picTrung[0] = picTrung1;
            picTrung[1] = picTrung2;
            picTrung[2] = picTrung3;
            picTrung[3] = picTrung4;

            broken = new PictureBox();
            broken.Size = new Size(50, 50);
            broken.BackColor = Color.Transparent;
            broken.Image = Image.FromFile(path + "broken.png");
            broken.SizeMode = PictureBoxSizeMode.StretchImage;

            boom = new PictureBox();
            boom.Size = new Size(50, 50);
            boom.BackColor = Color.Transparent;
            boom.Image = Image.FromFile(path + "boom.png");
            boom.SizeMode = PictureBoxSizeMode.StretchImage;
            this.panelGame.Controls.Add(boom);
            KhoiTao();
        }

        private void KhoiTao()
        {
            tocDo = 8;
            tamDung = false;
            tatAm = false;
            diem = 0;
            mang = 0;

            boom.Location = new Point(rand.Next(panelGame.Width - boom.Width), -50);
            picTrung1.Location = new Point(rand.Next(0, panelGame.Width / 4 - 40), rand.Next(100, 350) * -1);
            picTrung2.Location = new Point(rand.Next(panelGame.Width / 4, panelGame.Width / 4 * 2 - 40), rand.Next(50, 300) * -1);
            picTrung3.Location = new Point(rand.Next(panelGame.Width / 4 * 2, panelGame.Width / 4 * 3 - 40), rand.Next(100, 400) * -1);
            picTrung4.Location = new Point(rand.Next(panelGame.Width / 4 * 3, panelGame.Width - picTrung4.Width), rand.Next(50, 350) * -1);

            picRoTrung.Left = panelGame.ClientSize.Width / 2;
            picRoTrung.Image = Image.FromFile(path + "RoTrung.png");
            pic1.Image = pic2.Image = pic3.Image = pic4.Image = pic5.Image = Image.FromFile(path + "6.png");
            btTatAm.BackgroundImage = Properties.Resources.unmute;

            foreach (PictureBox item in picTrung)
            {
                item.Image = Image.FromFile(path + rand.Next(1, 11) + ".png");
                item.SizeMode = PictureBoxSizeMode.StretchImage;
                item.Size = new Size(40, 50);
                item.BackColor = Color.Transparent;
                this.panelGame.Controls.Add(item);
            }
        }
        private void btThoat_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();

            DialogResult dialogResult = MessageBox.Show("Bạn có muốn khỏi màn chơi này không???", 
                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                timer1.Stop();
                timer2.Stop();
                soundPlayer.Stop();
            }
            else
            {
                timer1.Start();
                timer2.Start();
            }    

        }
        private void RandomTrung(PictureBox p)
        {
            p.Top = rand.Next(50, 250) * -1;
            p.Image = Image.FromFile(path + rand.Next(1, 11) + ".png");
            if (p.Name == "picTrung1")
                p.Left = rand.Next(0, panelGame.Width / 4 - 40);
            if (p.Name == "picTrung2")
                p.Left = rand.Next(panelGame.Width / 4, panelGame.Width / 4 * 2 - 40);
            if (p.Name == "picTrung3")
                p.Left = rand.Next(panelGame.Width / 4 * 2, panelGame.Width / 4 * 3) - 40;
            if (p.Name == "picTrung4")
                p.Left = rand.Next(panelGame.Width / 4 * 3, panelGame.Width - p.Width);
        }

        private void DiChuyenTrung()
        {
            foreach (PictureBox p in picTrung)
            {
                if (p.Bottom >= panelGame.Height)
                {
                    broken.Location = p.Location;
                    broken.Top = panelGame.Height - broken.Height;
                    this.panelGame.Controls.Add(broken);
                    RandomTrung(p);
                    mang += 1;
                }
                p.Top += tocDo;
            }


            switch (diem)
            {
                case 1:
                    picRoTrung.Image = Image.FromFile(path + "r1.png");
                    break;
                case 2:
                    picRoTrung.Image = Image.FromFile(path + "r2.png");
                    break;
                case 3:
                    picRoTrung.Image = Image.FromFile(path + "r3.png");
                    break;
                case 4:
                    picRoTrung.Image = Image.FromFile(path + "r4.png");
                    break;
                case 5:
                    picRoTrung.Image = Image.FromFile(path + "r5.png");
                    break;

                case 7:
                    panelGame.BackColor = Color.LavenderBlush;
                    panel1.BackColor = Color.LavenderBlush;
                    tocDo++;
                    break;
                case 14:
                    panelGame.BackColor = Color.LemonChiffon;
                    panel1.BackColor = Color.LemonChiffon;
                    tocDo++;
                    break;
                case 21:
                    panelGame.BackColor = Color.LightSalmon;
                    tocDo++;
                    break;
                case 28:
                    panelGame.BackColor = Color.Aquamarine;
                    tocDo++;
                    break;
                case 35:
                    panelGame.BackColor = Color.White;
                    tocDo++;
                    break;
            }
        }

        private void KiemTraVaCham()
        {
            foreach (PictureBox p in picTrung)
            {
                if (picRoTrung.Bounds.IntersectsWith(p.Bounds))
                {
                    diem++;
                    RandomTrung(p);
                }
            }

            if (picRoTrung.Bounds.IntersectsWith(boom.Bounds))
            {
                boom.Location = new Point(rand.Next(panelGame.Width - boom.Width), rand.Next(100, 400) * -1);
                lbDiem.Text = diem.ToString();
                mang += 1;
                soundPlayer.Stop();
                sPlBoom.PlaySync();
                if (tatAm == false)
                {
                    btTatAm.BackgroundImage = Properties.Resources.unmute;
                    soundPlayer.PlayLooping();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbDiem.Text = "Score: " + diem;
            DiChuyenTrung();
            KiemTraVaCham();
            path = Application.StartupPath + @"\Images\";
            switch (mang)
            {
                case 1:
                    pic1.Image = Image.FromFile(path + "eggbroken.png");
                    pic1.BackColor = Color.Transparent;
                    break;
                case 2:
                    pic2.Image = Image.FromFile(path + "eggbroken.png");
                    pic2.BackColor = Color.Transparent;
                    break;
                case 3:
                    pic3.Image = Image.FromFile(path + "eggbroken.png");
                    pic3.BackColor = Color.Transparent;
                    break;
                case 4:
                    pic4.Image = Image.FromFile(path + "eggbroken.png");
                    pic4.BackColor = Color.Transparent;
                    break;
                case 5:
                    pic5.Image = Image.FromFile(path + "eggbroken.png");
                    pic5.BackColor = Color.Transparent;
                    soundPlayer.Stop();
                    timer1.Stop();
                    timer2.Stop();
                    soundPlayer.Stop();
                    LuuDiem();

                    DialogResult dialogResult = MessageBox.Show("Bạn có muốn chơi lại không??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        KhoiTao();
                        timer1.Start();
                        timer2.Start();
                        soundPlayer.Play();
                    }
                    else
                        this.Close();
                    break;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if ((boom.Right <= picTrung1.Right + 20 && boom.Left >= picTrung1.Left - 20) ||
                 (boom.Right <= picTrung2.Right + 20 && boom.Left >= picTrung2.Left - 20) ||
                 (boom.Right <= picTrung3.Right + 20 && boom.Left >= picTrung3.Left - 20) ||
                 (boom.Right <= picTrung4.Right + 20 && boom.Left >= picTrung4.Left - 20))
                boom.Location = new Point(rand.Next(panelGame.Width - boom.Width), rand.Next(100, 400) * -1);
            else
                boom.Top += tocDo - 1;

            if (boom.Top >= panelGame.Height - boom.Height)
                boom.Location = new Point(rand.Next(panelGame.Width - boom.Width), rand.Next(100, 400) * -1);
        }
        private void btPlay_Click(object sender, EventArgs e)
        {
            
            timer1.Stop();
            timer2.Stop();
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn chơi lại không??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                KhoiTao();
                soundPlayer.PlayLooping();
            }
            else
            {
                if (tamDung)
                {
                    timer1.Stop();
                    timer2.Stop();
                    soundPlayer.Stop();
                }
                else
                {
                    timer1.Start();
                    timer2.Start();
                    soundPlayer.PlayLooping();
                }
            }
        }

        private void btTamDung_Click(object sender, EventArgs e)
        {
            tamDung = !tamDung;
            if (tamDung)
            {
                timer1.Stop();
                timer2.Stop();
                soundPlayer.Stop();
                btTamDung.BackgroundImage = Properties.Resources.resume;
            }
            else
            {
                timer1.Start();
                timer2.Start();
                soundPlayer.PlayLooping();
                btTamDung.BackgroundImage = Properties.Resources.playing;
            }
        }


        private void btTatAm_Click(object sender, EventArgs e)
        {
            tatAm = !tatAm;
            if (tatAm)
            {
                btTatAm.BackgroundImage = Properties.Resources.mute;
                soundPlayer.Stop();
                sPlBoom.Stop();
            }
            else
            {
                btTatAm.BackgroundImage = Properties.Resources.unmute;
                soundPlayer.PlayLooping();
            }
        }

        

        private void LuuDiem()
        {
            sPlGameOver.PlaySync();

            //Kiểm tra có file -> tạo mới
            if (MessageBox.Show("Trò chơi kết thúc!!!" + Environment.NewLine + "Điểm: " + diem + Environment.NewLine
                + "Bạn có muốn lưu lại điểm số?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (diem > ClassDiemCao.max2)
                {
                    ClassDiemCao.max2 = diem;
                }

                if (!File.Exists(duongDan))
                {
                    using (w = File.CreateText(duongDan))//tạo mới 1 file)
                    {
                        w.WriteLine(lbDiem.Text + " " + "DateTime: " +
                           DateTime.Now);
                    }
                }
                //Nếu có rồi ghi đè
                else
                {
                    using (w = File.AppendText(duongDan))
                    {
                        w.WriteLine(lbDiem.Text + " " + "DateTime: " +
                            DateTime.Now);
                    }
                }
                MessageBox.Show("Lưu thành công!!!");
            }

        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Left:
                    if (picRoTrung.Left > 0)
                        picRoTrung.Left -= 9;
                    return true;
                case Keys.Right:
                    if (picRoTrung.Right < panelGame.Width)
                        picRoTrung.Left += 9;
                    return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void btTatAm_MouseHover(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Size = new Size(50, 55);
        }

        private void btTatAm_MouseLeave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Size = new Size(46, 49);
        }

        
    }
}
