using System;
using Server;

namespace Server.Items
{
	public class HessianSword : Longsword
	{
		public override int ArtifactRarity{ get{ return 13; } } 

		public override int AosStrengthReq{ get{ return 75; } }
		public override int AosSpeed{ get{ return 25; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public HessianSword() 
		{
			Weight = 8;
			Name = "Sword of the Hessian";
			Hue = 0x497;

			WeaponAttributes.HitFireball = 50;
			WeaponAttributes.HitFireArea = 40;
			WeaponAttributes.HitLowerAttack = 40;
			WeaponAttributes.HitLowerDefend = 50;
			WeaponAttributes.ResistFireBonus = 15;
			WeaponAttributes.ResistPhysicalBonus = 10;
			WeaponAttributes.SelfRepair = 5;

			Attributes.AttackChance = 20;
			Attributes.Luck = 100;
			Attributes.SpellChanneling = 1;
			Attributes.ReflectPhysical = 10;
			Attributes.WeaponDamage = 45;
			Attributes.WeaponSpeed = 25;
		}

		public HessianSword( Serial serial ) : base( serial )  
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