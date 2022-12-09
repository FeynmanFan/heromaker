namespace HeroMaker
{
    public class Power
    {
        public Power(string title, int level)
        {
            Title = title;
            Level = level;
        }

        public string Title { get; set; }


        public int Level { get; set; }
    }
}