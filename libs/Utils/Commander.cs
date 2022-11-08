using jogodaforca.libs.Entities;
using jogodaforca.libs.Parser;
using MyApp;
using System.Data.SqlClient;
namespace jogodaforca.libs.Utils
{
    public class Commander
    {    
        private Context context;
        public Commander(Context context)
        {
            this.context = context;
        }

        public void Run()
        {
            var args = this.context.Args;

            if (args.Length == 0)
            {
                Console.WriteLine(@"Favor, digitar opção  'cadastrar ou listar´");
                return;
            }

            if (args[0] == "cadastrar")
            {
                if (args.Length != 4)
                {
                    Console.WriteLine(@"Favor, digitar cadastrar nome idade altura");
                    return;
                }

                this.cadastrar();
                return;
            }

            if (args[0] == "listar")
            {
                this.listar();
                return;
            }

            Console.WriteLine($"Comando {args[0]} inválido");
        }

        private void cadastrar()
        {
            var args = this.context.Args;
            string nome = args[1];
            int idade = Convert.ToInt32(args[2]);
            int altura = Convert.ToInt32(args[3]);
            var newClient = new Client(nome, idade, altura);
            newClient.SaveFile("");

            Console.WriteLine(@"Cliente adicionado com sucesso");
        }

        private void listar()
        {
            //var parser = new ClientParser();
            //List<Client> clients = parser.GetClientsFromFile(this.path);

            List<Client> clients = new List<Client>();
            SqlCommand command = new SqlCommand(@" SELECT 
                                                         [Nome]
                                                        ,[Idade]
                                                        ,[Altura]
                                                    FROM [dbo].[Client]", this.context.Db);


            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string name = reader.GetString(0); // what ever datatype
                    int idade = reader.GetInt32(1);
                    int altura = reader.GetInt32(2);

                    var client = new Client(name, idade, altura);
                    clients.Add(client);
                }
            }

            var printer = new ClientPrinter();
            printer.PrintClients(clients);
        }
    }
}