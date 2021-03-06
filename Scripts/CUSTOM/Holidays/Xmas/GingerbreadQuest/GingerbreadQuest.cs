//Created by Milva
//////////////////////////////////////////////////////////////////////
// Automatically generated by Bradley's GumpStudio and roadmaster's 
// exporter.dll,  Special thanks goes to Daegon whose work the exporter
// was based off of, and Shadow wolf for his Template Idea.
//////////////////////////////////////////////////////////////////////
#define RunUo2_0

using System;
using Server;
using Server.Gumps;
using Server.Network;
using Server.Commands;

namespace Server.Gumps
{
    public class Gingerbreadquestgump : Gump
    {
        public static void Initialize()
        {
            CommandSystem.Register("Gingerbreadquestgump", AccessLevel.GameMaster, new CommandEventHandler(Gingerbreadquestgump_OnCommand));
		} 
		
		private static void Gingerbreadquestgump_OnCommand( CommandEventArgs e ) 
		{ 
			e.Mobile.SendGump( new Gingerbreadquestgump( e.Mobile ) ); 
		}

        public Gingerbreadquestgump(Mobile owner)
            : base(50, 50) 
		{
            this.Closable=true;
			this.Disposable=true;
			this.Dragable=true;
			this.Resizable=false;

			AddImageTiled(14, 10, 377, 433, 2524);
			AddImageTiled(9, 6, 388, 13, 1143);
			AddImageTiled(9, 433, 384, 11, 1143);
			AddImage(389, 191, 3003, 1152);
			AddImage(13, 19, 5057, 173);
			AddImage(389, 17, 3003, 1152);
			AddTextEntry(112, 40, 166, 20, 33, 0, @"   Gingerbread Quest!");
			AddButton(163, 385, 247, 248, 0, GumpButtonType.Reply, 0);
			AddImage(108, 29, 96);
			AddImage(104, 420, 96);
			AddItem(313, 30, 11225);
			AddItem(43, 38, 11228);
            AddHtml(59, 85, 302, 284, "<BODY>" +	
"<BASEFONT COLOR=Red>There is so much to do with baking Christmas desserts!<BR><BR>" +
"<BASEFONT COLOR=Red>Here I was very busy mixing and reading recipes<BR><BR>" +
"<BASEFONT COLOR=Red>I never noticed the Gingerbread Thief came in!<BR>" +
"<BASEFONT COLOR=Red>And ran off with all my Gingerbread Dough!!<BR>" +
"<BASEFONT COLOR=Red>This dough is really needed so that I might..<BR><BR>" +
"<BASEFONT COLOR=Red>Finish up the Gingerbread cookies today.<BR><BR>" +
"<BASEFONT COLOR=Red>Please if you can go find this Gingerbread Thief ...<BR><BR>" +
"<BASEFONT COLOR=Red>And bring me back my dough, I will reward you with my special gift!.<BR><BR>" +
"<BASEFONT COLOR=Red>My Collector one of a kind gift!.<BR><BR>" +
"<BASEFONT COLOR=Red>He will be running around the island here some where! !<BR><BR>" +
                             "</BODY>", false, true);

			
            AddImage(13, 119, 5057, 173);
            AddImage(25, 37, 2701, 152);
			AddImage(106, 70, 96 );
			AddItem(0, 114, 11233);
			AddItem(-2, 368, 11233);
			AddItem(1, 236, 11233);
            AddButton(163, 385, 247, 248, 0, GumpButtonType.Reply, 0);

        }
       

        public override void OnResponse(NetState sender, RelayInfo info)
        {
            Mobile from = sender.Mobile;

            switch(info.ButtonID)
            {
                case 0:
				{
					break;
				}

            }
        }
    }
}