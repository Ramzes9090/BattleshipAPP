namespace BattleshipAPP.Models
{
    public class ShipModel
    {
        public int Id { get; set; }
        public string ShipName { get; set; }
        public int StartColumn { get; set; }
        public int StartRow { get; set; }
        public int LengthShip { get; set; }
        public bool IsDestroyed { get; set; }
        public bool Horizontal { get; set; }
    }
}
