using UnityEngine;

public class JumpEffect : MonoBehaviour
{
    public ParticleSystem jumpParticles;
    //public AudioSource jumpSound;

    void OnEnable()
    {
        GameEvents.OnPlayerJumped += PlayJumpEffect;
    }

    void OnDisable()
    {
        GameEvents.OnPlayerJumped -= PlayJumpEffect;
    }

    void PlayJumpEffect()
    {
        jumpParticles?.Play();
        //jumpSound?.Play();
    }
}
