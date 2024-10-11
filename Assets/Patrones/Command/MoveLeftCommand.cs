using UnityEngine;

public class MoveLeftCommand : ICommand
{
    private PlayerCommand player;
    Vector3 previousPosition;

    public MoveLeftCommand(PlayerCommand player)
    {
        this.player = player;
    }

    public void Execute()
    {
        previousPosition = player.transform.position;
        player.Move(Vector3.left);
    }

    public void Undo()
    {
        player.transform.position = previousPosition;
    }
}
