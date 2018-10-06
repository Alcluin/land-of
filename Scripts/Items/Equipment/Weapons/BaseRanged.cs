#region Header
// **********
// ServUO - BaseRanged.cs
// **********
#endregion

#region References
using System;

using Server.Mobiles;
using Server.Network;
using Server.Spells;
#endregion

using Server.Targeting;

namespace Server.Items
{
	public abstract class BaseRanged : BaseMeleeWeapon
	{
		public static readonly TimeSpan PlayerFreezeDuration = TimeSpan.FromSeconds(3.0);
		public static readonly TimeSpan NPCFreezeDuration = TimeSpan.FromSeconds(6.0);
		
		public enum ArrowType
		{
			Normal = 0,
			Poison,
			Explosive,
			ArmorPiercing,
			Freeze,
			Lightning
		}
		
		private ArrowType m_ArrowType;
		
		[CommandProperty(AccessLevel.GameMaster)]
		public Type SpecialAmmoType { get; set; }
		
		public abstract int EffectID { get; }
		public abstract Type AmmoType { get; }
		public abstract Item Ammo { get; }

		public override int DefHitSound { get { return 0x234; } }
		public override int DefMissSound { get { return 0x238; } }

		public override SkillName DefSkill { get { return SkillName.Archery; } }
		public override WeaponType DefType { get { return WeaponType.Ranged; } }
		public override WeaponAnimation DefAnimation { get { return WeaponAnimation.ShootXBow; } }

		public override SkillName AccuracySkill { get { return SkillName.Archery; } }

		private Timer m_RecoveryTimer; // so we don't start too many timers
		private int m_Velocity;
		
		[CommandProperty(AccessLevel.GameMaster)]
		public ArrowType ArrowSelection
		{
			get { return m_ArrowType; }
			set 
			{ 
				m_ArrowType = value; 
				InvalidateProperties(); 
			}
		}

		[CommandProperty(AccessLevel.GameMaster)]
		public bool Balanced
		{
            get { return Attributes.BalancedWeapon > 0; }
			set
			{
                if (value)
                    Attributes.BalancedWeapon = 1;
                else
                    Attributes.BalancedWeapon = 0;
			}
		}

		[CommandProperty(AccessLevel.GameMaster)]
		public int Velocity
		{
			get { return m_Velocity; }
			set
			{
				m_Velocity = value;
				InvalidateProperties();
			}
		}

		public BaseRanged(int itemID)
			: base(itemID)
		{
			if ( SpecialAmmoType == null )
					{
						if( AmmoType == typeof(Bolt) )
							SpecialAmmoType = typeof(Bolt);
						else
							SpecialAmmoType = typeof(Arrow);
					}
		}

		public BaseRanged(Serial serial)
			: base(serial)
		{ }
		
		public override void OnDoubleClick(Mobile from)
		{
			if( this is BaseThrown )
				return;
			if (IsChildOf(from.Backpack) || Parent == from)
			{
				from.SendMessage("Please choose which type of arrows you wish to use.");
				from.Target = new InternalTarget(this);
			}
			
			else
				return;
		}

		public override TimeSpan OnSwing(Mobile attacker, IDamageable damageable)
		{
			// Make sure we've been standing still for .25/.5/1 second depending on Era
			if (Core.TickCount - attacker.LastMoveTime >= (Core.SE ? 250 : Core.AOS ? 500 : 1000) ||
				(Core.AOS && WeaponAbility.GetCurrentAbility(attacker) is MovingShot))
			{
				bool canSwing = true;

				if (Core.AOS)
				{
					canSwing = (!attacker.Paralyzed && !attacker.Frozen);

					if (canSwing)
					{
						Spell sp = attacker.Spell as Spell;

						canSwing = (sp == null || !sp.IsCasting || !sp.BlocksMovement);
					}
				}

				#region Dueling
				if (attacker is PlayerMobile)
				{
					PlayerMobile pm = (PlayerMobile)attacker;

					if (pm.DuelContext != null && !pm.DuelContext.CheckItemEquip(attacker, this))
					{
						canSwing = false;
					}
				}
				#endregion

				if (canSwing && attacker.HarmfulCheck(damageable))
				{
					attacker.DisruptiveAction();
					attacker.Send(new Swing(0, attacker, damageable));

					if (OnFired(attacker, damageable))
					{
                        if (CheckHit(attacker, damageable))
						{
                            OnHit(attacker, damageable);
						}
						else
						{
                            OnMiss(attacker, damageable);
						}
					}
				}

				attacker.RevealingAction();

				return GetDelay(attacker);
			}
			
			attacker.RevealingAction();

			return TimeSpan.FromSeconds(0.25);
		}

		public override void OnHit(Mobile attacker, IDamageable damageable, double damageBonus)
		{
			if( !(this is BaseThrown) )
			{
				if (  m_ArrowType != null && attacker.Player && damageable is Mobile && !((Mobile)damageable).Player && (((Mobile)damageable).Body.IsAnimal || ((Mobile)damageable).Body.IsMonster) &&
					0.4 >= Utility.RandomDouble())
				{
					((Mobile)damageable).AddToBackpack(Ammo);
				}
			}
			
			if (Core.ML && m_Velocity > 0)
			{
                int bonus = (int)attacker.GetDistanceToSqrt(damageable);

				if (bonus > 0 && m_Velocity > Utility.Random(100))
				{
                    AOS.Damage(damageable, attacker, bonus * 3, 100, 0, 0, 0, 0);

					if (attacker.Player)
					{
						attacker.SendLocalizedMessage(1072794); // Your arrow hits its mark with velocity!
					}

                    if (damageable is Mobile && ((Mobile)damageable).Player)
					{
						((Mobile)damageable).SendLocalizedMessage(1072795); // You have been hit by an arrow with velocity!
					}
				}
			}
			
			if( ArrowSelection > 0 )
				OnHitNewAmmo( attacker, damageable, damageBonus );

			base.OnHit(attacker, damageable, damageBonus);
		}
		
		public void OnHitNewAmmo(Mobile attacker, IDamageable damageable, double damageBonus)
		{
			Mobile defender = (Mobile)damageable;
			
			int randomizer = 0; 
			
			if (SpecialAmmoType == typeof( PoisonArrow ) || SpecialAmmoType == typeof( PoisonBolt ) )
			{
				defender.FixedParticles(0x3728, 200, 25, 69, EffectLayer.Waist);
				
				switch (Utility.Random(4))
				{
					case 0: defender.ApplyPoison(defender, Poison.Deadly); break;
					case 1: defender.ApplyPoison(defender, Poison.Greater); break;
					case 2: defender.ApplyPoison(defender, Poison.Regular); break;
					case 3: defender.ApplyPoison(defender, Poison.Lesser); break;
				}
				
				 
			}
			
			else if (SpecialAmmoType == typeof( ExplosiveArrow ) || SpecialAmmoType == typeof( ExplosiveBolt ) )
			{
				defender.FixedParticles(0x36BD, 20, 10, 5044, EffectLayer.Waist);
				defender.PlaySound(0x307);
				attacker.DoHarmful(defender);
				
				switch (Utility.Random(3))
				{
					case 0: randomizer = Utility.RandomMinMax(10, 50); break;
					case 1: randomizer = Utility.RandomMinMax(30, 70); break;
					case 2: randomizer = Utility.RandomMinMax(50, 100); break;
				}
				
				AOS.Damage(defender, attacker, randomizer, 0, 100, 0, 0, 0);
				
			}
			
			else if ( SpecialAmmoType == typeof( ArmorPiercingArrow ) || SpecialAmmoType == typeof( ArmorPiercingBolt ) )
			{
				defender.PlaySound(0x56);
				defender.FixedParticles(0x3728, 200, 25, 9942, EffectLayer.Waist);
				attacker.DoHarmful(defender);
				
				switch (Utility.Random(3))
				{
					case 0: randomizer = Utility.RandomMinMax(10, 50); break;
					case 1: randomizer = Utility.RandomMinMax(30, 70); break;
					case 2: randomizer = Utility.RandomMinMax(50, 100); break;
				}
				
				AOS.Damage(defender, attacker, randomizer, 100, 0, 0, 0, 0); 
			}
			
			else if ( SpecialAmmoType == typeof( FreezeArrow ) || SpecialAmmoType == typeof( FreezeBolt ) )
			{
				defender.PlaySound(0x204);
				defender.Freeze(defender.Player ? PlayerFreezeDuration : NPCFreezeDuration);
				defender.FixedEffect(0x376A, 9, 32);
				attacker.DoHarmful(defender);
						
				switch (Utility.Random(3))
				{
					case 0: randomizer = Utility.RandomMinMax(10, 50); break;
					case 1: randomizer = Utility.RandomMinMax(30, 70); break;
					case 2: randomizer = Utility.RandomMinMax(50, 100); break;
				}
				
				AOS.Damage(defender, attacker, randomizer, 0, 0, 100, 0, 0); 
			}
			
			else if ( SpecialAmmoType == typeof( LightningArrowAmmo ) || SpecialAmmoType == typeof( LightningBolt ) )
			{
				defender.PlaySound(1471);
				defender.BoltEffect(0);
				attacker.DoHarmful(defender);
						
				switch (Utility.Random(3))
				{
					case 0: randomizer = Utility.RandomMinMax(10, 50); break;
					case 1: randomizer = Utility.RandomMinMax(30, 70); break;
					case 2: randomizer = Utility.RandomMinMax(50, 100); break;
				}
				
				AOS.Damage(defender, attacker, randomizer, 100, 0, 0, 0, 0); 
			}
		
		
		}

        public override void OnMiss(Mobile attacker, IDamageable damageable)
		{
			if (attacker.Player && 0.4 >= Utility.RandomDouble())
			{
				if (Core.SE)
				{
					PlayerMobile p = attacker as PlayerMobile;

					if (p != null && m_ArrowType != null)
					{
						ArrowType ammo = m_ArrowType;
						Type ammotype = SpecialAmmoType;

						if (p.RecoverableAmmo.ContainsKey(ammotype))
						{
							p.RecoverableAmmo[ammotype]++;
						}
						else
						{
							p.RecoverableAmmo.Add(ammotype, 1);
						}

						if (!p.Warmode)
						{
							if (m_RecoveryTimer == null)
							{
								m_RecoveryTimer = Timer.DelayCall(TimeSpan.FromSeconds(10), p.RecoverAmmo);
							}

							if (!m_RecoveryTimer.Running)
							{
								m_RecoveryTimer.Start();
							}
						}
					}
				}
				else
				{
                    Point3D loc = damageable.Location;

					Ammo.MoveToWorld(
                        new Point3D(loc.X + Utility.RandomMinMax(-1, 1), loc.Y + Utility.RandomMinMax(-1, 1), loc.Z),
						damageable.Map);
				}
			}

			base.OnMiss(attacker, damageable);
		}

        public virtual bool OnFired(Mobile attacker, IDamageable damageable)
		{
			WeaponAbility ability = WeaponAbility.GetCurrentAbility(attacker);
			
			//Type type = (Color)Enum.Parse(typeof(Enumeration.ArrowType), m_ArrowType);
			
			// Respect special moves that use no ammo
			if (ability != null && ability.ConsumeAmmo == false)
			{
				return true;
			}

			if (attacker.Player)
			{
				BaseQuiver quiver = attacker.FindItemOnLayer(Layer.Cloak) as BaseQuiver;
				Container pack = attacker.Backpack;

                int lowerAmmo = AosAttributes.GetValue(attacker, AosAttribute.LowerAmmoCost);

                if (quiver == null || Utility.Random(100) >= lowerAmmo)
				{
					
					if (quiver != null && quiver.ConsumeTotal(SpecialAmmoType, 1))
					{
						//attacker.SendMessage("1");
						quiver.InvalidateWeight();
					}
					//else if (pack == null || !pack.ConsumeTotal(m_ArrowType, 1))
			/* UNIVERSAL STORAGE KEY BEGIN */ 
					
					else if (pack == null || !pack.ConsumeTotal(SpecialAmmoType, 1) && !BaseStoreKey.Consume(pack, SpecialAmmoType, 1) )
					{
						//attacker.SendMessage("2");
						return false;
					}
					
					
				}
				// if( ArrowSelection > 0 & (pack == null || pack.FindItemByType(SpecialAmmoType) == null) )
				// {
					// return false;
				// }
				else if ( quiver.FindItemByType(SpecialAmmoType) == null && (pack == null || pack.FindItemByType(SpecialAmmoType) == null))
				{
					// lower ammo cost should not work when we have no ammo at all
					//attacker.SendMessage("4");
					return false;
				}
				// else if( SpecialAmmoType != null && quiver.FindItemByType(SpecialAmmoType) == null && (pack == null || pack.FindItemByType(SpecialAmmoType) == null) )
				// {
					// return false;
				// }
			}

			attacker.MovingEffect(damageable, EffectID, 18, 1, false, false);
			

			return true;
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			writer.Write(5); // version

			writer.WriteEncodedInt((int)m_ArrowType);
			
			writer.Write(m_Velocity);
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			int version = reader.ReadInt();

			switch (version)
			{
				case 5: 
						m_ArrowType = (ArrowType)reader.ReadEncodedInt();
						goto case 4;
                case 4:
				case 3:
					{
                        if (version == 3 && reader.ReadBool())
                            Attributes.BalancedWeapon = 1;

						m_Velocity = reader.ReadInt();

						goto case 2;
					}
				case 2:
				case 1:
					{
						break;
					}
				case 0:
					{
						/*m_EffectID =*/
						reader.ReadInt();
						break;
					}
			}

			if (version < 2)
			{
				WeaponAttributes.MageWeapon = 0;
				WeaponAttributes.UseBestSkill = 0;
			}
			
					if ( ArrowSelection == ArrowType.Normal )
					{
						if( AmmoType == typeof(Bolt) )
							SpecialAmmoType = typeof(Bolt);
						else
							SpecialAmmoType = typeof(Arrow);
					}
					if( ArrowSelection == ArrowType.Poison )
					{
						if( AmmoType == typeof(Bolt) )
							SpecialAmmoType = typeof(PoisonBolt);
						else
							SpecialAmmoType = typeof(PoisonArrow);
					}
					
					else if (ArrowSelection == ArrowType.Explosive )
					{
						if( AmmoType == typeof(Bolt) )
							SpecialAmmoType = typeof(ExplosiveBolt);
						else
							SpecialAmmoType = typeof(ExplosiveArrow);
						
					}
				
					else if (ArrowSelection == ArrowType.ArmorPiercing )
					{
						if( AmmoType == typeof(Bolt) )
							SpecialAmmoType = typeof(ArmorPiercingBolt);
						else
							SpecialAmmoType = typeof(ArmorPiercingArrow);
					}
				
					else if (ArrowSelection == ArrowType.Freeze )
					{
						if( AmmoType == typeof(Bolt) )
							SpecialAmmoType = typeof(FreezeBolt);
						else
							SpecialAmmoType = typeof(FreezeArrow);
					}
					
					else if (ArrowSelection == ArrowType.Lightning )
					{
						if( AmmoType == typeof(Bolt) )
							SpecialAmmoType = typeof(LightningBolt);
						else
							SpecialAmmoType = typeof(LightningArrowAmmo);
					}
					
		}
		
		private class InternalTarget : Target
		{
			private BaseRanged it_Bow;
			
			public InternalTarget(BaseRanged bow) : base(1, false, TargetFlags.None)
			{
				it_Bow = bow;
			}
			
			protected override void OnTarget(Mobile from, object targeted)
			{
				if (targeted is Item)
				{
					Item item = (Item)targeted;
					
					if (item.GetType() == typeof(Arrow))
					{
						it_Bow.ArrowSelection = ArrowType.Normal;
						it_Bow.SpecialAmmoType = typeof(Arrow);
					}
					if (item.GetType() == typeof(Bolt))
					{
						it_Bow.ArrowSelection = ArrowType.Normal;
						it_Bow.SpecialAmmoType = typeof(Bolt);
					}
					else if (item.GetType() == typeof(PoisonArrow) )
					{
						it_Bow.ArrowSelection = ArrowType.Poison;
						it_Bow.SpecialAmmoType = typeof(PoisonArrow);
					}
					else if (item.GetType() == typeof(PoisonBolt) )
					{
						it_Bow.ArrowSelection = ArrowType.Poison;
						it_Bow.SpecialAmmoType = typeof(PoisonBolt);
					}
					else if (item.GetType() == typeof(ExplosiveArrow) )
					{
						it_Bow.ArrowSelection = ArrowType.Explosive;
						it_Bow.SpecialAmmoType = typeof(ExplosiveArrow);
					}
					else if (item.GetType() == typeof(ExplosiveBolt) )
					{
						it_Bow.ArrowSelection = ArrowType.Explosive;
						it_Bow.SpecialAmmoType = typeof(ExplosiveBolt);
					}
					else if (item.GetType() == typeof(ArmorPiercingArrow) )
					{
						it_Bow.ArrowSelection = ArrowType.ArmorPiercing;
						it_Bow.SpecialAmmoType = typeof(ArmorPiercingArrow);
					}
					else if (item.GetType() == typeof(ArmorPiercingBolt) )
					{
						it_Bow.ArrowSelection = ArrowType.ArmorPiercing;
						it_Bow.SpecialAmmoType = typeof(ArmorPiercingBolt);
					}
					else if (item.GetType() == typeof(FreezeArrow) )
					{
						it_Bow.ArrowSelection = ArrowType.Freeze;
						it_Bow.SpecialAmmoType = typeof(FreezeArrow);
					}
					else if (item.GetType() == typeof(FreezeBolt) )
					{
						it_Bow.ArrowSelection = ArrowType.Freeze;
						it_Bow.SpecialAmmoType = typeof(FreezeBolt);
					}
					else if (item.GetType() == typeof(LightningArrowAmmo) )
					{
						it_Bow.ArrowSelection = ArrowType.Lightning;
						it_Bow.SpecialAmmoType = typeof(LightningArrowAmmo);
					}
					else if (item.GetType() == typeof(LightningBolt) )
					{
						it_Bow.ArrowSelection = ArrowType.Lightning;
						it_Bow.SpecialAmmoType = typeof(LightningBolt);
					}
					
					else
						from.SendMessage("Must select an Arrow Type");
					
				}
				else
					from.SendMessage("Can Only Target Arrow Items");
			}
		}
	}
}