using Microsoft.AspNetCore.Mvc;
using BattleshipAPP.Models;

namespace BattleshipAPP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShipController : ControllerBase
    {
        private static readonly IEnumerable<ShipModel> Ships = new[]
        {
            new ShipModel{Id=1,ShipName = "ship-a",StartColumn = 1, StartRow = 1,LengthShip=3,IsDestroyed=false, Horizontal= true },
            new ShipModel{Id=2,ShipName = "ship-b",StartColumn = 5, StartRow = 6,LengthShip=1,IsDestroyed=false, Horizontal= true }
        };

        [HttpGet("{id:int}")]
        public ShipModel[] Get(int id)
        {
            ShipModel[] ships = Ships.Where(i=>i.Id==id).ToArray();
            return ships;
        }
    }
}
