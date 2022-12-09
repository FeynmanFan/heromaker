namespace HeroMaker
{
    internal class TelekinesisPower : Power, IRangedDamage
    {
        public TelekinesisPower(int level) : base("Telekinesis", level)
        {
        }

        public int RangedDamageBonus
        {
            get 
            {
                return 1 + (int)(.5 * this.Level);
            }
        }
    }
}