using System;

namespace Server.Items
{
	public class FreezeArrow : Arrow, ICommodity
	{
		public static readonly TimeSpan PlayerFreezeDuration = TimeSpan.FromSeconds( 3.0 ); 
		public static readonly TimeSpan NPCFreezeDuration = TimeSpan.FromSeconds( 6.0 );
		
		// string ICommodity.Description
		// {
			// get
			// {
				// return String.Format( Amount == 1 ? "{0} freezearrow" : "{0} freezearrows", Amount );
			// }
		// }
		
		int ICommodity.DescriptionNumber
        {
            get
            {
                return 3000487; // Freeze
            }
        }
        bool ICommodity.IsDeedable
        {
            get
            {
                return true;
            }
        }

		[Constructable]
		public FreezeArrow() : this( 1 )
		{
		}

		[Constructable]
		public FreezeArrow( int amount ) : base( 0xF3F )
		{
			Stackable = true;
			Name = "Freeze Arrow";
			Hue = 88;
			Weight = 0.1;
			Amount = amount;
		}

		public FreezeArrow( Serial serial ) : base( serial )
		{
		}

		// public override Item Dupe( int amount )
		// {
			// return base.Dupe( new FreezeArrow( amount ), amount );
		// }

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
