using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoiasProject
{
    class Program
    {
        static void Main(string[] args)
        {
        static void Main(string[] args)
        {
            int n = 0, optionMenu;
            string modelo, fabricante, cor;

            Carro[] carro = new Carro[300];
            Caminhao[] caminhao = new Caminhao[200];
            do
            {
                Console.WriteLine("****Menu**** \n 1 - Cadastrar carro \n 2 - Cadastrar caminhão \n 3 - Consultar por placa \n 4 - Consultar caminhão por modelo/marca \n 5 - Consultar carro por cor \n 6 - Exibir todos os carros cadastrados \n 7 - Exibir todos os caminhões cadastrados \n 0 - Sair");
                optionMenu = int.Parse(Console.ReadLine());
                switch (optionMenu)
                {
                    case 0:
                        Console.WriteLine("Deseja mesmo sair? [1 - sim/2- não]");
                        n = int.Parse(Console.ReadLine());
                        optClose(n);
                        break;
                    case 1:
                        //caso1(n);
                        n = 2;
                        Console.Clear();
                        break;
                    case 2:
                        //caso2(n);
                        n = 2;
                        Console.Clear();
                        break;
                    case 3:
                        break;
                    case 4:
                       break;
                    case 5:
                        n = 2;
                        Console.Clear();
                    break;
                };
            } while (n == 2);
            Console.ReadKey();
        }
      }
    }
}
