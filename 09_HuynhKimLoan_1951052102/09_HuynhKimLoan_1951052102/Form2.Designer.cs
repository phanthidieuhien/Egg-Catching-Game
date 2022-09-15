
namespace _09_HuynhKimLoan_1951052102
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerDH = new System.Windows.Forms.Timer(this.components);
            this.timerRand = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btTamDung = new System.Windows.Forms.Button();
            this.btPlay = new System.Windows.Forms.Button();
            this.btTatAm = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbMinute = new System.Windows.Forms.Label();
            this.lbDiem = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lab = new System.Windows.Forms.Label();
            this.lbSecond = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picHung = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbVo = new System.Windows.Forms.Label();
            this.picAdd2 = new System.Windows.Forms.PictureBox();
            this.picE4 = new System.Windows.Forms.PictureBox();
            this.picSub2 = new System.Windows.Forms.PictureBox();
            this.picE3 = new System.Windows.Forms.PictureBox();
            this.picE1 = new System.Windows.Forms.PictureBox();
            this.picE2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHung)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picE4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSub2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picE3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picE1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picE2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerDH
            // 
            this.timerDH.Enabled = true;
            this.timerDH.Interval = 1000;
            this.timerDH.Tick += new System.EventHandler(this.timerDH_Tick);
            // 
            // timerRand
            // 
            this.timerRand.Interval = 60;
            this.timerRand.Tick += new System.EventHandler(this.timerRand_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btTamDung);
            this.panel1.Controls.Add(this.btPlay);
            this.panel1.Controls.Add(this.btTatAm);
            this.panel1.Controls.Add(this.btThoat);
            this.panel1.Location = new System.Drawing.Point(702, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(62, 224);
            this.panel1.TabIndex = 18;
            // 
            // btTamDung
            // 
            this.btTamDung.BackColor = System.Drawing.Color.Transparent;
            this.btTamDung.BackgroundImage = global::_09_HuynhKimLoan_1951052102.Properties.Resources.playing;
            this.btTamDung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btTamDung.FlatAppearance.BorderSize = 0;
            this.btTamDung.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btTamDung.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btTamDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTamDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btTamDung.Location = new System.Drawing.Point(8, 67);
            this.btTamDung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btTamDung.Name = "btTamDung";
            this.btTamDung.Size = new System.Drawing.Size(40, 40);
            this.btTamDung.TabIndex = 22;
            this.btTamDung.UseVisualStyleBackColor = false;
            this.btTamDung.Click += new System.EventHandler(this.btTamDung_Click);
            this.btTamDung.MouseLeave += new System.EventHandler(this.btPlay_MouseLeave);
            this.btTamDung.MouseHover += new System.EventHandler(this.btPlay_MouseHover);
            // 
            // btPlay
            // 
            this.btPlay.BackColor = System.Drawing.Color.Transparent;
            this.btPlay.BackgroundImage = global::_09_HuynhKimLoan_1951052102.Properties.Resources.replay;
            this.btPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPlay.FlatAppearance.BorderSize = 0;
            this.btPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btPlay.Location = new System.Drawing.Point(9, 13);
            this.btPlay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(40, 40);
            this.btPlay.TabIndex = 21;
            this.btPlay.UseVisualStyleBackColor = false;
            this.btPlay.Click += new System.EventHandler(this.btPlay_Click);
            this.btPlay.MouseLeave += new System.EventHandler(this.btPlay_MouseLeave);
            this.btPlay.MouseHover += new System.EventHandler(this.btPlay_MouseHover);
            // 
            // btTatAm
            // 
            this.btTatAm.BackColor = System.Drawing.Color.Transparent;
            this.btTatAm.BackgroundImage = global::_09_HuynhKimLoan_1951052102.Properties.Resources.unmute2;
            this.btTatAm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btTatAm.FlatAppearance.BorderSize = 0;
            this.btTatAm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btTatAm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btTatAm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTatAm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTatAm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btTatAm.Location = new System.Drawing.Point(9, 120);
            this.btTatAm.Name = "btTatAm";
            this.btTatAm.Size = new System.Drawing.Size(40, 40);
            this.btTatAm.TabIndex = 18;
            this.btTatAm.UseVisualStyleBackColor = false;
            this.btTatAm.Click += new System.EventHandler(this.btTatAm_Click);
            this.btTatAm.MouseLeave += new System.EventHandler(this.btPlay_MouseLeave);
            this.btTatAm.MouseHover += new System.EventHandler(this.btPlay_MouseHover);
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.Transparent;
            this.btThoat.BackgroundImage = global::_09_HuynhKimLoan_1951052102.Properties.Resources.end2;
            this.btThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btThoat.FlatAppearance.BorderSize = 0;
            this.btThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThoat.Location = new System.Drawing.Point(9, 171);
            this.btThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(41, 41);
            this.btThoat.TabIndex = 17;
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            this.btThoat.MouseLeave += new System.EventHandler(this.btPlay_MouseLeave);
            this.btThoat.MouseHover += new System.EventHandler(this.btPlay_MouseHover);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.lbMinute);
            this.panel3.Controls.Add(this.lbDiem);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lab);
            this.panel3.Controls.Add(this.lbSecond);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(762, 127);
            this.panel3.TabIndex = 19;
            // 
            // lbMinute
            // 
            this.lbMinute.AutoSize = true;
            this.lbMinute.BackColor = System.Drawing.Color.Transparent;
            this.lbMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMinute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbMinute.Location = new System.Drawing.Point(134, 87);
            this.lbMinute.Name = "lbMinute";
            this.lbMinute.Size = new System.Drawing.Size(41, 29);
            this.lbMinute.TabIndex = 15;
            this.lbMinute.Text = "02";
            // 
            // lbDiem
            // 
            this.lbDiem.AutoSize = true;
            this.lbDiem.BackColor = System.Drawing.Color.Transparent;
            this.lbDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbDiem.Location = new System.Drawing.Point(480, 39);
            this.lbDiem.Name = "lbDiem";
            this.lbDiem.Size = new System.Drawing.Size(182, 51);
            this.lbDiem.TabIndex = 10;
            this.lbDiem.Text = "Score: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(176, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = ":";
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.BackColor = System.Drawing.Color.Transparent;
            this.lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lab.Location = new System.Drawing.Point(66, 87);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(77, 29);
            this.lab.TabIndex = 11;
            this.lab.Text = "Time:";
            // 
            // lbSecond
            // 
            this.lbSecond.AutoSize = true;
            this.lbSecond.BackColor = System.Drawing.Color.Transparent;
            this.lbSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSecond.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbSecond.Location = new System.Drawing.Point(194, 87);
            this.lbSecond.Name = "lbSecond";
            this.lbSecond.Size = new System.Drawing.Size(41, 29);
            this.lbSecond.TabIndex = 14;
            this.lbSecond.Text = "00";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(159, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = ":";
            // 
            // picHung
            // 
            this.picHung.BackColor = System.Drawing.Color.Transparent;
            this.picHung.Image = ((System.Drawing.Image)(resources.GetObject("picHung.Image")));
            this.picHung.Location = new System.Drawing.Point(317, 502);
            this.picHung.Name = "picHung";
            this.picHung.Size = new System.Drawing.Size(84, 43);
            this.picHung.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHung.TabIndex = 16;
            this.picHung.TabStop = false;
            this.picHung.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picHung_MouseDown);
            this.picHung.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picHung_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.lbVo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 545);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(762, 86);
            this.panel2.TabIndex = 17;
            // 
            // lbVo
            // 
            this.lbVo.AutoSize = true;
            this.lbVo.BackColor = System.Drawing.Color.Transparent;
            this.lbVo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVo.ForeColor = System.Drawing.Color.Black;
            this.lbVo.Location = new System.Drawing.Point(562, 41);
            this.lbVo.Name = "lbVo";
            this.lbVo.Size = new System.Drawing.Size(207, 51);
            this.lbVo.TabIndex = 9;
            this.lbVo.Text = "Missed: 0";
            // 
            // picAdd2
            // 
            this.picAdd2.BackColor = System.Drawing.Color.Transparent;
            this.picAdd2.Image = global::_09_HuynhKimLoan_1951052102.Properties.Resources.time;
            this.picAdd2.Location = new System.Drawing.Point(160, 227);
            this.picAdd2.Name = "picAdd2";
            this.picAdd2.Size = new System.Drawing.Size(47, 55);
            this.picAdd2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAdd2.TabIndex = 8;
            this.picAdd2.TabStop = false;
            this.picAdd2.Tag = "picEgg";
            // 
            // picE4
            // 
            this.picE4.BackColor = System.Drawing.Color.Transparent;
            this.picE4.Image = ((System.Drawing.Image)(resources.GetObject("picE4.Image")));
            this.picE4.Location = new System.Drawing.Point(257, 170);
            this.picE4.Name = "picE4";
            this.picE4.Size = new System.Drawing.Size(40, 50);
            this.picE4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picE4.TabIndex = 8;
            this.picE4.TabStop = false;
            this.picE4.Tag = "picEgg";
            // 
            // picSub2
            // 
            this.picSub2.BackColor = System.Drawing.Color.Transparent;
            this.picSub2.Image = ((System.Drawing.Image)(resources.GetObject("picSub2.Image")));
            this.picSub2.Location = new System.Drawing.Point(543, 203);
            this.picSub2.Name = "picSub2";
            this.picSub2.Size = new System.Drawing.Size(53, 50);
            this.picSub2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSub2.TabIndex = 8;
            this.picSub2.TabStop = false;
            this.picSub2.Tag = "picEgg";
            // 
            // picE3
            // 
            this.picE3.BackColor = System.Drawing.Color.Transparent;
            this.picE3.Image = ((System.Drawing.Image)(resources.GetObject("picE3.Image")));
            this.picE3.Location = new System.Drawing.Point(450, 133);
            this.picE3.Name = "picE3";
            this.picE3.Size = new System.Drawing.Size(40, 50);
            this.picE3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picE3.TabIndex = 8;
            this.picE3.TabStop = false;
            this.picE3.Tag = "picEgg";
            // 
            // picE1
            // 
            this.picE1.BackColor = System.Drawing.Color.Transparent;
            this.picE1.Image = ((System.Drawing.Image)(resources.GetObject("picE1.Image")));
            this.picE1.Location = new System.Drawing.Point(45, 170);
            this.picE1.Name = "picE1";
            this.picE1.Size = new System.Drawing.Size(40, 50);
            this.picE1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picE1.TabIndex = 4;
            this.picE1.TabStop = false;
            this.picE1.Tag = "picEgg";
            // 
            // picE2
            // 
            this.picE2.BackColor = System.Drawing.Color.Transparent;
            this.picE2.Image = ((System.Drawing.Image)(resources.GetObject("picE2.Image")));
            this.picE2.Location = new System.Drawing.Point(361, 227);
            this.picE2.Name = "picE2";
            this.picE2.Size = new System.Drawing.Size(40, 50);
            this.picE2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picE2.TabIndex = 3;
            this.picE2.TabStop = false;
            this.picE2.Tag = "picEgg";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(762, 631);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picHung);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.picAdd2);
            this.Controls.Add(this.picE4);
            this.Controls.Add(this.picSub2);
            this.Controls.Add(this.picE3);
            this.Controls.Add(this.picE1);
            this.Controls.Add(this.picE2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHung)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picE4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSub2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picE3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picE1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picE2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbVo;
        private System.Windows.Forms.Label lbDiem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picHung;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.PictureBox picE2;
        private System.Windows.Forms.PictureBox picE1;
        private System.Windows.Forms.Timer timerDH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbSecond;
        private System.Windows.Forms.Label lbMinute;
        private System.Windows.Forms.PictureBox picE4;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btTatAm;
        private System.Windows.Forms.PictureBox picE3;
        private System.Windows.Forms.Timer timerRand;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picAdd2;
        private System.Windows.Forms.PictureBox picSub2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btTamDung;
        private System.Windows.Forms.Button btPlay;
    }
}