
namespace ScrumProject
{
    partial class Form_AddTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AddTask));
            this.bt_AddTask = new System.Windows.Forms.Button();
            this.txt_TechEx = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_Act = new System.Windows.Forms.Label();
            this.lbl_Est = new System.Windows.Forms.Label();
            this.lbl_Expert = new System.Windows.Forms.Label();
            this.cbox_trStatus = new System.Windows.Forms.ComboBox();
            this.gr_Detailed = new System.Windows.Forms.GroupBox();
            this.rtxt_Notes = new System.Windows.Forms.RichTextBox();
            this.rtxt_Des = new System.Windows.Forms.RichTextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.gr_Basic = new System.Windows.Forms.GroupBox();
            this.txt_Act = new System.Windows.Forms.DateTimePicker();
            this.txt_Est = new System.Windows.Forms.DateTimePicker();
            this.bt_Close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gr_Track = new System.Windows.Forms.GroupBox();
            this.txt_trDate = new System.Windows.Forms.DateTimePicker();
            this.txt_trDesc = new System.Windows.Forms.TextBox();
            this.txt_trWork = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.gr_Card = new System.Windows.Forms.GroupBox();
            this.txt_Date = new System.Windows.Forms.DateTimePicker();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_DT = new System.Windows.Forms.Label();
            this.gr_Detailed.SuspendLayout();
            this.gr_Basic.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gr_Track.SuspendLayout();
            this.gr_Card.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_AddTask
            // 
            this.bt_AddTask.BackColor = System.Drawing.Color.White;
            this.bt_AddTask.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(145)))));
            this.bt_AddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_AddTask.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_AddTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(145)))));
            this.bt_AddTask.Image = ((System.Drawing.Image)(resources.GetObject("bt_AddTask.Image")));
            this.bt_AddTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_AddTask.Location = new System.Drawing.Point(158, 540);
            this.bt_AddTask.Name = "bt_AddTask";
            this.bt_AddTask.Size = new System.Drawing.Size(210, 39);
            this.bt_AddTask.TabIndex = 21;
            this.bt_AddTask.Text = "  Add Task";
            this.bt_AddTask.UseVisualStyleBackColor = false;
            this.bt_AddTask.Click += new System.EventHandler(this.bt_AddTask_Click);
            // 
            // txt_TechEx
            // 
            this.txt_TechEx.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_TechEx.Location = new System.Drawing.Point(166, 57);
            this.txt_TechEx.Multiline = true;
            this.txt_TechEx.Name = "txt_TechEx";
            this.txt_TechEx.Size = new System.Drawing.Size(244, 23);
            this.txt_TechEx.TabIndex = 10;
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Name.Location = new System.Drawing.Point(166, 33);
            this.txt_Name.Multiline = true;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(244, 23);
            this.txt_Name.TabIndex = 8;
            // 
            // lbl_Act
            // 
            this.lbl_Act.AutoSize = true;
            this.lbl_Act.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Act.Location = new System.Drawing.Point(453, 57);
            this.lbl_Act.Name = "lbl_Act";
            this.lbl_Act.Size = new System.Drawing.Size(96, 20);
            this.lbl_Act.TabIndex = 9;
            this.lbl_Act.Text = "Actual Time:";
            // 
            // lbl_Est
            // 
            this.lbl_Est.AutoSize = true;
            this.lbl_Est.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Est.Location = new System.Drawing.Point(453, 24);
            this.lbl_Est.Name = "lbl_Est";
            this.lbl_Est.Size = new System.Drawing.Size(118, 20);
            this.lbl_Est.TabIndex = 6;
            this.lbl_Est.Text = "Estimated Time:";
            // 
            // lbl_Expert
            // 
            this.lbl_Expert.AutoSize = true;
            this.lbl_Expert.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Expert.Location = new System.Drawing.Point(18, 57);
            this.lbl_Expert.Name = "lbl_Expert";
            this.lbl_Expert.Size = new System.Drawing.Size(131, 20);
            this.lbl_Expert.TabIndex = 5;
            this.lbl_Expert.Text = "Technical Expert:";
            // 
            // cbox_trStatus
            // 
            this.cbox_trStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_trStatus.FormattingEnabled = true;
            this.cbox_trStatus.Items.AddRange(new object[] {
            "ToDo",
            "Research",
            "In Progress",
            "Review",
            "Completed"});
            this.cbox_trStatus.Location = new System.Drawing.Point(193, 53);
            this.cbox_trStatus.Name = "cbox_trStatus";
            this.cbox_trStatus.Size = new System.Drawing.Size(165, 27);
            this.cbox_trStatus.TabIndex = 2;
            // 
            // gr_Detailed
            // 
            this.gr_Detailed.BackColor = System.Drawing.Color.White;
            this.gr_Detailed.Controls.Add(this.rtxt_Notes);
            this.gr_Detailed.Controls.Add(this.rtxt_Des);
            this.gr_Detailed.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.gr_Detailed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(145)))));
            this.gr_Detailed.Location = new System.Drawing.Point(-8, 160);
            this.gr_Detailed.Name = "gr_Detailed";
            this.gr_Detailed.Size = new System.Drawing.Size(891, 263);
            this.gr_Detailed.TabIndex = 19;
            this.gr_Detailed.TabStop = false;
            this.gr_Detailed.Text = "Project Detailed Info";
            // 
            // rtxt_Notes
            // 
            this.rtxt_Notes.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtxt_Notes.Location = new System.Drawing.Point(21, 151);
            this.rtxt_Notes.Name = "rtxt_Notes";
            this.rtxt_Notes.Size = new System.Drawing.Size(809, 106);
            this.rtxt_Notes.TabIndex = 1;
            this.rtxt_Notes.Text = "Notes:";
            // 
            // rtxt_Des
            // 
            this.rtxt_Des.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtxt_Des.Location = new System.Drawing.Point(21, 31);
            this.rtxt_Des.Name = "rtxt_Des";
            this.rtxt_Des.Size = new System.Drawing.Size(809, 114);
            this.rtxt_Des.TabIndex = 0;
            this.rtxt_Des.Text = "Description:";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Name.Location = new System.Drawing.Point(18, 33);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(88, 20);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "ID / Name:";
            // 
            // gr_Basic
            // 
            this.gr_Basic.BackColor = System.Drawing.Color.White;
            this.gr_Basic.Controls.Add(this.txt_Act);
            this.gr_Basic.Controls.Add(this.txt_Est);
            this.gr_Basic.Controls.Add(this.txt_TechEx);
            this.gr_Basic.Controls.Add(this.txt_Name);
            this.gr_Basic.Controls.Add(this.lbl_Act);
            this.gr_Basic.Controls.Add(this.lbl_Est);
            this.gr_Basic.Controls.Add(this.lbl_Expert);
            this.gr_Basic.Controls.Add(this.lbl_Name);
            this.gr_Basic.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.gr_Basic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(145)))));
            this.gr_Basic.Location = new System.Drawing.Point(-8, 77);
            this.gr_Basic.Name = "gr_Basic";
            this.gr_Basic.Size = new System.Drawing.Size(891, 83);
            this.gr_Basic.TabIndex = 18;
            this.gr_Basic.TabStop = false;
            this.gr_Basic.Text = "Project Basic Info";
            // 
            // txt_Act
            // 
            this.txt_Act.Location = new System.Drawing.Point(586, 49);
            this.txt_Act.Name = "txt_Act";
            this.txt_Act.Size = new System.Drawing.Size(244, 28);
            this.txt_Act.TabIndex = 15;
            // 
            // txt_Est
            // 
            this.txt_Est.Location = new System.Drawing.Point(586, 17);
            this.txt_Est.Name = "txt_Est";
            this.txt_Est.Size = new System.Drawing.Size(244, 28);
            this.txt_Est.TabIndex = 14;
            // 
            // bt_Close
            // 
            this.bt_Close.BackColor = System.Drawing.Color.White;
            this.bt_Close.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(145)))));
            this.bt_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Close.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(145)))));
            this.bt_Close.Image = ((System.Drawing.Image)(resources.GetObject("bt_Close.Image")));
            this.bt_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Close.Location = new System.Drawing.Point(449, 540);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(210, 39);
            this.bt_Close.TabIndex = 22;
            this.bt_Close.Text = "  Close";
            this.bt_Close.UseVisualStyleBackColor = false;
            this.bt_Close.Click += new System.EventHandler(this.bt_Close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bt_Close);
            this.panel1.Controls.Add(this.bt_AddTask);
            this.panel1.Controls.Add(this.gr_Basic);
            this.panel1.Controls.Add(this.gr_Detailed);
            this.panel1.Controls.Add(this.gr_Track);
            this.panel1.Controls.Add(this.gr_Card);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 590);
            this.panel1.TabIndex = 1;
            // 
            // gr_Track
            // 
            this.gr_Track.BackColor = System.Drawing.Color.White;
            this.gr_Track.Controls.Add(this.txt_trDate);
            this.gr_Track.Controls.Add(this.cbox_trStatus);
            this.gr_Track.Controls.Add(this.txt_trDesc);
            this.gr_Track.Controls.Add(this.txt_trWork);
            this.gr_Track.Controls.Add(this.textBox6);
            this.gr_Track.Controls.Add(this.textBox7);
            this.gr_Track.Controls.Add(this.textBox5);
            this.gr_Track.Controls.Add(this.textBox4);
            this.gr_Track.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gr_Track.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(145)))));
            this.gr_Track.Location = new System.Drawing.Point(-8, 431);
            this.gr_Track.Name = "gr_Track";
            this.gr_Track.Size = new System.Drawing.Size(891, 103);
            this.gr_Track.TabIndex = 20;
            this.gr_Track.TabStop = false;
            this.gr_Track.Text = "Job Tracking";
            // 
            // txt_trDate
            // 
            this.txt_trDate.Location = new System.Drawing.Point(21, 53);
            this.txt_trDate.Name = "txt_trDate";
            this.txt_trDate.Size = new System.Drawing.Size(166, 28);
            this.txt_trDate.TabIndex = 14;
            // 
            // txt_trDesc
            // 
            this.txt_trDesc.Location = new System.Drawing.Point(532, 52);
            this.txt_trDesc.Name = "txt_trDesc";
            this.txt_trDesc.Size = new System.Drawing.Size(328, 28);
            this.txt_trDesc.TabIndex = 8;
            this.txt_trDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_trWork
            // 
            this.txt_trWork.Location = new System.Drawing.Point(364, 52);
            this.txt_trWork.Name = "txt_trWork";
            this.txt_trWork.Size = new System.Drawing.Size(165, 28);
            this.txt_trWork.TabIndex = 7;
            this.txt_trWork.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox6.Location = new System.Drawing.Point(532, 27);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(328, 26);
            this.textBox6.TabIndex = 4;
            this.textBox6.Text = "Description";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox7.Location = new System.Drawing.Point(363, 27);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(166, 26);
            this.textBox7.TabIndex = 3;
            this.textBox7.Text = "Work";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox5.Location = new System.Drawing.Point(193, 27);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(165, 26);
            this.textBox5.TabIndex = 1;
            this.textBox5.Text = "Status";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox4.Location = new System.Drawing.Point(22, 27);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(165, 26);
            this.textBox4.TabIndex = 0;
            this.textBox4.Text = "Date";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gr_Card
            // 
            this.gr_Card.BackColor = System.Drawing.Color.White;
            this.gr_Card.Controls.Add(this.txt_Date);
            this.gr_Card.Controls.Add(this.txt_ID);
            this.gr_Card.Controls.Add(this.lbl_ID);
            this.gr_Card.Controls.Add(this.lbl_DT);
            this.gr_Card.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gr_Card.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(145)))));
            this.gr_Card.Location = new System.Drawing.Point(-8, -2);
            this.gr_Card.Name = "gr_Card";
            this.gr_Card.Size = new System.Drawing.Size(891, 73);
            this.gr_Card.TabIndex = 17;
            this.gr_Card.TabStop = false;
            this.gr_Card.Text = "Card Info";
            // 
            // txt_Date
            // 
            this.txt_Date.Location = new System.Drawing.Point(586, 34);
            this.txt_Date.Name = "txt_Date";
            this.txt_Date.Size = new System.Drawing.Size(244, 28);
            this.txt_Date.TabIndex = 13;
            // 
            // txt_ID
            // 
            this.txt_ID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ID.Location = new System.Drawing.Point(166, 34);
            this.txt_ID.Multiline = true;
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(244, 23);
            this.txt_ID.TabIndex = 2;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ID.Location = new System.Drawing.Point(18, 34);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(81, 21);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Text = "Card ID:";
            // 
            // lbl_DT
            // 
            this.lbl_DT.AutoSize = true;
            this.lbl_DT.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_DT.Location = new System.Drawing.Point(453, 36);
            this.lbl_DT.Name = "lbl_DT";
            this.lbl_DT.Size = new System.Drawing.Size(100, 21);
            this.lbl_DT.TabIndex = 6;
            this.lbl_DT.Text = "Date Time:";
            // 
            // Form_AddTask
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(875, 598);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form_AddTask";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Text = "Form_AddTask";
            this.gr_Detailed.ResumeLayout(false);
            this.gr_Basic.ResumeLayout(false);
            this.gr_Basic.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gr_Track.ResumeLayout(false);
            this.gr_Track.PerformLayout();
            this.gr_Card.ResumeLayout(false);
            this.gr_Card.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_AddTask;
        private System.Windows.Forms.TextBox txt_TechEx;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lbl_Act;
        private System.Windows.Forms.Label lbl_Est;
        private System.Windows.Forms.Label lbl_Expert;
        private System.Windows.Forms.ComboBox cbox_trStatus;
        private System.Windows.Forms.GroupBox gr_Detailed;
        private System.Windows.Forms.RichTextBox rtxt_Notes;
        private System.Windows.Forms.RichTextBox rtxt_Des;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.GroupBox gr_Basic;
        private System.Windows.Forms.Button bt_Close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gr_Track;
        private System.Windows.Forms.TextBox txt_trDesc;
        private System.Windows.Forms.TextBox txt_trWork;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox gr_Card;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_DT;
        private System.Windows.Forms.DateTimePicker txt_Act;
        private System.Windows.Forms.DateTimePicker txt_Est;
        private System.Windows.Forms.DateTimePicker txt_Date;
        private System.Windows.Forms.DateTimePicker txt_trDate;
    }
}