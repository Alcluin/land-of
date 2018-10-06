//=================================================
//This script was created by Gizmo's Uo Quest Maker
//This script was created on 6/24/2017 11:04:54 AM
//=================================================
using System;
using Server;
using Server.Items;
using System.Collections.Generic;

namespace Server.Mobiles
{
	[CorpseName( "an Ancient Dragon of Archon corpse" )]
	public class AncientDragonofArchon : WhiteWyrm
	{
		[Constructable]
		public AncientDragonofArchon()
		{
			Name = "Ancient Dragon of Archon";
			SetStr( 1700, 2200 );
			SetDex( 800, 800 );
			SetInt( 250, 250 );

			SetHits( 10000, 10000 );
			SetStam( 430, 430 );
			SetMana( 800, 800 );

			SetSkill( SkillName.Magery, 100, 120 );
			SetSkill( SkillName.Wrestling, 80, 200 );
			SetSkill( SkillName.Healing, 80, 200 );
			SetSkill( SkillName.Tactics, 80, 200 );
			SetSkill( SkillName.Anatomy, 80, 200 );

			SetResistance( ResistanceType.Physical, 40, 65 );
			SetResistance( ResistanceType.Fire, 40, 65 );
			SetResistance( ResistanceType.Cold, 40, 65 );
			SetResistance( ResistanceType.Poison, 40, 76 );
			SetResistance( ResistanceType.Energy, 40, 65 );

			Fame = 30000;
			Karma = 20000;

			this.VirtualArmor = 60;

			this.Tamable = true;
			this.ControlSlots = 3;
			this.MinTameSkill = 104.7;

		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.UltraRich, 2 );
			AddLoot( LootPack.Gems, 10 );
			AddLoot( LootPack.HighScrolls, 5 );
		}

		public AncientDragonofArchon( Serial serial ) : base( serial )
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
		}

	}
}
