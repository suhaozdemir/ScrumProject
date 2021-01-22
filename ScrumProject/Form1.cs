using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrumProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BLL frmbll = new BLL();

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = frmbll.Load();
            timer1.Start();
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            Form_AddTask frmadd = new Form_AddTask();
            frmadd.ShowDialog();            
        }

        private void bt_Edit_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Please double click on the card you want to edit in table." +
               " \nIf there isn't any card please try Refreshing Table or Add New Card");
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            Form_DeleteTask frmdlt = new Form_DeleteTask();
            frmdlt.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form_EditTask frmedit = new Form_EditTask();
            frmedit.txt_ID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmedit.txt_ID.ReadOnly = true;
            frmedit.txt_Date.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmedit.txt_Name.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmedit.txt_TechEx.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frmedit.txt_Est.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frmedit.txt_Act.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frmedit.rtxt_Des.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frmedit.rtxt_Notes.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            frmedit.txt_trDate.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            frmedit.cbox_trStatus.Text = this.dataGridView1.CurrentRow.Cells[10].Value.ToString();
            frmedit.txt_trWork.Text = this.dataGridView1.CurrentRow.Cells[11].Value.ToString();
            frmedit.txt_trDesc.Text = this.dataGridView1.CurrentRow.Cells[12].Value.ToString();
            

            frmedit.ShowDialog();
        }

        private void bt_Todo_Click(object sender, EventArgs e)
        {
            Form_TaskBoard frmtb = new Form_TaskBoard();
            frmtb.ShowDialog();
        }    

        private void bt_Refresh_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = frmbll.Load();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Date.Text = DateTime.Now.ToLongDateString();
            lbl_Time.Text = DateTime.Now.ToLongTimeString();
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
