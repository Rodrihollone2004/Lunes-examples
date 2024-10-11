using UnityEngine;

public class MoveForwardCommand : ICommand
{
    private PlayerCommand player;
    private Vector3 previousPosition;

    public MoveForwardCommand(PlayerCommand player)
    {
        this.player = player;
    }

    public void Execute()
    {
        previousPosition = player.transform.position;
        player.Move(Vector3.up);
    }

    public void Undo()
    {
        player.transform.position = previousPosition;
    }
}
