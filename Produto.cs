using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_361
{
 internal class Produto
 {

public int Codigo { get; set; }
public string Nome { get; set; }
public int Quantidade { get; set; }
public double ValorCompra { get; set; }
public double ValorVenda { get; set; }

public Produto(
int codigo, string nome, int quantidade, 
double valorCompra, double valorVenda )
{
   Codigo = codigo;
   Nome = nome;
   Quantidade = quantidade;
   ValorCompra = valorCompra;
   ValorVenda = valorVenda;
}


 public void ExibirProduto(){
   Console.WriteLine($"Codigo do Produto: {Codigo}");
   Console.WriteLine($"Nome do Produto: {Nome}");
   Console.WriteLine($"Quantidade: {Quantidade}");
   Console.WriteLine($"Valor de Compra: {ValorCompra}");
   Console.WriteLine($"Valor de Venda: {ValorVenda}");
   Console.Write("");


  }

 }
}
