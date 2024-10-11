using UnityEngine;

public class PlayerEventQueue : MonoBehaviour
{
    public void Move(Vector3 direction)
    {
        transform.Translate(direction);
    }
}

