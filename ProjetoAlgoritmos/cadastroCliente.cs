namespace Padaria
{    public class cadastroCliente
    {
        private string nome { get; set; } // Nome do cliente
        private string telefone { get; set; } // Telefone do cliente
        private string email { get; set; } // Email do cliente

        // Métodos para obter e definir o nome
        public string GetNome() => this.nome;
        public void SetNome(string nome) => this.nome = nome;

        public string GetTelefone() => this.telefone;
        public void SetTelefone(string telefone) => this.telefone = telefone;

        public string GetEmail() => this.email;
        public void SetEmail(string email) => this.email = email;

        // Retorna o objeto como string
        public override string ToString()
        {
            return $"{nome},{telefone},{email}";
        }

        // Cria um objeto cadastroCliente
        public static cadastroCliente FromString(string data)
        {
            var parts = data.Split(',');
            return new cadastroCliente
            {
                nome = parts[0],
                telefone = parts[1],
                email = parts[2]
            };
        }
    }
}
