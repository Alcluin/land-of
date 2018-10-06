
using System;
using Server;

namespace Server.Items
{
	public class LightHouseGlobe : Item
	{
		


		[Constructable]
		public LightHouseGlobe() : base(0xE2E) 
		{
			Weight = 1.0;
			Name = "A Snowy Scene Of Light House";
			



			LootType = LootType.Blessed; 
		}

		public LightHouseGlobe( Serial serial ) : base( serial )
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