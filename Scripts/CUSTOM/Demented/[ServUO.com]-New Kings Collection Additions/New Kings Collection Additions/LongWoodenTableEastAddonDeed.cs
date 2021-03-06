
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
	public class LongWoodenTableEastAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {19667, 1, -1, 0}, {19666, 1, 0, 0}, {19668, 1, 1, 0}// 1	2	3	
			, {19670, 0, -1, 0}, {19671, 0, 0, 0}, {19669, 0, 1, 0}// 4	5	6	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new LongWoodenTableEastAddonDeed();
			}
		}

		[ Constructable ]
		public LongWoodenTableEastAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public LongWoodenTableEastAddon( Serial serial ) : base( serial )
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

	public class LongWoodenTableEastAddonDeed : BaseAddonDeed
	{
		public override int LabelNumber{ get{ return 1154167; } } //Long Wooden Table (East)
		public override BaseAddon Addon
		{
			get
			{
				return new LongWoodenTableEastAddon();
			}
		}

		[Constructable]
		public LongWoodenTableEastAddonDeed()
		{
			//Name = "Large Wooden Table(East)";
		}

		public LongWoodenTableEastAddonDeed( Serial serial ) : base( serial )
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