using Chapter.Command;

public class MoveRightCommand : Command
{
    private PlayerMovement _player;

    public MoveRightCommand(PlayerMovement player)
    {
        _player = player;
    }

    public override void Execute()
    {
        _player.MoveRight();
    }
}
