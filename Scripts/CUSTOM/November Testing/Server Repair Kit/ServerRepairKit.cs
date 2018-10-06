/* Created by Hammerhand*/
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class ServerRepairKit : WoodenBox
	{
		public override string DefaultName
		{
			get { return "a Server Repair Kit"; }
		}

		[Constructable]
		public ServerRepairKit() : this (1)
		{
			Movable = true;
			Hue = 2965;
		}

		[Constructable]
		public ServerRepairKit( int amount )
		{
			DropItem(new DuctTape());
            DropItem(new SuperGlue());
            DropItem(new BalingWire());
            DropItem(new BugSpray());
		}

        public ServerRepairKit(Serial serial)
            : base(serial)
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}