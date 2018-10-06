using System;
 
namespace Server.Items
{
    public class Quatloo : BlankScroll
    {
        [Constructable]
        public Quatloo() : base()
        {
            this.Name = "Quatloo";
            this.Hue = 2044;
			LootType = LootType.Blessed;
		}
 
        public Quatloo( Serial serial ) : base( serial )
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
