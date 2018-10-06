using System; 
using Server; 
using Server.Items;

namespace Server.Items
{ 
   public class GargNewbieArmorMale : Bag 
   { 
		[Constructable] 
		public GargNewbieArmorMale() : this( 1 ) 
		{ 
			Movable = true;  
			Name = "A Bag Of Gargoyle Male Newbie Armor";
			Hue = 1910;
		}
		[Constructable]
		public GargNewbieArmorMale( int amount )
		{
			DropItem( new NewbieHat() );
			DropItem( new ApprenticeMaleGargoyleLegs() );
			DropItem( new ApprenticeMaleGargoyleChest());
			DropItem( new ApprenticeMaleGargoyleSleeves() );
			DropItem( new ApprenticeGargoyleWingArmor());
			DropItem( new ApprenticeMaleGargoyleKilt());
			DropItem( new ApprenticeGargoyleHalfApron());
			DropItem( new ApprenticeGargoyleRing());
			DropItem( new ApprenticeGargoyleBracelet());
			DropItem( new ApprenticeGargoyleEarrings());
			DropItem( new ApprenticeGargoyleSword());
			DropItem(new ApprenticeGargoyleShield());
			DropItem( new GroveSandals() );
		}

      public GargNewbieArmorMale( Serial serial ) : base( serial ) 
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
