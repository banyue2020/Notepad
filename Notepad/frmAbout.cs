﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }
        // 【确定】按钮
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // 使用LinkLabel打开邮件或者网页
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.bilibili.com/video/BV1GJ411x7h7");
        }
    }
}
