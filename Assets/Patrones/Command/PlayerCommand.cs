using UnityEngine;

public class PlayerCommand : MonoBehaviour
{
    public void Move(Vector3 direction)
    {
        transform.Translate(direction);
    }
}
