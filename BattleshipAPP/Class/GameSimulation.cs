using BattleshipAPP.Class;
using System.Collections.Generic;

namespace BattleshipAPP.Class
{
    public class GameSimulation
    {
        public static void connectSquares(List<int[]> listSquares, List<int[]> listShips) 
        {
            int index = 0;
            bool Ok = false;
            while (!Ok)
            {
                int[] shotSquare = new int[2];
                bool Okx = false;
                while (!Okx)
                {
                    shotSquare[0] = RandNum.RandNumber(0, 9);
                    shotSquare[1] = RandNum.RandNumber(0, 9);

                    if (!CheckField.checkList(listSquares, shotSquare))
                    {
                        if (CheckField.checkList(listShips, shotSquare))
                        {
                            index++;
                            Console.WriteLine("Index: " + index);
                        }
                        Okx = true;
                    }
                    else
                    {

                        Okx = false;
                    }
                }
                
                listSquares.Add(shotSquare);

                if (index >= 10)
                    Ok = true;
                else if (listSquares.Count == 100)
                    Ok = true;
            }
        }

    }
}
