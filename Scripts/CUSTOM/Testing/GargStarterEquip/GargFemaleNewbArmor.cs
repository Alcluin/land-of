using System; 
using Server; 
using Server.Items;

namespace Server.Items
{ 
   public class GargNewbieArmorFemale : Bag 
   { 
		[Constructable] 
		public GargNewbieArmorFemale() : this( 1 ) 
		{ 
			Movable = true;  
			Name = "A Bag Of Gargoyle Female Newbie Armor";
			Hue = 1910;
		}
		[Constructable]
		public GargNewbieArmorFemale( int amount )
		{
			DropItem( new NewbieHat() );
			DropItem( new ApprenticeFemaleGargoyleLegs() );
			DropItem( new ApprenticeFemaleGargoyleChest());
			DropItem( new ApprenticeFemaleGargoyleSleeves() );
			DropItem( new ApprenticeGargoyleWingArmor());
			DropItem( new ApprenticeFemaleGargoyleKilt());
			DropItem( new ApprenticeGargoyleHalfApron());
			DropItem( new ApprenticeGargoyleRing());
			DropItem( new ApprenticeGargoyleBracelet());
			DropItem( new ApprenticeGargoyleEarrings());
			DropItem( new ApprenticeGargoyleSword());
			DropItem(new ApprenticeGargoyleShield());
			DropItem( new GroveSandals() );
		}

      public GargNewbieArmorFemale( Serial serial ) : base( serial ) 
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
