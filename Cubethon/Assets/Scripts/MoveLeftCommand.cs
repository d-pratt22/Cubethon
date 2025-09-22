using Chapter.Command;

public class MoveLeftCommand : Command
{
    private PlayerMovement _player;

    public MoveLeftCommand(PlayerMovement player)
    {
        _player = player;
    }

    public override void Execute()
    {
        _player.MoveLeft();
    }
}
