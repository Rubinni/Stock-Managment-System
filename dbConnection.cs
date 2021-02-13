using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMTS
{
    class dbConnection
    {

        static dbConnection()
            {

            try
            {
                string connectionString;
                SqlConnection cnn;

                connectionString = @"Data Source=PC-COM\SQLEXPRESS;Initial Catalog=stms;Integrated Security=True";
                cnn = new SqlConnection(connectionString);

                cnn.Open();

                Console.WriteLine("Connection Opend");

                cnn.Close();

            }catch(Exception e)
            {
                Console.WriteLine(e);
                
            }
                 
   
            }

    }
}
