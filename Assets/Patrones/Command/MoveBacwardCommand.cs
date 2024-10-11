using UnityEngine;

public class MoveBacwardCommand : ICommand
{
    private PlayerCommand player;
    Vector3 previousPosition;

    public MoveBacwardCommand(PlayerCommand player)
    {
        this.player = player;
    }

    public void Execute()
    {
        previousPosition = player.transform.position;
        player.Move(Vector3.down);
    }

    public void Undo()
    {
        player.transform.position = previousPosition;
    }
}
