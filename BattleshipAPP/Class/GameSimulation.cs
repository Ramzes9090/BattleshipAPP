using BattleshipAPP.Class;
using System.Collections.Generic;

namespace BattleshipAPP.Class
{
    public class GameSimulation
    {
        public static int[] shotField(List<int[]> listField)
        {
            int[] shotSquare = new int[2];
            bool Ok = false;
            while (!Ok)
            {
                shotSquare[0] = RandNum.RandNumber(0, 9);
                shotSquare[1] = RandNum.RandNumber(0, 9);

                if (!CheckField.checkList(listField, shotSquare))
                {
                    Ok = true;
                }
                else
                {
                    //Console.WriteLine("Field already exist!");
                    Ok = false;
                }
            }
            listField.Add(shotSquare);
            return shotSquare;

        }

        public static void connectSquares(List<int[]> listSquares, List<int[]> listShips) 
        {
            bool Ok = false;
            while(!Ok)
            {
                shotField(listSquares);
                var list = listSquares.Where(i => listShips.Contains(i)).ToList();
                if (list.Count == listShips.Count)
                    Ok = true;
            }
        }

    }
}
