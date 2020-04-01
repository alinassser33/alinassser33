namespace Project01
{
    partial class addCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addCourse));
            System.Windows.Forms.Label courseLabel;
            System.Windows.Forms.Label credit_HoursLabel;
            System.Windows.Forms.Label class_TimeLabel;
            System.Windows.Forms.Label classroom_IDLabel;
            System.Windows.Forms.Label instructorLabel;
            System.Windows.Forms.Label class_DaysLabel;
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
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.coursesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.courseTextBox = new System.Windows.Forms.TextBox();
            this.credit_HoursNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.class_TimeTextBox = new System.Windows.Forms.TextBox();
            this.classroom_IDTextBox = new System.Windows.Forms.TextBox();
            this.instructorTextBox = new System.Windows.Forms.TextBox();
            this.class_DaysTextBox = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            courseLabel = new System.Windows.Forms.Label();
            credit_HoursLabel = new System.Windows.Forms.Label();
            class_TimeLabel = new System.Windows.Forms.Label();
            classroom_IDLabel = new System.Windows.Forms.Label();
            instructorLabel = new System.Windows.Forms.Label();
            class_DaysLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.regesterationAppDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingNavigator)).BeginInit();
            this.coursesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.credit_HoursNumericUpDown)).BeginInit();
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
            this.coursesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.coursesBindingNavigator.BindingSource = this.coursesBindingSource;
            this.coursesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.coursesBindingNavigator.DeleteItem = null;
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
            this.bindingNavigatorAddNewItem,
            this.coursesBindingNavigatorSaveItem});
            this.coursesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.coursesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.coursesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.coursesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.coursesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.coursesBindingNavigator.Name = "coursesBindingNavigator";
            this.coursesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.coursesBindingNavigator.Size = new System.Drawing.Size(545, 25);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
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
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // coursesBindingNavigatorSaveItem
            // 
            this.coursesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.coursesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("coursesBindingNavigatorSaveItem.Image")));
            this.coursesBindingNavigatorSaveItem.Name = "coursesBindingNavigatorSaveItem";
            this.coursesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.coursesBindingNavigatorSaveItem.Text = "Save Data";
            this.coursesBindingNavigatorSaveItem.Click += new System.EventHandler(this.CoursesBindingNavigatorSaveItem_Click);
            // 
            // courseLabel
            // 
            courseLabel.AutoSize = true;
            courseLabel.Location = new System.Drawing.Point(42, 95);
            courseLabel.Name = "courseLabel";
            courseLabel.Size = new System.Drawing.Size(45, 13);
            courseLabel.TabIndex = 3;
            courseLabel.Text = "Course:";
            // 
            // courseTextBox
            // 
            this.courseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "Course", true));
            this.courseTextBox.Location = new System.Drawing.Point(122, 92);
            this.courseTextBox.Name = "courseTextBox";
            this.courseTextBox.Size = new System.Drawing.Size(120, 20);
            this.courseTextBox.TabIndex = 4;
            // 
            // credit_HoursLabel
            // 
            credit_HoursLabel.AutoSize = true;
            credit_HoursLabel.Location = new System.Drawing.Point(42, 118);
            credit_HoursLabel.Name = "credit_HoursLabel";
            credit_HoursLabel.Size = new System.Drawing.Size(71, 13);
            credit_HoursLabel.TabIndex = 5;
            credit_HoursLabel.Text = "Credit Hours:";
            // 
            // credit_HoursNumericUpDown
            // 
            this.credit_HoursNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.coursesBindingSource, "Credit Hours", true));
            this.credit_HoursNumericUpDown.Location = new System.Drawing.Point(122, 118);
            this.credit_HoursNumericUpDown.Name = "credit_HoursNumericUpDown";
            this.credit_HoursNumericUpDown.Size = new System.Drawing.Size(49, 20);
            this.credit_HoursNumericUpDown.TabIndex = 6;
            // 
            // class_TimeLabel
            // 
            class_TimeLabel.AutoSize = true;
            class_TimeLabel.Location = new System.Drawing.Point(42, 147);
            class_TimeLabel.Name = "class_TimeLabel";
            class_TimeLabel.Size = new System.Drawing.Size(61, 13);
            class_TimeLabel.TabIndex = 7;
            class_TimeLabel.Text = "Class Time:";
            // 
            // class_TimeTextBox
            // 
            this.class_TimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "Class Time", true));
            this.class_TimeTextBox.Location = new System.Drawing.Point(122, 144);
            this.class_TimeTextBox.Name = "class_TimeTextBox";
            this.class_TimeTextBox.Size = new System.Drawing.Size(120, 20);
            this.class_TimeTextBox.TabIndex = 8;
            // 
            // classroom_IDLabel
            // 
            classroom_IDLabel.AutoSize = true;
            classroom_IDLabel.Location = new System.Drawing.Point(320, 124);
            classroom_IDLabel.Name = "classroom_IDLabel";
            classroom_IDLabel.Size = new System.Drawing.Size(74, 13);
            classroom_IDLabel.TabIndex = 11;
            classroom_IDLabel.Text = "Classroom ID:";
            // 
            // classroom_IDTextBox
            // 
            this.classroom_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "Classroom ID", true));
            this.classroom_IDTextBox.Location = new System.Drawing.Point(400, 121);
            this.classroom_IDTextBox.Name = "classroom_IDTextBox";
            this.classroom_IDTextBox.Size = new System.Drawing.Size(120, 20);
            this.classroom_IDTextBox.TabIndex = 12;
            // 
            // instructorLabel
            // 
            instructorLabel.AutoSize = true;
            instructorLabel.Location = new System.Drawing.Point(320, 150);
            instructorLabel.Name = "instructorLabel";
            instructorLabel.Size = new System.Drawing.Size(59, 13);
            instructorLabel.TabIndex = 13;
            instructorLabel.Text = "Instructor:";
            // 
            // instructorTextBox
            // 
            this.instructorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "Instructor", true));
            this.instructorTextBox.Location = new System.Drawing.Point(400, 147);
            this.instructorTextBox.Name = "instructorTextBox";
            this.instructorTextBox.Size = new System.Drawing.Size(120, 20);
            this.instructorTextBox.TabIndex = 14;
            // 
            // class_DaysLabel
            // 
            class_DaysLabel.AutoSize = true;
            class_DaysLabel.Location = new System.Drawing.Point(320, 92);
            class_DaysLabel.Name = "class_DaysLabel";
            class_DaysLabel.Size = new System.Drawing.Size(63, 13);
            class_DaysLabel.TabIndex = 14;
            class_DaysLabel.Text = "Class Days:";
            // 
            // class_DaysTextBox
            // 
            this.class_DaysTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "Class Days", true));
            this.class_DaysTextBox.Location = new System.Drawing.Point(400, 89);
            this.class_DaysTextBox.Name = "class_DaysTextBox";
            this.class_DaysTextBox.Size = new System.Drawing.Size(120, 20);
            this.class_DaysTextBox.TabIndex = 15;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Green;
            this.btn_Add.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(105, 214);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(137, 42);
            this.btn_Add.TabIndex = 16;
            this.btn_Add.Text = "Add Course";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(360, 214);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 42);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "Exit";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click_1);
            // 
            // addCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(545, 300);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(class_DaysLabel);
            this.Controls.Add(this.class_DaysTextBox);
            this.Controls.Add(courseLabel);
            this.Controls.Add(this.courseTextBox);
            this.Controls.Add(credit_HoursLabel);
            this.Controls.Add(this.credit_HoursNumericUpDown);
            this.Controls.Add(class_TimeLabel);
            this.Controls.Add(this.class_TimeTextBox);
            this.Controls.Add(classroom_IDLabel);
            this.Controls.Add(this.classroom_IDTextBox);
            this.Controls.Add(instructorLabel);
            this.Controls.Add(this.instructorTextBox);
            this.Controls.Add(this.coursesBindingNavigator);
            this.Name = "addCourse";
            this.Text = "New Course";
            this.Load += new System.EventHandler(this.AddCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.regesterationAppDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingNavigator)).EndInit();
            this.coursesBindingNavigator.ResumeLayout(false);
            this.coursesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.credit_HoursNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private regesterationAppDataSet2 regesterationAppDataSet2;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private regesterationAppDataSet2TableAdapters.coursesTableAdapter coursesTableAdapter;
        private regesterationAppDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator coursesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton coursesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox courseTextBox;
        private System.Windows.Forms.NumericUpDown credit_HoursNumericUpDown;
        private System.Windows.Forms.TextBox class_TimeTextBox;
        private System.Windows.Forms.TextBox classroom_IDTextBox;
        private System.Windows.Forms.TextBox instructorTextBox;
        private System.Windows.Forms.TextBox class_DaysTextBox;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btnDelete;
    }
}