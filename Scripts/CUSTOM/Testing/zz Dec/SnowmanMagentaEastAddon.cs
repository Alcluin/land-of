
////////////////////////////////////////
//                                     //
//   Generated by CEO's YAAAG - Ver 2  //
// (Yet Another Arya Addon Generator)  //
//    Modified by Hammerhand for       //
//      SA & High Seas content         //
//                                     //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class SnowmanMagentaEastAddon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new SnowmanMagentaEastAddonDeed();
			}
		}

		[ Constructable ]
		public SnowmanMagentaEastAddon()
		{



			AddComplexComponent( (BaseAddon) this, 9001, 0, 0, 0, 222, -1, "", 1);// 1

		}

		public SnowmanMagentaEastAddon( Serial serial ) : base( serial )
		{
		}

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource)
        {
            AddComplexComponent(addon, item, xoffset, yoffset, zoffset, hue, lightsource, null, 1);
        }

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource, string name, int amount)
        {
            AddonComponent ac;
            ac = new AddonComponent(item);
            if (name != null && name.Length > 0)
                ac.Name = name;
            if (hue != 0)
                ac.Hue = hue;
            if (amount > 1)
            {
                ac.Stackable = true;
                ac.Amount = amount;
            }
            if (lightsource != -1)
                ac.Light = (LightType) lightsource;
            addon.AddComponent(ac, xoffset, yoffset, zoffset);
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

	public class SnowmanMagentaEastAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new SnowmanMagentaEastAddon();
			}
		}

		[Constructable]
		public SnowmanMagentaEastAddonDeed()
		{
			Name = "SnowmanMagentaEast";
		}

		public SnowmanMagentaEastAddonDeed( Serial serial ) : base( serial )
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