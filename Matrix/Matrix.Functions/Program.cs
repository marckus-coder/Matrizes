using System;

namespace Course {
	class Program {
		static void Main(string[] args){
			Console.WriteLine("Informe o número de linhas: ");
			int M = int.Parse(Console.ReadLine());
			Console.WriteLine("Informe o número de colunas: ");
			int N = int.Parse(Console.ReadLine());

			int[,] mat = new int[M, N];

			for (int i = 0; i < M; i++)
			{
				string[] value = Console.ReadLine().Split(); 

				for (int j = 0; j < N; j++)
				{
					mat[i, j] = int.Parse(value[j]);					
				}
			}
            Console.WriteLine("Informe o valor da matriz: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (mat[i, j] == x)
                    {
                         Console.WriteLine($"Posição do valor {x}: Linha {i}, Coluna {j}");

                         if (i > 0)
                        {
                            Console.WriteLine("UP: " + mat[i - 1, j]);                        
                        }
                        if (i < M - 1)
                        {
                            Console.WriteLine("DOWN: " + mat[i + 1, j]);                        
                        }
                        if (j > 0)
                        {
                            Console.WriteLine("LEFT: " + mat[i, j - 1]);                        
                        }
                         if (j < N -1)
                        {
                            Console.WriteLine("RIGHT: " + mat[i, j + 1]);                        
                        }
                    }
                }
            }     

		}
	}
}