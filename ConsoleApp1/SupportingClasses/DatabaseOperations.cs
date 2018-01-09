using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;

namespace ConsoleApp1.SupportingClasses
{    
    class DatabaseOperations
    {
        private static MySqlConnection connection = null;
        private static String JDBC_DRIVER = null;
        //"com.mysql.jdbc.Driver"
        private static String DB_URL = null;
        private static String USER = null;
        private static String PASS = null; 
        private String query = null;
        private Boolean stamt;
        private static MySqlCommand command;
        private static MySqlDataReader Datareader;
        private static MySqlRowUpdatingEventHandler updaterowhandler;
        private static DataSet ds;
        public DatabaseOperations(String Server, String UName, String Pwd)
        {
            DB_URL = Server;
            USER = UName;
            PASS = Pwd;
        }
        static void InitializeConnection()
        {
            String ConnectionCredentials;
            ConnectionCredentials = "SERVER =" + DB_URL + "; UID=" + USER + "; PASSWORD=" + PASS + ";";
            connection = new MySqlConnection(ConnectionCredentials);
        }

        public static void CloseConn() 
        {

            connection.Close();

            connection = null;
	}

    public void GetDataObjects(String query) 
    {
		this.query = query;
            command = new MySqlCommand();
            command.CommandText = this.query;
            command.Connection = connection;
            command.ExecuteNonQuery();
    }
    
    public void CopyTable(String ActualTable, String DuplicateTable) 
    {

        DatabaseMetaData dad = (DatabaseMetaData) conn.getMetaData();
        ResultSet tables =   dad.getTables(null, null, DuplicateTable, null);
		if( tables.next())

        {
            //table exists
            System.out.println("table exists");
        }
		else  

        {
            //table not exists
            String CopyQuery = "CREATE TABLE " + DuplicateTable + " LIKE " + ActualTable + ";";
            stamt = conn.createStatement().execute(CopyQuery);
        }
    }

    public Boolean MoveForward()  
    {
		
			return Datareader.NextResult();

    }
    public void move_next()  
    {
        Datareader.NextResult();
    }

    public String ReadData(String column_name)  
    {
        Datareader = command.ExecuteReader();
        return Datareader.GetString(column_name);
    }

    public void WriteData(String column_name, String value)  
    {
        rs.updateString(column_name, value);
    }

    public void UpdateRow()  
    {
        rs.updateRow();
    }
}
}
