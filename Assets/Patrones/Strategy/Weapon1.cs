using UnityEngine;

public class Weapon1 : MonoBehaviour, IStrategy
{
    public void PickWeapon()
    {
        Debug.Log("You pick minigun");
    }

    public void Attack()
    {
        Debug.Log("Minigun atacando");
    }
}
