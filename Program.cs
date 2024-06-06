namespace Assignment_5._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] flowerbed = { 1, 0, 0, 0, 0, 1 };
            int n = 1;

            bool canPlant = CanPlaceFlowers(flowerbed, n);

            Console.WriteLine($"Can plant {n} new flowers: {canPlant}");
        }

        public static bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (flowerbed[i] == 0 &&
                    (i == 0 || flowerbed[i - 1] == 0) &&
                    (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0))
                {
                    flowerbed[i] = 1;
                    n--;
                }

                if (n <= 0)
                    return true;
            }

            return false;
        }

    }
}
