namespace BeehiveManagementSystem
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
            this.report = new System.Windows.Forms.TextBox();
            this.nextShift = new System.Windows.Forms.Button();
            this.workerBeeJob = new System.Windows.Forms.ComboBox();
            this.shifts = new System.Windows.Forms.NumericUpDown();
            this.assignWork = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).BeginInit();
            this.SuspendLayout();
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(12, 120);
            this.report.Multiline = true;
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(415, 162);
            this.report.TabIndex = 0;
            // 
            // nextShift
            // 
            this.nextShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextShift.Location = new System.Drawing.Point(279, 18);
            this.nextShift.Name = "nextShift";
            this.nextShift.Size = new System.Drawing.Size(147, 91);
            this.nextShift.TabIndex = 1;
            this.nextShift.Text = "Work The Next Shift";
            this.nextShift.UseVisualStyleBackColor = true;
            this.nextShift.Click += new System.EventHandler(this.nextShift_Click);
            // 
            // workerBeeJob
            // 
            this.workerBeeJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workerBeeJob.FormattingEnabled = true;
            this.workerBeeJob.Items.AddRange(new object[] {
            "Baby Bee Tutoring",
            "Egg Care",
            "Hive Maintenance ",
            "Honey Manufacturing",
            "Nectar Collector",
            "Sting Patrol"});
            this.workerBeeJob.Location = new System.Drawing.Point(36, 56);
            this.workerBeeJob.Name = "workerBeeJob";
            this.workerBeeJob.Size = new System.Drawing.Size(121, 21);
            this.workerBeeJob.TabIndex = 2;
            // 
            // shifts
            // 
            this.shifts.Location = new System.Drawing.Point(162, 56);
            this.shifts.Name = "shifts";
            this.shifts.Size = new System.Drawing.Size(96, 20);
            this.shifts.TabIndex = 3;
            // 
            // assignWork
            // 
            this.assignWork.Location = new System.Drawing.Point(34, 84);
            this.assignWork.Name = "assignWork";
            this.assignWork.Size = new System.Drawing.Size(224, 23);
            this.assignWork.TabIndex = 4;
            this.assignWork.Text = "Assign This Job To A Bee";
            this.assignWork.UseVisualStyleBackColor = true;
            this.assignWork.Click += new System.EventHandler(this.assignWork_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Job";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Shifts";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 96);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Worker Bee Assignments";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 294);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.assignWork);
            this.Controls.Add(this.shifts);
            this.Controls.Add(this.workerBeeJob);
            this.Controls.Add(this.nextShift);
            this.Controls.Add(this.report);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Beehive Management System";
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox report;
        private System.Windows.Forms.Button nextShift;
        private System.Windows.Forms.ComboBox workerBeeJob;
        private System.Windows.Forms.NumericUpDown shifts;
        private System.Windows.Forms.Button assignWork;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

