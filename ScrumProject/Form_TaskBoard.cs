using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ScrumProject
{
    public partial class Form_TaskBoard : Form
    {
        public Form_TaskBoard()
        {
            InitializeComponent();
        }
        static SqlConnection con = new SqlConnection(@"Data Source=OMEN\SQL2017;Initial Catalog=db_taskboard;Integrated Security=True");
        static SqlCommand cmd;
        BLL frmbll = new BLL();
        private void Form_TaskBoard_Load(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tbl_tracking", con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                switch ((dr["taskStatus"].ToString()))
                {
                    case "ToDo":
                        lb_ToDo.Items.Add(dr["taskWork"].ToString());
                        break;

                    case "Research":
                        lb_Research.Items.Add(dr["taskWork"].ToString());
                        break;

                    case "In Progress":
                        lb_InProgress.Items.Add(dr["taskWork"].ToString());
                        break;

                    case "Review":
                        lb_Review.Items.Add(dr["taskWork"].ToString());
                        break;

                    case "Completed":
                        lb_Completed.Items.Add(dr["taskWork"].ToString());
                        break;
                }
            }
            con.Close();

        }
        private void listBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
                e.Effect = DragDropEffects.Move;
        }

        private void listBox_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
                e.Effect = DragDropEffects.All;
        }

        ListBox listbox_Item_Selected;
        ListBox lstbox_Item_Dropped;
        int Listbox_Index = 0;

        private void listBox_MouseDown(object sender, MouseEventArgs e)
        {
            listbox_Item_Selected = sender as ListBox;

            Point blind_spot = new Point(e.X, e.Y);
            Listbox_Index = listbox_Item_Selected.IndexFromPoint(blind_spot);
            if (Listbox_Index == -1)
                return;
            if (e.Button == MouseButtons.Left)
                listbox_Item_Selected.DoDragDrop(listbox_Item_Selected.Items[Listbox_Index].ToString(), DragDropEffects.All);
        }

        private void listBox_DragDrop(object sender, DragEventArgs e)
        {
            lstbox_Item_Dropped = sender as ListBox;
            lstbox_Item_Dropped.Items.Add(listbox_Item_Selected.Items[Listbox_Index]);
            listbox_Item_Selected.Items.Remove(listbox_Item_Selected.Items[Listbox_Index]);
        }

        private void bt_Close_Click(object sender, EventArgs e)
        {
           Close();
        }
    }
}
