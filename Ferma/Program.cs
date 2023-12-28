namespace Ferma
{
    public class Program
    {
        public static bool Ferma(int n, out int x1, out int y1, out int z1)
        {
            x1 = 0;
            y1 = 0;
            z1 = 0;
            if (n < 0)
                return false;
            for (int x = 1; x <= 100; x++)
                for (int y = 1; y <= 100; y++)
                    for (int z = 1; z <= 100; z++)
                        if (Math.Pow(x, n) + Math.Pow(y, n) == Math.Pow(z, n))
                        {
                            x1 = x;
                            y1 = y;
                            z1 = z;
                            return true;
                        }
            return false;
        }

        static void Main()
        {
            int n = 2;
            if (Ferma(n, out int x, out int y, out int z))
                Console.WriteLine("Теорема Ферма верна для n={0}, x={1}, y={2}, z={3}", n, x, y, z);
            else
                Console.WriteLine("Теорема Ферма не верна для n={0}", n);
        }
    }
}