namespace Project01
{
    partial class CourseEdit
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label course_IDLabel;
            System.Windows.Forms.Label courseLabel;
            System.Windows.Forms.Label credit_HoursLabel;
            System.Windows.Forms.Label class_TimeLabel;
            System.Windows.Forms.Label class_DaysLabel;
            System.Windows.Forms.Label classroom_IDLabel;
            System.Windows.Forms.Label instructorLabel;
            this.regesterationAppDataSet1 = new Project01.regesterationAppDataSet1();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesTableAdapter = new Project01.regesterationAppDataSet1TableAdapters.coursesTableAdapter();
            this.tableAdapterManager = new Project01.regesterationAppDataSet1TableAdapters.TableAdapterManager();
            this.regesterationAppDataSet2 = new Project01.regesterationAppDataSet2();
            this.coursesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.coursesTableAdapter1 = new Project01.regesterationAppDataSet2TableAdapters.coursesTableAdapter();
            this.tableAdapterManager1 = new Project01.regesterationAppDataSet2TableAdapters.TableAdapterManager();
            this.course_IDTextBox = new System.Windows.Forms.TextBox();
            this.courseTextBox = new System.Windows.Forms.TextBox();
            this.credit_HoursNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.class_TimeTextBox = new System.Windows.Forms.TextBox();
            this.class_DaysCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.classroom_IDTextBox = new System.Windows.Forms.TextBox();
            this.instructorTextBox = new System.Windows.Forms.TextBox();
            this.coursesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            course_IDLabel = new System.Windows.Forms.Label();
            courseLabel = new System.Windows.Forms.Label();
            credit_HoursLabel = new System.Windows.Forms.Label();
            class_TimeLabel = new System.Windows.Forms.Label();
            class_DaysLabel = new System.Windows.Forms.Label();
            classroom_IDLabel = new System.Windows.Forms.Label();
            instructorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.regesterationAppDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regesterationAppDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.credit_HoursNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // regesterationAppDataSet1
            // 
            this.regesterationAppDataSet1.DataSetName = "regesterationAppDataSet1";
            this.regesterationAppDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "courses";
            this.coursesBindingSource.DataSource = this.regesterationAppDataSet1;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.coursesTableAdapter = this.coursesTableAdapter;
            this.tableAdapterManager.studentsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project01.regesterationAppDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // regesterationAppDataSet2
            // 
            this.regesterationAppDataSet2.DataSetName = "regesterationAppDataSet2";
            this.regesterationAppDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coursesBindingSource1
            // 
            this.coursesBindingSource1.DataMember = "courses";
            this.coursesBindingSource1.DataSource = this.regesterationAppDataSet2;
            // 
            // coursesTableAdapter1
            // 
            this.coursesTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.coursesTableAdapter = this.coursesTableAdapter1;
            this.tableAdapterManager1.studentsTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Project01.regesterationAppDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // course_IDLabel
            // 
            course_IDLabel.AutoSize = true;
            course_IDLabel.Location = new System.Drawing.Point(26, 114);
            course_IDLabel.Name = "course_IDLabel";
            course_IDLabel.Size = new System.Drawing.Size(59, 13);
            course_IDLabel.TabIndex = 0;
            course_IDLabel.Text = "Course ID:";
            // 
            // course_IDTextBox
            // 
            this.course_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource1, "Course ID", true));
            this.course_IDTextBox.Location = new System.Drawing.Point(106, 111);
            this.course_IDTextBox.Name = "course_IDTextBox";
            this.course_IDTextBox.Size = new System.Drawing.Size(120, 20);
            this.course_IDTextBox.TabIndex = 1;
            // 
            // courseLabel
            // 
            courseLabel.AutoSize = true;
            courseLabel.Location = new System.Drawing.Point(26, 140);
            courseLabel.Name = "courseLabel";
            courseLabel.Size = new System.Drawing.Size(45, 13);
            courseLabel.TabIndex = 2;
            courseLabel.Text = "Course:";
            // 
            // courseTextBox
            // 
            this.courseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource1, "Course", true));
            this.courseTextBox.Location = new System.Drawing.Point(106, 137);
            this.courseTextBox.Name = "courseTextBox";
            this.courseTextBox.Size = new System.Drawing.Size(120, 20);
            this.courseTextBox.TabIndex = 3;
            // 
            // credit_HoursLabel
            // 
            credit_HoursLabel.AutoSize = true;
            credit_HoursLabel.Location = new System.Drawing.Point(26, 163);
            credit_HoursLabel.Name = "credit_HoursLabel";
            credit_HoursLabel.Size = new System.Drawing.Size(71, 13);
            credit_HoursLabel.TabIndex = 4;
            credit_HoursLabel.Text = "Credit Hours:";
            // 
            // credit_HoursNumericUpDown
            // 
            this.credit_HoursNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.coursesBindingSource1, "Credit Hours", true));
            this.credit_HoursNumericUpDown.Location = new System.Drawing.Point(106, 163);
            this.credit_HoursNumericUpDown.Name = "credit_HoursNumericUpDown";
            this.credit_HoursNumericUpDown.Size = new System.Drawing.Size(54, 20);
            this.credit_HoursNumericUpDown.TabIndex = 5;
            // 
            // class_TimeLabel
            // 
            class_TimeLabel.AutoSize = true;
            class_TimeLabel.Location = new System.Drawing.Point(26, 192);
            class_TimeLabel.Name = "class_TimeLabel";
            class_TimeLabel.Size = new System.Drawing.Size(61, 13);
            class_TimeLabel.TabIndex = 6;
            class_TimeLabel.Text = "Class Time:";
            // 
            // class_TimeTextBox
            // 
            this.class_TimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource1, "Class Time", true));
            this.class_TimeTextBox.Location = new System.Drawing.Point(106, 189);
            this.class_TimeTextBox.Name = "class_TimeTextBox";
            this.class_TimeTextBox.Size = new System.Drawing.Size(120, 20);
            this.class_TimeTextBox.TabIndex = 7;
            // 
            // class_DaysLabel
            // 
            class_DaysLabel.AutoSize = true;
            class_DaysLabel.Location = new System.Drawing.Point(26, 215);
            class_DaysLabel.Name = "class_DaysLabel";
            class_DaysLabel.Size = new System.Drawing.Size(63, 13);
            class_DaysLabel.TabIndex = 8;
            class_DaysLabel.Text = "Class Days:";
            // 
            // class_DaysCheckedListBox
            // 
            this.class_DaysCheckedListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.coursesBindingSource1, "Class Days", true));
            this.class_DaysCheckedListBox.FormattingEnabled = true;
            this.class_DaysCheckedListBox.Items.AddRange(new object[] {
            "U",
            "M",
            "T",
            "W",
            "R"});
            this.class_DaysCheckedListBox.Location = new System.Drawing.Point(106, 215);
            this.class_DaysCheckedListBox.Name = "class_DaysCheckedListBox";
            this.class_DaysCheckedListBox.Size = new System.Drawing.Size(64, 94);
            this.class_DaysCheckedListBox.TabIndex = 9;
            // 
            // classroom_IDLabel
            // 
            classroom_IDLabel.AutoSize = true;
            classroom_IDLabel.Location = new System.Drawing.Point(26, 320);
            classroom_IDLabel.Name = "classroom_IDLabel";
            classroom_IDLabel.Size = new System.Drawing.Size(74, 13);
            classroom_IDLabel.TabIndex = 10;
            classroom_IDLabel.Text = "Classroom ID:";
            // 
            // classroom_IDTextBox
            // 
            this.classroom_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource1, "Classroom ID", true));
            this.classroom_IDTextBox.Location = new System.Drawing.Point(106, 317);
            this.classroom_IDTextBox.Name = "classroom_IDTextBox";
            this.classroom_IDTextBox.Size = new System.Drawing.Size(120, 20);
            this.classroom_IDTextBox.TabIndex = 11;
            // 
            // instructorLabel
            // 
            instructorLabel.AutoSize = true;
            instructorLabel.Location = new System.Drawing.Point(26, 346);
            instructorLabel.Name = "instructorLabel";
            instructorLabel.Size = new System.Drawing.Size(59, 13);
            instructorLabel.TabIndex = 12;
            instructorLabel.Text = "Instructor:";
            // 
            // instructorTextBox
            // 
            this.instructorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource1, "Instructor", true));
            this.instructorTextBox.Location = new System.Drawing.Point(106, 343);
            this.instructorTextBox.Name = "instructorTextBox";
            this.instructorTextBox.Size = new System.Drawing.Size(120, 20);
            this.instructorTextBox.TabIndex = 13;
            // 
            // coursesDataGridView
            // 
            this.coursesDataGridView.AutoGenerateColumns = false;
            this.coursesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coursesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.coursesDataGridView.DataSource = this.coursesBindingSource1;
            this.coursesDataGridView.Location = new System.Drawing.Point(263, 114);
            this.coursesDataGridView.Name = "coursesDataGridView";
            this.coursesDataGridView.Size = new System.Drawing.Size(746, 220);
            this.coursesDataGridView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Course ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Course ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Course";
            this.dataGridViewTextBoxColumn2.HeaderText = "Course";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Credit Hours";
            this.dataGridViewTextBoxColumn3.HeaderText = "Credit Hours";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Class Time";
            this.dataGridViewTextBoxColumn4.HeaderText = "Class Time";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Class Days";
            this.dataGridViewTextBoxColumn5.HeaderText = "Class Days";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Classroom ID";
            this.dataGridViewTextBoxColumn6.HeaderText = "Classroom ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Instructor";
            this.dataGridViewTextBoxColumn7.HeaderText = "Instructor";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // CourseEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 421);
            this.Controls.Add(this.coursesDataGridView);
            this.Controls.Add(course_IDLabel);
            this.Controls.Add(this.course_IDTextBox);
            this.Controls.Add(courseLabel);
            this.Controls.Add(this.courseTextBox);
            this.Controls.Add(credit_HoursLabel);
            this.Controls.Add(this.credit_HoursNumericUpDown);
            this.Controls.Add(class_TimeLabel);
            this.Controls.Add(this.class_TimeTextBox);
            this.Controls.Add(class_DaysLabel);
            this.Controls.Add(this.class_DaysCheckedListBox);
            this.Controls.Add(classroom_IDLabel);
            this.Controls.Add(this.classroom_IDTextBox);
            this.Controls.Add(instructorLabel);
            this.Controls.Add(this.instructorTextBox);
            this.Name = "CourseEdit";
            this.Text = "CourseEdit";
            this.Load += new System.EventHandler(this.CourseEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.regesterationAppDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regesterationAppDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.credit_HoursNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private regesterationAppDataSet1 regesterationAppDataSet1;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private regesterationAppDataSet1TableAdapters.coursesTableAdapter coursesTableAdapter;
        private regesterationAppDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private regesterationAppDataSet2 regesterationAppDataSet2;
        private System.Windows.Forms.BindingSource coursesBindingSource1;
        private regesterationAppDataSet2TableAdapters.coursesTableAdapter coursesTableAdapter1;
        private regesterationAppDataSet2TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox course_IDTextBox;
        private System.Windows.Forms.TextBox courseTextBox;
        private System.Windows.Forms.NumericUpDown credit_HoursNumericUpDown;
        private System.Windows.Forms.TextBox class_TimeTextBox;
        private System.Windows.Forms.CheckedListBox class_DaysCheckedListBox;
        private System.Windows.Forms.TextBox classroom_IDTextBox;
        private System.Windows.Forms.TextBox instructorTextBox;
        private System.Windows.Forms.DataGridView coursesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}