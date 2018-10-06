using System;
using Server.Mobiles;

/*****************************
Items:

HotChocolate
HotChocolateM  // with Marshmallows
Coffee
*****************************/

namespace Server.Items
{
	public static class OnDrink
	{
	
		public static void SaySomething( Mobile from )
		{
			// case 0 counts as 1, so it you have case 0 thru 5, it would be total of 6 
			// if you add more cases but don't increase this number, those new cases will never happen
			switch ( Utility.Random( 3 ) ) 
			{
				case 0:
				{
					from.Say("Mmm...");
					break;
				}
				case 1: 
				{
					from.Say("Mmm yummy...");
					break;
				}
				case 2:
				{
					from.Say("Delicious!");
					break;
				}
			
			}
		
		}
	
	}
	
	public class HotChocolate : CeramicMug
    {
        public override int MaxQuantity{ get{ return 5; } } //How many times "sips"

        [Constructable]
        public HotChocolate() : base(BeverageType.HotChocolate)
        {
			Name = "a Mug of Hot Chocolate";
            this.Weight = 1.0;
        }

        public HotChocolate(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)1); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
	
	public class HotChocolateM : CeramicMug
    {
        public override int MaxQuantity{ get{ return 5; } } //How many times "sips"

        [Constructable]
        public HotChocolateM() : base(BeverageType.HotChocolateM)
        {
			Name = "a Mug of Hot Chocolate with Marshmallows";
            this.Weight = 1.0;
        }

        public HotChocolateM(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)1); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
	
	public class Coffee : CeramicMug
    {
        public override int MaxQuantity{ get{ return 5; } } //How many times "sips"

        [Constructable]
        public Coffee() : base(BeverageType.Coffee)
        {
			Name = "a Mug of Coffee";
            this.Weight = 1.0;
        }

        public Coffee(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)1); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
}