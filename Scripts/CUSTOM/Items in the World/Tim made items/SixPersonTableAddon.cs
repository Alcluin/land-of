
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
	public class SixPersonTableAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {2907, 0, -1, 0}, {2909, 2, 0, 0}, {2909, 2, 1, 0}// 10	11	12	
			, {2906, -2, 0, 0}, {2906, -2, 1, 0}, {2907, -1, -1, 0}// 13	14	15	
			, {4609, 1, 2, 0}, {4611, 1, 1, 0}, {4610, 1, 0, 0}// 16	17	18	
			, {4609, 0, 2, 0}, {4611, 0, 1, 0}, {4610, 0, 0, 0}// 19	20	21	
			, {4609, -1, 2, 0}, {4611, -1, 1, 0}, {4610, -1, 0, 0}// 22	23	24	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new SixPersonTableAddonDeed();
			}
		}

		[ Constructable ]
		public SixPersonTableAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 2754, 1, 2, 6, 2041, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 2809, 0, 2, 6, 2041, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 2756, -1, 2, 6, 2041, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 2808, 1, 1, 6, 2041, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 2750, 0, 1, 6, 2041, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 2806, -1, 1, 6, 2041, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 2757, 1, 0, 6, 2041, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 2807, 0, 0, 6, 2041, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 2755, -1, 0, 6, 2041, -1, "", 1);// 9

		}

		public SixPersonTableAddon( Serial serial ) : base( serial )
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

	public class SixPersonTableAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new SixPersonTableAddon();
			}
		}

		[Constructable]
		public SixPersonTableAddonDeed()
		{
			Name = "SixPersonTable";
		}

		public SixPersonTableAddonDeed( Serial serial ) : base( serial )
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