﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Diary.Presentation_Layer
{
    public partial class Home : Form
    {
        string message;
        public Home(string message)
        {
            this.message = message;
            InitializeComponent();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void manageUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserManagement userManagement = new UserManagement(this,message);
            userManagement.Show();
            this.Hide();
        }

        private void manageEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventManagement eventManagement = new EventManagement(this,message);
            eventManagement.Show();
            this.Hide();
        }
    }
}
