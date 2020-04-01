namespace Project01
{
    partial class ViewCourseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCourseForm));
            System.Windows.Forms.Label course_IDLabel;
            System.Windows.Forms.Label courseLabel;
            System.Windows.Forms.Label credit_HoursLabel;
            System.Windows.Forms.Label class_TimeLabel;
            System.Windows.Forms.Label class_DaysLabel;
            System.Windows.Forms.Label classroom_IDLabel;
            System.Windows.Forms.Label instructorLabel;
            this.regesterationAppDataSet2 = new Project01.regesterationAppDataSet2();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesTableAdapter = new Project01.regesterationAppDataSet2TableAdapters.coursesTableAdapter();
            this.tableAdapterManager = new Project01.regesterationAppDataSet2TableAdapters.TableAdapterManager();
            this.coursesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.course_IDTextBox = new System.Windows.Forms.TextBox();
            this.courseTextBox = new System.Windows.Forms.TextBox();
            this.credit_HoursNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.class_TimeTextBox = new System.Windows.Forms.TextBox();
            this.class_DaysTextBox = new System.Windows.Forms.TextBox();
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
            this.Update = new System.Windows.Forms.Button();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnDelete = new System.Windows.Forms.Button();
            course_IDLabel = new System.Windows.Forms.Label();
            courseLabel = new System.Windows.Forms.Label();
            credit_HoursLabel = new System.Windows.Forms.Label();
            class_TimeLabel = new System.Windows.Forms.Label();
            class_DaysLabel = new System.Windows.Forms.Label();
            classroom_IDLabel = new System.Windows.Forms.Label();
            instructorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.regesterationAppDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingNavigator)).BeginInit();
            this.coursesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.credit_HoursNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // regesterationAppDataSet2
            // 
            this.regesterationAppDataSet2.DataSetName = "regesterationAppDataSet2";
            this.regesterationAppDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "courses";
            this.coursesBindingSource.DataSource = this.regesterationAppDataSet2;
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
            this.tableAdapterManager.UpdateOrder = Project01.regesterationAppDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // coursesBindingNavigator
            // 
            this.coursesBindingNavigator.AddNewItem = null;
            this.coursesBindingNavigator.BindingSource = this.coursesBindingSource;
            this.coursesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.coursesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.coursesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel1,
            this.bindingNavigatorDeleteItem});
            this.coursesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.coursesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.coursesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.coursesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.coursesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.coursesBindingNavigator.Name = "coursesBindingNavigator";
            this.coursesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.coursesBindingNavigator.Size = new System.Drawing.Size(768, 25);
            this.coursesBindingNavigator.TabIndex = 0;
            this.coursesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(58, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // course_IDLabel
            // 
            course_IDLabel.AutoSize = true;
            course_IDLabel.Location = new System.Drawing.Point(14, 265);
            course_IDLabel.Name = "course_IDLabel";
            course_IDLabel.Size = new System.Drawing.Size(65, 13);
            course_IDLabel.TabIndex = 1;
            course_IDLabel.Text = "Course ID:";
            // 
            // course_IDTextBox
            // 
            this.course_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "Course ID", true));
            this.course_IDTextBox.Location = new System.Drawing.Point(107, 262);
            this.course_IDTextBox.Name = "course_IDTextBox";
            this.course_IDTextBox.Size = new System.Drawing.Size(139, 21);
            this.course_IDTextBox.TabIndex = 2;
            // 
            // courseLabel
            // 
            courseLabel.AutoSize = true;
            courseLabel.Location = new System.Drawing.Point(14, 291);
            courseLabel.Name = "courseLabel";
            courseLabel.Size = new System.Drawing.Size(49, 13);
            courseLabel.TabIndex = 3;
            courseLabel.Text = "Course:";
            // 
            // courseTextBox
            // 
            this.courseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "Course", true));
            this.courseTextBox.Location = new System.Drawing.Point(107, 288);
            this.courseTextBox.Name = "courseTextBox";
            this.courseTextBox.Size = new System.Drawing.Size(139, 21);
            this.courseTextBox.TabIndex = 4;
            // 
            // credit_HoursLabel
            // 
            credit_HoursLabel.AutoSize = true;
            credit_HoursLabel.Location = new System.Drawing.Point(14, 314);
            credit_HoursLabel.Name = "credit_HoursLabel";
            credit_HoursLabel.Size = new System.Drawing.Size(80, 13);
            credit_HoursLabel.TabIndex = 5;
            credit_HoursLabel.Text = "Credit Hours:";
            // 
            // credit_HoursNumericUpDown
            // 
            this.credit_HoursNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.coursesBindingSource, "Credit Hours", true));
            this.credit_HoursNumericUpDown.Location = new System.Drawing.Point(107, 314);
            this.credit_HoursNumericUpDown.Name = "credit_HoursNumericUpDown";
            this.credit_HoursNumericUpDown.Size = new System.Drawing.Size(140, 21);
            this.credit_HoursNumericUpDown.TabIndex = 6;
            // 
            // class_TimeLabel
            // 
            class_TimeLabel.AutoSize = true;
            class_TimeLabel.Location = new System.Drawing.Point(463, 265);
            class_TimeLabel.Name = "class_TimeLabel";
            class_TimeLabel.Size = new System.Drawing.Size(70, 13);
            class_TimeLabel.TabIndex = 7;
            class_TimeLabel.Text = "Class Time:";
            // 
            // class_TimeTextBox
            // 
            this.class_TimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "Class Time", true));
            this.class_TimeTextBox.Location = new System.Drawing.Point(575, 258);
            this.class_TimeTextBox.Name = "class_TimeTextBox";
            this.class_TimeTextBox.Size = new System.Drawing.Size(139, 21);
            this.class_TimeTextBox.TabIndex = 8;
            // 
            // class_DaysLabel
            // 
            class_DaysLabel.AutoSize = true;
            class_DaysLabel.Location = new System.Drawing.Point(463, 291);
            class_DaysLabel.Name = "class_DaysLabel";
            class_DaysLabel.Size = new System.Drawing.Size(70, 13);
            class_DaysLabel.TabIndex = 9;
            class_DaysLabel.Text = "Class Days:";
            // 
            // class_DaysTextBox
            // 
            this.class_DaysTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "Class Days", true));
            this.class_DaysTextBox.Location = new System.Drawing.Point(575, 284);
            this.class_DaysTextBox.Name = "class_DaysTextBox";
            this.class_DaysTextBox.Size = new System.Drawing.Size(139, 21);
            this.class_DaysTextBox.TabIndex = 10;
            // 
            // classroom_IDLabel
            // 
            classroom_IDLabel.AutoSize = true;
            classroom_IDLabel.Location = new System.Drawing.Point(463, 317);
            classroom_IDLabel.Name = "classroom_IDLabel";
            classroom_IDLabel.Size = new System.Drawing.Size(85, 13);
            classroom_IDLabel.TabIndex = 11;
            classroom_IDLabel.Text = "Classroom ID:";
            // 
            // classroom_IDTextBox
            // 
            this.classroom_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "Classroom ID", true));
            this.classroom_IDTextBox.Location = new System.Drawing.Point(575, 310);
            this.classroom_IDTextBox.Name = "classroom_IDTextBox";
            this.classroom_IDTextBox.Size = new System.Drawing.Size(139, 21);
            this.classroom_IDTextBox.TabIndex = 12;
            // 
            // instructorLabel
            // 
            instructorLabel.AutoSize = true;
            instructorLabel.Location = new System.Drawing.Point(463, 343);
            instructorLabel.Name = "instructorLabel";
            instructorLabel.Size = new System.Drawing.Size(68, 13);
            instructorLabel.TabIndex = 13;
            instructorLabel.Text = "Instructor:";
            // 
            // instructorTextBox
            // 
            this.instructorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "Instructor", true));
            this.instructorTextBox.Location = new System.Drawing.Point(575, 336);
            this.instructorTextBox.Name = "instructorTextBox";
            this.instructorTextBox.Size = new System.Drawing.Size(139, 21);
            this.instructorTextBox.TabIndex = 14;
            // 
            // coursesDataGridView
            // 
            this.coursesDataGridView.AllowUserToAddRows = false;
            this.coursesDataGridView.AllowUserToDeleteRows = false;
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
            this.coursesDataGridView.DataSource = this.coursesBindingSource;
            this.coursesDataGridView.Location = new System.Drawing.Point(14, 32);
            this.coursesDataGridView.Name = "coursesDataGridView";
            this.coursesDataGridView.ReadOnly = true;
            this.coursesDataGridView.Size = new System.Drawing.Size(742, 220);
            this.coursesDataGridView.TabIndex = 15;
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
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.Blue;
            this.Update.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.ForeColor = System.Drawing.Color.GhostWhite;
            this.Update.Location = new System.Drawing.Point(51, 386);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(195, 42);
            this.Update.TabIndex = 16;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.Red;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(47, 22);
            this.toolStripLabel1.Text = "DELETE";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(685, 386);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(71, 42);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "Exit";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // ViewCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 449);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.Update);
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
            this.Controls.Add(this.class_DaysTextBox);
            this.Controls.Add(classroom_IDLabel);
            this.Controls.Add(this.classroom_IDTextBox);
            this.Controls.Add(instructorLabel);
            this.Controls.Add(this.instructorTextBox);
            this.Controls.Add(this.coursesBindingNavigator);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ViewCourseForm";
            this.Text = "View / Edit Course";
            this.Load += new System.EventHandler(this.ViewCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.regesterationAppDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingNavigator)).EndInit();
            this.coursesBindingNavigator.ResumeLayout(false);
            this.coursesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.credit_HoursNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private regesterationAppDataSet2 regesterationAppDataSet2;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private regesterationAppDataSet2TableAdapters.coursesTableAdapter coursesTableAdapter;
        private regesterationAppDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator coursesBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox course_IDTextBox;
        private System.Windows.Forms.TextBox courseTextBox;
        private System.Windows.Forms.NumericUpDown credit_HoursNumericUpDown;
        private System.Windows.Forms.TextBox class_TimeTextBox;
        private System.Windows.Forms.TextBox class_DaysTextBox;
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
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Button btnDelete;
    }
}