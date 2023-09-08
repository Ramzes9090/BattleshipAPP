using BattleshipAPP.Class;
namespace BattleshipAPP.Class
{
    public class PlacingShips
    {
        // board 10x10, row: 0 - 9, column: 0-9, random position for start field and type of diffrent ship

        // ship on 1 square
        public static int[] ShipOneColRow(List<int[]> occupiedColRow, bool horizontal)
        {

            int[] squareOne = new int[2];
            bool Ok = false;
            while (!Ok)
            {
                if (horizontal)
                {
                    squareOne[0] = RandNum.RandNumber(0, 9);
                    squareOne[1] = RandNum.RandNumber(0, 9);
                }
                else
                {
                    squareOne[0] = RandNum.RandNumber(0, 9);
                    squareOne[1] = RandNum.RandNumber(0, 9);
                }
                if (!CheckField.checkList(occupiedColRow, squareOne))
                {
                    Ok = true;
                }
                else
                {
                    Console.WriteLine("Number occupied!");
                    Ok = false;
                }
            }
            occupiedColRow.Add(squareOne);
            return squareOne;
        }
        // ship on 2 square
        public static int[] ShipTwoColRow(List<int[]> occupiedColRow, bool horizontal)
        {
            int[] squareOne = new int[2];
            int[] squareTwo = new int[2];
            bool Ok = false;
            while (!Ok)
            {
                if (horizontal)
                {
                    squareOne[0] = RandNum.RandNumber(0, 8);
                    squareOne[1] = RandNum.RandNumber(0, 9);

                    squareTwo[0] = squareOne[0] + 1;
                    squareTwo[1] = squareOne[1];
                }
                else
                {
                    squareOne[0] = RandNum.RandNumber(0, 9);
                    squareOne[1] = RandNum.RandNumber(0, 8);

                    squareTwo[0] = squareOne[0];
                    squareTwo[1] = squareOne[1] + 1;
                }

                if (!CheckField.checkList(occupiedColRow, squareOne) && !CheckField.checkList(occupiedColRow, squareTwo))
                {
                    Ok = true;
                }
                else
                {
                    Console.WriteLine("Number occupied!");
                    Ok = false;
                }
            }
            occupiedColRow.Add(squareTwo);
            occupiedColRow.Add(squareOne);
            return squareOne;
        }
        // ship on 3 square
        public static int[] ShipThreeColRow(List<int[]> occupiedColRow, bool horizontal)
        {
            int[] squareOne = new int[2];
            int[] squareTwo = new int[2];
            int[] squareThree = new int[2];
            bool Ok = false;
            while (!Ok)
            {
                if (horizontal)
                {
                    squareOne[0] = RandNum.RandNumber(0, 7);
                    squareOne[1] = RandNum.RandNumber(0, 9);

                    squareTwo[0] = squareOne[0] + 1;
                    squareTwo[1] = squareOne[1];

                    squareThree[0] = squareOne[0] + 2;
                    squareThree[1] = squareOne[1];
                }
                else
                {
                    squareOne[0] = RandNum.RandNumber(0, 9);
                    squareOne[1] = RandNum.RandNumber(0, 7);

                    squareTwo[0] = squareOne[0];
                    squareTwo[1] = squareOne[1] + 1;

                    squareThree[0] = squareOne[0];
                    squareThree[1] = squareOne[1] + 2;
                }

                if (!CheckField.checkList(occupiedColRow, squareOne) && !CheckField.checkList(occupiedColRow, squareTwo)
                    && !CheckField.checkList(occupiedColRow, squareThree))
                {
                    Ok = true;
                }
                else
                {
                    Console.WriteLine("Number occupied!");
                    Ok = false;
                }
            }
            occupiedColRow.Add(squareThree);
            occupiedColRow.Add(squareTwo);
            occupiedColRow.Add(squareOne);
            return squareOne;
        }
        // ship on 4 square
        public static int[] ShipFourColRow(List<int[]> occupiedColRow, bool horizontal)
        {
            int[] squareOne = new int[2];
            int[] squareTwo = new int[2];
            int[] squareThree = new int[2];
            int[] squareFour = new int[2];
            bool Ok = false;
            while (!Ok)
            {

                if (horizontal)
                {
                    squareOne[0] = RandNum.RandNumber(0, 6);
                    squareOne[1] = RandNum.RandNumber(0, 9);

                    squareTwo[0] = squareOne[0] + 1;
                    squareTwo[1] = squareOne[1];

                    squareThree[0] = squareOne[0] + 2;
                    squareThree[1] = squareOne[1];

                    squareFour[0] = squareOne[0] + 3;
                    squareFour[1] = squareOne[1];
                }
                else
                {
                    squareOne[0] = RandNum.RandNumber(0, 9);
                    squareOne[1] = RandNum.RandNumber(0, 6);

                    squareTwo[0] = squareOne[0];
                    squareTwo[1] = squareOne[1] + 1;

                    squareThree[0] = squareOne[0];
                    squareThree[1] = squareOne[1] + 2;

                    squareFour[0] = squareOne[0];
                    squareFour[1] = squareOne[1] + 3;
                }

                if (!CheckField.checkList(occupiedColRow, squareOne) && !CheckField.checkList(occupiedColRow, squareTwo)
                    && !CheckField.checkList(occupiedColRow, squareThree) && !CheckField.checkList(occupiedColRow, squareFour))
                {
                    Ok = true;
                }
                else
                {
                    Console.WriteLine("Number occupied!");
                    Ok = false;
                }

            }
            occupiedColRow.Add(squareFour);
            occupiedColRow.Add(squareThree);
            occupiedColRow.Add(squareTwo);
            occupiedColRow.Add(squareOne);
            return squareOne;
        }
    }
}
