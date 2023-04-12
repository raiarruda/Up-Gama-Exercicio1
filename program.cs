using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] produtos = new string[10];
            float[] valorProdutos = new float[10];
            int[] produtosEscolhidos = new produtosEscolhifos

            Console.WriteLine("Cadastre 10 produtos: \n");
            int codigoProduto = 0;
            do{
                
                Console.WriteLine("Nome do produto: ");
                produtos[codigoProduto] = Console.ReadLine();
                
                Console.WriteLine("Valor do produto: ");
                valorProdutos[codigoProduto] = Console.ReadLine();

            }while (codigoProduto<10);
            
            Console.WriteLine("Qual o nome do Cliente? \n");
            string nomeCliente = Console.ReadLine();

            //exibir produtos

            for(int i = 0; i<10;i++)
            {
                Console.WriteLine($" cod: {i+1} - {produtos[i]} - {valorProdutos[i]}");
            }

            Console.WriteLine("Escolha até 10 produtos: \n");
            int codigoProduto = 0;
            do{
                
                Console.WriteLine("Nome do produto: ");
                produtos[0,codigoProduto] = Console.ReadLine();
            }while (codigoProduto<10);

          
        }
    }
}