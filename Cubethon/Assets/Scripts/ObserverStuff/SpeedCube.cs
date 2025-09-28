using UnityEngine;

public class SpeedCube : MonoBehaviour
{
    public float speedBoost = 3f;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerController>().IncreaseSpeed(speedBoost);
            GameEvents.RaiseSpeedIncreased();
            Destroy(gameObject);
        }
    }
}
