using System;
using Server.Gumps;
using Server.Network;
using Server.Mobiles;
using Server.Items;
using System.Collections.Generic;
using System.Linq;

namespace Server.Engines.BulkOrders
{
    public class LargeBODGump : Gump
    {
        private readonly LargeBOD m_Deed;
        private readonly Mobile m_From;
        public LargeBODGump(Mobile from, LargeBOD deed)
            : base(25, 25)
        {
            this.m_From = from;
            this.m_Deed = deed;

            this.m_From.CloseGump(typeof(LargeBODGump));
            this.m_From.CloseGump(typeof(SmallBODGump));

            LargeBulkEntry[] entries = deed.Entries;

            this.AddPage(0);

            int height = 0;

            if (BulkOrderSystem.NewSystemEnabled)
            {
                if (deed.RequireExceptional || deed.Material != BulkMaterialType.None)
                    height += 24;

                if (deed.RequireExceptional)
                    height += 24;

                if (deed.Material != BulkMaterialType.None)
                    height += 24;
            }

            this.AddBackground(50, 10, 455, 218 + height + (entries.Length * 24), 5054);

            this.AddImageTiled(58, 20, 438, 200 + height + (entries.Length * 24), 2624);
            this.AddAlphaRegion(58, 20, 438, 200 + height + (entries.Length * 24));

            this.AddImage(45, 5, 10460);
            this.AddImage(480, 5, 10460);
            this.AddImage(45, 203 + height + (entries.Length * 24), 10460);
            this.AddImage(480, 203 + height + (entries.Length * 24), 10460);

            this.AddHtmlLocalized(225, 25, 120, 20, 1045134, 0x7FFF, false, false); // A large bulk order

            this.AddHtmlLocalized(75, 48, 250, 20, 1045138, 0x7FFF, false, false); // Amount to make:
            this.AddLabel(275, 48, 1152, deed.AmountMax.ToString());

            this.AddHtmlLocalized(75, 72, 120, 20, 1045137, 0x7FFF, false, false); // Items requested:
            this.AddHtmlLocalized(275, 76, 200, 20, 1045153, 0x7FFF, false, false); // Amount finished:

            int y = 96;

            for (int i = 0; i < entries.Length; ++i)
            {
                LargeBulkEntry entry = entries[i];
                SmallBulkEntry details = entry.Details;

                this.AddHtmlLocalized(75, y, 210, 20, details.Number, 0x7FFF, false, false);
                this.AddLabel(275, y, 0x480, entry.Amount.ToString());

                y += 24;
            }

            if (deed.RequireExceptional || deed.Material != BulkMaterialType.None)
            {
                this.AddHtmlLocalized(75, y, 200, 20, 1045140, 0x7FFF, false, false); // Special requirements to meet:
                y += 24;
            }

            if (deed.RequireExceptional)
            {
                this.AddHtmlLocalized(75, y, 300, 20, 1045141, 0x7FFF, false, false); // All items must be exceptional.
                y += 24;
            }

            if (deed.Material != BulkMaterialType.None)
            {
                //this.AddHtmlLocalized(75, y, 300, 20, SmallBODGump.GetMaterialNumberFor(deed.Material), 0x7FFF, false, false); // All items must be made with x material.
				//daat99 OWLTR start - custom resources
                AddHtml(75, y, 400, 25, "<basefont color=#FF0000>All items must be crafted with " + GetMaterialStringFor(deed.Material), false, false);
            //daat99 OWLTR end - custom resources
                y += 24;
            }

            if (BulkOrderSystem.NewSystemEnabled)
            {
                BODContext c = BulkOrderSystem.GetContext((PlayerMobile)from);

                int points = 0;
                double banked = 0.0;

                BulkOrderSystem.ComputePoints(deed, out points, out banked);

                AddHtmlLocalized(75, y, 300, 20, 1157301, String.Format("{0}\t{1}", points, banked.ToString("0.000000")), 0x7FFF, false, false); // Worth ~1_POINTS~ turn in points and ~2_POINTS~ bank points.
                y += 24;

                AddButton(125, y, 4005, 4007, 3, GumpButtonType.Reply, 0);
                AddHtmlLocalized(160, y, 300, 20, c.PointsMode == PointsMode.Enabled ? 1157302 : c.PointsMode == PointsMode.Disabled ? 1157303 : 1157309, 0x7FFF, false, false); // Banking Points Enabled/Disabled/Automatic
                y += 24;

                AddButton(125, y, 4005, 4007, 2, GumpButtonType.Reply, 0);
                AddHtmlLocalized(160, y, 300, 20, 1045154, 0x7FFF, false, false); // Combine this deed with the item requested.
                y += 24;

                this.AddButton(125, y, 4005, 4007, 4, GumpButtonType.Reply, 0);
                this.AddHtmlLocalized(160, y, 300, 20, 1157304, 0x7FFF, false, false); // Combine this deed with contained items.
                y += 24;

                this.AddButton(125, y, 4005, 4007, 1, GumpButtonType.Reply, 0);
                this.AddHtmlLocalized(160, y, 120, 20, 1011441, 0x7FFF, false, false); // EXIT
            }
            else
            {
                this.AddButton(125, 168 + (entries.Length * 24), 4005, 4007, 2, GumpButtonType.Reply, 0);
                this.AddHtmlLocalized(160, 168 + (entries.Length * 24), 300, 20, 1045155, 0x7FFF, false, false); // Combine this deed with another deed.

                this.AddButton(125, 192 + (entries.Length * 24), 4005, 4007, 1, GumpButtonType.Reply, 0);
                this.AddHtmlLocalized(160, 192 + (entries.Length * 24), 120, 20, 1011441, 0x7FFF, false, false); // EXIT
            }
        }

        public override void OnResponse(NetState sender, RelayInfo info)
        {
            if (this.m_Deed.Deleted || !this.m_Deed.IsChildOf(this.m_From.Backpack))
                return;

            if (info.ButtonID == 2) // Combine
            {
                this.m_From.SendGump(new LargeBODGump(this.m_From, this.m_Deed));
                this.m_Deed.BeginCombine(this.m_From);
            }
            else if (info.ButtonID == 3) // bank button
            {
                BODContext c = BulkOrderSystem.GetContext(m_From);

                if (c != null)
                {
                    switch (c.PointsMode)
                    {
                        case PointsMode.Enabled: c.PointsMode = PointsMode.Disabled; break;
                        case PointsMode.Disabled: c.PointsMode = PointsMode.Automatic; break;
                        case PointsMode.Automatic: c.PointsMode = PointsMode.Enabled; break;
                    }
                }

                this.m_From.SendGump(new LargeBODGump(this.m_From, this.m_Deed));
            }
            else if (info.ButtonID == 4) // combine from container
            {
                m_From.BeginTarget(-1, false, Server.Targeting.TargetFlags.None, (m, targeted) =>
                {
                    if (!m_Deed.Deleted && targeted is Container)
                    {
                        List<SmallBOD> list = ((Container)targeted).Items.OfType<SmallBOD>().ToList();

                        foreach (SmallBOD item in list)
                        {
                            m_Deed.EndCombine(m_From, item);
                        }

                        list.Clear();
                    }
                });
            }
			//
			// NOT SURE HOW TO IMPLEMENT WITH NEWER SYSTEM YET ~ ZERODOWNED
			//
			/*
			 //daat99 OWLTR start - custom bods
            else if (info.ButtonID >= 3)
            {
                bool IsFound = false;
                IPooledEnumerable eable = m_From.GetMobilesInRange(6);
                foreach (Mobile vendor in eable)
                {
                    switch (info.ButtonID)
                    {
                        case 3: IsFound = (vendor is Blacksmith || vendor is Weaponsmith || vendor is Armorer); break;
                        case 4: IsFound = (vendor is Tailor || vendor is Weaver); break;
                        case 5: IsFound = (vendor is Carpenter); break;
                        case 6: IsFound = (vendor is Bowyer); break;
                    }
                    if (IsFound == true)
                        break;
                }
                if (IsFound == false)
                    switch (info.ButtonID)
                    {
                        case 3: m_From.SendMessage("You must be near a Blacksmith, Weaponsmith or Armorer to claim that."); break;
                        case 4: m_From.SendMessage("You must be near a Tailor or Weaver to claim that."); break;
                        case 5: m_From.SendMessage("You must be near a Carpenter to claim that."); break;
                        case 6: m_From.SendMessage("You must be near a Bowyer to claim that."); break;
                    }
                else
                    daat99.daat99.ClaimBods(m_From, m_Deed);

            }
            //daat99 OWLTR end - custom bods
			*/
        }
		
		//daat99 OWLTR start - custom resource
        public static string GetMaterialStringFor(BulkMaterialType material)
        {
            string result = "UNKNOWN";
            switch ((int)material)
            {
                case 1: result = "dull copper ingots"; break;
                case 2: result = "shadow iron ingots"; break;
                case 3: result = "copper ingots"; break;
                case 4: result = "bronze ingots"; break;
                case 5: result = "gold ingots"; break;
                case 6: result = "agapite ingots"; break;
                case 7: result = "verite ingots"; break;
                case 8: result = "valorite ingots"; break;
                case 9: result = "blaze ingots"; break;
                case 10: result = "ice ingots"; break;
                case 11: result = "toxic ingots"; break;
                case 12: result = "electrum ingots"; break;
                case 13: result = "platinum ingots"; break;
                case 14: result = "spined leather"; break;
                case 15: result = "horned leather"; break;
                case 16: result = "barbed leather"; break;
                case 17: result = "polar leather"; break;
                case 18: result = "synthetic leather"; break;
                case 19: result = "blaze leather"; break;
                case 20: result = "daemonic leather"; break;
                case 21: result = "shadow leather"; break;
                case 22: result = "frost leather"; break;
                case 23: result = "ethereal leather"; break;
                //	case 24: result = "regular wood"; break;
                case 24: result = "oak wood"; break;
                case 25: result = "ash wood"; break;
                case 26: result = "yew wood"; break;
                case 27: result = "heartwood wood"; break;
                case 28: result = "bloodwood wood"; break;
                case 29: result = "frostwood wood"; break;
                case 30: result = "ebony wood"; break;
                case 31: result = "bamboo wood"; break;
                case 32: result = "purpleheart wood"; break;
                case 33: result = "redwood wood"; break;
                case 34: result = "petrified wood"; break;
            }
            return result;
        }
        //daat99 OWLTR end - custom resource
		
    }
}