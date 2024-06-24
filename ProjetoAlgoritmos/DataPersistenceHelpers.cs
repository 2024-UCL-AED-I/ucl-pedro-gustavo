using System;
using System.Collections.Generic;
using System.IO;

namespace Padaria
{
    public static class DataPersistenceHelpers
    {
        public static void SaveClientes(List<cadastroCliente> clientes)
        {
            using (StreamWriter writer = new StreamWriter(Constants.ClientesFileName))
            {
                foreach (var cliente in clientes)
                {
                    writer.WriteLine(cliente.ToString());
                }
            }
        }

        public static List<cadastroCliente> LoadClientes()
        {
            var clientes = new List<cadastroCliente>();

            if (File.Exists(Constants.ClientesFileName))
            {
                using (StreamReader reader = new StreamReader(Constants.ClientesFileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        clientes.Add(cadastroCliente.FromString(line));
                    }
                }
            }

            return clientes;
        }

        public static void SaveProdutos(List<estoque> produtos)
        {
            using (StreamWriter writer = new StreamWriter(Constants.ProdutosFileName))
            {
                foreach (var produto in produtos)
                {
                    writer.WriteLine(produto.ToString());
                }
            }
        }

        public static List<estoque> LoadProdutos()
        {
            var produtos = new List<estoque>();

            if (File.Exists(Constants.ProdutosFileName))
            {
                using (StreamReader reader = new StreamReader(Constants.ProdutosFileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        produtos.Add(estoque.FromString(line));
                    }
                }
            }

            return produtos;
        }
    }
}
