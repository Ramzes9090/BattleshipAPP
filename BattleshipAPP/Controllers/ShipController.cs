using Microsoft.AspNetCore.Mvc;
using BattleshipAPP.Models;
using BattleshipAPP.Class;

namespace BattleshipAPP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShipController : ControllerBase
    {

        static bool horizontalA = false;
        static bool horizontalB = true;
        static bool horizontalC = false;
        static bool horizontalD= true;
        static bool horizontalE = false;
        static bool horizontalF = true;
        static bool horizontalG = false;
        static bool horizontalH = true;

        static List<int[]> fullGameList = new List<int[]>();

        static List<int[]>  occupiedColRow = new List<int[]>();
        static List<int[]>  occupiedColRowSec = new List<int[]>();

        static List<int[]>  shootedColRow = new List<int[]>();
        static List<int[]>  shootedColRowSec = new List<int[]>();

        static int[] startD = PlacingShips.ShipFourColRow(occupiedColRow, horizontalD);
        static int[] startC = PlacingShips.ShipThreeColRow(occupiedColRow, horizontalC);
        static int[] startB = PlacingShips.ShipTwoColRow(occupiedColRow, horizontalB);
        static int[] startA = PlacingShips.ShipOneColRow(occupiedColRow, horizontalA);

        static int[] startE = PlacingShips.ShipOneColRow(occupiedColRowSec, horizontalE);
        static int[] startF = PlacingShips.ShipTwoColRow(occupiedColRowSec, horizontalF);
        static int[] startG = PlacingShips.ShipThreeColRow(occupiedColRowSec, horizontalG);
        static int[] startH = PlacingShips.ShipFourColRow(occupiedColRowSec, horizontalH);

        

        private static readonly IEnumerable<ShipModel> Ships = new[]
        {
            new ShipModel{Id=1,ClassShip=1,ShipName = "ship-a",StartColumn = startA[0], StartRow = startA[1],LengthShip=1,IsDestroyed=false, Horizontal= horizontalA },
            new ShipModel{Id=2,ClassShip=1,ShipName = "ship-b",StartColumn = startB[0], StartRow = startB[1],LengthShip=2,IsDestroyed=false, Horizontal= horizontalB },
            new ShipModel{Id=3,ClassShip=1,ShipName = "ship-c",StartColumn = startC[0], StartRow = startC[1],LengthShip=3,IsDestroyed=false, Horizontal= horizontalC},
            new ShipModel{Id=4,ClassShip=1,ShipName = "ship-d",StartColumn = startD[0], StartRow = startD[1],LengthShip=4,IsDestroyed=false, Horizontal= horizontalD },
            new ShipModel{Id=5,ClassShip=1,ShipName = "ship-e",StartColumn = startE[0], StartRow = startE[1],LengthShip=1,IsDestroyed=false, Horizontal= horizontalE },
            new ShipModel{Id=6,ClassShip=1,ShipName = "ship-f",StartColumn = startF[0], StartRow = startF[1],LengthShip=2,IsDestroyed=false, Horizontal= horizontalF },
            new ShipModel{Id=7,ClassShip=1,ShipName = "ship-g",StartColumn = startG[0], StartRow = startG[1],LengthShip=3,IsDestroyed=false, Horizontal= horizontalG },
            new ShipModel{Id=8,ClassShip=1,ShipName = "ship-h",StartColumn = startH[0], StartRow = startH[1],LengthShip=4,IsDestroyed=false, Horizontal= horizontalH }
        };
       
        [HttpGet("{classShip:int}")]
        public ShipModel[] Get(int classShip) 
        {
            foreach (int[] aPart in occupiedColRow)
            {
                Console.Write(aPart[0]);
                Console.Write(" , "); 
                Console.Write(aPart[1]);
                Console.WriteLine();
            }
            
            ShipModel[] ships = Ships.Where(i=>i.ClassShip==classShip).ToArray();
            return ships;
        }
        [HttpGet]
        public List<int[]> Start()
        {
            GameSimulation.connectSquares(shootedColRow, occupiedColRow);
            GameSimulation.connectSquares(shootedColRowSec, occupiedColRowSec);
            Console.WriteLine();
            Console.WriteLine("shootedColRow:  ");
            foreach (int[] aPart in shootedColRow)
            {
                Console.Write(aPart[0]);
                Console.Write(" , ");
                Console.Write(aPart[1]);
            }
            Console.WriteLine();
            Console.WriteLine("shootedColRowSec:  ");
            foreach (int[] aPart in shootedColRowSec)
            {
                Console.Write(aPart[0]);
                Console.Write(" , ");
                Console.Write(aPart[1]);
            }
            int[] count = new int[2];
            count[0] = shootedColRow.Count;
            count[1] = shootedColRowSec.Count;
            fullGameList.Add(count);
            fullGameList.AddRange(shootedColRow);
            fullGameList.AddRange(shootedColRowSec);
            return fullGameList;
        }

    }
}
