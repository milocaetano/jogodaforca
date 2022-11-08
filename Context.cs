using System.Data.SqlClient;

namespace MyApp // Note: actual namespace depends on the project name.
{

    public class Context{
            public string[] Args { get; set; }
            public SqlConnection Db {get; set; }
    }
}