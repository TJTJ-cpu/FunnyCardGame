using UnityEngine;

using System.Collections.Generic;
using UnityEngine;

public class DeckManager : MonoBehaviour
{
    public List<Card> deck = new List<Card>();

    public void InitializeDeck()
    {
        deck.Clear();
        foreach (Card.Suit suit in System.Enum.GetValues(typeof(Card.Suit)))
        {
            for (int value = 1; value <= 13; value++)
            {
                deck.Add(new Card(value, suit));
            }
        }

        ShuffleDeck();
    }

    public void ShuffleDeck()
    {
        for (int i = 0; i < deck.Count; i++)
        {
            int rand = Random.Range(i, deck.Count);
            Card temp = deck[i];
            deck[i] = deck[rand];
            deck[rand] = temp;
        }
    }

    public List<Card> DrawCards(int count)
    {
        List<Card> drawn = deck.GetRange(0, count);
        deck.RemoveRange(0, count);
        return drawn;
    }
}

