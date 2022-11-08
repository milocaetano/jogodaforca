using System;
using System.Collections.Generic;
using jogodaforca.libs.Entities;
using jogodaforca.libs.Utils;
using System.Data.SqlClient;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string myConnectionString = "Initial Catalog=JOGODAFORCA;Data Source=localhost;Integrated Security=SSPI;";

                using (SqlConnection conn = new SqlConnection(myConnectionString))
                {
                    conn.Open();
                    var context = new Context()
                    {
                        Args = args,
                        Db = conn
                    };

                    var commander = new Commander(context);
                    commander.Run();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Deu Pau");
                Console.WriteLine(e.Message);
            }


            // string myInsertQuery = "INSERT INTO tts (min, max, average, lh, stdev, main_id) Values(5,5,5,'ASU',5,55)";
            // SqlCommand myCommand = new SqlCommand(myInsertQuery);
            // myCommand.Connection = myConnection;
            // myConnection.Open();
            // myCommand.ExecuteNonQuery();
            // myCommand.Connection.Close();



        }
    }
}