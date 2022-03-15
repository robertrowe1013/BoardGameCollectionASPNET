namespace BoardGameCollection.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MinPlayerCount { get; set; }
        public int MaxPlayerCount { get; set; }


        public Game()
        {
        }
    }
}
