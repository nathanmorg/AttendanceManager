namespace AttendanceManager
{
    partial class Form1
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
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label gradeLevelLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label numberAbsencesLabel;
            System.Windows.Forms.Label teacherLabel;
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.gradeLevelTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.numberAbsencesTextBox = new System.Windows.Forms.TextBox();
            this.teacherTextBox = new System.Windows.Forms.TextBox();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnMarkAbsent = new System.Windows.Forms.Button();
            firstNameLabel = new System.Windows.Forms.Label();
            gradeLevelLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            numberAbsencesLabel = new System.Windows.Forms.Label();
            teacherLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(165, 86);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(57, 13);
            firstNameLabel.TabIndex = 1;
            firstNameLabel.Text = "first Name:";
            // 
            // gradeLevelLabel
            // 
            gradeLevelLabel.AutoSize = true;
            gradeLevelLabel.Location = new System.Drawing.Point(363, 88);
            gradeLevelLabel.Name = "gradeLevelLabel";
            gradeLevelLabel.Size = new System.Drawing.Size(66, 13);
            gradeLevelLabel.TabIndex = 3;
            gradeLevelLabel.Text = "grade Level:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(165, 111);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(57, 13);
            lastNameLabel.TabIndex = 7;
            lastNameLabel.Text = "last Name:";
            // 
            // numberAbsencesLabel
            // 
            numberAbsencesLabel.AutoSize = true;
            numberAbsencesLabel.Location = new System.Drawing.Point(334, 111);
            numberAbsencesLabel.Name = "numberAbsencesLabel";
            numberAbsencesLabel.Size = new System.Drawing.Size(95, 13);
            numberAbsencesLabel.TabIndex = 9;
            numberAbsencesLabel.Text = "number Absences:";
            // 
            // teacherLabel
            // 
            teacherLabel.AutoSize = true;
            teacherLabel.Location = new System.Drawing.Point(176, 142);
            teacherLabel.Name = "teacherLabel";
            teacherLabel.Size = new System.Drawing.Size(46, 13);
            teacherLabel.TabIndex = 11;
            teacherLabel.Text = "teacher:";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(AttendanceManager.Student);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "firstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(228, 83);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 2;
            // 
            // gradeLevelTextBox
            // 
            this.gradeLevelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "gradeLevel", true));
            this.gradeLevelTextBox.Location = new System.Drawing.Point(435, 85);
            this.gradeLevelTextBox.Name = "gradeLevelTextBox";
            this.gradeLevelTextBox.Size = new System.Drawing.Size(100, 20);
            this.gradeLevelTextBox.TabIndex = 4;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "lastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(228, 111);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 8;
            // 
            // numberAbsencesTextBox
            // 
            this.numberAbsencesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "numberAbsences", true));
            this.numberAbsencesTextBox.Location = new System.Drawing.Point(435, 111);
            this.numberAbsencesTextBox.Name = "numberAbsencesTextBox";
            this.numberAbsencesTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberAbsencesTextBox.TabIndex = 10;
            // 
            // teacherTextBox
            // 
            this.teacherTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "teacher", true));
            this.teacherTextBox.Location = new System.Drawing.Point(228, 139);
            this.teacherTextBox.Name = "teacherTextBox";
            this.teacherTextBox.Size = new System.Drawing.Size(100, 20);
            this.teacherTextBox.TabIndex = 12;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(268, 254);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(44, 35);
            this.btnFirst.TabIndex = 13;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(316, 254);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(44, 35);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(366, 254);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(44, 35);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(416, 254);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(44, 35);
            this.btnLast.TabIndex = 16;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnMarkAbsent
            // 
            this.btnMarkAbsent.Location = new System.Drawing.Point(316, 225);
            this.btnMarkAbsent.Name = "btnMarkAbsent";
            this.btnMarkAbsent.Size = new System.Drawing.Size(94, 23);
            this.btnMarkAbsent.TabIndex = 17;
            this.btnMarkAbsent.Text = "Mark Absent";
            this.btnMarkAbsent.UseVisualStyleBackColor = true;
            this.btnMarkAbsent.Click += new System.EventHandler(this.btnMarkAbsent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMarkAbsent);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(gradeLevelLabel);
            this.Controls.Add(this.gradeLevelTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(numberAbsencesLabel);
            this.Controls.Add(this.numberAbsencesTextBox);
            this.Controls.Add(teacherLabel);
            this.Controls.Add(this.teacherTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox gradeLevelTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox numberAbsencesTextBox;
        private System.Windows.Forms.TextBox teacherTextBox;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnMarkAbsent;
    }
}

