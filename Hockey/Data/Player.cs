namespace Hockey.Data
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rank { get; set; }
        public decimal Age { get; set; }
        public string Projection { get; set; }
        public int TeamId { get; set; }
    }
}