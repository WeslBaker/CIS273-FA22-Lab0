using System;
namespace Uno
{
	public class Player
	{
        public string Name { get; set; }
        public List<Card> Hand { get; set; }
        public Player()
		{
            Name = "";
            Hand = new List<Card>();

        }

        public bool HasPlayableCard(Card card)
        {
            foreach(var handCard in Hand)
            {
                if (Card.PlaysOn(handCard, card))
                {
                    return true;
                }
            }
            return false;
        }

        public Card GetFirstPlayableCard(Card card)
        {
            foreach (var handCard in Hand)
            {
                if (Card.PlaysOn(handCard, card))
                {
                    return handCard;
                }
            }
            return null;
        }
        public Color MostCommonColor()
        {
            int numRed = 0;
            int numYellow = 0;
            int numBlue = 0;
            int numGreen = 0;

            foreach (var card in Hand)
            {
                if (card.Color == Color.Red)
                {
                    numRed++;
                }
                else if (card.Color == Color.Yellow)
                {
                    numGreen++;
                }
                else if (card.Color == Color.Blue)
                {
                    numYellow++;
                }
                else if (card.Color == Color.Green)
                {
                    numBlue++;
                }
            }
            if (numRed >= numYellow && numRed >= numBlue && numRed >= numGreen)
            {
                return Color.Red;
            }
            else if (numYellow >= numRed && numYellow >= numBlue && numYellow >= numGreen)
            {
                return Color.Yellow;
            }
            else if (numBlue >= numRed && numBlue >= numYellow && numBlue >= numGreen)
            {
                return Color.Blue;
            }
            else
            {
                return Color.Green;
            }
        }
    }
}

