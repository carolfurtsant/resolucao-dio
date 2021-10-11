using System;

namespace _52._36_URI_1759
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());

            //Exibir "Ho" do papai noel
            for (int i = 0; i < N; i++)
            {
                if (i < N - 1)
                {
                    Console.Write("Ho ");                  //Complete o código no espaço em branco
                }
                else
                {
                    Console.WriteLine("Ho!");
                }
            }
        }
    }
}