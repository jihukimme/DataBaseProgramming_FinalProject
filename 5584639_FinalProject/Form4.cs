﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;


namespace _5584639_FinalProject
{
    public partial class Form4 : Form
    {

        private IconButton currentBtn;
        private Panel leftBorderBtn;

        string seller_id;


        public Form4(string id)
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 80);
            panel1.Controls.Add(leftBorderBtn);

            // Call iconButton1_Click event handler
            iconButton1_Click(iconButton1, new EventArgs());

            seller_id = id;
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(37, 36, 81);
        }

        private void ActivateButton(object senderBtn, Color color)
        {

            if (senderBtn != null)
            {
                DisableButton();
                //button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.White;
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //iconCurrentChildForm
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(0, 153, 255);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            lbTitleChildForm.Text = iconButton1.Text;

            openChildForm(new Form4_ChildForm.Form4_Home(seller_id));

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            lbTitleChildForm.Text = iconButton2.Text;

            openChildForm(new Form4_ChildForm.Form4_MyItem(seller_id));

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            lbTitleChildForm.Text = iconButton3.Text;

            openChildForm(new Form4_ChildForm.Form4_Sales(seller_id));

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            lbTitleChildForm.Text = iconButton4.Text;

            openChildForm(new Form4_ChildForm.Form4_Refund(seller_id));

        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            lbTitleChildForm.Text = iconButton6.Text;

            openChildForm(new Form4_ChildForm.Form4_User(seller_id, this));
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            lbTitleChildForm.Text = iconButton5.Text;

            this.Close();
        }

        private Form currentChildForm;
        private void openChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        
    }
}
