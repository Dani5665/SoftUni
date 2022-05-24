using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string biggestKeg = "";
            double kegVolume = 0;

            for (int i = 0; i < n; i++)
            {
                string kegName = Console.ReadLine();
                float kegRadius = float.Parse(Console.ReadLine());
                int kegHeight = int.Parse(Console.ReadLine());

                double currKegVolume = Math.PI * ((int)kegRadius ^ 2) * kegHeight;

                if (currKegVolume > kegVolume)
                {
                    kegVolume = currKegVolume;
                    biggestKeg = kegName;
                }
            }
            Console.WriteLine(biggestKeg);
        }
    }
}
