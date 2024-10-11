using UnityEngine;

public class Weapon3 : MonoBehaviour, IStrategy
{
    public void PickWeapon()
    {
        Debug.Log("You pick Sword");
    }

    public void Attack()
    {
        Debug.Log("Sword atacando");
    }
}
