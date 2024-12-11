﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelRes1
{
    public partial class FormDashboard : Form
    {
        public string Username;

        public FormDashboard()
        {
            InitializeComponent();
        }

        private void MovePanel(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;
        }

        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            DialogResult message = MessageBox.Show("Do you want to log out", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (message == DialogResult.Yes) {
                timer1.Stop();
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDateTime.Text = DateTime.Now.ToString("dd-MMM-yyy hh:mm:ss tt");
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelUsername.Text = Username;
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            MovePanel(buttonDashboard);
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            MovePanel(buttonClient);
        }

        private void buttonRoom_Click(object sender, EventArgs e)
        {
            MovePanel(buttonRoom);
        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            MovePanel(buttonReservation);
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            MovePanel(buttonSetting);   
        }
    }
}
