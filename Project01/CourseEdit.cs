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
    public partial class CourseEdit : Form
    {
        public CourseEdit()
        {
            InitializeComponent();
        }

        private void CoursesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.coursesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.regesterationAppDataSet1);

        }

        private void CourseEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'regesterationAppDataSet2.courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter1.Fill(this.regesterationAppDataSet2.courses);


        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.coursesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.regesterationAppDataSet1);
        }

        private void BindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
