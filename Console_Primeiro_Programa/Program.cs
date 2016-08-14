using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Primeiro_Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            //\n quebra de linha
            //\t para dar espaço
            string nome;								         /*string armazena caracteres*/

            Console.Write("Digite seu nome\n");                  /*console é uma e write é um método*/
            nome = Console.ReadLine();							/*nome recebe o que escrito no metódo ReadLine*/
            Console.WriteLine("Ola tudo bem " + nome + "!");

            int num;

            Console.WriteLine("digite um número");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine(num);

            if (num % 2 == 0)                                                /*quando só há uma instrução não necessidade de abrir chaves e fechar chaves*/
            {
                Console.WriteLine("número é par");
            }
            else
            {
                Console.WriteLine("número é impar");
            }

            //float nota;
            //float salario;

            //nota += nota + 0.2f;                      /*a letra 'f' é usado para indicar que variável é float.*/

            //Console.WriteLine("digite sua nota");
            //nota = float.Parse(Console.ReadLine());     
            //Console.WriteLine("digite seu salário");
            //salario = float.Parse(Console.ReadLine());

            //Console.WriteLine("nota:" + nota + "\nsalário :" + salario);

            //Console.WriteLine("a sua nota é {0:F2} e o seu salário é {1:C2}", nota, salario);  //F2 F = float e o '2' é numero de casa decimais; C = Currenty formatação monetária

            //char letra = 'c';    // quando é usado apenas um caracter é usado aspas simples
            //bool teste;

            Console.ReadKey();
        }
    }
}
