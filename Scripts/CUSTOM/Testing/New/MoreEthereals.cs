using System;
using Server;

namespace Server.Mobiles
{
	public class EtherealPolarBear : EtherealMount
	{
		[Constructable]
		public EtherealPolarBear() : base( 0x20E1, 0x3EC5 )
		{
			Name = "Ethereal Polar Bear Statuette";
		}

		public EtherealPolarBear( Serial serial ) : base( serial )
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
 public class EtherealChimera : EtherealMount
	{
		[Constructable]
		public EtherealChimera() : base( 11669, 0x3E90 )
		{
			Name = "Ethereal Chimera Statuette";
			LootType = LootType.Blessed;
		}

		public EtherealChimera( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();

			if ( Name == "an ethereal chimera statuette" )
				Name = null;
		}
	}

 /*public class EtherealCuSidhe : EtherealMount
 {
     [Constructable]
     public EtherealCuSidhe() : base( 11670, 0x3E91 )
     {
         Name = "Ethereal Cu Sidhe Statuette";
         LootType = LootType.Blessed;
     }

     public EtherealCuSidhe( Serial serial ) : base( serial )
     {
     }

     public override void Serialize( GenericWriter writer )
     {
         base.Serialize( writer );
         writer.Write( (int) 0 );
     }

     public override void Deserialize( GenericReader reader )
     {
         base.Deserialize( reader );
         int version = reader.ReadInt();

         if ( Name == "an ethereal cu sidhe statuette" )
             Name = null;
     }
 }*/

 /*public class EtherealTiger : EtherealMount
	{
		[Constructable]
		public EtherealTiger() : base( 0x9844, 0x3EC8 )
		{
			Name = "Ethereal Tiger Statuette";
			LootType = LootType.Blessed;
		}

        public EtherealTiger(Serial serial)
            : base(serial)
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();

            if (Name == "an Ethereal Tiger statuette")
				Name = null;
		}
	} */

	public class EtherealHellsteed : EtherealMount
	{
		[Constructable]
		public EtherealHellsteed() : base( 0x2617, 0x3EBB )
		{
			Name = "Ethereal Hell Steed Statuette";
			LootType = LootType.Blessed;
		}

		public EtherealHellsteed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();

			if ( Name == "an ethereal hell steed statuette" )
				Name = null;
		}
	}

	public class EtherealArmoredSwampDragon : EtherealMount
	{
		[Constructable]
		public EtherealArmoredSwampDragon() : base( 0x2619, 0x3EBE )
		{
			Name = "Ethereal Armored Swamp Dragon Statuette";
			LootType = LootType.Blessed;
		}

		public EtherealArmoredSwampDragon( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();

			if ( Name == "an ethereal armored swamp dragon statuette" )
				Name = null;
		}
	}

	public class EtherealForestOstard : EtherealMount
	{
		[Constructable]
		public EtherealForestOstard() : base( 0x2137, 0x3EA5 )
		{
			Name = "Ethereal Forest Ostard Statuette";
			LootType = LootType.Blessed;
		}

		public EtherealForestOstard( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();

			if ( Name == "an ethereal forest ostard statuette" )
				Name = null;
		}
	}

	public class EtherealFrenziedOstard : EtherealMount
	{
		[Constructable]
		public EtherealFrenziedOstard() : base( 0x2136, 0x3EA4 )
		{
			Name = "Ethereal Frenzied Ostard Statuette";
			LootType = LootType.Blessed;
		}

		public EtherealFrenziedOstard( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();

			if ( Name == "an ethereal frenzied ostard statuette" )
				Name = null;
		}
	}

	public class EtherealSavageRidgeback : EtherealMount
	{
		[Constructable]
		public EtherealSavageRidgeback() : base( 0x2615, 0x3EB8 )
		{
			Name = "Ethereal Savage Ridgeback Statuette";
			LootType = LootType.Blessed;
		}

		public EtherealSavageRidgeback( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();

			if ( Name == "an ethereal savage ridgeback statuette" )
				Name = null;
		}
	}
 
        public class EtherealUndeadSteed : EtherealMount
	{

		[Constructable]
		public EtherealUndeadSteed() : base( 11669, 0x3E90 )
		{
			Name = "Ethereal Undead Steed Statuette";
			ItemID = 9680;
 			MountedID = 16059;
			RegularID = 9680;
			LootType = LootType.Blessed;
                }

		public EtherealUndeadSteed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();

			if ( Name != "Ethereal Undead Steed Statuette" )
				Name = "Ethereal Undead Steed Statuette";
		}
	}
        public class EtherealDemon : EtherealMount
	{

		[Constructable]
		public EtherealDemon() : base( 11670, 0x3E91 )
		{
			Name = "Ethereal Demon Statuette";
			ItemID = 8403;
			MountedID = 16239;
			RegularID = 8403;
			LootType = LootType.Blessed;
		}

		public EtherealDemon( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();

			if ( Name != "Ethereal Demon Statuette" )
				Name = "Ethereal Demon Statuette";
		}
	}
}
