
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
	public class DisplayGreyPlankSouthAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1993, 1, 0, 10}, {1993, 0, 1, 5}, {1994, -1, 1, 5}// 1	2	3	
			, {1994, 0, 0, 10}, {1993, 1, 1, 5}, {1993, -1, 0, 10}// 4	5	6	
			, {1822, 1, 0, 5}, {1822, 0, 0, 5}, {1822, -1, 0, 5}// 7	8	9	
			, {1822, 1, 0, 0}, {1822, 0, 0, 0}, {1822, -1, 0, 0}// 10	11	12	
			, {1822, 1, 1, 0}, {1822, 0, 1, 0}, {1822, -1, 1, 0}// 13	14	15	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new DisplayGreyPlankSouthAddonDeed();
			}
		}

		[ Constructable ]
		public DisplayGreyPlankSouthAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public DisplayGreyPlankSouthAddon( Serial serial ) : base( serial )
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

	public class DisplayGreyPlankSouthAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new DisplayGreyPlankSouthAddon();
			}
		}

		[Constructable]
		public DisplayGreyPlankSouthAddonDeed()
		{
			Name = "DisplayGreyPlankSouth";
		}

		public DisplayGreyPlankSouthAddonDeed( Serial serial ) : base( serial )
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