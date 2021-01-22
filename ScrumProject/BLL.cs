using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace ScrumProject
{
    public class BLL
    {
        //tbl.card
        public int cardID { get; set; }
        public DateTime cardDate { get; set; }           
        public string projectName { get; set; }
        public string projectTech { get; set; }
        public DateTime projectEstTime { get; set; }
        public DateTime projectActTime { get; set; }
        public string projectDesc { get; set; }
        public string projectNotes { get; set; }     

        //tbl.tracking
        public int taskID { get; set; }
        public DateTime taskDate { get; set; }
        public string taskStatus { get; set; }
        public string taskWork { get; set; }
        public string taskDesc { get; set; }
        public int tcardID { get; set; }
     

        public void Insert()
        {
            DAL.insertCard(this);
        }

        public void Update()
        {
            DAL.updateCard(this);
        }
        public void Delete()
        {
            DAL.deleteCard(this);
        }
        public DataTable Load()
        {
            DataTable dt = DAL.loadData();
            return dt;
        }
 
        public int Check()
        {
            int count = DAL.checkCard(this);
            return count;
        }
   
    }       

}
