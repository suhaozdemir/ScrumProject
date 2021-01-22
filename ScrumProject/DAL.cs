using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ScrumProject
{
    public class DAL
    {
        static SqlConnection con = new SqlConnection(@"Data Source=OMEN\SQL2017;Initial Catalog=db_taskboard;Integrated Security=True");
        static DataTable dt;
        static SqlCommand cmd, cmd2;
        static SqlDataAdapter sda;

        public static void insertCard(BLL bll)
        {

            cmd = new SqlCommand("INSERT INTO tbl_card (cardID, cardDate,projectName, projectTech, projectEstTime, projectActTime,  projectDesc, projectNotes)" +
                " VALUES (@cardID, @cardDate,@projectName, @projectTech, @projectEstTime, @projectActTime, @projectDesc, @projectNotes);", con);

            cmd2 = new SqlCommand("INSERT INTO tbl_tracking (taskDate, taskStatus, taskWork, taskDesc, tcardID)" +
           " VALUES (@taskDate, @taskStatus, @taskWork, @taskDesc, @tcardID);", con);

            addParameters(bll);
        }

        public static void updateCard(BLL bll)
        {

            cmd = new SqlCommand("UPDATE tbl_card SET cardDate=@cardDate, projectName=@projectName,projectTech=@projectTech," +
                "projectEstTime=@projectEstTime,projectActTime=@projectActTime,projectDesc=@projectDesc,projectNotes=@projectNotes" +
                " WHERE cardID=@cardID;", con);

            cmd2 = new SqlCommand("UPDATE tbl_tracking SET taskDate=@taskDate, taskStatus=@taskStatus, taskWork=@taskWork" +
                ", taskDesc=@taskDesc  WHERE tcardID=@tcardID;", con);

            addParameters(bll);
        }
        
        public static void deleteCard(BLL bll)
        {
            cmd = new SqlCommand("DELETE FROM tbl_card WHERE cardID=@cardID;", con);
            cmd.Parameters.AddWithValue("@cardID", bll.cardID);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }           

        public static DataTable loadData()
        {
            dt = new DataTable();
            sda = new SqlDataAdapter("SELECT * FROM tbl_card INNER JOIN tbl_tracking ON tbl_card.cardID = tbl_tracking.tcardID", con);
            sda.Fill(dt);
            return dt;
        }

        public static int checkCard(BLL bll)
        {
            int count = 0;
            cmd = new SqlCommand("SELECT COUNT(*) FROM tbl_card WHERE cardID=@cardID", con);
            cmd.Parameters.AddWithValue("@cardID", bll.cardID);

            con.Open();
            count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return count;

        }

        public static void addParameters(BLL bll)
        {
            cmd.Parameters.AddWithValue("@cardID", bll.cardID);
            cmd.Parameters.AddWithValue("@cardDate", bll.cardDate);
            cmd.Parameters.AddWithValue("@projectName", bll.projectName);
            cmd.Parameters.AddWithValue("@projectTech", bll.projectTech);
            cmd.Parameters.AddWithValue("@projectEstTime", bll.projectEstTime);
            cmd.Parameters.AddWithValue("@projectActTime", bll.projectActTime);
            cmd.Parameters.AddWithValue("@projectDesc", bll.projectDesc);
            cmd.Parameters.AddWithValue("@projectNotes", bll.projectNotes);

            cmd2.Parameters.AddWithValue("@taskDate", bll.taskDate);
            cmd2.Parameters.AddWithValue("@taskStatus", bll.taskStatus);
            cmd2.Parameters.AddWithValue("@taskWork", bll.taskWork);
            cmd2.Parameters.AddWithValue("@taskDesc", bll.taskDesc);
            cmd2.Parameters.AddWithValue("@tcardID", bll.tcardID);

            con.Open();
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            con.Close();
        }
    
    }
}
