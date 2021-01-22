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
    public partial class Form_DeleteTask : Form
    {
        public Form_DeleteTask()
        {
            InitializeComponent();
        }
        BLL frmbll = new BLL();
        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter an ID");
            }
            else
            {
                frmbll.cardID = Convert.ToInt32(txt_ID.Text);
                DialogResult res = MessageBox.Show("Are you sure you want to delete Card?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    int count = frmbll.Check();
                    if (count <= 0)
                    {
                         MessageBox.Show("ERROR: Cannot delete! Card does not exist.");
                    }
                    else {
                        frmbll.Delete();
                        MessageBox.Show("Card has been deleted successfully!");
                    }
                  
                }
                else
                {
                    Close();
                }
            }
        }
    }
}
