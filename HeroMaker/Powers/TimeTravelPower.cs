
namespace HeroMaker.Powers
{
    public class TimeTravelPower : Power
    {
        private const string Title = "TimeTravel";

        public TimeTravelPower(int level) : base(Title, level)
        {
        }

        public TimeTravelPower() : base(Title, 1)
        {
        }
    }
}
