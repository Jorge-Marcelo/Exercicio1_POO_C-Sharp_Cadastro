using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_361
{
 internal class Program
 {
  static void Main(string[] args)
  {

List<Produto> produtos = new List<Produto>();

Console.WriteLine("CADASTRO DE PRODUTOS");
Console.WriteLine("--------------------------------------");


   for (int iterador = 0; iterador < 30; iterador++){
Console.Write($"Digite o  nome do {iterador + 1}° produto: ");
string nome = Console.ReadLine();

Console.Write("Digite o codigo do produto: ");
int codigo = int.Parse(Console.ReadLine());

Console.Write("Digite a quantidade: ");
int quantidade = int.Parse(Console.ReadLine());

Console.Write("Digite no valor de compra: ");
double valorCompra = double.Parse(Console.ReadLine());

Console.Write("Digite no valor de venda: ");
double valorVenda = double.Parse(Console.ReadLine());

Console.WriteLine("--------------------------------------");

produtos.Add(new Produto(codigo, nome, quantidade, valorCompra, valorVenda));



Console.WriteLine("ESCOLHA UMA OPÇÃO");
Console.WriteLine("--------------------------------------");
Console.WriteLine("1 - Mostrar Produto ");
Console.WriteLine("2 - Sair ");
Console.Write("\nOpção: ");
int op = int.Parse(Console.ReadLine());

Console.WriteLine("--------------------------------------");

Console.WriteLine("");


    switch (op)
{
case 1: 
foreach (Produto produto in produtos) {
produto.ExibirProduto();
Console.WriteLine("--------------------------------------");
}
break;
case 2: System.Environment.Exit(0);
      break;

}
   }

  }
 }
}
