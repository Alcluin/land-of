
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
	public class GeneralCrookedTreeRedAddonAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {3279, 0, 0, 0}, {3277, 0, 0, 0}// 1	2	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new GeneralCrookedTreeRedAddonAddonDeed();
			}
		}

		[ Constructable ]
		public GeneralCrookedTreeRedAddonAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public GeneralCrookedTreeRedAddonAddon( Serial serial ) : base( serial )
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

	public class GeneralCrookedTreeRedAddonAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new GeneralCrookedTreeRedAddonAddon();
			}
		}

		[Constructable]
		public GeneralCrookedTreeRedAddonAddonDeed()
		{
			Name = "GeneralCrookedTreeRedAddon";
		}

		public GeneralCrookedTreeRedAddonAddonDeed( Serial serial ) : base( serial )
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