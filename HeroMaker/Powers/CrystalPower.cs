namespace HeroMaker.Powers
{
    public class CrystalPower : Power, IRangedDamage, IDamageResistance
    {
        private const string TITLE = "Shoot crystals and convert skin into crystal";

        public CrystalPower() : base(TITLE, 1)
        {
        }

        public CrystalPower(int level) : base(TITLE, level)
        {
        }

        public void ConvertSkinIntoCrystal()
        {
            // TODO: make this do something
        }

        public void shootCrystals()
        {
            // TODO: make this do something
        }

        public int RangedDamageBonus
        {
            get
            {
                return 1 * Level;
            }
        }

        public int DamageResistance
        {
            get
            {
                return 1 * Level;
            }
        }
    }
}
