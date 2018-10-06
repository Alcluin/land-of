/////////////////////////////////////////////////
//                                             //
// Automatically generated by the              //
// AddonGenerator script by Arya               //
//                                             //
/////////////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class CandyCaneNewGreenAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new CandyCaneNewGreenAddonDeed();
			}
		}

		[ Constructable ]
		public CandyCaneNewGreenAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 933 );
			ac.Hue = 2246;
			ac.Name = "Candy Cane";
			AddComponent( ac, 0, 1, 11 );
			ac = new AddonComponent( 4964 );
			ac.Hue = 1153;
			ac.Name = "Candy Cane";
			AddComponent( ac, 0, 1, 14 );
			ac = new AddonComponent( 933 );
			ac.Hue = 1153;
			ac.Name = "Candy Cane";
			AddComponent( ac, 0, 1, 9 );
			ac = new AddonComponent( 933 );
			ac.Hue = 1153;
			ac.Name = "Candy Cane";
			AddComponent( ac, 1, 1, 20 );
			ac = new AddonComponent( 933 );
			ac.Hue = 1153;
			ac.Name = "Candy Cane";
			AddComponent( ac, 1, 0, 13 );
			ac = new AddonComponent( 933 );
			ac.Hue = 2246;
			ac.Name = "Candy Cane";
			AddComponent( ac, 1, 0, 10 );
			ac = new AddonComponent( 933 );
			ac.Hue = 2246;
			ac.Name = "Candy Cane";
			AddComponent( ac, 1, 0, 5 );
			ac = new AddonComponent( 933 );
			ac.Hue = 1153;
			ac.Name = "Candy Cane";
			AddComponent( ac, 1, 0, 3 );
			ac = new AddonComponent( 4964 );
			ac.Hue = 1153;
			ac.Name = "Candy Cane";
			AddComponent( ac, 1, 0, 16 );
			ac = new AddonComponent( 933 );
			ac.Hue = 1153;
			ac.Name = "Candy Cane";
			AddComponent( ac, 1, 0, 8 );
			ac = new AddonComponent( 4964 );
			ac.Hue = 1153;
			ac.Name = "Candy Cane";
			AddComponent( ac, 1, 1, 23 );
			ac = new AddonComponent( 933 );
			ac.Hue = 2246;
			ac.Name = "Candy Cane";
			AddComponent( ac, 1, 0, 0 );

		}

		public CandyCaneNewGreenAddon( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class CandyCaneNewGreenAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new CandyCaneNewGreenAddon();
			}
		}

		[Constructable]
		public CandyCaneNewGreenAddonDeed()
		{
			Name = "CandyCaneNewGreen";
		}

		public CandyCaneNewGreenAddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}