
namespace WorkTime4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dateTimeJobStart = new System.Windows.Forms.DateTimePicker();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.btnAddJob = new System.Windows.Forms.Button();
            this.textJobName = new System.Windows.Forms.TextBox();
            this.jobName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textTimeEntry = new System.Windows.Forms.TextBox();
            this.labelStartTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimeJobStart
            // 
            this.dateTimeJobStart.Location = new System.Drawing.Point(12, 33);
            this.dateTimeJobStart.Name = "dateTimeJobStart";
            this.dateTimeJobStart.Size = new System.Drawing.Size(270, 23);
            this.dateTimeJobStart.TabIndex = 1;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox2.Location = new System.Drawing.Point(288, 33);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(444, 367);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "";
            // 
            // btnAddJob
            // 
            this.btnAddJob.Location = new System.Drawing.Point(110, 120);
            this.btnAddJob.Name = "btnAddJob";
            this.btnAddJob.Size = new System.Drawing.Size(75, 23);
            this.btnAddJob.TabIndex = 5;
            this.btnAddJob.Text = "Add Job";
            this.btnAddJob.UseVisualStyleBackColor = true;
            this.btnAddJob.Click += new System.EventHandler(this.btnAddJob_Click);
            // 
            // textJobName
            // 
            this.textJobName.ForeColor = System.Drawing.Color.DimGray;
            this.textJobName.Location = new System.Drawing.Point(81, 62);
            this.textJobName.Name = "textJobName";
            this.textJobName.Size = new System.Drawing.Size(201, 23);
            this.textJobName.TabIndex = 6;
            this.textJobName.Text = "Enter Job Name...";
            this.textJobName.Enter += new System.EventHandler(this.jobNameEnter);
            this.textJobName.Leave += new System.EventHandler(this.jobNameLeave);
            // 
            // jobName
            // 
            this.jobName.AutoSize = true;
            this.jobName.BackColor = System.Drawing.SystemColors.Control;
            this.jobName.Location = new System.Drawing.Point(12, 65);
            this.jobName.Name = "jobName";
            this.jobName.Size = new System.Drawing.Size(63, 15);
            this.jobName.TabIndex = 7;
            this.jobName.Text = "Job Name:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 451);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // textTimeEntry
            // 
            this.textTimeEntry.ForeColor = System.Drawing.Color.DimGray;
            this.textTimeEntry.Location = new System.Drawing.Point(81, 91);
            this.textTimeEntry.Name = "textTimeEntry";
            this.textTimeEntry.Size = new System.Drawing.Size(201, 23);
            this.textTimeEntry.TabIndex = 9;
            this.textTimeEntry.Text = "Time HH:MM";
            this.textTimeEntry.TextChanged += new System.EventHandler(this.textTimeChanged);
            this.textTimeEntry.Enter += new System.EventHandler(this.StartTimeEnter);
            this.textTimeEntry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressEvent);
            this.textTimeEntry.Leave += new System.EventHandler(this.startTimeLeave);
            // 
            // labelStartTime
            // 
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.Location = new System.Drawing.Point(12, 91);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(60, 15);
            this.labelStartTime.TabIndex = 10;
            this.labelStartTime.Text = "Start Time";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelStartTime);
            this.Controls.Add(this.textTimeEntry);
            this.Controls.Add(this.jobName);
            this.Controls.Add(this.textJobName);
            this.Controls.Add(this.btnAddJob);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.dateTimeJobStart);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "WorkTime 4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimeJobStart;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button btnAddJob;
        private System.Windows.Forms.TextBox textJobName;
        private System.Windows.Forms.Label jobName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textTimeEntry;
        private System.Windows.Forms.Label labelStartTime;
    }
}

