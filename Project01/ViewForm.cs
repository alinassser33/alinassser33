﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project01
{
    public partial class ViewForm : Form
    {
        public ViewForm()
        {
            InitializeComponent();
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'regesterationAppDataSet1.students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.regesterationAppDataSet1.students);

        }
    }
}
