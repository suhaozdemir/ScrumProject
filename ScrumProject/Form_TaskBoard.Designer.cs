
namespace ScrumProject
{
    partial class Form_TaskBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_TaskBoard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ToDo = new System.Windows.Forms.Label();
            this.lb_Completed = new System.Windows.Forms.ListBox();
            this.lb_Review = new System.Windows.Forms.ListBox();
            this.lb_InProgress = new System.Windows.Forms.ListBox();
            this.lb_Research = new System.Windows.Forms.ListBox();
            this.lb_ToDo = new System.Windows.Forms.ListBox();
            this.panel_Title = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lbl_Top = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.bt_Close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel_Title.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bt_Close);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_ToDo);
            this.panel1.Controls.Add(this.lb_Completed);
            this.panel1.Controls.Add(this.lb_Review);
            this.panel1.Controls.Add(this.lb_InProgress);
            this.panel1.Controls.Add(this.lb_Research);
            this.panel1.Controls.Add(this.lb_ToDo);
            this.panel1.Controls.Add(this.panel_Title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 610);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(145)))));
            this.label4.Location = new System.Drawing.Point(991, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Completed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(145)))));
            this.label3.Location = new System.Drawing.Point(745, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Review";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(145)))));
            this.label2.Location = new System.Drawing.Point(502, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "In Progress";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(145)))));
            this.label1.Location = new System.Drawing.Point(260, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Research";
            // 
            // lbl_ToDo
            // 
            this.lbl_ToDo.AutoSize = true;
            this.lbl_ToDo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_ToDo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(145)))));
            this.lbl_ToDo.Location = new System.Drawing.Point(20, 103);
            this.lbl_ToDo.Name = "lbl_ToDo";
            this.lbl_ToDo.Size = new System.Drawing.Size(50, 19);
            this.lbl_ToDo.TabIndex = 4;
            this.lbl_ToDo.Text = "ToDo";
            // 
            // lb_Completed
            // 
            this.lb_Completed.AllowDrop = true;
            this.lb_Completed.FormattingEnabled = true;
            this.lb_Completed.ItemHeight = 16;
            this.lb_Completed.Location = new System.Drawing.Point(995, 128);
            this.lb_Completed.Name = "lb_Completed";
            this.lb_Completed.Size = new System.Drawing.Size(204, 436);
            this.lb_Completed.TabIndex = 10;
            this.lb_Completed.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox_DragDrop);
            this.lb_Completed.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox_DragEnter);
            this.lb_Completed.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox_DragOver);
            this.lb_Completed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDown);
            // 
            // lb_Review
            // 
            this.lb_Review.AllowDrop = true;
            this.lb_Review.FormattingEnabled = true;
            this.lb_Review.ItemHeight = 16;
            this.lb_Review.Location = new System.Drawing.Point(749, 128);
            this.lb_Review.Name = "lb_Review";
            this.lb_Review.Size = new System.Drawing.Size(204, 436);
            this.lb_Review.TabIndex = 9;
            this.lb_Review.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox_DragDrop);
            this.lb_Review.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox_DragEnter);
            this.lb_Review.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox_DragOver);
            this.lb_Review.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDown);
            // 
            // lb_InProgress
            // 
            this.lb_InProgress.AllowDrop = true;
            this.lb_InProgress.FormattingEnabled = true;
            this.lb_InProgress.ItemHeight = 16;
            this.lb_InProgress.Location = new System.Drawing.Point(506, 128);
            this.lb_InProgress.Name = "lb_InProgress";
            this.lb_InProgress.Size = new System.Drawing.Size(204, 436);
            this.lb_InProgress.TabIndex = 8;
            this.lb_InProgress.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox_DragDrop);
            this.lb_InProgress.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox_DragEnter);
            this.lb_InProgress.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox_DragOver);
            this.lb_InProgress.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDown);
            // 
            // lb_Research
            // 
            this.lb_Research.AllowDrop = true;
            this.lb_Research.FormattingEnabled = true;
            this.lb_Research.ItemHeight = 16;
            this.lb_Research.Location = new System.Drawing.Point(264, 128);
            this.lb_Research.Name = "lb_Research";
            this.lb_Research.Size = new System.Drawing.Size(204, 436);
            this.lb_Research.TabIndex = 7;
            this.lb_Research.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox_DragDrop);
            this.lb_Research.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox_DragEnter);
            this.lb_Research.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox_DragOver);
            this.lb_Research.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDown);
            // 
            // lb_ToDo
            // 
            this.lb_ToDo.AllowDrop = true;
            this.lb_ToDo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_ToDo.FormattingEnabled = true;
            this.lb_ToDo.ItemHeight = 16;
            this.lb_ToDo.Location = new System.Drawing.Point(24, 128);
            this.lb_ToDo.Name = "lb_ToDo";
            this.lb_ToDo.Size = new System.Drawing.Size(204, 436);
            this.lb_ToDo.TabIndex = 6;
            this.lb_ToDo.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox_DragDrop);
            this.lb_ToDo.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox_DragEnter);
            this.lb_ToDo.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox_DragOver);
            this.lb_ToDo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDown);
            // 
            // panel_Title
            // 
            this.panel_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.panel_Title.Controls.Add(this.panelTop);
            this.panel_Title.Controls.Add(this.lbl_Title);
            this.panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(1234, 100);
            this.panel_Title.TabIndex = 5;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(124)))));
            this.panelTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelTop.Controls.Add(this.lbl_Top);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(228, 100);
            this.panelTop.TabIndex = 3;
            // 
            // lbl_Top
            // 
            this.lbl_Top.AutoSize = true;
            this.lbl_Top.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Top.ForeColor = System.Drawing.Color.White;
            this.lbl_Top.Location = new System.Drawing.Point(36, 39);
            this.lbl_Top.Name = "lbl_Top";
            this.lbl_Top.Size = new System.Drawing.Size(156, 34);
            this.lbl_Top.TabIndex = 0;
            this.lbl_Top.Text = "Task Board App";
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(145)))));
            this.lbl_Title.Location = new System.Drawing.Point(646, 39);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(110, 34);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "TaskBoard";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.bt_Close.Location = new System.Drawing.Point(24, 568);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(1175, 39);
            this.bt_Close.TabIndex = 23;
            this.bt_Close.Text = "  Close";
            this.bt_Close.UseVisualStyleBackColor = false;
            this.bt_Close.Click += new System.EventHandler(this.bt_Close_Click);
            // 
            // Form_TaskBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 610);
            this.Controls.Add(this.panel1);
            this.Name = "Form_TaskBoard";
            this.Text = "Form_TaskBoard";
            this.Load += new System.EventHandler(this.Form_TaskBoard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_Title.ResumeLayout(false);
            this.panel_Title.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_Title;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lbl_Top;
        private System.Windows.Forms.Label lbl_ToDo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox lb_ToDo;
        public System.Windows.Forms.ListBox lb_Completed;
        public System.Windows.Forms.ListBox lb_Review;
        public System.Windows.Forms.ListBox lb_InProgress;
        public System.Windows.Forms.ListBox lb_Research;
        private System.Windows.Forms.Button bt_Close;
    }
}