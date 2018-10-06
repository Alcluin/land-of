
////////////////////////////////////////
//                                    //
//   Generated by CEO's YAAAG - V1.2  //
// (Yet Another Arya Addon Generator) //
//                                    //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class BBQSouthAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {5110, -3, 1, 8}, {5625, 1, 0, 9}, {5634, -1, 0, 11}// 5	6	7	
			, {5628, -2, 0, 9}, {5637, 2, 0, 8}, {2450, -3, 1, 7}// 8	9	10	
			, {2416, 1, 1, 14}, {4329, 2, 1, 7}, {2420, 1, 1, 6}// 11	12	13	
			, {1822, 0, 0, 1}, {1822, -1, 0, 1}, {1822, 0, 0, 6}// 14	15	16	
			, {1822, 0, 0, 1}, {5634, -1, 0, 11}, {1822, -1, 0, 6}// 17	18	19	
			, {1822, -1, 0, 1}, {1822, -1, 1, 0}, {1822, -3, 0, 3}// 20	21	22	
			, {2416, 1, 1, 14}, {2420, 1, 1, 6}, {1822, 1, 1, 0}// 23	24	25	
			, {4329, 2, 1, 7}, {1822, 2, 1, 0}, {1822, 2, 1, 2}// 26	27	28	
			, {5637, 2, 0, 8}, {1822, 2, 0, 0}, {1822, 2, 0, 3}// 29	30	31	
			, {5625, 1, 0, 9}, {1822, 1, 0, 4}, {5110, -3, 1, 8}// 32	33	34	
			, {2450, -3, 1, 7}, {1822, -3, 1, 0}, {1822, -3, 1, 2}// 35	36	37	
			, {1822, -2, 1, 0}, {5628, -2, 0, 9}, {1822, -2, 0, 4}// 38	39	40	
			, {6467, 0, 1, 4}, {1822, 0, 1, 0}, {1822, 0, 1, 2}// 41	42	43	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new BBQSouthAddonDeed();
			}
		}

		[ Constructable ]
		public BBQSouthAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 4846, -2, 1, 5, 0, 2, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 4846, -1, 1, 5, 0, 2, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 4846, 1, 1, 5, 0, 2, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 6580, 1, 1, 0, 0, 1, "", 1);// 44
			AddComplexComponent( (BaseAddon) this, 6580, -1, 1, 0, 0, 1, "", 1);// 45
			AddComplexComponent( (BaseAddon) this, 6580, -2, 1, 0, 0, 1, "", 1);// 46
			AddComplexComponent( (BaseAddon) this, 3530, -2, 1, 6, 1, -1, "Grill", 1);// 49
			AddComplexComponent( (BaseAddon) this, 3530, -1, 1, 6, 1, -1, "Grill", 1);// 50
			AddComplexComponent( (BaseAddon) this, 3530, 1, 1, 6, 1, -1, "Grill", 1);// 51
			AddComplexComponent( (BaseAddon) this, 7704, -2, 1, 7, 0, -1, "Grilled Salmon", 1);// 52
			AddComplexComponent( (BaseAddon) this, 7704, -1, 1, 7, 0, -1, "Grilled Salmon", 1);// 53
			AddComplexComponent( (BaseAddon) this, 7135, 3, 1, 1, 0, -1, "Mesquite Logs", 1);// 54
			AddComplexComponent( (BaseAddon) this, 2459, 0, 0, 11, 0, -1, "Cooking Wine", 1);// 55
			AddComplexComponent( (BaseAddon) this, 2518, -3, 0, 8, 0, -1, "Marinade", 1);// 56
			AddComplexComponent( (BaseAddon) this, 6467, 0, 1, 4, 0, -1, "Imported Spices", 1);// 57

		}

		public BBQSouthAddon( Serial serial ) : base( serial )
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

	public class BBQSouthAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new BBQSouthAddon();
			}
		}

		[Constructable]
		public BBQSouthAddonDeed()
		{
			Name = "BBQSouth";
		}

		public BBQSouthAddonDeed( Serial serial ) : base( serial )
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