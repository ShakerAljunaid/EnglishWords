using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Drawing;
using System.Data.OleDb;

namespace English_word.Classes
{
    class Add_Notes
    {

        //Instance of the db connection class
        Classes.DB_connection dbconn = new DB_connection();

        //Method used to automatically increments the id when new call
        public int AUtoNum()
        {

            //Instance of DataTable into that the resulted data will be stored
            DataTable dt = new DataTable();
            //Command that is used to increment one row depending on the max row in the table
            dt = dbconn.Execute_command("select ID from Notes where ID=(select max(ID) from Notes)");

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
            dt = dbconn.Execute_command("insert into Notes(ID) values('" + AUtoNum() + "')");
            return (dt);


        }
        //End of the Insert New Row method

        //Method that is used to delete a chosen row in the table
        public DataTable Delete_Row(int deletedRow)
        {
            //Instance of DataTable into that the resulted data will be stored
            DataTable dt = new DataTable();

            //Command that is used to delete  one row depending on the number selected by the user
                dt = dbconn.Execute_command("Delete from  Notes where ID =" + deletedRow );
                dt = dbconn.Execute_command("update Notes set ID=ID -1 where ID>" + deletedRow);
                                                   
                return (dt);

           
        }
        //End of Delete Row  method


        //Method that is used to execute the update operation
        public DataTable update_Row(int updatedRow, string[] textboxes, DateTime dateTime)
        {
            // Instance of DataTable into that the resulted data will be stored
            DataTable dt = new DataTable();

            //Make an array that contains the name of the fields in the table in the db 
            string[] field = new string[4];
            field[0] = "Subject";
            field[1] = "Note_info";
            field[2] = "More_info";
            field[3] = "Pic_comment";


            //Call the set params that executes the update command after making parameters to every field and assign values to this parameters 
            dt = dbconn.set_params(field, textboxes, "Notes", updatedRow, dateTime);

            return (dt);

        }
        //End of update Row method

        //Method that is used to save the image
        public void Save_Snapshot(int id, Image image)
        {
            dbconn.openCon();
            OleDbCommand cm = new OleDbCommand("update Notes set Note_pic=@Picture where id=" + id, dbconn.OleDbconn);
            if (image != null)
            {
                cm.Parameters.AddWithValue("@Picture", imgtobyte(image));
                cm.ExecuteNonQuery();
            }
            else
            {
                image = null;

            }
            dbconn.closeCon();

        }
        //End of the save image method



        //Method that is used to show all  the data in a chosen row  in the table
        public DataTable Show_Data()
        {
            // Instance of DataTable into that the resulted data will be stored
            DataTable dt = new DataTable();
            //Command that is used to display the stoerd data   in a row depending on the number selected by the user
            dt = dbconn.Select_Table(" Notes ");

            return (dt);
        }
        //End of show data method



        //Method that is used to search for the data  that is similar to the user input text 
        public DataTable Search_Data(string Criterion)
        {
            // Instance of DataTable into that the resulted data will be stored
            DataTable dt = new DataTable();
            //Command that is used to select  the similat data depending on the text inserted by the user
            //  dt = dbconn.Select_Table(" Notes where Belongingofword like '%" + Criterion + "%' or Kinda like '%" + Criterion + "%' or KIndOfuse like '%" + Criterion + "%' or Kind like '%" + Criterion + "%' or Word like '%" + Criterion + "%' or  ID  like '%" + Criterion + "%' ");
            dt = dbconn.Select_Table(" Notes where  Subject like '%" + Criterion + "%' or  ID  like '%" + Criterion + "%'");


            return (dt);

        }
        //End of Search Data method

        //That method is necessary to convert the image to binary format that can be saved in the db
        public Byte[] imgtobyte(Image ig)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                ig.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] img = new byte[ms.Length - 1];
                ms.Position = 0;
                ms.Read(img, 0, img.Length);
                return img;
            }
            catch (Exception)
            {
                return null;
                throw;
            }

        }
        //End of the converting method
        
    }
}
