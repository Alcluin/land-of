
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
	public class WagonHauntedHouseAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {5794, -1, -3, 0}, {25, -2, -1, 10}, {3892, 0, 0, 7}// 1	2	3	
			, {2000, 1, -3, 6}, {5799, 1, -3, 0}, {4310, 1, 3, 9}// 4	5	6	
			, {1999, 0, 0, 6}, {24, -1, -4, 10}, {7570, 1, -1, 0}// 7	8	9	
			, {2000, -1, -1, 6}, {25, -2, -2, 7}, {2000, -1, -3, 6}// 10	11	12	
			, {1999, -1, 3, 6}, {2861, 0, 3, 7}, {2861, -1, 3, 7}// 13	14	15	
			, {25, 1, -2, 7}, {4150, -1, -2, 8}, {1999, 1, -2, 6}// 16	17	18	
			, {1999, 0, 3, 6}, {25, 1, 2, 7}, {4654, 0, -2, 8}// 19	20	21	
			, {3892, 1, -1, 7}, {1999, 1, 1, 6}, {25, 1, 0, 10}// 22	23	24	
			, {25, -2, -3, 10}, {25, -2, -2, 10}, {1998, 0, 1, 6}// 25	26	27	
			, {4311, -1, -3, 7}, {1999, 0, 2, 6}, {24, 0, -4, 7}// 28	29	30	
			, {3892, 1, -1, 7}, {1999, -1, 0, 6}, {7571, 0, 4, 0}// 31	32	33	
			, {7572, 2, -1, 0}, {25, -2, 0, 7}, {25, -2, 1, 7}// 34	35	36	
			, {3892, 1, 1, 7}, {4150, 0, -2, 7}, {25, -2, 1, 10}// 37	38	39	
			, {25, -2, 2, 10}, {25, -2, 0, 10}, {5741, 0, -3, 8}// 40	41	42	
			, {25, 1, 0, 7}, {25, 1, -1, 7}, {7570, 1, 3, 0}// 43	44	45	
			, {2000, -1, -2, 6}, {4151, 1, -2, 7}, {4150, -1, 2, 7}// 46	47	48	
			, {24, 1, 2, 7}, {24, 1, -4, 10}, {3892, 0, 2, 7}// 49	50	51	
			, {25, 1, 1, 10}, {1999, -1, 2, 6}, {24, 1, -4, 7}// 52	53	54	
			, {24, 1, 2, 10}, {24, 0, 2, 10}, {24, 0, -4, 10}// 55	56	57	
			, {25, 1, 2, 10}, {1999, 0, -3, 6}, {2000, 0, -1, 6}// 58	59	60	
			, {25, -2, -3, 7}, {24, -1, -4, 7}, {2000, 1, 2, 6}// 61	62	63	
			, {7574, -1, -1, 5}, {4151, -1, -1, 7}, {3892, 0, -3, 7}// 64	65	66	
			, {25, -2, 2, 7}, {1999, 1, -1, 6}, {25, 1, -2, 10}// 67	68	69	
			, {25, 1, -1, 10}, {4151, 0, 1, 7}, {3892, -1, 1, 7}// 70	71	72	
			, {25, 1, -3, 7}, {25, -2, -1, 7}, {2000, 1, 0, 6}// 73	74	75	
			, {5800, 1, 2, 0}, {4653, 0, 0, 8}, {10723, -1, 3, 0}// 76	77	78	
			, {24, -1, 2, 7}, {4651, -1, 1, 7}, {24, 0, 2, 7}// 79	80	81	
			, {2000, 0, -2, 6}, {25, 1, 1, 7}, {25, 1, -3, 10}// 82	83	84	
			, {3892, -1, -2, 7}, {5794, -1, 2, 0}, {2861, 1, 3, 7}// 85	86	87	
			, {1998, 1, 3, 6}, {24, -1, 2, 10}, {1999, -1, 1, 6}// 88	89	90	
			, {10723, -1, 5, 0}, {10723, -1, 4, 0}, {10722, 0, 3, 0}// 91	92	93	
			, {10722, -1, 3, 0}, {10723, 0, 3, 0}, {10723, -2, 3, 0}// 94	95	96	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new WagonHauntedHouseAddonDeed();
			}
		}

		[ Constructable ]
		public WagonHauntedHouseAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public WagonHauntedHouseAddon( Serial serial ) : base( serial )
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

	public class WagonHauntedHouseAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new WagonHauntedHouseAddon();
			}
		}

		[Constructable]
		public WagonHauntedHouseAddonDeed()
		{
			Name = "WagonHauntedHouse";
		}

		public WagonHauntedHouseAddonDeed( Serial serial ) : base( serial )
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