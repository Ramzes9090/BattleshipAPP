namespace BattleshipAPP.Class
{
    public class CheckField
    {
        // list with already occupied values, function checks the whole list and return true if value is in the list
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
    }
}
