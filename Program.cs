using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Void que vai rodar;
            MediaIdade();
            ImparPar();
            Maioridade();
            Salario();
            Altura();
            Fibbinacci();
            Palindrome();
        }

        static void MediaIdade()
        {
            Console.WriteLine("Digite a idade dos 5 alunos: ");

            int input1 = Convert.ToInt32(Console.ReadLine ());
            int input2 = Convert.ToInt32(Console.ReadLine ());
            int input3 = Convert.ToInt32(Console.ReadLine ());
            int input4 = Convert.ToInt32(Console.ReadLine ());
            int input5 = Convert.ToInt32(Console.ReadLine ());

            int idadem = (input1+input2+input3+input4+input5)/5;

            Console.WriteLine("A média das idades é: {0}",idadem);
        }
        static void ImparPar()
        {
            Console.WriteLine("Digite um número: ");
            int input = Convert.ToInt32(Console.ReadLine ());

            if (input%2 == 0)
                Console.WriteLine("O número é par.");
            else
                Console.WriteLine("O número é ímpar.");

        }
        static void Maioridade()
        {
            Console.WriteLine("Digite a idade das 10 pessoas: ");

            int input1 = Convert.ToInt32(Console.ReadLine ());
            int input2 = Convert.ToInt32(Console.ReadLine ());
            int input3 = Convert.ToInt32(Console.ReadLine ());
            int input4 = Convert.ToInt32(Console.ReadLine ());
            int input5 = Convert.ToInt32(Console.ReadLine ());
            int input6 = Convert.ToInt32(Console.ReadLine ());
            int input7 = Convert.ToInt32(Console.ReadLine ());
            int input8 = Convert.ToInt32(Console.ReadLine ());
            int input9 = Convert.ToInt32(Console.ReadLine ());
            int input10 = Convert.ToInt32(Console.ReadLine ());

            int [] inputs = new int [] {input1,input2,input3,input4,input5,input6,input7,input8,input9,input10};
            int maiores = 0;

            foreach (int input in inputs)
            {
                if (input >= 18)
                    maiores++;
            }

            Console.WriteLine("O número de maiores de idade é: {0}",maiores);
        }
        static void Salario()
        {
            Console.WriteLine("Digite o salário dos 10 funcionários: ");

            double sal1 = Convert.ToDouble(Console.ReadLine ());
            double sal2 = Convert.ToDouble(Console.ReadLine ());
            double sal3 = Convert.ToDouble(Console.ReadLine ());
            double sal4 = Convert.ToDouble(Console.ReadLine ());
            double sal5 = Convert.ToDouble(Console.ReadLine ());
            double sal6 = Convert.ToDouble(Console.ReadLine ());
            double sal7 = Convert.ToDouble(Console.ReadLine ());
            double sal8 = Convert.ToDouble(Console.ReadLine ());
            double sal9 = Convert.ToDouble(Console.ReadLine ());
            double sal10 = Convert.ToDouble(Console.ReadLine ());

            double [] sals = new double[] {sal1,sal2,sal3,sal4,sal5,sal6,sal7,sal8,sal9,sal10};
            double nsal;
            int nfuncionario = 1;

            foreach (double sal in sals)
            {
                if (sal >= 300)
                {
                    nsal = sal*1.3;
                    Console.WriteLine("O salário do funcionário {0} era {1}, agora é {2}",nfuncionario,sal,nsal);
                    nfuncionario++;
                }
                if (sal < 300)
                {
                    nsal = sal*1.5;
                    Console.WriteLine("O salário do funcionário {0} era {1}, agora é {2}",nfuncionario,sal,nsal);
                    nfuncionario++;
                }
            }
        }
        static void Altura()
        {
            Console.WriteLine("Digite a altura dos 10 alunos: ");

            double input1 = Convert.ToDouble(Console.ReadLine ());
            double input2 = Convert.ToDouble(Console.ReadLine ());
            double input3 = Convert.ToDouble(Console.ReadLine ());
            double input4 = Convert.ToDouble(Console.ReadLine ());
            double input5 = Convert.ToDouble(Console.ReadLine ());
            double input6 = Convert.ToDouble(Console.ReadLine ());
            double input7 = Convert.ToDouble(Console.ReadLine ());
            double input8 = Convert.ToDouble(Console.ReadLine ());
            double input9 = Convert.ToDouble(Console.ReadLine ());
            double input10 = Convert.ToDouble(Console.ReadLine ());

            double [] alturas = new double [] {input1,input2,input3,input4,input5,input6,input7,input8,input9,input10};
            Array.Sort(alturas);
            Console.WriteLine("A altura mais baixa é {0}, e a mais alta é {1}",alturas[0],alturas[9]);
        }
        static void Fibbinacci()
        {
            long n = 2, a1 = 1, a2 = 1;
            Console.WriteLine(a1);
            Console.WriteLine(a2);

            while (n <= 100)
            {
                a1=a1+a2;
                Console.WriteLine(a1);
                a2=a1+a2;
                Console.WriteLine(a2);
                n = n + 2;
            }
            Console.WriteLine("100 primeiros números da sequência de Fibonnacci");

        }
        static void Palindrome()
        {
            Console.WriteLine("Escreva uma palavra");
            string word = Console.ReadLine();
            char[] seq = word.ToCharArray();
            
            bool isPalindrome = true;

            for (int i = 0; i <= seq.Length/2; i++)
            {
                if (seq[i] != seq[seq.Length - 1 - i])
                    isPalindrome = false;
            }

            if (isPalindrome)
                Console.WriteLine("A palavra é um palíndromo");
            else
                Console.WriteLine("A palavra não é um palíndromo");

        }
    }
}