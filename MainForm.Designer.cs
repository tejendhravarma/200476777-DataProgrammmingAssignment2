
namespace LoginApp
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.txtTimeTable = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtEmailId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGPA = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(285, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(676, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Student Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(285, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Course";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(489, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Time Table";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(672, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Contact Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(283, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Email Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(676, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Gender";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(215, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 0;
            // 
            // txtStudentId
            // 
            this.txtStudentId.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtStudentId.Location = new System.Drawing.Point(386, 101);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(250, 30);
            this.txtStudentId.TabIndex = 1;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtStudentName.Location = new System.Drawing.Point(824, 101);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(250, 30);
            this.txtStudentName.TabIndex = 1;
            // 
            // txtCourse
            // 
            this.txtCourse.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCourse.Location = new System.Drawing.Point(386, 148);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(73, 30);
            this.txtCourse.TabIndex = 1;
            // 
            // txtTimeTable
            // 
            this.txtTimeTable.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTimeTable.Location = new System.Drawing.Point(586, 148);
            this.txtTimeTable.Name = "txtTimeTable";
            this.txtTimeTable.Size = new System.Drawing.Size(50, 30);
            this.txtTimeTable.TabIndex = 1;
            // 
            // txtSex
            // 
            this.txtSex.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSex.Location = new System.Drawing.Point(745, 148);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(35, 30);
            this.txtSex.TabIndex = 1;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtContactNumber.Location = new System.Drawing.Point(824, 193);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(250, 30);
            this.txtContactNumber.TabIndex = 1;
            // 
            // txtEmailId
            // 
            this.txtEmailId.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEmailId.Location = new System.Drawing.Point(386, 193);
            this.txtEmailId.Name = "txtEmailId";
            this.txtEmailId.Size = new System.Drawing.Size(250, 30);
            this.txtEmailId.TabIndex = 2;
            this.txtEmailId.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(581, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(711, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(269, 360);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(826, 188);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(283, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "GPA";
            // 
            // txtGPA
            // 
            this.txtGPA.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtGPA.Location = new System.Drawing.Point(386, 246);
            this.txtGPA.Name = "txtGPA";
            this.txtGPA.Size = new System.Drawing.Size(44, 30);
            this.txtGPA.TabIndex = 2;
            this.txtGPA.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtResult.Location = new System.Drawing.Point(755, 246);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(35, 30);
            this.txtResult.TabIndex = 1;
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Result.Location = new System.Drawing.Point(676, 253);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(57, 23);
            this.Result.TabIndex = 5;
            this.Result.Text = "Result";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label10.Font = new System.Drawing.Font("Verdana", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(269, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(808, 55);
            this.label10.TabIndex = 6;
            this.label10.Text = "Georgian College Students Data";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 549);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtGPA);
            this.Controls.Add(this.txtEmailId);
            this.Controls.Add(this.txtContactNumber);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.txtTimeTable);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.TextBox txtTimeTable;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtEmailId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGPA;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label label10;
    }
}