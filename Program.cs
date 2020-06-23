using System;
using System.Collections.Generic;

namespace ListaDesejos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nova lista do tipo Produto (é um obejto)
            List<Produto> produtos = new List<Produto>();
            List<Cartao> card = new List<Cartao>();
                
            // Primeira forma
            Produto prod1 = new Produto();
            prod1.Codigo = 001;
            prod1.Nome = "SmartTV LG";
            prod1.Preco = 1998.9f;

            // Adicionar o prod1 na lista produtos 
            produtos.Add(prod1);

            // Adicionando produtos com outro construtor

            produtos.Add(new Produto(002, "Geladeira Brastemp", 6800.9f));
            produtos.Add(new Produto(003, "Aspidor de pó Polishop", 500.5f));
            produtos.Add(new Produto(004, "Microondas Electrolux", 800.9f));
            produtos.Add(new Produto(005, "PS5 Sony", 7800.9f));

            card.Add(new Cartao("Luis Fernando", 12345, "MasterCard", DateTime.Now, 599));
            card.Add(new Cartao("Maria", 12345, "Visa", DateTime.Now, 199));
            card.Add(new Cartao("José", 12345, "Maestro", DateTime.Now, 529));
            card.Add(new Cartao("Fernanda", 12345, "MasterCard", DateTime.Now, 593));
            // Ler esses produtos 
            foreach (var item in produtos)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine($"Produto: {item.Nome}, Preço R${item.Preco} ");
            }
            Console.ResetColor();

            produtos.Remove(prod1);
            produtos.RemoveAt(2); // Eliminar registro pelo índice 
            produtos.RemoveAll(y => y.Nome == "PS5 Sony");

            foreach (var item in produtos)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine($"Produto: {item.Nome}, Preço R${item.Preco} ");

            }

            Produto geladeira = produtos.Find(x => x.Codigo == 003);
            System.Console.WriteLine(geladeira.Nome + geladeira.Preco);

            System.Console.WriteLine("\n\n  --- Cartão \n");
            foreach (var item in card)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                System.Console.WriteLine($"Dados do cartão - \nTitular: {item.Titular}\n Bandeira: {item.Bandeira}");
            }
            Console.ResetColor();

            // Excluindo um item 
            card.RemoveAll(y => y.Titular == "Maria");
            System.Console.WriteLine("\n\n---- Maria removida");
            foreach (var item in card)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                System.Console.WriteLine($"Dados do cartão - \nTitular: {item.Titular}\n Bandeira: {item.Bandeira}");
            }
            Console.ResetColor();

            Cartao c = card.Find(z => z.Titular == "Luis Fernando");

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine(c.Titular);
            Console.ResetColor();

        }
    }
}
