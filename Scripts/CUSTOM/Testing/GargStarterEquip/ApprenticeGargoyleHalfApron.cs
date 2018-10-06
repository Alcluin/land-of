using Server;
using System;
using Server.Items;

namespace Server.Items
{
	public class ApprenticeGargoyleHalfApron : LeatherChest
	{ 
		
		public override int InitMinHits{ get{ return 100; } }
		public override int InitMaxHits{ get{ return 100; } }
		
		public override int BasePhysicalResistance{ get{ return 0; } }
		public override int BaseFireResistance{ get{ return 0; } }
		public override int BaseColdResistance{ get{ return 0; } }
		public override int BasePoisonResistance{ get{ return 0; } }
		public override int BaseEnergyResistance{ get{ return 0; } }
               

		public override int AosStrReq{ get{ return 15; } }
		public override int OldStrReq{ get{ return 15; } } 
                public override Race RequiredRace{ get { return Race.Gargoyle; } }
		public override bool CanBeWornByGargoyles{ get{ return true; } }
		
		[Constructable]
		public ApprenticeGargoyleHalfApron () 
		{
			
			Name = "Apprentice Gargoyle Half-Apron ";
			Weight = 5;
            ItemID = 20696;
             Layer = Layer.Waist;
			
			Attributes.LowerManaCost = 5;
			Attributes.Luck = 5;
            Attributes.BonusDex = 3;
			
			PhysicalBonus = 4;
			FireBonus = 3;
			ColdBonus = 2;
			PoisonBonus = 4;
			EnergyBonus = 4;
			
			
			LootType = LootType.Blessed;
			
		} 
		public ApprenticeGargoyleHalfApron ( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 );
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();

		}
	}
}
