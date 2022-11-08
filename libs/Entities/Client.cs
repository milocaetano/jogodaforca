namespace jogodaforca.libs.Entities
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

        public void Imprime()
        {
            Console.WriteLine($"Nome: {this.Nome} | Idade: {this.Idade} | Altura: {this.Altura}");
        }

        public void SaveFile(string path)
        {
            //string path = @"C:\temp\bancodedados.txt";
            string createText = $"{this.Nome}|{this.Idade}|{this.Altura}" + Environment.NewLine;

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

}