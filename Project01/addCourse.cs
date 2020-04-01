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
    public partial class addCourse : Form
    {
        public addCourse()
        {
            InitializeComponent();
        }

        private void CoursesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.coursesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.regesterationAppDataSet2);

        }

        private void AddCourse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'regesterationAppDataSet2.courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.regesterationAppDataSet2.courses);

        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.coursesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.regesterationAppDataSet2);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnDelete_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
