using Server;
using System;
using Server.Items;

namespace Server.Items
{
	public class ApprenticeFemaleGargoyleKilt : LeatherChest
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
        public override bool AllowMaleWearer{ get{ return false; } }
                
		
		
		[Constructable]
		public ApprenticeFemaleGargoyleKilt () 
		{
			Hue = 333;
			Name = "Apprentice Female Gargoyle Kilt ";
			Weight = 5;
                        ItemID = 785;
                        Layer = Layer.OuterLegs;
			
			
			Attributes.LowerManaCost = 5;
			Attributes.Luck = 5;
			
			
			PhysicalBonus = 4;
			FireBonus = 2;
			ColdBonus = 3;
			PoisonBonus = 3;
			EnergyBonus = 4;
			
			LootType = LootType.Blessed;
				
		} 
		public ApprenticeFemaleGargoyleKilt ( Serial serial ) : base( serial )
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
