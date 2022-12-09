using HeroMaker;
using HeroMaker.Powers;

Hero crystal = Hero.CreateHero("Crystal", "Zapped by light in a crystal cave", 21);

crystal.FirstName = "Dianna";
crystal.LastName = "Jonson";
crystal.Weapons.Add(new Weapon { Title = "Crystal Sword" });

CrystalPower power = new();

crystal.Powers = new [] {power};

Hero timeManiac = Hero.CreateHero("timeManiac", "time mashine found, particles left behind", 21);

timeManiac.FirstName = "Jenny";
timeManiac.LastName = "Jonson";
TimeTravelPower timeTravelPower = new();

timeManiac.Powers = new[] {timeTravelPower};

var lightning = Hero.CreateHero("lightning", "Zapped by lightning", 16);
lightning.FirstName = "Lacey";
lightning.LastName = "Fox";
lightning.Powers = new Power[] { };

var Voltage = Hero.CreateHero("Voltage", "Zapped by lightning", 16);
Voltage.FirstName = "Lexy";
Voltage.LastName = "Fox";
Voltage.Powers = new Power[] { };

var elemento = Hero.CreateHero("elemento", "Power from a crystal", 21);
elemento.FirstName = "Jason";
elemento.LastName = "Fox";
elemento.Powers = new Power[] { };

var kestrel = Hero.CreateHero("Kestrel", "Got her power from a magical kestrel", 16);
kestrel.FirstName = "Charlie";
kestrel.LastName = "Jonson";
kestrel.Powers = new Power[] { };

var manOfSteel = Hero.CreateHero("manOfSteel", "Power from a science experiment gone wrong", 22);
manOfSteel.FirstName = "David";
manOfSteel.LastName = "Johnson";
manOfSteel.Powers = new Power[] { };

Hero[]  heros = new[] { elemento, crystal, lightning, kestrel, manOfSteel, timeManiac, Voltage};

for (int i = 0; i < heros.Length; i++) 
{
    Console.WriteLine(heros[i].GetInfo());
}
