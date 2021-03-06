﻿using System;
using Server.Mobiles;

namespace Server.Engines.CannedEvil
{
    public enum ChampionSpawnType
    {
        Abyss,
		Newbie,
		EasyChamp,
        Arachnid,
        ColdBlood,
        ForestLord,
        VerminHorde,
        UnholyTerror,
        SleepingDragon,
        Glade,
        Corrupt,
        #region Stygian Abyss
        Terror,
        Infuse,
        #endregion
        #region TOL
        DragonTurtle,
        #endregion
		 //daat99 OWLTR start - MotA champ
        Crafter,
        //daat99 OWLTR end - MotA champ
		Winter,
		Elemental,
		Undead,
		Hellfire,
		Desert
	}

    public class ChampionSpawnInfo
    {
        private readonly string m_Name;
        private readonly Type m_Champion;
        private readonly Type[][] m_SpawnTypes;
        private readonly string[] m_LevelNames;

        public string Name
        {
            get
            {
                return this.m_Name;
            }
        }
        public Type Champion
        {
            get
            {
                return this.m_Champion;
            }
        }
        public Type[][] SpawnTypes
        {
            get
            {
                return this.m_SpawnTypes;
            }
        }
        public string[] LevelNames
        {
            get
            {
                return this.m_LevelNames;
            }
        }

        public ChampionSpawnInfo(string name, Type champion, string[] levelNames, Type[][] spawnTypes)
        {
            this.m_Name = name;
            this.m_Champion = champion;
            this.m_LevelNames = levelNames;
            this.m_SpawnTypes = spawnTypes;
        }

        public static ChampionSpawnInfo[] Table
        {
            get
            {
                return m_Table;
            }
        }

        private static readonly ChampionSpawnInfo[] m_Table = new ChampionSpawnInfo[]
        {
            new ChampionSpawnInfo("Abyss", typeof(Semidar), new string[] { "Foe", "Assassin", "Conqueror" }, new Type[][]	// Abyss
            { // Abyss
                new Type[] { typeof(GreaterMongbat), typeof(Imp) }, // Level 1
                new Type[] { typeof(Gargoyle), typeof(Harpy) }, // Level 2
                new Type[] { typeof(FireGargoyle), typeof(StoneGargoyle) }, // Level 3
                new Type[] { typeof(Daemon), typeof(Succubus) }// Level 4
            }),
			 new ChampionSpawnInfo("Newbie", typeof(GreaterDragon), new string[] { "Adversary", "Subjugator", "Eradicator" }, new Type[][]	// Newbie
            { // Newbie
                new Type[] { typeof(GiantRat), typeof(Skeleton) }, // Level 1
                new Type[] { typeof(Ghoul), typeof(Spectre) }, // Level 2
                new Type[] { typeof(Harpy), typeof(Gazer) }, // Level 3
                new Type[] { typeof(Wight), typeof(Mummy) }// Level 4
            }),
			  new ChampionSpawnInfo("EasyChamp", typeof(RatLord), new string[] { "Adversary", "Subjugator", "Eradicator" }, new Type[][]	// EasyChamp
            { // EasyChamp
                new Type[] { typeof(GiantRat), typeof(Slime) }, // Level 1
                new Type[] { typeof(Skeleton), typeof(Ratman) }, // Level 2
                new Type[] { typeof(Mongbat), typeof(Harpy) }, // Level 3
                new Type[] { typeof(Ettin), typeof(Mummy) }// Level 4
            }),
			new ChampionSpawnInfo("Arachnid", typeof(Mephitis), new string[] { "Bane", "Killer", "Vanquisher" }, new Type[][]	// Arachnid
            { // Arachnid
                new Type[] { typeof(Scorpion), typeof(GiantSpider) }, // Level 1
                new Type[] { typeof(TerathanDrone), typeof(TerathanWarrior) }, // Level 2
                new Type[] { typeof(DreadSpider), typeof(TerathanMatriarch) }, // Level 3
                new Type[] { typeof(PoisonElemental), typeof(TerathanAvenger) }// Level 4
            }),
            new ChampionSpawnInfo("Cold Blood", typeof(Rikktor), new string[] { "Blight", "Slayer", "Destroyer" }, new Type[][]	// Cold Blood
            { // Cold Blood
                new Type[] { typeof(Lizardman), typeof(Snake) }, // Level 1
                new Type[] { typeof(LavaLizard), typeof(OphidianWarrior) }, // Level 2
                new Type[] { typeof(Drake), typeof(OphidianArchmage) }, // Level 3
                new Type[] { typeof(Dragon), typeof(OphidianKnight) }// Level 4
            }),
            new ChampionSpawnInfo("Forest Lord", typeof(LordOaks), new string[] { "Enemy", "Curse", "Slaughterer" }, new Type[][]	// Forest Lord
            { // Forest Lord
                new Type[] { typeof(Pixie), typeof(ShadowWisp) }, // Level 1
                new Type[] { typeof(Kirin), typeof(Wisp) }, // Level 2
                new Type[] { typeof(Centaur), typeof(Unicorn) }, // Level 3
                new Type[] { typeof(EtherealWarrior), typeof(SerpentineDragon) }// Level 4
            }),
            new ChampionSpawnInfo("Vermin Horde", typeof(Barracoon), new string[] { "Adversary", "Subjugator", "Eradicator" }, new Type[][]	// Vermin Horde
            { // Vermin Horde
                new Type[] { typeof(GiantRat), typeof(Slime) }, // Level 1
                new Type[] { typeof(DireWolf), typeof(Ratman) }, // Level 2
                new Type[] { typeof(HellHound), typeof(RatmanMage) }, // Level 3
                new Type[] { typeof(RatmanArcher), typeof(SilverSerpent) }// Level 4
            }),
            new ChampionSpawnInfo("Unholy Terror", typeof(Neira), new string[] { "Scourge", "Punisher", "Nemesis" }, new Type[][]	// Unholy Terror
            { // Unholy Terror
                (Core.AOS ? new Type[] { typeof(Bogle), typeof(Ghoul), typeof(Shade), typeof(Spectre), typeof(Wraith) }// Level 1 (Pre-AoS)
                 : new Type[] { typeof(Ghoul), typeof(Shade), typeof(Spectre), typeof(Wraith) }), // Level 1

                new Type[] { typeof(BoneMagi), typeof(Mummy), typeof(SkeletalMage) }, // Level 2
                new Type[] { typeof(BoneKnight), typeof(Lich), typeof(SkeletalKnight) }, // Level 3
                new Type[] { typeof(LichLord), typeof(RottingCorpse) }// Level 4
            }),
            new ChampionSpawnInfo("Sleeping Dragon", typeof(Serado), new string[] { "Rival", "Challenger", "Antagonist" }, new Type[][]
            { // Unholy Terror
                new Type[] { typeof(DeathwatchBeetleHatchling), typeof(Lizardman) },
                new Type[] { typeof(DeathwatchBeetle), typeof(Kappa) },
                new Type[] { typeof(LesserHiryu), typeof(RevenantLion) },
                new Type[] { typeof(Hiryu), typeof(Oni) }
            }),
            new ChampionSpawnInfo("Glade", typeof(Twaulo), new string[] { "Banisher", "Enforcer", "Eradicator" }, new Type[][]
            { // Glade
                new Type[] { typeof(Pixie), typeof(ShadowWisp) },
                new Type[] { typeof(Centaur), typeof(MLDryad) },
                new Type[] { typeof(Satyr), typeof(CuSidhe) },
                new Type[] { typeof(FeralTreefellow), typeof(RagingGrizzlyBear) }
            }),
            new ChampionSpawnInfo("Corrupt", typeof(Ilhenir), new string[] { "Cleanser", "Expunger", "Depurator" }, new Type[][]
            { // Corrupt
                new Type[] { typeof(PlagueSpawn), typeof(Bogling) },
                new Type[] { typeof(PlagueBeast), typeof(BogThing) },
                new Type[] { typeof(PlagueBeastLord), typeof(InterredGrizzle) },
                new Type[] { typeof(FetidEssence), typeof(PestilentBandage) }
            }),

            #region SA
            new ChampionSpawnInfo("Terror", typeof(AbyssalInfernal), new string[] { "Banisher", "Enforcer", "Eradicator" }, new Type[][]
            { // Terror
                new Type[] { typeof(HordeMinion), typeof(ChaosDaemon) }, // Level 1
                new Type[] { typeof(StoneHarpy), typeof(ArcaneDaemon) }, // Level 2
                new Type[] { typeof(PitFiend), typeof(Moloch) }, // Level 3
                new Type[] { typeof(ArchDaemon), typeof(AbyssalAbomination) }// Level 4
            }),
            new ChampionSpawnInfo("Infuse", typeof(PrimevalLich), new string[] { "Cleanser", "Expunger", "Depurator" }, new Type[][]
            { // Infused
                new Type[] { typeof(GoreFiend), typeof(VampireBat) }, // Level 1
                new Type[] { typeof(FleshGolem), typeof(DarkWisp) }, // Level 2
                new Type[] { typeof(UndeadGargoyle), typeof(Wight) }, // Level 3
                new Type[] { typeof(SkeletalDrake), typeof(DreamWraith) }// Level 4
            }),
            #endregion

            #region TOL
            new ChampionSpawnInfo( "Valley", typeof( DragonTurtle ), new string[]{ "Explorer", "Huntsman", "Msafiri", } , new Type[][]
		    {																											// DragonTurtle
				new Type[]{ typeof( MyrmidexDrone ), typeof( MyrmidexLarvae ) },										// Level 1
				new Type[]{ typeof( SilverbackGorilla ), typeof( WildTiger ) },											// Level 2
				new Type[]{ typeof( GreaterPhoenix  ), typeof( Infernus ) },										    // Level 3
				new Type[]{ typeof( Dimetrosaur ), typeof( Allosaurus ) }											    // Level 4
			} ),
                #endregion
			 //daat99 OWLTR start - MotA champ mobs
			new ChampionSpawnInfo( "Master of the Arts", typeof(MasterOfTheArts), new string[]{ "Destoyer", "Smelter", "Crafter" } , new Type[][]
			{																											// Crafter
				new Type[]{ typeof( CarpenterAutomaton ), typeof( BabyBellhop ) },										// Level 1
				new Type[]{ typeof( TailorAutomaton ), typeof( Bellhop ) },												// Level 2
				new Type[]{ typeof( BlacksmithAutomaton ), typeof( StrongBellhop ) },									// Level 3
				new Type[]{ typeof( FletcherAutomaton ), typeof( BurntOne ) }											// Level 4
			} ),
			//daat99 OWLTR end - MotA champ mobs
			new ChampionSpawnInfo("Winter", typeof(Mephitis), new string[] { "Foe", "Assassin", "Conqueror" }, new Type[][]	// Abyss
            { // Abyss
                new Type[] { typeof(WhiteWolf), typeof(IceSnake) }, // Level 1
                new Type[] { typeof(FrostOoze), typeof(FrostSpider) }, // Level 2
				new Type[] { typeof(IceHound), typeof(FrostTroll) }, // Level 3
                new Type[] { typeof(IceElemental), typeof(ArcticOgreLord) }// Level 4
            }),
			new ChampionSpawnInfo("Elemental", typeof(Semidar), new string[] { "Foe", "Assassin", "Conqueror" }, new Type[][]	// Abyss
            { // Abyss
                new Type[] { typeof(Scorpion), typeof(Imp) }, // Level 1
                new Type[] { typeof(EarthElemental), typeof(Harpy) }, // Level 2
                new Type[] { typeof(DullCopperElemental), typeof(StoneGargoyle) }, // Level 3
                new Type[] { typeof(BloodElemental), typeof(Daemon) }// Level 4
            }),
			new ChampionSpawnInfo("Undead", typeof(Neira), new string[] { "Foe", "Assassin", "Conqueror" }, new Type[][]	// Abyss
            { // Abyss
                new Type[] { typeof(Slime), typeof(Imp) }, // Level 1
                new Type[] { typeof(Skeleton), typeof(Mummy) }, // Level 2
                new Type[] { typeof(Zombie), typeof(Ghoul) }, // Level 3
                new Type[] { typeof(SkeletalKnight), typeof(BoneKnight) }// Level 4
            }),
			new ChampionSpawnInfo("HellFire", typeof(RatLord), new string[] { "Cleanser", "Expunger", "Depurator" }, new Type[][]	// Abyss
            { // Abyss
                new Type[] { typeof(Slime), typeof(Imp) }, // Level 1
                new Type[] { typeof(FireAnt), typeof(FireElemental) }, // Level 2
                new Type[] { typeof(FireGargoyle), typeof(FireDaemon) }, // Level 3
                new Type[] { typeof(FireBeetle), typeof(FireDaemon) }// Level 4
            }),
			new ChampionSpawnInfo("Desert", typeof(Rikktor), new string[] { "Foe", "Assassin", "Conqueror" }, new Type[][]	// Abyss
            { // Abyss
                new Type[] { typeof(Imp), typeof(Scorpion) }, // Level 1
                new Type[] { typeof(GiantSpider), typeof(Mummy) }, // Level 2
                new Type[] { typeof(OphidianKnight), typeof(SandVortex) }, // Level 3
                new Type[] { typeof(OphidianMage), typeof(Wyvern) }// Level 4
            }),

		};

        public static ChampionSpawnInfo GetInfo(ChampionSpawnType type)
        {
            int v = (int)type;

            if (v < 0 || v >= m_Table.Length)
                v = 0;

            return m_Table[v];
        }
    }
}