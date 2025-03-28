using UnityEngine;

public class Card
{
    public enum Suit { 
        Hearts, 
        Diamonds,
        Clubs,
        Spades 
    }

    public int Value;
    public Suit CardSuit;

    public Card(int value, Suit suit) {
        Value = value;
        CardSuit = suit;

    }

    public override string ToString() {

        return $"{Value} of {CardSuit}";
    }
}

