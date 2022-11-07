using System;
using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{


    public class Client
    {

        public int Idade { get; set; }
        public string Nome { get; set; }
        public int Altura { get; set; }

        public Client(string nome, int idade, int altura)
        {

            this.Altura = altura;
            this.Idade = idade;
            this.Nome = nome;
        }

        public void ImprimeClient()
        {
            Console.WriteLine($"Nome: {this.Nome} Idade: {this.Idade} Altura: {this.Altura}");
        }

        public void SaveFile()
        {
            string path = @"C:\temp\bancodedados.txt";
            string createText = $"Nome: {this.Nome} Idade: {this.Idade} Altura: {this.Altura}" + Environment.NewLine;

            if (File.Exists(path))
            {
                File.AppendAllText(path, createText);
            }
            else
            {
                File.WriteAllText(path, createText);
            }
        }


    }


    public class Calculadora
    {


        public Calculadora()
        {
        }

        public int Soma(int x, int y)
        {

            int result = x + y;

            return result;
        }

        public int Multiplica(int x, int y)
        {

            int result = x * y;

            return result;
        }

        public static int SomaStatic(int x, int y)
        {

            int result = x + y;

            return result;
        }

    }


    public class ClientPrint
    {

        public ClientPrint()
        {


        }

        public void PrintClients(List<Client> clients)
        {

            for (int index = 0; index < clients.Count; index++)
            {

                Console.WriteLine($"Nome: {clients[index].Nome} | Idade: {clients[index].Idade} | Altura: {clients[index].Altura}");

            }
        }

        public void PrintClientsDoJeitoDoBucks(List<String> nomes, List<int> idades, List<int> alturas)
        {

            for (int index = 0; index < nomes.Count; index++)
            {

                Console.WriteLine($"Nome: {nomes[index]} | Idade: {idades[index]} | Altura: {alturas[index]}");

            }
        }


    }



    internal class Program
    {
        static void Main(string[] args)
        {


            List<Client> clients = new List<Client>();
            var client1 = new Client("Murilo", 34, 189);

            client1.SaveFile();

            var client2 = new Client("Camilo", 32, 234);

            client2.SaveFile();
            clients.Add(client1);
            clients.Add(client2);
            clients.Add(new Client("Outro nome3", 32, 234));
            clients.Add(new Client("Outro nome4", 32, 234));
            clients.Add(new Client("Outro nome6", 32, 234));
            clients.Add(new Client("Outro nome7", 32, 234));
            clients.Add(new Client("Outro nome9", 32, 234));


            var printer = new ClientPrint();













            //    if(args.Length == 3){

            //         if(args[0] == "somar"){

            //             int x = Convert.ToInt32(args[1]);
            //             int y = Convert.ToInt32(args[2]);
            //             Calculadora calc = new Calculadora();
            //             int result= calc.Soma(x, y);
            //             Console.WriteLine(result);                
            //         }

            //          if(args[0] == "multiplicar"){

            //             int x = Convert.ToInt32(args[1]);
            //             int y = Convert.ToInt32(args[2]);
            //             Calculadora calc = new Calculadora();
            //             int result= calc.Multiplica(x, y);
            //             Console.WriteLine(result);                
            //         }
            //    }


        }


    }
}