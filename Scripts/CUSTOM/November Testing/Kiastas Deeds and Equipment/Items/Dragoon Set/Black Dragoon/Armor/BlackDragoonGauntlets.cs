using System;
using Server;
using Server.Items;

namespace Server.Kiasta
{
	[FlipableAttribute( 0x2643, 0x2644 )]
	public class BlackDragoonGauntlets : BaseDragoonArmor
	{
		[Constructable]
		public BlackDragoonGauntlets() : base( 0x2643 )
        {
            Resource = CraftResource.BlackScales;
            Name = "Gauntlets "+Settings.DragoonEquipmentName.Suffix;
			Weight = 2.0;
		}

        public BlackDragoonGauntlets(Serial serial)
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