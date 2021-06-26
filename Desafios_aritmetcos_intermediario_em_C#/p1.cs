/*
Leia um valor de ponto flutuante com duas casas decimais. Este valor representa um valor monetário. A seguir, calcule o menor número de notas e moedas possíveis no qual o valor pode ser decomposto. As notas consideradas são de 100, 50, 20, 10, 5, 2. As moedas possíveis são de 1, 0.50, 0.25, 0.10, 0.05 e 0.01. A seguir mostre a relação de notas necessárias.

Entrada
O arquivo de entrada contém um valor de ponto flutuante N (0 ≤ N ≤ 1000000.00).

Saída
Imprima a quantidade mínima de notas e moedas necessárias para trocar o valor inicial, conforme exemplo fornecido.

Obs: Utilize ponto (.) para separar a parte decimal.
*/

using System; 

class minhaClasse {

    static void Main(string[] args) { 

            double valor;
            int inteiro, TrocoNotas, TrocoMoedas;

            valor = Convert.ToDouble(Console.ReadLine());
            
            inteiro = (int)valor;
            valor *= 100;
            TrocoMoedas = (int)valor;
            TrocoNotas = inteiro;

            Console.WriteLine("NOTAS:");
            Console.WriteLine("{0} nota(s) de R$ 100.00", inteiro / 100);
            TrocoNotas = (inteiro % 100);
            //complete o código
            
            inteiro = TrocoNotas;
            Console.WriteLine("{0} nota(s) de R$ 50.00", inteiro / 50);
            TrocoNotas = (inteiro % 50);
            
            inteiro = TrocoNotas;
            Console.WriteLine("{0} nota(s) de R$ 20.00", inteiro / 20);
            TrocoNotas = (inteiro % 20);
            
            inteiro = TrocoNotas;
            Console.WriteLine("{0} nota(s) de R$ 10.00", inteiro / 10);
            TrocoNotas = (inteiro % 10);
            
            inteiro = TrocoNotas;
            Console.WriteLine("{0} nota(s) de R$ 5.00", inteiro / 5);
            TrocoNotas = (inteiro % 5);
            
            inteiro = TrocoNotas;
            Console.WriteLine("{0} nota(s) de R$ 2.00", inteiro / 2);
            TrocoNotas = (inteiro % 2);

            Console.WriteLine("MOEDAS:");
            Console.WriteLine("{0} moeda(s) de R$ 1.00", TrocoNotas / 1);
            TrocoMoedas %= 100;
            //complete o codigo
            
            Console.WriteLine("{0} moeda(s) de R$ 0.50", TrocoMoedas / 50);
            TrocoNotas = (TrocoMoedas % 50);
            
            TrocoMoedas = TrocoNotas;
            Console.WriteLine("{0} moeda(s) de R$ 0.25", TrocoMoedas / 25);
            TrocoNotas = (TrocoMoedas % 25);
            
            TrocoMoedas = TrocoNotas;
            Console.WriteLine("{0} moeda(s) de R$ 0.10", TrocoMoedas / 10);
            TrocoNotas = (TrocoMoedas % 10);
            
            TrocoMoedas = TrocoNotas;
            Console.WriteLine("{0} moeda(s) de R$ 0.05", TrocoMoedas / 5);
            TrocoNotas = (TrocoMoedas % 5);
            
            TrocoMoedas = TrocoNotas;
            Console.WriteLine("{0} moeda(s) de R$ 0.01", TrocoMoedas / 1);
            TrocoNotas = (TrocoMoedas % 5);

    }

}