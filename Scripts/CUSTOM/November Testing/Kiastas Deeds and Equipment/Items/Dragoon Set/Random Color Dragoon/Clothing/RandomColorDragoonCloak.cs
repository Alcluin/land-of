using System;
using Server;
using Server.Items;

namespace Server.Kiasta
{
	[Flipable]
	public class RandomColorDragoonCloak : BaseDragoonClothing
	{
		[Constructable]
		public RandomColorDragoonCloak() : this(0)
		{
		}
		[Constructable]
		public RandomColorDragoonCloak(int hue) : base(0x1515, Layer.Cloak)
		{
            Name = "Cloak "+Settings.DragoonEquipmentName.Suffix;
			Weight = 1.0;
		}
		public RandomColorDragoonCloak(Serial serial) : base(serial)
		{
		}
		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);
            writer.Write((int)0);
		}
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);
			int version = reader.ReadInt();

			if ( Weight == 4.0 )
				Weight = 3.0;
		}
	}
}