using jogodaforca.libs.Entities;
namespace jogodaforca.libs.Parser
{
     public class ClientParser
    {
        public List<Client> GetClientsFromFile(string path)
        {
            
            var listaDeClients = new List<Client>();   
            var text = File.ReadAllText(path);
            if (text.Length > 1)
            {                  
                string[] lines = text.Split(Environment.NewLine);

                // for(int index =0 ; index < lines.Length; index++){

                //         Console.WriteLine(lines[index]);

               // }

                foreach (string line in lines){
                  
                        string[] columns = line.Split("|");

                        if(columns.Length != 3){
                            continue; //tem algo errado pq não tem 3 columnas no banco de dados
                        }

                        string colName = columns[0];
                        int colIdade = Convert.ToInt32(columns[1]);
                        int colAltura =  Convert.ToInt32(columns[2]);
                        var client = new Client(colName, colIdade, colAltura);
                       listaDeClients.Add(client);
                }
            }

            return listaDeClients;
        }
    }

}