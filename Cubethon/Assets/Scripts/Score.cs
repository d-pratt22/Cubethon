using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    private int nextMilestone = 100;

    void Update()
    {
        int currentScore = Mathf.FloorToInt(player.position.z);
        scoreText.text = currentScore.ToString();

        if (currentScore >= nextMilestone)
        {
            GameEvents.RaiseScoreMilestoneReached();
            Debug.Log("Milestone reached: " + nextMilestone);
            nextMilestone += 100;
        }
    }
}
