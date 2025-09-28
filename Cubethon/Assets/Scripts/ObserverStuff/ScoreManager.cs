using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    private int nextMilestone = 100;

    void Start()
    {
        UpdateUI();
        nextMilestone = 100;
    }

    public void AddScore(int amount)
    {
        score += amount;
        UpdateUI();

        if (score >= nextMilestone)
        {
            GameEvents.RaiseScoreMilestoneReached();
            nextMilestone += 100;
        }
    }

    void UpdateUI()
    {
        if (scoreText != null)
            scoreText.text = "Score: " + score;
    }
}
