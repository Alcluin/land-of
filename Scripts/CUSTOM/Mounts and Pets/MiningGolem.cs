using System;
using System.Collections.Generic;
using Server.Items;
using Server.ContextMenus;
using Server.Engines.Harvest;
using Server.Regions;

using Server.Network;
using Server.Misc;
using Server.SkillHandlers;
using System.Collections;
using System.Collections.Generic;

namespace Server.Mobiles
{
    [CorpseName("a mining golem corpse")]
    public class MiningGolem : BaseCreature
    {
		private static Hashtable s_Keywords;
		
		enum Commands { None = 0, StartMining, StopMining }

		static MiningGolem()
		{
			string [] keyWords = { " ", "start mining", "stop mining" };

			s_Keywords = new Hashtable( keyWords.Length, StringComparer.OrdinalIgnoreCase );

			for ( int i = 0; i < keyWords.Length; ++i )
				s_Keywords[keyWords[i]] = i;
		}
		
		public override void OnSpeech( SpeechEventArgs e )
		{
			Mobile from = e.Mobile;

			if ( ControlMaster != from || IsDeadPet )
			{
				base.OnSpeech( e );
				return;
			}
			
			base.OnSpeech( e );

			object command = Commands.None;

			if ( e.Speech.Length > "all ".Length && e.Speech.Substring( 0, "all ".Length ).ToLower() == "all " )
				command = s_Keywords[ e.Speech.Substring( "all ".Length ) ];
			else if ( e.Speech.Length > Name.Length + 1 && e.Speech.Substring( 0, Name.Length + 1 ).ToLower() == Name.ToLower() + ' ' )
				command = s_Keywords[ e.Speech.Substring( Name.Length + 1 ) ];

			switch ( (command == null ? (int)Commands.None : (int)command) )
			{
				case (int)Commands.StartMining:
					//ControlOrder = OrderType.None;
					if (this.CheckControlChance(from))
									{
										this.ControlTarget = from;
										this.ControlOrder = OrderType.Follow;
										//FollowWhenMining();
									}
					m_MiningTimer = Timer.DelayCall(MiningInterval, MiningInterval, DoMining);
					Emote( String.Format("{0} starts mining", Name) );
					break;
				case (int)Commands.StopMining:
					m_MiningTimer.Stop();
					ControlOrder = OrderType.Stay;
					Emote( String.Format("{0} stops mining", Name) );
					break;
				// default:
					//m_MiningTimer.Stop();
					// if( m_MiningTimer != null && m_MiningTimer.Running )
					// {
						// m_MiningTimer.Stop();
						// Emote( String.Format("{0} stops mining", Name) );
					// }
					
					//return;
			}

			e.Handled = true;
		}
		
		
        [Constructable]
        public MiningGolem()
            : base(AIType.AI_Melee, FightMode.Closest, 10, 1, 0.25, 0.5)
        {
            this.Name = "a golem";
            this.Body = 752;
			
			double scalar = 1;
			
			this.SetStr((int)(251 * scalar), (int)(350 * scalar));
            this.SetDex((int)(76 * scalar), (int)(100 * scalar));
            this.SetInt((int)(101 * scalar), (int)(150 * scalar));

            this.SetHits((int)(151 * scalar), (int)(210 * scalar));

            this.SetDamage((int)(13 * scalar), (int)(24 * scalar));

            this.SetDamageType(ResistanceType.Physical, 100);

            this.SetResistance(ResistanceType.Physical, (int)(35 * scalar), (int)(55 * scalar));
			this.SetResistance(ResistanceType.Fire, (int)(100 * scalar));
			this.SetResistance(ResistanceType.Cold, (int)(10 * scalar), (int)(30 * scalar));
            this.SetResistance(ResistanceType.Poison, (int)(10 * scalar), (int)(25 * scalar));
            this.SetResistance(ResistanceType.Energy, (int)(30 * scalar), (int)(40 * scalar));

            this.SetSkill(SkillName.MagicResist, (150.1 * scalar), (190.0 * scalar));
            this.SetSkill(SkillName.Tactics, (60.1 * scalar), (100.0 * scalar));
            this.SetSkill(SkillName.Wrestling, (60.1 * scalar), (100.0 * scalar));
			
			this.SetSkill(SkillName.Mining, 150.0);

           // this.Skills.Mining.Cap = 120;

            this.Fame = 3500;
            this.Karma = -3500;

            this.Tamable = true;
            this.MinTameSkill = 71.1;
            this.ControlSlots = 3;

            this.VirtualArmor = 38;
			
			Container pack = this.Backpack;

            if (pack != null)
                pack.Delete();

            pack = new StrongBackpack();
            pack.Movable = false;

            this.AddItem(pack);

           // m_MiningTimer = Timer.DelayCall(MiningInterval, MiningInterval, DoMining);
        }
		
		public override bool OnDragDrop(Mobile from, Item item)
        {
            if (this.CheckFeed(from, item))
                return true;

            if (PackAnimal.CheckAccess(this, from))
            {
                this.AddToBackpack(item);
                return true;
            }

            return base.OnDragDrop(from, item);
        }

        public override bool CheckNonlocalDrop(Mobile from, Item item, Item target)
        {
            return PackAnimal.CheckAccess(this, from);
        }

        public override bool CheckNonlocalLift(Mobile from, Item item)
        {
            return PackAnimal.CheckAccess(this, from);
        }
		
		public override bool IsSnoop(Mobile from)
        {
            if (PackAnimal.CheckAccess(this, from))
                return false;

            return base.IsSnoop(from);
        }
		
		public override FoodType FavoriteFood
        {
            get
            {
                return FoodType.Metal;
            }
        }
		
		public override bool CanBeDistracted
        {
            get
            {
                return false;
            }
        }
		
		public override Poison PoisonImmune
        {
            get
            {
                return Poison.Lethal;
            }
        }
		
		 public override void OnDoubleClick(Mobile from)
        {
            PackAnimal.TryPackOpen(this, from);
        }

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
            AddLoot(LootPack.Gems);
        }

        public override void OnDeath(Container c)
        {
            base.OnDeath(c);

            if (Controlled)
                return;
		}

        public override bool SubdueBeforeTame { get { return true; } }
        public override bool StatLossAfterTame { get { return true; } }

        public override bool OverrideBondingReqs() { return true; }
        public override double GetControlChance(Mobile m, bool useBaseSkill) { return 1.0; }

        public override int GetAngerSound()
        {
            return 541;
        }

        public override int GetIdleSound()
        {
            if (!this.Controlled)
                return 542;

            return base.GetIdleSound();
        }

        public override int GetDeathSound()
        {
            if (!this.Controlled)
                return 545;

            return base.GetDeathSound();
        }

        public override int GetAttackSound()
        {
            return 562;
        }

        public override int GetHurtSound()
        {
            if (this.Controlled)
                return 320;

            return base.GetHurtSound();
        }

        #region Mining
        private static readonly TimeSpan MiningInterval = TimeSpan.FromSeconds(1.5); // 5.0

        private Timer m_MiningTimer;
		private DateTime m_NextOreEat;

        private void GetMiningOffset(Direction d, ref int x, ref int y)
        {
            switch (d & Direction.Mask)
            {
                case Direction.North: --y; break;
                case Direction.South: ++y; break;
                case Direction.West: --x; break;
                case Direction.East: ++x; break;
                case Direction.Right: ++x; --y; break;
                case Direction.Left: --x; ++y; break;
                case Direction.Down: ++x; ++y; break;
                case Direction.Up: --x; --y; break;
            }
        }

        public override void OnThink()
        {
            base.OnThink();

            if (Owners.Count > 0 || m_NextOreEat > DateTime.UtcNow)
                return;

           m_NextOreEat = DateTime.UtcNow + TimeSpan.FromSeconds(3.0);

            if (0.5 > Utility.RandomDouble())
            {
                foreach (Item item in Map.GetItemsInRange(Location, 1))
                {
                    if (item is BaseOre)
                    {
                       //Hue = item.Hue;

                      //  item.Delete();
						return;
                    }
                }
            }
		}

        public void DoMining()
        {
            if (Map == null || Map == Map.Internal)
                return;

            // We may not mine while we are fighting
            if (Combatant != null)
                return;
				
			if( this.Backpack.TotalWeight >= this.Backpack.MaxWeight )
			{
				Emote( String.Format("My backpack is full and cannot hold anymore!", Name) );
				
				if( m_MiningTimer != null && m_MiningTimer.Running )
				{
					m_MiningTimer.Stop();
					Emote( String.Format("{0} stops mining", Name) );
				}
			}

            HarvestSystem system = Mining.System;
            HarvestDefinition def = Mining.System.OreAndStone;

            // Our target is the land tile under us
            Map map = this.Map;
            Point3D loc = this.Location;
            int x = 0, y = 0;
            GetMiningOffset(this.Direction, ref x, ref y);
            loc.X += x;
            loc.Y += y;
            int tileId = map.Tiles.GetLandTile(loc.X, loc.Y).ID & ( 0x3FFF | 0x4000 );
			
			foreach ( StaticTile staticTile in this.GetStaticTilesInRange( map, 0 ) )
			{
				if ( (staticTile.ID >= 1339 && staticTile.ID >= 1359) || (staticTile.ID >= 1361 && staticTile.ID >= 1363) || 
					staticTile.ID ==1386 )
				{
					tileId = staticTile.ID;
				}
			}

            if (!def.Validate(tileId) && !def.ValidateSpecial(tileId))
                return;

            HarvestBank bank = def.GetBank(map, loc.X, loc.Y);
			
			bool available = (bank != null && bank.Current >= def.ConsumedPerHarvest);
			
			if (!available)
			{
				Emote( String.Format("There is no metal here to mine") );
				return;
			}

            if (bank == null || bank.Current < def.ConsumedPerHarvest)
                return;

            HarvestVein vein = bank.Vein;

            if (vein == null)
                return;

            HarvestResource primary = vein.PrimaryResource;
            HarvestResource fallback = def.Resources[0];

            HarvestResource resource = system.MutateResource(this, null, def, map, loc, vein, primary, fallback);

            double skillBase = this.Skills[def.Skill].Base;

            Type type = null;

            if (skillBase >= resource.ReqSkill && this.CheckSkill(def.Skill, resource.MinSkill, resource.MaxSkill))
            {
                type = system.GetResourceType(this, null, def, map, loc, resource);

                if (type != null)
                    type = system.MutateType(type, this, null, def, map, loc, resource);

                if (type != null)
                {
                    Item item = system.Construct(type, this, null);

                    if (item == null)
                    {
                        type = null;
                    }
                    else
                    {
                        if (item.Stackable)
                        {
                            int amount = def.ConsumedPerHarvest;
                            int feluccaAmount = def.ConsumedPerFeluccaHarvest;

                            bool inFelucca = (map == Map.Felucca);

                            if (inFelucca)
                                item.Amount = feluccaAmount;
                            else
                                item.Amount = amount;
                        }

                        bank.Consume(item.Amount, this);
						
						Container pack = this.Backpack;

						if (pack == null)
						{
							return;
						}
						
						this.Hue = item.Hue;
						
						pack.DropItem(item);
						
						if( item.ItemID == 6583 )
							item.Delete();
						else
							Smelt(item);

                       // item.MoveToWorld(loc, map);

                        system.DoHarvestingEffect(this, null, def, map, loc);
                        system.DoHarvestingSound(this, null, def, null);

                        // Mine for gems
                        BonusHarvestResource bonus = def.GetBonusResource();

                        if (bonus != null && bonus.Type != null && skillBase >= bonus.ReqSkill)
                        {
                            Item bonusItem = system.Construct(bonus.Type, this, null);

                            //item.MoveToWorld(loc, map);
							//pack.DropItem( bonusItem );
							pack.TryDropItem( this, bonusItem, false);
                        }
                    }
                }
            }
        }
		
		public void Smelt( Item ore )
		{
			         int toConsume = ore.Amount;

                        
                        if (toConsume >= 1)
                        {
                            if (toConsume > 30000)
                                toConsume = 30000;

                            int ingotAmount;

                            if (ore.ItemID == 0x19B7)
                            {
                                ingotAmount = toConsume / 2;

                                if (toConsume % 2 != 0)
                                    --toConsume;
                            }
                            else if (ore.ItemID == 0x19B9)
                            {
                                ingotAmount = toConsume * 2;
                            }
                            else
                            {
                                ingotAmount = toConsume;
                            }
							
							BaseOre baseOre = (BaseOre)ore;

                            BaseIngot ingot = baseOre.GetIngot();
                            ingot.Amount = ingotAmount;

                            baseOre.Consume(toConsume);
                            this.AddToBackpack(ingot);
                            //from.PlaySound( 0x57 );
						}
		
		}

        public override void GetContextMenuEntries(Mobile from, List<ContextMenuEntry> list)
        {
            base.GetContextMenuEntries(from, list);

            if (Controlled && ControlMaster == from)
            {
                PlayerMobile pm = from as PlayerMobile;

                if (pm == null)
                    return;

                ContextMenuEntry miningEntry = new ContextMenuEntry(pm.ToggleMiningStone ? 6179 : 6178);
                miningEntry.Color = 0x421F;
                list.Add(miningEntry);

                list.Add(new BaseHarvestTool.ToggleMiningStoneEntry(pm, false, false, 6176));
                list.Add(new BaseHarvestTool.ToggleMiningStoneEntry(pm, true, false, 6177));
            }
        }
        #endregion        

        public MiningGolem(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();

            //m_MiningTimer = Timer.DelayCall(MiningInterval, MiningInterval, DoMining);
        }
    }
}