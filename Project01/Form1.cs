using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            addForm addForm = new addForm();
            addForm.Show();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAddCourse_Click(object sender, EventArgs e)
        {
            addCourse addCourse = new addCourse();
            addCourse.Show();
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
           ViewCourseForm viewCourseForm = new ViewCourseForm();
            viewCourseForm.Show();

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            DeletStu deletStu = new DeletStu();
            deletStu.Show();


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ViewForm viewForm = new ViewForm();
            viewForm.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ViewCourseForm viewCourseForm = new ViewCourseForm();
            viewCourseForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
