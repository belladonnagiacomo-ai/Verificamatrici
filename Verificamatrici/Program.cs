namespace Verificamatrici
{
    internal class Program
    {
        static bool RigheU(int[,] m)
        {
            int[,] m2 = new int[m.GetLength(0), m.GetLength(1)];
            bool verifica = false;
            int k = 0, r = 0; 
            for(int i = 0; i < m.GetLength(0); i++)
            {
                k = 0;
                for(int j = 0;  j < m.GetLength(1); j++)
                {
                    if(m[r, j]  == m[i + r, j])
                    {
                        k++;
                    }

                   
                }
                r++;
                if(k == 4)
                {
                    verifica = true;
                    return verifica;
                }
            }
            return verifica;
            
        }
        static void cerca1(int[,] m, int colonna)
        {
            int c = 0;
            for(int i = 0; i < m.GetLength(0); i++)
            {
                for(int j = 0; j < m.GetLength(1); j++)
                {
                    if (m[i,j] == 1)
                    {
                        c = j;
                    }
                }
            }
            if(colonna == c)
            {
                Console.WriteLine("Hai indovinato la posizione");
            }
            else if(colonna > c)
            {
                Console.WriteLine("Sinistra");
            }
            else if(colonna < c)
            {
                Console.WriteLine("Destra");
            }

        }
        static void Pattern(string[,] pattern, int r)
        {
            string t;
            for(int i = 0; i <pattern.GetLength(1); i++)
            {
                t = pattern[r,i];
                for(int k = 0;  k < pattern.GetLength(1); k++)
                {
                    if(t == pattern[r, k] && i!=k)
                    {
                        Console.WriteLine("Ci sono lettere uguali in " + i);
                        
                    }
                }
                
            }
            return;



        }
        static void Main(string[] args)
        {
            int[,] m = { { 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };
            string[,] pattern = { { "G", "A", "L", "E", "G" }, { "R", "O", "K", "N", "O" }, { "M", "E", "L", "E", "S" }, { "C", "I", "N", "I", "S" } };
            Console.WriteLine("Dammi la colonna");
            int colonna = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            cerca1(m, colonna);
            Console.WriteLine();
            Console.WriteLine("Dammi la riga");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Pattern(pattern, r);
           
        }
    }
}
