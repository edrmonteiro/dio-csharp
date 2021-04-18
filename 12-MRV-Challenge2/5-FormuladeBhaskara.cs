/*
5 / 5 - Fórmula de Bhaskara
Leia 3 valores de ponto flutuante e efetue o cálculo das raízes da equação de Bhaskara. Se não for possível calcular as raízes, mostre a mensagem correspondente “Impossivel calcular”, caso haja uma divisão por 0 ou raiz de numero negativo.

Entrada
Leia três valores de ponto flutuante (double) A, B e C.

Saída
Se não houver possibilidade de calcular as raízes, apresente a mensagem "Impossivel calcular". Caso contrário, imprima o resultado das raízes com 5 dígitos após o ponto, com uma mensagem correspondente conforme exemplo abaixo. Imprima sempre o final de linha após cada mensagem.

 
Exemplos de Entrada	    Exemplos de Saída
10.0 20.1 5.1                   R1 = -0.29788
                                        R2 = -1.71212
0.0 20.0 5.0                    Impossivel calcular
10.3 203.0 5.0                  R1 = -0.02466
                                        R2 = -19.68408
10.0 3.0 5.0                    Impossivel calcular

*/

using System; 

class minhaClasse {

    static void Main(string[] args) { 

        double a, b, c, delta, r1, r2;
        string[] valor = Console.ReadLine().Split();

        a = Convert.ToDouble(valor[0]);
        b = Convert.ToDouble(valor[1]);
        c = Convert.ToDouble(valor[2]);
        //declare as demais variaveis

        delta = (Math.Pow(b, 2) - (4 * a * c));

        if (( a == 0) || (delta < 0))
        {
            //complete a condicional
            Console.WriteLine("Impossivel calcular");
        }
        else
        {
            r1 = (-b + Math.Sqrt(delta)) / (2 * a);
            r2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"R1 = " + Math.Round(r1, 5));
            Console.WriteLine($"R2 = " + Math.Round(r2, 5));
        }

    }

}

