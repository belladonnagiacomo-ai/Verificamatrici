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
                Console.WriteLine("Alto");
            }
            else if(colonna < c)
            {
                Console.WriteLine("Basso");
            }

        }

        static void Main(string[] args)
        {
            int[,] m = { { 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };
            Console.WriteLine("Dammi la colonna");
            int colonna = Convert.ToInt32(Console.ReadLine());
            cerca1(m, colonna);
           
        }
    }
}
