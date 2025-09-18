using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            Pedido pedido = new Pedido();
            pedido.cliente = cliente;
            cliente.nome = "Arthur";
            cliente.cpf = "288.288.288.93";
            pedido.NumeroPedido = 1;
            pedido.ExibirPedido();
        }
        public class Cliente
        {
            public string nome;
            public string cpf;
        }
        public class Pedido
        {
            public int NumeroPedido;
            public Cliente cliente;

            public void ExibirPedido()
            {
                Console.WriteLine($"Nome do Cliente {cliente.nome} cpf {cliente.cpf} numero do pedido {NumeroPedido}");
            }
        }
    }
}
