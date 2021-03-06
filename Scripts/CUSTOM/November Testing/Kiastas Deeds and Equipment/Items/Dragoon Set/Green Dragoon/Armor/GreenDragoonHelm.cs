using System;
using Server;
using Server.Items;

namespace Server.Kiasta
{
	[Flipable( 0x2645, 0x2646 )]
    public class GreenDragoonHelm : BaseDragoonArmor
	{
		[Constructable]
		public GreenDragoonHelm() : base( 0x2645 )
        {
            Resource = CraftResource.GreenScales;
            Name = "Helm "+Settings.DragoonEquipmentName.Suffix;
			Weight = 5.0;
		}

        public GreenDragoonHelm(Serial serial)
            : base(serial)
		{
		}
		
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}