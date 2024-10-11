using UnityEngine;

public class MoveRightCommand : ICommand
{
    private PlayerCommand player;
    Vector3 previousPosition;

    public MoveRightCommand(PlayerCommand player)
    {
        this.player = player;
    }

    public void Execute()
    {
        previousPosition = player.transform.position;
        player.Move(Vector3.right);
    }

    public void Undo()
    {
        player.transform.position = previousPosition;
    }
}
