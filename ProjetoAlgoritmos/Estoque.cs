namespace Padaria
{
    // Classe que representa o estoque de produtos
    public class estoque
    {
        // Propriedade privada para armazenar o nome e valor do produto
        private string produto { get; set; }
        private float valor { get; set; }

        //  para obter o nome do produto e valor
        public string GetProduto() => this.produto;

        public void SetProduto(string produto) => this.produto = produto;

        public float GetValor() => this.valor;
        //  para definir o valor do produto
        public void SetValor(float valor) => this.valor = valor;

        public override string ToString()
        {
            return $"{produto},{valor}";
        }

        public static estoque FromString(string data)
        {
            var parts = data.Split(',');
            return new estoque
            {
                produto = parts[0],
                valor = float.Parse(parts[1])
            };
        }
    }
}