﻿using System;
namespace Uno
{
	public enum CardType
	{
		Number,
		Wild,
		Draw2,
		WildDraw4,
		Skip,
		Reverse
	}

	public enum Color
	{
        Red, Yellow, Blue, Green, Wild
    }

	public class Card 
	{
		public CardType Type { get; set; }
		public Color Color { get; set; }
		public int? Number { get; set; }	

		public Card()
		{
		}

		public Card(CardType type, Color color, int? number=null)
		{
			Type = type;
			Color = color;
			Number = number;
		}

		// Does card1 play on card2
		public static bool PlaysOn(Card card1, Card card2)
		{
			if (card1.Type == CardType.Wild || card2.Type == CardType.Wild || card1.Type == CardType.WildDraw4 || card2.Type == CardType.WildDraw4 || card1.Color == card2.Color || (card1.Number == card2.Number && card1.Number != null))
			{
				return true;
			}
			else if((card1.Type == CardType.Reverse && card2.Type == CardType.Reverse) || (card1.Type == CardType.Skip && card2.Type == CardType.Skip) || (card1.Type == CardType.Draw2 && card2.Type == CardType.Draw2))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public override string ToString()
		{
			// Blue 4
			if (Type == CardType.Number)
			{
				return $"{Color} {Number}";
			}
			else if (Type == CardType.Wild)
			{
				return "Wild";
			}
			else if (Type == CardType.WildDraw4)
			{
				return Type.ToString();
			}
			else 
			{
				// Draw 2, Skip, Reverse
				return $"{Color} {Type}";
			}
		}

	}
}

