using UnityEngine;

public class GameManager : MonoBehaviour
{
    public DeckManager deckManager;

    private int round = 1;
    private int currentScore = 0;
    private int targetScore = 50;

    void Start()
    {
        deckManager.InitializeDeck();
        StartRound();
    }

    void StartRound()
    {
        Debug.Log($"Starting Round {round}");
        // Draw, play hand, score, upgrade
    }

    public void EndRound()
    {
        if (currentScore >= targetScore)
        {
            round++;
            targetScore += 50;
            // Let player pick upgrade
        }
        else
        {
            // Game Over
        }
    }
}
