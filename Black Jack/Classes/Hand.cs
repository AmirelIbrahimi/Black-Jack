using Back_Jack;
using System;
using System.Collections.Generic;
using WindowsFormsApp1;

public class Hand
{
    // Kaarten in hand
    private List<Card> cards;

    // Totale score
    private int score;

    // Geeft aan of de hand gewonnen heeft
    private bool winner;

    // Geeft aan of de hand verloren heeft
    private bool loser;

    // Geeft aan of de hand blackjack is
    private bool blackjack;

    // Of de speler heeft gepast
    bool hasStood = false;

    // Constructor maakt een lege hand
    public Hand()
    {
        cards = new List<Card>();
        score = 0;
        winner = false;
        loser = false;
        blackjack = false;
    }

    // Speler trekt een kaart
    public void Hit(Card card)
    {
        cards.Add(card);
    }

    // Speler past
    public void Stand()
    {
        hasStood = true;
    }
}
