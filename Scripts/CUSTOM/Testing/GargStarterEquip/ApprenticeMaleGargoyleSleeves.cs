using Server;
using System;
using Server.Items;

namespace Server.Items
{
	public class ApprenticeMaleGargoyleSleeves :  LeatherArms
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
                public override bool AllowFemaleWearer{ get{ return false; } }

		
		
		[Constructable]
		public ApprenticeMaleGargoyleSleeves() 
		{
			Hue = 57;
			Name = "Apprentice Male Gargoyle Sleeves";
			Weight = 5;
                        ItemID = 770;
			
			Attributes.BonusMana = 5;
			Attributes.Luck = 5;
						
			PhysicalBonus = 5;
			FireBonus = 4;
			ColdBonus = 4;
			PoisonBonus = 3;
			EnergyBonus = 4;
			
			LootType = LootType.Blessed;
				
		} 
		public ApprenticeMaleGargoyleSleeves( Serial serial ) : base( serial )
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
