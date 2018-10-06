using System;
using Server;
using System.Collections;
using System.Collections.Generic;
using Server.Items;
using Server.Targeting;

namespace Server.Mobiles
{
	[CorpseName( "A Drelgor The Impaler Corpse" )]
	public class Drelgor : BaseCreature
	{

        private DateTime recoverDelay;
        private static bool m_Talked;  

        string[] Drelgorsay = new string[] // things to say while greeting 
		      { 

			 "Who dares to defile Haven?", 

             "I am Drelgor the Impaler, I shall claim your souls as payment for this intrusion!",

             	};

		[Constructable]
		public Drelgor() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
            Name = "Drelgor the Impaler";
            //Title = "The Impaler";
			Body = 147;
			BaseSoundID = 451;

			SetStr( 200, 250 );
			SetDex( 80, 95 );
			SetInt( 40, 60 );

			SetHits( 150, 200 );

			SetDamage( 10, 20 );

			SetDamageType( ResistanceType.Physical, 40 );
			SetDamageType( ResistanceType.Cold, 60 );

			SetResistance( ResistanceType.Physical, 40, 50 );
			SetResistance( ResistanceType.Fire, 25, 35 );
			SetResistance( ResistanceType.Cold, 55, 65 );
			SetResistance( ResistanceType.Poison, 25, 35 );
			SetResistance( ResistanceType.Energy, 35, 45 );

			SetSkill( SkillName.MagicResist, 70.1, 85.0 );
			SetSkill( SkillName.Tactics, 90.1, 105.0 );
            SetSkill(SkillName.Swords, 75.1, 85.0);
			SetSkill( SkillName.Wrestling, 90.1, 100.0 );

			Fame = 3200;
			Karma = -3200;

			VirtualArmor = 40;

            PackItem(new Scimitar());
            PackItem(new WoodenShield());

			switch ( Utility.Random( 5 ) )
			{
                case 0: PackItem(new ImpalerHelm()); break;
                case 1: PackItem(new ImpalerChest()); break;
                case 2: PackItem(new ImpalerArms()); break;
                case 3: PackItem(new ImpalerGloves()); break;
                case 4: PackItem(new ImpalerLegs()); break;
			}
		}

		public override void GenerateLoot()
		{
            AddLoot(LootPack.FilthyRich);
            AddLoot(LootPack.Average);
		}

		public override bool BleedImmune{ get{ return true; } }

        public override void OnMovement(Mobile m, Point3D oldLocation)
        {
            if (m_Talked == false)
            {
                if (m.InRange(this, 4))
                {
                    m_Talked = true;
                    SayRandom(Drelgorsay, this);
                    this.Move(GetDirectionTo(m.Location));

                    SpamTimer t = new SpamTimer();
                    t.Start();
                }
            }
        }

        private class SpamTimer : Timer
        {
            public SpamTimer()
                : base(TimeSpan.FromSeconds(30))
            {
                Priority = TimerPriority.OneSecond;
            }

            protected override void OnTick()
            {
                m_Talked = false;
            }
        }

        private static void SayRandom(string[] say, Mobile m)
        {
            m.Say(say[Utility.Random(say.Length)]);
        }

        public Drelgor(Serial serial)
            : base(serial)
		{
		}

		public override OppositionGroup OppositionGroup
		{
			get{ return OppositionGroup.FeyAndUndead; }
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}