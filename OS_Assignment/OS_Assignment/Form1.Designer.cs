namespace OS_Assignment
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
            this.DGV_QUEUES = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.SJF_Button = new System.Windows.Forms.Button();
            this.Priority_Button = new System.Windows.Forms.Button();
            this.RoundRobin_Button = new System.Windows.Forms.Button();
            this.NonPreem_Button = new System.Windows.Forms.Button();
            this.Preemptive_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.procName_text = new System.Windows.Forms.TextBox();
            this.BurstTime_Text = new System.Windows.Forms.TextBox();
            this.PriNumber_Text = new System.Windows.Forms.TextBox();
            this.ArrivalTime_text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Finish_Button = new System.Windows.Forms.Button();
            this.AddProc_Button = new System.Windows.Forms.Button();
            this.FCFS_Button = new System.Windows.Forms.Button();
            this.ProcessListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_QUEUES)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_QUEUES
            // 
            this.DGV_QUEUES.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_QUEUES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_QUEUES.Location = new System.Drawing.Point(709, 12);
            this.DGV_QUEUES.Name = "DGV_QUEUES";
            this.DGV_QUEUES.Size = new System.Drawing.Size(457, 472);
            this.DGV_QUEUES.TabIndex = 0;
            this.DGV_QUEUES.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_QUEUES_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type of scheduler";
            // 
            // SJF_Button
            // 
            this.SJF_Button.Location = new System.Drawing.Point(210, 23);
            this.SJF_Button.Name = "SJF_Button";
            this.SJF_Button.Size = new System.Drawing.Size(91, 23);
            this.SJF_Button.TabIndex = 3;
            this.SJF_Button.Text = "SJF ";
            this.SJF_Button.UseVisualStyleBackColor = true;
            this.SJF_Button.Click += new System.EventHandler(this.SJF_Button_Click);
            // 
            // Priority_Button
            // 
            this.Priority_Button.Location = new System.Drawing.Point(307, 23);
            this.Priority_Button.Name = "Priority_Button";
            this.Priority_Button.Size = new System.Drawing.Size(75, 23);
            this.Priority_Button.TabIndex = 4;
            this.Priority_Button.Text = "Priority";
            this.Priority_Button.UseVisualStyleBackColor = true;
            this.Priority_Button.Click += new System.EventHandler(this.Priority_Button_Click);
            // 
            // RoundRobin_Button
            // 
            this.RoundRobin_Button.Location = new System.Drawing.Point(400, 23);
            this.RoundRobin_Button.Name = "RoundRobin_Button";
            this.RoundRobin_Button.Size = new System.Drawing.Size(99, 23);
            this.RoundRobin_Button.TabIndex = 5;
            this.RoundRobin_Button.Text = "Round Robin";
            this.RoundRobin_Button.UseVisualStyleBackColor = true;
            this.RoundRobin_Button.Click += new System.EventHandler(this.RoundRobin_Button_Click);
            // 
            // NonPreem_Button
            // 
            this.NonPreem_Button.Location = new System.Drawing.Point(307, 77);
            this.NonPreem_Button.Name = "NonPreem_Button";
            this.NonPreem_Button.Size = new System.Drawing.Size(116, 31);
            this.NonPreem_Button.TabIndex = 6;
            this.NonPreem_Button.Text = "Non Preemptive";
            this.NonPreem_Button.UseVisualStyleBackColor = true;
            this.NonPreem_Button.Click += new System.EventHandler(this.NonPreem_Button_Click);
            // 
            // Preemptive_Button
            // 
            this.Preemptive_Button.Location = new System.Drawing.Point(187, 77);
            this.Preemptive_Button.Name = "Preemptive_Button";
            this.Preemptive_Button.Size = new System.Drawing.Size(91, 31);
            this.Preemptive_Button.TabIndex = 7;
            this.Preemptive_Button.Text = "Preemptive";
            this.Preemptive_Button.UseVisualStyleBackColor = true;
            this.Preemptive_Button.Click += new System.EventHandler(this.Preemptive_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Priority Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Arrival Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Process Name";
            // 
            // procName_text
            // 
            this.procName_text.Location = new System.Drawing.Point(149, 172);
            this.procName_text.Name = "procName_text";
            this.procName_text.Size = new System.Drawing.Size(100, 20);
            this.procName_text.TabIndex = 11;
            // 
            // BurstTime_Text
            // 
            this.BurstTime_Text.Location = new System.Drawing.Point(149, 264);
            this.BurstTime_Text.Name = "BurstTime_Text";
            this.BurstTime_Text.Size = new System.Drawing.Size(100, 20);
            this.BurstTime_Text.TabIndex = 12;
            // 
            // PriNumber_Text
            // 
            this.PriNumber_Text.Location = new System.Drawing.Point(149, 317);
            this.PriNumber_Text.Name = "PriNumber_Text";
            this.PriNumber_Text.Size = new System.Drawing.Size(100, 20);
            this.PriNumber_Text.TabIndex = 13;
            // 
            // ArrivalTime_text
            // 
            this.ArrivalTime_text.Location = new System.Drawing.Point(149, 218);
            this.ArrivalTime_text.Name = "ArrivalTime_text";
            this.ArrivalTime_text.Size = new System.Drawing.Size(100, 20);
            this.ArrivalTime_text.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Burst Time";
            // 
            // Finish_Button
            // 
            this.Finish_Button.Location = new System.Drawing.Point(317, 378);
            this.Finish_Button.Name = "Finish_Button";
            this.Finish_Button.Size = new System.Drawing.Size(85, 23);
            this.Finish_Button.TabIndex = 16;
            this.Finish_Button.Text = "Finish";
            this.Finish_Button.UseVisualStyleBackColor = true;
            this.Finish_Button.Click += new System.EventHandler(this.Finish_Button_Click);
            // 
            // AddProc_Button
            // 
            this.AddProc_Button.Location = new System.Drawing.Point(158, 378);
            this.AddProc_Button.Name = "AddProc_Button";
            this.AddProc_Button.Size = new System.Drawing.Size(82, 23);
            this.AddProc_Button.TabIndex = 17;
            this.AddProc_Button.Text = "Add Process";
            this.AddProc_Button.UseVisualStyleBackColor = true;
            this.AddProc_Button.Click += new System.EventHandler(this.AddProc_Button_Click);
            // 
            // FCFS_Button
            // 
            this.FCFS_Button.Location = new System.Drawing.Point(129, 23);
            this.FCFS_Button.Name = "FCFS_Button";
            this.FCFS_Button.Size = new System.Drawing.Size(75, 23);
            this.FCFS_Button.TabIndex = 2;
            this.FCFS_Button.Text = "FCFS";
            this.FCFS_Button.UseVisualStyleBackColor = true;
            this.FCFS_Button.Click += new System.EventHandler(this.FCFS_Button_Click);
            // 
            // ProcessListBox
            // 
            this.ProcessListBox.FormattingEnabled = true;
            this.ProcessListBox.Location = new System.Drawing.Point(372, 138);
            this.ProcessListBox.Name = "ProcessListBox";
            this.ProcessListBox.Size = new System.Drawing.Size(183, 199);
            this.ProcessListBox.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 496);
            this.Controls.Add(this.ProcessListBox);
            this.Controls.Add(this.AddProc_Button);
            this.Controls.Add(this.Finish_Button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ArrivalTime_text);
            this.Controls.Add(this.PriNumber_Text);
            this.Controls.Add(this.BurstTime_Text);
            this.Controls.Add(this.procName_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Preemptive_Button);
            this.Controls.Add(this.NonPreem_Button);
            this.Controls.Add(this.RoundRobin_Button);
            this.Controls.Add(this.Priority_Button);
            this.Controls.Add(this.SJF_Button);
            this.Controls.Add(this.FCFS_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_QUEUES);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_QUEUES)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_QUEUES;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SJF_Button;
        private System.Windows.Forms.Button Priority_Button;
        private System.Windows.Forms.Button RoundRobin_Button;
        private System.Windows.Forms.Button NonPreem_Button;
        private System.Windows.Forms.Button Preemptive_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox procName_text;
        private System.Windows.Forms.TextBox BurstTime_Text;
        private System.Windows.Forms.TextBox PriNumber_Text;
        private System.Windows.Forms.TextBox ArrivalTime_text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Finish_Button;
        private System.Windows.Forms.Button AddProc_Button;
        private System.Windows.Forms.Button FCFS_Button;
        private System.Windows.Forms.ListBox ProcessListBox;
    }
}

