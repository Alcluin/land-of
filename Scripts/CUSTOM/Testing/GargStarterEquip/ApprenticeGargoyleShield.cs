using Server;
using System;
using Server.Items;

namespace Server.Items
{
	public class ApprenticeGargoyleShield : MetalKiteShield
	{ 
                
				
		public override int InitMinHits{ get{ return 150; } }
		public override int InitMaxHits{ get{ return 150; } }

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
		public ApprenticeGargoyleShield()
		{
			
			Name = "Apprentice Gargoyle Shield";
			Weight = 10;
            ItemID = 16938;
			
			Attributes.SpellChanneling = 1;
			Attributes.DefendChance = 5;
			Attributes.AttackChance = 5;
			Attributes.Luck = 15;
			
			LootType = LootType.Blessed;
			
			PhysicalBonus = 6;
			FireBonus = 5;
			ColdBonus = 5;
			PoisonBonus = 6;			
			EnergyBonus = 5;
		} 
		
		public ApprenticeGargoyleShield( Serial serial ) : base( serial )
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
