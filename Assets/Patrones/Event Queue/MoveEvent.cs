using UnityEngine;

public class MoveEvent : IEvent
{
    private PlayerEventQueue player;
    private Vector3 direction;

    public MoveEvent(PlayerEventQueue player, Vector3 direction)
    {
        this.player = player;
        this.direction = direction;
    }

    public void Execute()
    {
        player.Move(direction);
    }
}

