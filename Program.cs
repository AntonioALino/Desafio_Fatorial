using System.Security.Cryptography.X509Certificates;

public class Desafio
{
    static void Main(string[] args)
    {
   
        int numero;

        int fatorial = 1;

        Console.WriteLine("Digite um numero do qual voce deseja descobrir o fatorial: ");
        numero = int.Parse(Console.ReadLine());

        if (numero > 0)
        {
            for (int i = 0; i < numero; i = i + 1)
            {
                fatorial *= numero - i;

                Console.WriteLine("{0}", fatorial);
            }
        }
        else
        {
            Console.WriteLine("Não podemos fazer o fatorial de numeros negativos");


        }
         
    }
    
}


