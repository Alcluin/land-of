/* Created by Hammerhand*/
using System;
using Server;

namespace Server.Items
{
	public class DuctTape : Item
	{
	
		[Constructable]
		public DuctTape() : base(0x1879 )
		{
            Name = "DuctTape";
            Hue = 1900;
            Movable = false;
			Weight = 1.0;						
		}

        public DuctTape(Serial serial)
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
    public class SuperGlue : Item
    {

        [Constructable]
        public SuperGlue() : base(0xFC0)
        {
            Name = "SuperGlue";
            Hue = 1159;
            Movable = false;
            Weight = 1.0;
        }

        public SuperGlue(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
    public class BalingWire : Item
    {

        [Constructable]
        public BalingWire() : base(0x1420)
        {
            Name = "BalingWire";
            Hue = 2315;
            Movable = false;
            Weight = 1.0;
        }

        public BalingWire(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
    public class BugSpray : Item
    {

        [Constructable]
        public BugSpray()
            : base(0x1837)
        {
            Name = "BugSpray";
            Movable = false;
            Weight = 1.0;
        }

        public BugSpray(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
}

