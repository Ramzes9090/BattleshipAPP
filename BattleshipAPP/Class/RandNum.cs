using System;
namespace BattleshipAPP.Class
{
    public class RandNum
    {
        // function to generate random numbers in given range
        public static int RandNumber(int rangeMin, int rangeMax)
        {
            Random random = new Random();
            int randNumber = random.Next(rangeMin, rangeMax + 1);

            return randNumber;
        }
        
    }
}
