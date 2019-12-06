using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Data.Produtos
{
    public class ListagemProduto
    {
        public List<Produto> BuscarProdutos()
        {
            List<Produto> produtos = new List<Produto>();

            string connectionString = "";

            string queryString = "SELECT Nome, Descricao, Preco FROM Produtos";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Produto produtoDoBanco = new Produto();

                        produtoDoBanco.Nome = reader["Nome"].ToString();
                        produtoDoBanco.Descricao = reader["Descricao"].ToString();
                        produtoDoBanco.Preco = Convert.ToDecimal(reader["Preco"]);

                        produtos.Add(produtoDoBanco);

                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

                return produtos;
            }

        }
    }
}
