using UnityEngine;

public class PlayerInputEventQueue : MonoBehaviour
{
    [SerializeField] EventQueue eventQueue;
    [SerializeField] PlayerEventQueue playerEventQueue;

    private void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            eventQueue.AddEvent(new MoveEvent(playerEventQueue, Vector3.up));
        }
        if (Input.GetKeyDown("s"))
        {
            eventQueue.AddEvent(new MoveEvent(playerEventQueue, Vector3.down));
        }
        if (Input.GetKeyDown("a"))
        {
            eventQueue.AddEvent(new MoveEvent(playerEventQueue, Vector3.left));
        }
        if (Input.GetKeyDown("d"))
        {
            eventQueue.AddEvent(new MoveEvent(playerEventQueue, Vector3.right));
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            eventQueue.Execute();
        }
    }

}