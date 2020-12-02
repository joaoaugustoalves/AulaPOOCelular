using System;
using AulaPOOCelular.Classe;

namespace AulaPOOCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular celular = new Celular();

            Console.Write("Digite a cor do celular: ");
            celular.cor = Console.ReadLine();

            Console.Write("Digite o modelo do celular: ");
            celular.modelo = Console.ReadLine();

            Console.Write("Digite o tamanho do celular: ");
            celular.tamanho = int.Parse(Console.ReadLine());

            Console.Write("O celular está ligado? (S/N)");
            string resposta1 = Console.ReadLine();

            if(resposta1.ToLower() == "s"){
                celular.ligado = true;
            } else if (resposta1.ToLower() == "n"){
                celular.ligado = false;
            }

            Console.Write("Deseja fazer uma ligação? (S/N)");
            string resposta2 = Console.ReadLine();
            
            if(resposta2.ToLower() == "s"){
                celular.ligado = true;
            } else if (resposta2.ToLower() == "n"){
                celular.ligado = false;
            }

            Console.Write("Deseja enviar uma mensagem? (S/N)");
            string resposta3 = Console.ReadLine();
           
            if(resposta3.ToLower() == "s"){
                celular.ligado = true;
            } else if (resposta3.ToLower() == "n"){
                celular.ligado = false;
            }

        }
    }
}
