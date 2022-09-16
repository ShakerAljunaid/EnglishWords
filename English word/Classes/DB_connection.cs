using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace English_word.Classes
{
    

    //Class that is used for set a connection to a database and contains the main methods used to manipulate the data from this connected db
    class DB_connection
    {

        //Initialize connection 
        public OleDbConnection OleDbconn;
        //Constructor
        public DB_connection()
        {  //Choose the database to connected 

            OleDbconn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=Dictinary.accdb");
            /*Notes
            if we want to use the localhost as the serever we type (@"Server=.\..."....)
             if the database uses windows authentication we set Integrated Security=true and do not write the username and pw parameters
          */

        }  //End of the constructor

        //Method to open the connection
        public void openCon()
        {
            if (OleDbconn.State != ConnectionState.Open)
            {
                OleDbconn.Open();

            }//End if

        }//End open method


        //Method to close the connection
        public void closeCon()
        {
            if (OleDbconn.State == ConnectionState.Open)
            {
                OleDbconn.Close();
            }//End if
        } //End close Method 


        //Method to execute sent commands from other methods
        public DataTable Execute_command(string Command)
        {
            openCon();
            //Instance of the oledb command in where the command will be stored and executed
            OleDbCommand command = new OleDbCommand(Command);
            //Select the connection of the command
            command.Connection = OleDbconn;
            //OleDataAdapter to execute the command
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            //Then fill the result into a datatable
            DataTable dt = new DataTable();
            da.Fill(dt);
            closeCon();
            return (dt);

        }
        //End of Execution Method

        //Method to select a table and retrieve its data
        public DataTable Select_Table(string TableName)
        {
            //Instance of the oledb command in where the command will be stored and executed
            OleDbCommand command = new OleDbCommand("Select * from" + TableName);
            //Select the connection of the command
            command.Connection = OleDbconn;
            //Make DataAdapter that executes the commands
            OleDbDataAdapter oleDA = new OleDbDataAdapter(command);

            //Make Datatable to store the results of the DataAdapter
            DataTable dt = new DataTable();
            oleDA.Fill(dt);
            return (dt);

        }
        //End  of the select table method

        //Method that makes parameters and set them to the instances in the db
        public DataTable set_params(string[] fields, string[] value, string table_name, int id, DateTime dtime)
        {
            string Command;
            string[] parms = new string[fields.Length];

            //Instance of the oledb command in where the command will be stored and executed
            for (int i = 0; i < fields.Length; i++)
                parms[i] = "@" + fields[i];
            Command = "update " + table_name + " set ";
            for (int i = 0; i < fields.Length; i++)
                Command += fields[i] + "=" + parms[i] + ",";

            Command += "written_Date ='" + dtime + "'where ID=" + id;

            OleDbCommand command = new OleDbCommand(Command);
            for (int i = 0; i < parms.Length; i++)
                command.Parameters.AddWithValue(parms[i], value[i]);

            //Select the connection of the command
            command.Connection = OleDbconn;
            //Make DataAdapter that executes the commands
            OleDbDataAdapter oleDA = new OleDbDataAdapter(command);

            //Make Datatable to store the results of the DataAdapter
            DataTable dt = new DataTable();
            oleDA.Fill(dt);
            return (dt);
        }

        public string setp(string[] fields)
        {
            string Command;
            string table_name = "Table";
            int id = 0;

            string[] parms = new string[fields.Length];

            for (int i = 0; i < fields.Length; i++)
                parms[i] = "@" + fields[i];
            Command = "update " + table_name + " set ";
            for (int i = 0; i < fields.Length; i++)
                Command += fields[i] + "=" + parms[i] + ",";

            Command += "where ID=" + id;

            return (Command);

        }
    }
    //End of the connection class
}
