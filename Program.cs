using System;

namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3;

            Console.Write("Digite o nome completo do Aluno: ");
            String nomeCompleto = Console.ReadLine();
            Console.WriteLine("--------------------------");
            Console.Write("Digita Primeira Nota: ");
            nota1 = float.Parse(Console.ReadLine());
            Console.Write("Digita Segunda Nota: ");
            nota2 = float.Parse(Console.ReadLine());
            Console.Write("Digita Terceira Nota: ");
            nota3 = float.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------");

            float mediaNotas = (nota1 + nota2 + nota3)/3;

            if(mediaNotas>5){
                Console.WriteLine("A média do Aluno é: " + mediaNotas);
                Console.WriteLine("O aluno "+ nomeCompleto +" está APROVADO");
            }else{
                Console.WriteLine("A média do Aluno é: " + mediaNotas);
                Console.WriteLine("O aluno "+ nomeCompleto +" está REPROVADO");
            }
        } 
    }
}
