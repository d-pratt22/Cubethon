using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    public GameObject replayPromptUI;

    private InputHandler _inputHandler;
    private PlayerMovement _player;

    void Start()
    {
        _inputHandler = FindObjectOfType<InputHandler>();
        _player = FindObjectOfType<PlayerMovement>();
        replayPromptUI.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _inputHandler.StopRecording();

            replayPromptUI.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void OnReplayYes()
    {
        replayPromptUI.SetActive(false);
        Time.timeScale = 1f;
        _inputHandler.StartReplay();
        Debug.Log("Replay Yes clicked");
    }

    public void OnReplayNo()
    {
        replayPromptUI.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
