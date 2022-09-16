﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.OleDb;
using System.Drawing;

namespace English_word.Classes
{
    class Add_Gram
    {
        //Instance of the db connection class
        Classes.DB_connection dbconn = new DB_connection();

        //Method used to automatically increments the id when new call
        public int AUtoNum()
        {

            //Instance of DataTable into that the resulted data will be stored
            DataTable dt = new DataTable();
            //Command that is used to increment one row depending on the max row in the table
            dt = dbconn.Execute_command("select ID from Grammar where ID=(select max(ID) from Grammar)");

            int number = Convert.ToInt32(dt.Rows[0]["ID"].ToString());
            return (number + 1);


        }
        //End of the AutoNum method

        //Method that is used to insert one new row after the last row in the table
        public DataTable Insert_NewRow()
        {
            //Instance of DataTable into that the resulted data will be stored
            DataTable dt = new DataTable();
            //Command that is used to insert  one row depending on the number sent from the AutoNum method
            dt = dbconn.Execute_command("insert into Grammar(ID) values('" + AUtoNum() + "')");
            return (dt);


        }
        //End of the Insert New Row method

        //Method that is used to delete a chosen row in the table
        public DataTable Delete_Row(int deletedRow)
        {
            //Instance of DataTable into that the resulted data will be stored
            DataTable dt = new DataTable();

            //Command that is used to delete  one row depending on the number selected by the user
            dt = dbconn.Execute_command("Delete from  Grammar where ID like'" + deletedRow + "'");

            dt = dbconn.Execute_command("update Grammar set ID=ID -1 where ID>" + deletedRow);

            return (dt);
        }
        //End of Delete Row  method


        //Method that is used to execute the update operation
        public DataTable update_Row(int updatedRow, string[] textboxes, DateTime dateTime)
        {
            // Instance of DataTable into that the resulted data will be stored
            DataTable dt = new DataTable();

            //Make an array that contains the name of the fields in the table in the db 
            string[] field = new string[5];
            field[0] = "Title";
            field[1] = "Subject";
            field[2] = "Grammar";
            field[3] = "Examples";
            field[4] = "More_info";
            
            

            //Call the set params that executes the update command after making parameters to every field and assign values to this parameters 
            dt = dbconn.set_params(field, textboxes, "Grammar", updatedRow, dateTime);

            return (dt);

        }
        //End of update Row method

       


        //Method that is used to show all  the data in a chosen row  in the table
        public DataTable Show_Data()
        {
            // Instance of DataTable into that the resulted data will be stored
            DataTable dt = new DataTable();
            //Command that is used to display the stoerd data   in a row depending on the number selected by the user
            dt = dbconn.Select_Table(" Grammar ");

            return (dt);
        }
        //End of show data method



        //Method that is used to search for the data  that is similar to the user input text 
        public DataTable Search_Data(string Criterion)
        {
            // Instance of DataTable into that the resulted data will be stored
            DataTable dt = new DataTable();
            //Command that is used to select  the similat data depending on the text inserted by the user
            //  dt = dbconn.Select_Table(" Grammar where Belongingofword like '%" + Criterion + "%' or Kinda like '%" + Criterion + "%' or KIndOfuse like '%" + Criterion + "%' or Kind like '%" + Criterion + "%' or Word like '%" + Criterion + "%' or  ID  like '%" + Criterion + "%' ");
            dt = dbconn.Select_Table(" Grammar where  Title like '%" + Criterion + "%' or  ID  like '%" + Criterion + "%' or  Subject  like '%" + Criterion + "%'");


            return (dt);

        }
        //End of Search Data method

        

       
       

    }
}
