using HeroMaker.Powers;

namespace HeroMaker.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CrystalPowerGivesRangedBonusOne()
        {
            // arrange 
            Hero crystal = Hero.CreateHero("Crystal", "Zapped by light in a crystal cave", 17);

            CrystalPower power = new CrystalPower();

            crystal.Powers = new[] { power };



            // act
            // assert
            Assert.AreEqual(1, crystal.RangedDamage);
        }

        [TestMethod]
        public void TelekinesisPowersRangedDamage()
        {
            // arrange
            Hero crystal = Hero.CreateHero("Crystal", "Zapped by light in a crystal cave", 17);

            TelekinesisPower power = new(3);

            crystal.Powers = new[] { power };

            // act
            // assert
            Assert.AreEqual(2, crystal.RangedDamage);
        }

        [TestMethod]
        public void CrystalPowerGivesDamageResistOne() 
        {
            // arrange
            Hero crystal = Hero.CreateHero("Crystal", "Zapped by light in a crystal cave", 17);

            CrystalPower power = new CrystalPower(3);

            crystal.Powers = new[] { power };

            // act
            // assert
            Assert.AreEqual(3, crystal.DamageResistance);
        }
        [TestMethod]
        public void SimpleWeaponsTest() 
        {
            // arrange
            var dagger = new Weapon();
            dagger.Title = "dagger";
            // act
            // assert        
            Assert.AreEqual("dagger", dagger.Title, "titel did'nt match");
        
        
        }
    }
}