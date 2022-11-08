using jogodaforca.libs.Entities;
using jogodaforca.libs.Parser;
namespace jogodaforca.libs.Utils
{
    public class Commander
    {
        private string[] args;
        private string path;
        public Commander(string[] args, string path)
        {
            this.args = args;
            this.path = path;
        }

        public void Run()
        {
            if (args.Length == 0)
            {
                Console.WriteLine(@"Favor, digitar opção  'cadastrar ou listar´");
                return;
            }

            if (this.args[0] == "cadastrar")
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
            string nome = args[1];
            int idade = Convert.ToInt32(args[2]);
            int altura = Convert.ToInt32(args[3]);
            var newClient = new Client(nome, idade, altura);
            newClient.SaveFile(this.path);

            Console.WriteLine(@"Cliente adicionado com sucesso");
        }

        private void listar()
        {
            var parser = new ClientParser();
            List<Client> clients = parser.GetClientsFromFile(this.path);

            if(this.args.Length == 2){

                string searchNameClient = this.args[1].ToUpper();              

                foreach(var client in clients){

                    if( client.Nome.ToUpper().Contains(searchNameClient) ){
                        client.Imprime();
                    }
                }

                return;
            }

            var printer = new ClientPrinter();
            printer.PrintClients(clients);
        }
    }
}