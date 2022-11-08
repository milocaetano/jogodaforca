using jogodaforca.libs.Entities;

namespace jogodaforca.libs.Utils
{
    public class ClientPrinter
    {
        public ClientPrinter()
        {
        }

        public void PrintClients(List<Client> clients)
        {
            foreach (var item in clients)
            {
                //Console.WriteLine($"Nome: {item.Nome} | Idade: {item.Idade} | Altura: {item.Altura}");
                item.Imprime();
            }
            // for (int index = 0; index < clients.Count; index++)
            // {

            //     Console.WriteLine($"Nome: {clients[index].Nome} | Idade: {clients[index].Idade} | Altura: {clients[index].Altura}");

            // }
        }
    }
}