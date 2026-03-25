namespace Verificamatrici
{
    internal class Program
    {
        static bool RigheU(int[,] m)
        {
            int[,] m2 = new int[m.GetLength(0), m.GetLength(1)];
            bool verifica = false;
            for(int i = 0; i < m.GetLength(0); i++)
            {
                for(int j = 0;  j < m.GetLength(1); j++)
                {
                    if(m[i, j]  == m[i + 1, j])
                    {
                        verifica = true;
                        return verifica;
                    }
                   
                }
            }
            return verifica;
            
        }
        static void Main(string[] args)
        {
            int[,] m = { {0,1,1,1}, { 1,1,0,0}, { 1,1,1,1}, { 0,0,1,1} };
            if(RigheU(m) == true)
            {
                Console.WriteLine("c'è una coppia di righe uguali");
            }
            else
            {
                Console.WriteLine("non ci sono righe uguali");
            }
        }
    }
}
