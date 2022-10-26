namespace Lab8
{
    partial class CourseForm
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
            this.courseListBox = new System.Windows.Forms.ListBox();
            this.getCourseButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.meetingTimeLabel = new System.Windows.Forms.Label();
            this.instructorLabel = new System.Windows.Forms.Label();
            this.roomNumberLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Course Number";
            // 
            // courseListBox
            // 
            this.courseListBox.FormattingEnabled = true;
            this.courseListBox.ItemHeight = 25;
            this.courseListBox.Location = new System.Drawing.Point(219, 96);
            this.courseListBox.Name = "courseListBox";
            this.courseListBox.Size = new System.Drawing.Size(314, 254);
            this.courseListBox.TabIndex = 1;
            // 
            // getCourseButton
            // 
            this.getCourseButton.Location = new System.Drawing.Point(219, 387);
            this.getCourseButton.Name = "getCourseButton";
            this.getCourseButton.Size = new System.Drawing.Size(314, 39);
            this.getCourseButton.TabIndex = 2;
            this.getCourseButton.Text = "Get Course Info";
            this.getCourseButton.UseVisualStyleBackColor = true;
            this.getCourseButton.Click += new System.EventHandler(this.getCourseButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.meetingTimeLabel);
            this.groupBox1.Controls.Add(this.instructorLabel);
            this.groupBox1.Controls.Add(this.roomNumberLabel);
            this.groupBox1.Location = new System.Drawing.Point(152, 486);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 218);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Course Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Meeting Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Instructor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Room Number";
            // 
            // meetingTimeLabel
            // 
            this.meetingTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.meetingTimeLabel.Location = new System.Drawing.Point(209, 162);
            this.meetingTimeLabel.Name = "meetingTimeLabel";
            this.meetingTimeLabel.Size = new System.Drawing.Size(225, 36);
            this.meetingTimeLabel.TabIndex = 2;
            // 
            // instructorLabel
            // 
            this.instructorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.instructorLabel.Location = new System.Drawing.Point(209, 113);
            this.instructorLabel.Name = "instructorLabel";
            this.instructorLabel.Size = new System.Drawing.Size(225, 36);
            this.instructorLabel.TabIndex = 1;
            // 
            // roomNumberLabel
            // 
            this.roomNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomNumberLabel.Location = new System.Drawing.Point(209, 63);
            this.roomNumberLabel.Name = "roomNumberLabel";
            this.roomNumberLabel.Size = new System.Drawing.Size(225, 36);
            this.roomNumberLabel.TabIndex = 0;
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 808);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.getCourseButton);
            this.Controls.Add(this.courseListBox);
            this.Controls.Add(this.label1);
            this.Name = "CourseForm";
            this.Text = "CourseForm1";
            this.Load += new System.EventHandler(this.CourseForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox courseListBox;
        private System.Windows.Forms.Button getCourseButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label meetingTimeLabel;
        private System.Windows.Forms.Label instructorLabel;
        private System.Windows.Forms.Label roomNumberLabel;
    }
}