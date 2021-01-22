
namespace ScrumProject
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_Title = new System.Windows.Forms.Panel();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.bt_Todo = new System.Windows.Forms.Button();
            this.bt_Delete = new System.Windows.Forms.Button();
            this.bt_Edit = new System.Windows.Forms.Button();
            this.panel_UI = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_Add = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lbl_Top = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.bt_Refresh = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_Title.SuspendLayout();
            this.panel_UI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Title
            // 
            this.panel_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.panel_Title.Controls.Add(this.lbl_Date);
            this.panel_Title.Controls.Add(this.lbl_Title);
            this.panel_Title.Controls.Add(this.lbl_Time);
            this.panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title.Location = new System.Drawing.Point(220, 0);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(862, 100);
            this.panel_Title.TabIndex = 4;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 11.2F, System.Drawing.FontStyle.Bold);
            this.lbl_Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(145)))));
            this.lbl_Date.Location = new System.Drawing.Point(746, 34);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(46, 23);
            this.lbl_Date.TabIndex = 2;
            this.lbl_Date.Text = "label1";
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(145)))));
            this.lbl_Title.Location = new System.Drawing.Point(366, 34);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(65, 34);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Menu";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 11.2F, System.Drawing.FontStyle.Bold);
            this.lbl_Time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(145)))));
            this.lbl_Time.Location = new System.Drawing.Point(722, 57);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(46, 23);
            this.lbl_Time.TabIndex = 1;
            this.lbl_Time.Text = "label1";
            // 
            // bt_Todo
            // 
            this.bt_Todo.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Todo.FlatAppearance.BorderSize = 0;
            this.bt_Todo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Todo.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_Todo.ForeColor = System.Drawing.Color.White;
            this.bt_Todo.Image = ((System.Drawing.Image)(resources.GetObject("bt_Todo.Image")));
            this.bt_Todo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Todo.Location = new System.Drawing.Point(0, 307);
            this.bt_Todo.Name = "bt_Todo";
            this.bt_Todo.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.bt_Todo.Size = new System.Drawing.Size(220, 69);
            this.bt_Todo.TabIndex = 6;
            this.bt_Todo.Text = "  To Do List";
            this.bt_Todo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Todo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Todo.UseVisualStyleBackColor = true;
            this.bt_Todo.Click += new System.EventHandler(this.bt_Todo_Click);
            // 
            // bt_Delete
            // 
            this.bt_Delete.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Delete.FlatAppearance.BorderSize = 0;
            this.bt_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Delete.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_Delete.ForeColor = System.Drawing.Color.White;
            this.bt_Delete.Image = ((System.Drawing.Image)(resources.GetObject("bt_Delete.Image")));
            this.bt_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Delete.Location = new System.Drawing.Point(0, 238);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.bt_Delete.Size = new System.Drawing.Size(220, 69);
            this.bt_Delete.TabIndex = 5;
            this.bt_Delete.Text = "  Delete Task";
            this.bt_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Delete.UseVisualStyleBackColor = true;
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            // 
            // bt_Edit
            // 
            this.bt_Edit.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Edit.FlatAppearance.BorderSize = 0;
            this.bt_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Edit.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_Edit.ForeColor = System.Drawing.Color.White;
            this.bt_Edit.Image = ((System.Drawing.Image)(resources.GetObject("bt_Edit.Image")));
            this.bt_Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Edit.Location = new System.Drawing.Point(0, 169);
            this.bt_Edit.Name = "bt_Edit";
            this.bt_Edit.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.bt_Edit.Size = new System.Drawing.Size(220, 69);
            this.bt_Edit.TabIndex = 4;
            this.bt_Edit.Text = "  Edit Task";
            this.bt_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Edit.UseVisualStyleBackColor = true;
            this.bt_Edit.Click += new System.EventHandler(this.bt_Edit_Click);
            // 
            // panel_UI
            // 
            this.panel_UI.BackColor = System.Drawing.Color.White;
            this.panel_UI.Controls.Add(this.dataGridView1);
            this.panel_UI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_UI.Location = new System.Drawing.Point(220, 0);
            this.panel_UI.Name = "panel_UI";
            this.panel_UI.Size = new System.Drawing.Size(862, 513);
            this.panel_UI.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(844, 404);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // bt_Add
            // 
            this.bt_Add.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Add.FlatAppearance.BorderSize = 0;
            this.bt_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Add.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_Add.ForeColor = System.Drawing.Color.White;
            this.bt_Add.Image = ((System.Drawing.Image)(resources.GetObject("bt_Add.Image")));
            this.bt_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Add.Location = new System.Drawing.Point(0, 100);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.bt_Add.Size = new System.Drawing.Size(220, 69);
            this.bt_Add.TabIndex = 3;
            this.bt_Add.Text = "   Add Task";
            this.bt_Add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Add.UseVisualStyleBackColor = true;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(124)))));
            this.panelTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelTop.Controls.Add(this.lbl_Top);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(220, 100);
            this.panelTop.TabIndex = 1;
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
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(145)))));
            this.panelMenu.Controls.Add(this.bt_Exit);
            this.panelMenu.Controls.Add(this.bt_Refresh);
            this.panelMenu.Controls.Add(this.bt_Todo);
            this.panelMenu.Controls.Add(this.bt_Delete);
            this.panelMenu.Controls.Add(this.bt_Edit);
            this.panelMenu.Controls.Add(this.bt_Add);
            this.panelMenu.Controls.Add(this.panelTop);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 513);
            this.panelMenu.TabIndex = 3;
            // 
            // bt_Exit
            // 
            this.bt_Exit.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Exit.FlatAppearance.BorderSize = 0;
            this.bt_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Exit.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_Exit.ForeColor = System.Drawing.Color.White;
            this.bt_Exit.Image = ((System.Drawing.Image)(resources.GetObject("bt_Exit.Image")));
            this.bt_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Exit.Location = new System.Drawing.Point(0, 445);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.bt_Exit.Size = new System.Drawing.Size(220, 69);
            this.bt_Exit.TabIndex = 8;
            this.bt_Exit.Text = "  Close App";
            this.bt_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Exit.UseVisualStyleBackColor = true;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // bt_Refresh
            // 
            this.bt_Refresh.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Refresh.FlatAppearance.BorderSize = 0;
            this.bt_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Refresh.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_Refresh.ForeColor = System.Drawing.Color.White;
            this.bt_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("bt_Refresh.Image")));
            this.bt_Refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Refresh.Location = new System.Drawing.Point(0, 376);
            this.bt_Refresh.Name = "bt_Refresh";
            this.bt_Refresh.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.bt_Refresh.Size = new System.Drawing.Size(220, 69);
            this.bt_Refresh.TabIndex = 7;
            this.bt_Refresh.Text = "  Refresh Table";
            this.bt_Refresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Refresh.UseVisualStyleBackColor = true;
            this.bt_Refresh.Click += new System.EventHandler(this.bt_Refresh_Click_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 513);
            this.Controls.Add(this.panel_Title);
            this.Controls.Add(this.panel_UI);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_Title.ResumeLayout(false);
            this.panel_Title.PerformLayout();
            this.panel_UI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_Title;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Button bt_Todo;
        private System.Windows.Forms.Button bt_Delete;
        private System.Windows.Forms.Button bt_Edit;
        private System.Windows.Forms.Panel panel_UI;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lbl_Top;
        private System.Windows.Forms.Panel panelMenu;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_Refresh;
        private System.Windows.Forms.Button bt_Exit;
        private System.Windows.Forms.Timer timer1;
    }
}

