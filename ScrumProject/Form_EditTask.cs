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
    public partial class Form_EditTask : Form
    {
        public Form_EditTask()
        {
            InitializeComponent();
        }
        BLL frmbll = new BLL();
        private void bt_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
       

        private void bt_EditTask_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text.Trim() == string.Empty || txt_TechEx.Text.Trim() == string.Empty || txt_trDate.Text.Trim() == string.Empty || cbox_trStatus.SelectedItem == null || txt_trWork.Text.Trim() == string.Empty || txt_trDesc.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill empty fields.");
            }
            else
            {
                frmbll.cardID = Convert.ToInt32(txt_ID.Text);
                frmbll.cardDate = Convert.ToDateTime(txt_Date.Text);

                frmbll.tcardID = frmbll.cardID;

                frmbll.projectName = Convert.ToString(txt_Name.Text);
                frmbll.projectTech = Convert.ToString(txt_TechEx.Text);
                frmbll.projectEstTime = Convert.ToDateTime(txt_Est.Text);
                frmbll.projectActTime = Convert.ToDateTime(txt_Act.Text);
                frmbll.projectDesc = Convert.ToString(rtxt_Des.Text);
                frmbll.projectNotes = Convert.ToString(rtxt_Notes.Text);

                frmbll.taskDate = Convert.ToDateTime(txt_trDate.Text);
                frmbll.taskStatus = (cbox_trStatus.SelectedItem.ToString());
                frmbll.taskWork = Convert.ToString(txt_trWork.Text);
                frmbll.taskDesc = Convert.ToString(txt_trDesc.Text);
                             
                frmbll.Update();
                MessageBox.Show("Card has been edited successfully!");                       
                 
            }          
        }

    }
}
