
namespace _09_HuynhKimLoan_1951052102
{
    partial class FormHuongDan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHuongDan));
            this.btThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.Transparent;
            this.btThoat.BackgroundImage = global::_09_HuynhKimLoan_1951052102.Properties.Resources.btHome;
            this.btThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btThoat.FlatAppearance.BorderSize = 0;
            this.btThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThoat.Location = new System.Drawing.Point(881, 12);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(53, 53);
            this.btThoat.TabIndex = 0;
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // FormHuongDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_09_HuynhKimLoan_1951052102.Properties.Resources.bgBD;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(946, 600);
            this.Controls.Add(this.btThoat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormHuongDan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hướng dẫn";
            this.Load += new System.EventHandler(this.FormHuongDan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btThoat;
    }
}