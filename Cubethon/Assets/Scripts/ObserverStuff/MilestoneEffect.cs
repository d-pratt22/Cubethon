using UnityEngine;

public class MilestoneEffect : MonoBehaviour
{
    public ParticleSystem milestoneParticles;
    //public AudioSource milestoneSound;

    void OnEnable()
    {
        GameEvents.OnScoreMilestoneReached += PlayEffect;
    }

    void OnDisable()
    {
        GameEvents.OnScoreMilestoneReached -= PlayEffect;
    }

    void PlayEffect()
    {
        milestoneParticles?.Play();
        //milestoneSound?.Play();
    }
}
