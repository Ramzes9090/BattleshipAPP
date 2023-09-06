using System;
namespace BattleshipAPP.Class
{
    public class RandNum
    {
        // list with already occupied values, function to check it
        public static bool checkList(List<int[]> list, int[] tab)
        {
            bool res = false;
            foreach (int[] aPart in list)
            {
                if (aPart[0] == tab[0] && aPart[1] == tab[1])
                    res = true;
            }
            return res;
        }
        public static int RandNumber(int rangeMin, int rangeMax)
        {
            Random random = new Random();
            int randNumber = random.Next(rangeMin, rangeMax + 1);

            return randNumber;
        }
        // board 10x10, row: 0 - 9, column: 0-9, random position of start filed for diffrent ship

        // ship on 1 square
        public static int[] ShipOneColRow(List<int[]> occupiedColRow, bool horizontal)
        {

            int[] squareOne = new int[2];
            if (horizontal)
            {
                squareOne[0] = RandNumber(0, 9);
                squareOne[1] = RandNumber(0, 9);
            }
            else
            {
                squareOne[0] = RandNumber(0, 9);
                squareOne[1] = RandNumber(0, 9);
            }
            if (!checkList(occupiedColRow, squareOne))
            {
                occupiedColRow.Add(squareOne);
                return squareOne;
            }
            else
            {
                Console.WriteLine("Number occupied!");
                ShipOneColRow(occupiedColRow, horizontal);
            }
            return null;
        }
        // ship on 2 square
        public static int[] ShipTwoColRow(List<int[]> occupiedColRow, bool horizontal)
        {
            int[] squareOne = new int[2];
            int[] squareTwo = new int[2];
            if (horizontal)
            {
                squareOne[0] = RandNumber(0, 8);
                squareOne[1] = RandNumber(0, 9);

                squareTwo[0] = squareOne[0] + 1;
                squareTwo[1] = squareOne[1];
            }
            else
            {
                squareOne[0] = RandNumber(0, 9);
                squareOne[1] = RandNumber(0, 8);

                squareTwo[0] = squareOne[0];
                squareTwo[1] = squareOne[1] + 1;
            }

            if (!checkList(occupiedColRow, squareOne) && !checkList(occupiedColRow, squareTwo))
            {
                occupiedColRow.Add(squareTwo);
                occupiedColRow.Add(squareOne);
                return squareOne;
            }
            else
            {
                Console.WriteLine("Number occupied!");
                ShipTwoColRow(occupiedColRow, horizontal);
            }
            return null;
        }
        // ship on 3 square
        public static int[] ShipThreeColRow(List<int[]> occupiedColRow, bool horizontal)
        {
            int[] squareOne = new int[2];
            int[] squareTwo = new int[2];
            int[] squareThree = new int[2];
            if (horizontal)
            {
                squareOne[0] = RandNumber(0, 7);
                squareOne[1] = RandNumber(0, 9);

                squareTwo[0] = squareOne[0] + 1;
                squareTwo[1] = squareOne[1];

                squareThree[0] = squareOne[0] + 2;
                squareThree[1] = squareOne[1];
            }
            else
            {
                squareOne[0] = RandNumber(0, 9);
                squareOne[1] = RandNumber(0, 7);

                squareTwo[0] = squareOne[0];
                squareTwo[1] = squareOne[1] + 1;

                squareThree[0] = squareOne[0];
                squareThree[1] = squareOne[1] + 2;
            }

            if (!checkList(occupiedColRow, squareOne) && !checkList(occupiedColRow, squareTwo)
                && !checkList(occupiedColRow, squareThree))
            {
                occupiedColRow.Add(squareThree);
                occupiedColRow.Add(squareTwo);
                occupiedColRow.Add(squareOne);
                return squareOne;
            }
            else
            {
                Console.WriteLine("Number occupied!");
                ShipThreeColRow(occupiedColRow, horizontal);
            }
            return null;
        }
        public static int[] ShipFourColRow(List<int[]> occupiedColRow, bool horizontal)
        {
            int[] squareOne = new int[2];
            int[] squareTwo = new int[2];
            int[] squareThree = new int[2];
            int[] squareFour = new int[2];
            if (horizontal)
            {
                squareOne[0] = RandNumber(0, 6);
                squareOne[1] = RandNumber(0, 9);

                squareTwo[0] = squareOne[0] + 1;
                squareTwo[1] = squareOne[1];

                squareThree[0] = squareOne[0] + 2;
                squareThree[1] = squareOne[1];

                squareFour[0] = squareOne[0] + 3;
                squareFour[1] = squareOne[1];
            }
            else
            {
                squareOne[0] = RandNumber(0, 9);
                squareOne[1] = RandNumber(0, 6);

                squareTwo[0] = squareOne[0];
                squareTwo[1] = squareOne[1] + 1;

                squareThree[0] = squareOne[0];
                squareThree[1] = squareOne[1] + 2;

                squareFour[0] = squareOne[0];
                squareFour[1] = squareOne[1] + 3;
            }

            if (!checkList(occupiedColRow, squareOne) && !checkList(occupiedColRow, squareTwo)
                && !checkList(occupiedColRow, squareThree) && !checkList(occupiedColRow,squareFour))
            {
                occupiedColRow.Add(squareFour);
                occupiedColRow.Add(squareThree);
                occupiedColRow.Add(squareTwo);
                occupiedColRow.Add(squareOne);
                return squareOne;
            }
            else
            {
                Console.WriteLine("Number occupied!");
                ShipFourColRow(occupiedColRow, horizontal);
            }
            return null;
        }
    }
}
