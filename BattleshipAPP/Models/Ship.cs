namespace BattleshipAPP.Models
{
    public class Ship
    {
        public int Id { get; set; }
        public int length { get; set; }
        public bool IsDestroyed { get; set; }
        public bool Orientation { get; set; }
    }
}
