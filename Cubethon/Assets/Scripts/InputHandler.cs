using UnityEngine;
using Chapter.Command;

public class InputHandler : MonoBehaviour
{
    private Invoker _invoker;
    private PlayerMovement _player;

    private Command _moveLeftCommand;
    private Command _moveRightCommand;

    private bool _isRecording;
    private bool _isReplaying;

    void Start()
    {
        _invoker = gameObject.AddComponent<Invoker>();
        _player = FindObjectOfType<PlayerMovement>();

        _moveLeftCommand = new MoveLeftCommand(_player);
        _moveRightCommand = new MoveRightCommand(_player);

        ResetPlayer();
        _isRecording = true;
        _isReplaying = false;
        _invoker.Record();
    }

    void Update()
    {
        if (!_isReplaying && _isRecording)
        {
            if (Input.GetKey(KeyCode.A))
                _invoker.ExecuteCommand(_moveLeftCommand);

            if (Input.GetKey(KeyCode.D))
                _invoker.ExecuteCommand(_moveRightCommand);
        }
    }

    public void StopRecording()
    {
        _isRecording = false;
        ResetPlayer();
    }

    public void StartReplay()
    {
        _isReplaying = true;
        _invoker.Replay();
    }

    void ResetPlayer()
    {
        _player.rb.velocity = Vector3.zero;
        _player.rb.angularVelocity = Vector3.zero;
        _player.transform.position = new Vector3(0, 1.054f, 0);
        _player.transform.rotation = Quaternion.identity;
    }
}
