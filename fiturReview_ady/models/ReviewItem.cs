
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fiturReview_ady;

namespace fiturReview_ady.models
{
    internal class ReviewItem
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ratingRembangan));
        Panel panelUlasan = new Panel();
        PictureBox pbProfil = new PictureBox();
        Label lbUlasan = new Label();
        Label lbUser = new Label();
        PictureBox showStar5 = new PictureBox();
        PictureBox showStar4 = new PictureBox();
        PictureBox showStar3 = new PictureBox();
        PictureBox showStar2 = new PictureBox();
        PictureBox showStar1 = new PictureBox();
        Button buttonHapus = new Button();

        public ReviewItem(string ulasan, int star)
        {
            panelUlasan.BackgroundImageLayout = ImageLayout.None;
            panelUlasan.Controls.Add(buttonHapus);
            panelUlasan.Controls.Add(showStar5);
            panelUlasan.Controls.Add(showStar4);
            panelUlasan.Controls.Add(showStar3);
            panelUlasan.Controls.Add(showStar2);
            panelUlasan.Controls.Add(showStar1);
            panelUlasan.Controls.Add(pbProfil);
            panelUlasan.Controls.Add(lbUlasan);
            panelUlasan.Controls.Add(lbUser);
            panelUlasan.Location = new Point(3, 3);
            panelUlasan.Name = "panelUlasan";
            panelUlasan.Size = new Size(709, 248);
            panelUlasan.TabIndex = 26;
            // 
            // buttonHapus
            // 
            buttonHapus.BackColor = Color.FromArgb(55, 163, 165);
            buttonHapus.FlatAppearance.BorderSize = 0;
            buttonHapus.FlatStyle = FlatStyle.Flat;
            buttonHapus.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            buttonHapus.ForeColor = SystemColors.ControlLightLight;
            buttonHapus.Location = new Point(582, 191);
            buttonHapus.Name = "buttonHapus";
            buttonHapus.Size = new Size(94, 29);
            buttonHapus.TabIndex = 22;
            buttonHapus.Text = "HAPUS";
            buttonHapus.UseVisualStyleBackColor = false;
            //buttonHapus.Click += buttonHapus_Click;
            // 
            // showStar5
            // 
            showStar5.Image = fiturReview_ady.Properties.Resources.star__2___1_;
            showStar5.Location = new Point(112, 78);
            showStar5.Name = "showStar5";
            showStar5.Size = new Size(22, 20);
            showStar5.SizeMode = PictureBoxSizeMode.AutoSize;
            showStar5.TabIndex = 25;
            showStar5.TabStop = false;
            // 
            // showStar4
            // 
            showStar4.Image = fiturReview_ady.Properties.Resources.star__2___1_;
            showStar4.Location = new Point(84, 78);
            showStar4.Name = "showStar4";
            showStar4.Size = new Size(22, 20);
            showStar4.SizeMode = PictureBoxSizeMode.AutoSize;
            showStar4.TabIndex = 24;
            showStar4.TabStop = false;
            // 
            // showStar3
            // 
            showStar3.Image = fiturReview_ady.Properties.Resources.star__2___1_;
            showStar3.Location = new Point(56, 78);
            showStar3.Name = "showStar3";
            showStar3.Size = new Size(22, 20);
            showStar3.SizeMode = PictureBoxSizeMode.AutoSize;
            showStar3.TabIndex = 23;
            showStar3.TabStop = false;
            // 
            // showStar2
            // 
            showStar2.Image = fiturReview_ady.Properties.Resources.star__2___1_;
            showStar2.Location = new Point(28, 78);
            showStar2.Name = "showStar2";
            showStar2.Size = new Size(22, 20);
            showStar2.SizeMode = PictureBoxSizeMode.AutoSize;
            showStar2.TabIndex = 22;
            showStar2.TabStop = false;
            // 
            // showStar1
            // 
            showStar1.Image = fiturReview_ady.Properties.Resources.star__2___1_;
            showStar1.Location = new Point(0, 78);
            showStar1.Name = "showStar1";
            showStar1.Size = new Size(22, 20);
            showStar1.SizeMode = PictureBoxSizeMode.AutoSize;
            showStar1.TabIndex = 22;
            showStar1.TabStop = false;
            // 
            // pbProfil
            // 
            pbProfil.Image = (Image)resources.GetObject("pbProfil.Image");
            pbProfil.Location = new Point(0, 14);
            pbProfil.Name = "pbProfil";
            pbProfil.Size = new Size(44, 45);
            pbProfil.TabIndex = 5;
            pbProfil.TabStop = false;
            // 
            // lbUlasan
            // 
            lbUlasan.AutoSize = true;
            lbUlasan.BackColor = Color.Transparent;
            lbUlasan.Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbUlasan.ForeColor = Color.Black;
            lbUlasan.Location = new Point(0, 118);
            lbUlasan.Name = "lbUlasan";
            lbUlasan.Size = new Size(637, 189);
            lbUlasan.TabIndex = 2;
            lbUlasan.Text = resources.GetString("lbUlasan.Text");
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.BackColor = Color.Transparent;
            lbUser.Font = new Font("Poppins SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Pixel);
            lbUser.ForeColor = Color.Black;
            lbUser.Location = new Point(50, 22);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(135, 32);
            lbUser.TabIndex = 1;
            lbUser.Text = "JT-Apps user";

            lbUlasan.Text = ulasan;
            
            
        }
        public Panel CreateItem()
        {
            return panelUlasan;
        }
    }
}
