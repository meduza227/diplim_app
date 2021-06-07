
using System.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Buffers;


namespace diplim_app
{
    using MySql.Data.MySqlClient;
    public class DB
    {

       // private static string cmd = "server=localhost; port=3306; user id = root; password=meduza227; database=xenia";

        //private MySqlCommand mySqlCommand;

        protected MySqlConnection mySqlConnection ;



        public void OpenConnection()
        {
            mySqlConnection = new MySqlConnection("Server=localhost; Port=3306; Database=xenia; Uid=root; Pwd=meduza227");
            mySqlConnection.Open();
        }
        //  mySqlCommand = new MySqlCommand(cmd);



        public void CloseConnection() {
            mySqlConnection = new MySqlConnection("Server=localhost; Port=3306; Database=xenia; Uid=root; Pwd=meduza227");
            mySqlConnection.Close(); }

        public MySqlConnection getConnection()
        {
            mySqlConnection = new MySqlConnection("Server=localhost; Port=3306; Database=xenia; Uid=root; Pwd=meduza227");
            return mySqlConnection;
        }
      
    
    }


}
