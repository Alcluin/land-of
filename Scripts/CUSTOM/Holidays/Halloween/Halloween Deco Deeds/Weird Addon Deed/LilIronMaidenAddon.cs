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
	public class LilIronMaidenAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new LilIronMaidenAddonDeed();
			}
		}

		[ Constructable ]
		public LilIronMaidenAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 16149 );
			AddComponent( ac, 0, 0, 0 );

		}

		public LilIronMaidenAddon( Serial serial ) : base( serial )
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

	public class LilIronMaidenAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new LilIronMaidenAddon();
			}
		}

		[Constructable]
		public LilIronMaidenAddonDeed()
		{
			Name = "LilIronMaiden";
            
		}

		public LilIronMaidenAddonDeed( Serial serial ) : base( serial )
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