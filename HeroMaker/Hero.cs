namespace HeroMaker
{
    public class Hero
    {
        // Stored info
        /* Hero name
         * powers
         * first name
         * last name*/

        /// <summary>
        /// This is the name that the public knows the hero by.
        /// </summary>
        public string HeroName { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        /// <summary>
        /// This is the list of special abilities
        /// </summary>
        public Power[] Powers { get; set; }
        public string BackStory { get; set; }
        public int Age { get; set; }

        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }

        /// <summary>
        /// This is the amount of damage they do in a fist fight.
        /// </summary>
        public int MeleeDamage
        {
            get 
            {
                return this.Strength;
            }
        }

        public int MeleeWeaponsDamageBonus
        {
            get
            {
                int totalBonus = 0;

                foreach (var weapon in this.Weapons)
                {
                    if (weapon is MeleeWeapon)
                    {
                        totalBonus += weapon.AttackDamage;
                    }
                }
                return totalBonus;
            }

        }





        public int RangedBonusFromPowers
        {
            get
            {
                int totalBonus = 0;

                for (var i = 0; i < Powers.Length; i++)
                {
                    if (Powers[i] is IRangedDamage) 
                    { 
                        totalBonus += ((IRangedDamage)this.Powers[i]).RangedDamageBonus;
                    }
                }
                return totalBonus;
            }
        }

        public int DamageResistanceFromPowers
        {
            get
            {
                int totalBonus = 0;

                for (var i = 0; i < Powers.Length; i++)
                {
                    if ((Powers[i] is IDamageResistance))
                    {
                        totalBonus += ((IDamageResistance)this.Powers[i]).DamageResistance;
                    }
                }
                return totalBonus;
            }
        }

        public List<Weapon> Weapons { get; set; }

        public int RangedDamage 
        {
            get 
            {
                return 0 + this.RangedBonusFromPowers;
            }
        }



        /// <summary>
        /// This is the ability to avoid attack
        /// </summary>
        public int Dodge 
        { 
            get 
            {
                return this.Dexterity;
            }
         }

        /// <summary>
        /// this is how the hero resists damage
        /// </summary>
        public int DamageResistance 
        {
            get
            {
                return this.Constitution + this.DamageResistanceFromPowers;
            }
        }
        
        /*Crystal powers" , "portals" , "telekinesis" , "Crystal powers", "time travel", "power replication" , "lightning" , "tazer" ,
         * "elements" , "telekinesis" , "flight", "telekinesis", "super speed" , "force field", "lasers", "feels no pain"
         */


        private Hero()
        {
            this.Weapons = new List<Weapon>();
        }
        
        /// <summary>
        /// Creates a hero
        /// </summary>
        /// <param name="heroName"></param>
        /// <param name="backStory"></param>
        /// <param name="age"></param>
        /// <returns>A hero object</returns>
        /// <exception cref="Exception"></exception>
        public static Hero CreateHero(string heroName, string backStory, int age = 17)
        {
            if (backStory == "")
            {
                throw new Exception("Backstory can't be an empty string, dummy!");
            }

            Hero hero = new Hero();
            hero.HeroName = heroName;
            hero.BackStory = backStory;
            hero.Age = age;

            return hero;
        }

        public string GetInfo()
        {
            
            var info = this.HeroName;
            info = info + "\n" + this.FirstName;
            info += "\n" + this.LastName;
            info += "\n" + this.Age + "\n";

            // info += "\n" + this.Powers[0];
            // list the powers 
            for (var i = 0; i < Powers.Length; i++)
            {
                info += this.Powers[i].Title + "\n";
            }

            foreach (var weapon in this.Weapons)
            {
                info += weapon.Title + "\n";
            }

            return info;
        }
    }
}