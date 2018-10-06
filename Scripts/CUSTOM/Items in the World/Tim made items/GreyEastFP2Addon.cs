
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
	public class GreyEastFP2Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1997, 0, -1, 14}, {1997, 0, 0, 14}, {1315, 1, -2, 4}// 7	8	9	
			, {3553, -1, 1, 4}, {3553, -1, 0, 0}, {3553, -1, -1, 0}// 10	11	12	
			, {2598, 0, -2, 15}, {2598, 0, 2, 15}, {1315, 1, -1, 4}// 13	14	15	
			, {1315, 1, 0, 4}, {1822, -1, -2, 9}, {1822, -1, -1, 9}// 16	17	18	
			, {1822, -1, 2, 4}, {1315, 1, 2, 4}, {1822, -1, 1, 4}// 19	20	22	
			, {1997, 0, 1, 14}, {1822, -1, 1, 9}, {1315, -1, -1, 4}// 23	24	25	
			, {1315, -1, 0, 4}, {1822, 0, -2, 4}, {1822, -1, 2, 9}// 26	27	28	
			, {1822, -1, 0, 14}, {1822, -1, -1, 14}, {1822, -1, -2, 14}// 29	30	31	
			, {1822, -1, 0, 9}, {1315, 1, 1, 4}, {1315, 0, 2, 4}// 32	33	35	
			, {1822, 0, 2, 9}, {1997, 0, 2, 14}, {1315, 0, -2, 4}// 36	37	38	
			, {1822, -1, -1, 4}, {1822, 0, -2, 9}, {1822, -1, 2, 14}// 39	40	41	
			, {1315, -1, 2, 4}, {1822, -1, 1, 14}, {1315, -1, 1, 4}// 42	43	44	
			, {1822, 0, 2, 4}, {1315, -1, -2, 4}, {1822, -1, 0, 4}// 45	46	48	
			, {1822, -1, -2, 4}, {1997, 0, -2, 14}// 49	50	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new GreyEastFP2AddonDeed();
			}
		}

		[ Constructable ]
		public GreyEastFP2Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 3555, 0, -1, 4, 0, 29, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 3555, 0, -1, 7, 0, 29, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 3555, 0, 0, 4, 0, 29, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 3555, 0, 0, 7, 0, 29, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 3555, 0, 1, 4, 0, 29, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 3555, 0, 1, 7, 0, 29, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 1304, 0, 0, 4, 1140, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 1304, 0, -1, 4, 1140, -1, "", 1);// 34
			AddComplexComponent( (BaseAddon) this, 1302, 0, 1, 4, 1140, -1, "", 1);// 47

		}

		public GreyEastFP2Addon( Serial serial ) : base( serial )
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

	public class GreyEastFP2AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new GreyEastFP2Addon();
			}
		}

		[Constructable]
		public GreyEastFP2AddonDeed()
		{
			Name = "GreyEastFP2";
		}

		public GreyEastFP2AddonDeed( Serial serial ) : base( serial )
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