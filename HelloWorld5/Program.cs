using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld5
{
    class Program
    {

        // enum: A maneira de criar um tipo pra valores limitados de dados. Cada um tem seu id (mais organizado)
                   //     20       21        80         81
        // enum Cor { Azul = 20, Verde, Amarelo = 80, Vermelho}

                    // 0   1   2   3
        enum Estados { BH, DF, GO, SP}
        enum Opcao { criar = 1, deletar, editar, listar, atualizar}

        static void Main(string[] args)
        {
            Console.WriteLine("Escolha entre vermelho, amarelo e azul");
            string cor = Console.ReadLine();

            //switch - outra forma de condicional, mas sem operadores comparacionais:
            switch (cor)
            {
                case "vermelho":
                    Console.WriteLine("Sua cor é vermelho");
                    break; // precisa ser terminado com break cada case do switch
                case "amarelo":
                    Console.WriteLine("Sua cor é amarelo");
                    break;
                case "azul":
                    Console.WriteLine("Sua cor é azul");
                    break;
                default:  // é acionado quando nenhum caso existente é selecionado. Funciona parecido com else
                    Console.WriteLine("cor invalida");
                    break;         
            }
            Estados estadoFav = Estados.DF;
            Estados estadoUnfav = Estados.BH;

            Console.WriteLine("estados: ");
            Console.WriteLine(estadoUnfav);

            // cast - converter um tipo para o outro exemplo: ((int)estadoFav), nesse caso vai mostrar o id que está em int
            Console.WriteLine((int)estadoFav);
            Console.WriteLine((Estados)2); //nesse caso o cast atribuiu o valor de Estados (que nesse caso é GO) ao numero 2


            // menu com switch + enum
            Console.WriteLine("");
            Console.WriteLine("Escolha uma das opcões abaixo: ");
            Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listar \n5-Atualizar"); // \n - quebrar linha
            int index = int.Parse(Console.ReadLine());
            Opcao opcaoSelecionada = (Opcao)index; // converter o index para enum Opcao e transformar o numero do id no texto correspondido

            switch (opcaoSelecionada)
            {
                case Opcao.criar:
                    Console.WriteLine("criado");
                    break;
                case Opcao.deletar:
                    Console.WriteLine("deletado");
                    break;
                case Opcao.editar:
                    Console.WriteLine("editado");
                    break;
                case Opcao.listar:
                    Console.WriteLine("listado");
                    break;
                case Opcao.atualizar:
                    Console.WriteLine("atualizado");
                    break;
                default:
                    Console.WriteLine("Opção invalida");
                    break;
                    
            }

            Console.ReadLine();
        }
    }
}
