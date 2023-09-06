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

        static List<int[]>  occupiedColRow = new List<int[]>();
        static int[] startA = RandNum.ShipOneColRow(occupiedColRow, horizontalA);
        static int[] startB = RandNum.ShipTwoColRow(occupiedColRow, horizontalB);
        static int[] startC = RandNum.ShipThreeColRow(occupiedColRow, horizontalC);
        static int[] startD = RandNum.ShipFourColRow(occupiedColRow, horizontalD);


        private static readonly IEnumerable<ShipModel> Ships = new[]
        {
            new ShipModel{Id=1,ClassShip=1,ShipName = "ship-a",StartColumn = startA[0], StartRow = startA[1],LengthShip=1,IsDestroyed=false, Horizontal= horizontalA },
            new ShipModel{Id=2,ClassShip=1,ShipName = "ship-b",StartColumn = startB[0], StartRow = startB[1],LengthShip=2,IsDestroyed=false, Horizontal= horizontalB },
            new ShipModel{Id=3,ClassShip=1,ShipName = "ship-c",StartColumn = startC[0], StartRow = startC[1],LengthShip=3,IsDestroyed=false, Horizontal= horizontalC},
            new ShipModel{Id=4,ClassShip=1,ShipName = "ship-d",StartColumn = startD[0], StartRow = startD[0],LengthShip=4,IsDestroyed=false, Horizontal= horizontalD },
            new ShipModel{Id=5,ClassShip=1,ShipName = "ship-e",StartColumn = 4, StartRow = 4,LengthShip=3,IsDestroyed=false, Horizontal= true },
            new ShipModel{Id=6,ClassShip=1,ShipName = "ship-f",StartColumn = 0, StartRow = 1,LengthShip=1,IsDestroyed=false, Horizontal= true },
            new ShipModel{Id=7,ClassShip=1,ShipName = "ship-g",StartColumn = 8, StartRow = 3,LengthShip=4,IsDestroyed=false, Horizontal= false },
            new ShipModel{Id=8,ClassShip=1,ShipName = "ship-h",StartColumn = 1, StartRow = 8,LengthShip=2,IsDestroyed=false, Horizontal= true }
        };

        [HttpGet("{classShip:int}")]
        public ShipModel[] Get(int classShip) 
        {
            ShipModel[] ships = Ships.Where(i=>i.ClassShip==classShip).ToArray();
            return ships;
        }
    }
}
